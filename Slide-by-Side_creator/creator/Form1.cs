using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Timers;
using System.Windows.Media;
using System.Threading;
using System.Windows.Threading;

namespace formNamespace
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog d = new FolderBrowserDialog();      // create the folder broswer dialog 'd'
        OpenFileDialog ofd = new OpenFileDialog();
        SlideShowHandler sh = new SlideShowHandler();
        Encoder en = new Encoder();
        Decoder de = new Decoder();

        //Variable Declaration


        // All selected images to add to slideshow panel////////////////////////////////////////////////
        // TODO: move to the slideShowHandler class in the future
        List<PictureBox> selectedImages = new List<PictureBox>();

        //Temp Music Track Handling Variables///////////////////////////////////////////////////////////
        private readonly string currentTrackName = "No Track Selected";
        private string currentMusicPathName = "";
        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        //END OF TEMP VARIABLES/////////////////////////////////////////////////////////////////////////


        //Variable Declaration
        private MediaPlayer currentPlayer = new MediaPlayer();
        private bool musicPlaying = false;
        private readonly object _lock = new object();
        private Dispatcher myDispatcher;
        private int tracksPlayed = 0;
        private int numTracksToPlay = 0;
        private int totalDuration = 0;
        private BackgroundWorker bgw = new BackgroundWorker(); //This is our worker that plays the musics and updates the progress bar
        private string instructionText = " Welcome to SlidebySide Creator!"+
            "\n\nPlease start by importing images and soundtracks using the buttons to the left!";
        private string saveFileLocation;

        public Form1()
        {
            d = new FolderBrowserDialog();      // create the folder broswer dialog 'd'
            ofd = new OpenFileDialog();
            sh = new SlideShowHandler();
            en = new Encoder();
            de = new Decoder();
            
            InitializeComponent();

            //used for handling the playing of multiple tracks in succession
            myDispatcher = Dispatcher.CurrentDispatcher;
            currentPlayer.MediaFailed  += (s, e) => { Console.WriteLine("Media Failed to play...\n");  };

            // set up the background worker to DoWork and update progress when it's called to run Async
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork); // This plays the song and updates the progress
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            //add the welcome message
            instructionsTextBox.Text = instructionText;

            //Add save file instructions
            saveTextBox.Text = "Once you have your show set up the way you want, click the red "+
                "button below to choose a destination and a file name.";
        }



        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        browseDirectoryDropDown.Show(item, new Point(e.X, e.Y));    //places the menu at the pointer position
                        selectedImages.Add(item);
                        
                        //slideshowDropDown.Show(item, new Point(e.X, e.Y));    //places the menu at the pointer position
                    }
                    break;
            }
            
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            var mouseEventArgs = e as MouseEventArgs;
            slideshowDropDown.Show(item, new Point(mouseEventArgs.X, mouseEventArgs.Y));    //places the menu at the pointer position
             
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            d.SelectedPath = dirTextbox.Text;                                 // add the selected path from the folder broswer dialog to the text box
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
                dirTextbox.Text = d.SelectedPath;                             // make the path show up on the textbox

            
            string[] images = Directory.GetFiles(d.SelectedPath, "*.JPG");  // make an array that consists of the path to each .JPG file in the selected path
             

            foreach (string image in images)                // loop for each file in the array
            {
                                                                                        //--------------------------------------
                PictureBox pb = new PictureBox();                                       //
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);                    //Add handler for a dropdown menu on each picture box 
                
                pb.Image = new Bitmap(image);                                           // move all of this functionality 
                pb.SizeMode = PictureBoxSizeMode.StretchImage;                          // to slide handler class function and
                                                                                        // replace with a function call
                thumbnailLayoutPanel.Controls.Add(pb);                                  //--------------------------------------
            }

            //update instructions text
            instructionsTextBox.Text = "Images Successfully Imported! Right click on an image to add it to the timeline";

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void thumbnailLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.thumbnailLayoutPanel.AutoScroll = true;                            // add the scrollbar to the layout panel
        }

        private void Music_Select_Button_Click(object sender, EventArgs e)
        {
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
            {
                //add all .wav files in this directory to tracks array
                string[] wavTracks = Directory.GetFiles(d.SelectedPath, "*.wav");
                string[] aiffTracks = Directory.GetFiles(d.SelectedPath, "*.aiff");

                foreach (string wavTrack in wavTracks)
                {
                    //check for repeat items before add
                    if (!AvailSoundTrackListBox.Items.Contains(wavTrack))
                    {
                        //make new sound track objects for each .wav
                        //and add to the soundtrack list
                        sh.createSoundTrack(wavTrack);
                    }
                }

                foreach (string aiffTrack in aiffTracks)
                {
                    //check for repeat items before add
                    if (!AvailSoundTrackListBox.Items.Contains(aiffTrack))
                    {
                        //make new sound track objects for each .aiff 
                        //and add to the soundtrack list
                        sh.createSoundTrack(aiffTrack);
                    }
                }

                //clear out current items in list box and rebuild with current avail track list
                AvailSoundTrackListBox.Items.Clear();
                foreach (var track in sh.ImportedSoundTrackList)
                {
                    //AvailSoundTrackListView.Items.Add(track.Path);
                    AvailSoundTrackListBox.Items.Add(track.Path);
                }
            }

            //updated instrucitons
            instructionsTextBox.Text = "Soundtracks successfully imported! Click on a track to highlight it and then click the \"Add Track to Show\" Button";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addPictureToSlideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PictureBox selected in selectedImages)
            {
                slideLayoutPanel.Controls.Add(selected);
                selected.MouseDown -= pb_MouseDown;
                selected.Click += new EventHandler(pb_Click);

                //panelName.Controls.Add(temp);
                //temp.Width = 50;
                //temp.Height = 350;
                //temp.BorderStyle = BorderStyle.FixedSingle;
                //temp.BackColor = Color.Red;
                //temp.Top = temp.Height * panelName.Controls.Count;
                //temp.Left = 300;
                //topPipe[i] = temp;
                //topPipe[i].Visible = true;
            }

            //update instructions
            if (sh.SlideshowSoundTrackList != null)
            {
                instructionsTextBox.Text = "Great! Edit your slideshow on the timeline below and then click" +
                        "the big red \"PRODUCE SLIDESHOW\" button when you're ready to write it to a foler!";
            }
            else
            {
                instructionsTextBox.Text = "Awesome! Be sure to add some Soundtracks to your timeline as well!";
            }

        }


        private void Music_Test_Click(object sender, EventArgs e)
        {
            //if button not pressed yet or music finished entirely, start play sequence
            if (musicPlaying == false && !bgw.IsBusy)
            {
                musicPlaying = true;
                numTracksToPlay = sh.SlideshowSoundTrackList.Count;

                //calculate total duration for progress bar
                foreach (SoundTrack track in sh.SlideshowSoundTrackList)
                {
                    totalDuration = totalDuration + track.Duration;
                }
                progressBar.Maximum = totalDuration;
                bgw.RunWorkerAsync();
            }
            else //currently playing, so stop sequence
            {
                currentPlayer.Stop();
                musicPlaying = false;

                bgw.CancelAsync(); 
                
                //reset progess bar at end
                progressBar.Value = 0;
                progressBar.Update();
                // reset tracks played
                tracksPlayed = 0;
                // reset duration
                totalDuration = 0;
                numTracksToPlay = 0;
            }
        }

        // Run async so the music can play and the progress bar update so the UI thread isn't
        // 100% consumed by the while loop updating the progress bar
        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {            
            var timeElapsed = 0;

            // iterate through the list of tracks chosen
            for (tracksPlayed = 0; tracksPlayed < numTracksToPlay; tracksPlayed++)
            {
                var currentTime = 0; // in seconds
                SoundTrack currentTrack = sh.SlideshowSoundTrackList.ElementAt(tracksPlayed);
                string currentPath = currentTrack.Path;

                // Since we're on a background thread doing UI stuff, we need to dispatch
                // out work to the currentPlayer because it's on the main thread
                myDispatcher.Invoke(() =>
                    {
                        PlayMusic(currentPlayer, currentPath);                        
                    }
                );

                // update the progressbar until the current track is complete
                while (currentTime < currentTrack.Duration)
                {
                    Thread.Sleep(1000);
                    currentTime += 1;
                    //still playing, stay here
                    bgw.ReportProgress(timeElapsed + currentTime);

                    // If the user has hit the button a second time and chosen to end playing of music
                    // then we need to check in the loop and return if so
                    if(bgw.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                timeElapsed += currentTime;
            }
            // we've finished playing
            musicPlaying = false;
        }

        // Background worker listener for when progress is reported from the background worker thread;
        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        void PlayMusic(MediaPlayer currentPlayer, string path)
        {
            //get path
            currentPlayer.Open(new Uri(path, UriKind.Relative));
            currentPlayer.Play(); //start music
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no action (its just a label)
        }

        private void musicNameBox1_TextChanged(object sender, EventArgs e)
        {
            //do nothing (i.e. this box just holds the track name)
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //do nothing. this event handler is just used for labels
        }

        private void AvailSoundTrackListBox_ListIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void SwapTracksButton_Click(object sender, EventArgs e)
        {
            CheckBox validationBox = new CheckBox();
            int a = 0;
            int b = 0;
            int swapCounter = 0;

            foreach (Panel cb in musicLayoutPanel.Controls)
            {
                foreach (CheckBox c in cb.Controls)
                {
                    if (c.Checked == true)
                    {
                        if (swapCounter == 0) //get first item for swap
                        {
                            string path = c.Text;
                            // Remove selected track to slideshow
                            SoundTrack selectedTrack = sh.SlideshowSoundTrackList.Find(x => x.Path.Contains(path));
                            a = sh.SlideshowSoundTrackList.IndexOf(selectedTrack);
                            swapCounter++;
                        }
                        else if (swapCounter == 1) //get second item for swap
                        {
                            string path = c.Text;
                            // Remove selected track to slideshow
                            SoundTrack selectedTrack = sh.SlideshowSoundTrackList.Find(y => y.Path.Contains(path));
                            b = sh.SlideshowSoundTrackList.IndexOf(selectedTrack);
                            swapCounter++;
                        }
                        else //too many items for swap
                        {
                            Console.WriteLine("ERROR: TOO MANY ITEMS SELECTED FOR SWAP. PLEASE SELECT ONLY TWO ITEMS.\n\n");

                            //reset all checked items
                            foreach (Panel cr in musicLayoutPanel.Controls)
                            {
                                foreach (CheckBox r in cb.Controls)
                                {
                                    r.Checked = false;
                                }
                            }

                            swapCounter = 0;
                        }
                    }

                }
            }

            //if made it through looping without reset (i.e. only two items selected)
            // then perform swap
            if (swapCounter == 2)
            {
                SlideShowHandler.Swap(sh.SlideshowSoundTrackList, a, b);

                //update music panel with new list
                updateMusicPanel();
            }
        }

        private void AddTrackToShow_Button_click(object sender, EventArgs e)
        {
            //get path of selected music track
            var tmp = AvailSoundTrackListBox.SelectedItem.ToString();

            // Add selected track to slideshow
            SoundTrack selectedTrack = sh.ImportedSoundTrackList.Find(x => x.Path.Contains(tmp));
            sh.addSoundTrackToSlideshow(selectedTrack);

            //update panel
            updateMusicPanel();

            //update instructions
            if(sh.slideList != null)
            {
                instructionsTextBox.Text = "Great! Edit your slideshow on the timeline below and then click"+
                        "the big red \"PRODUCE SLIDESHOW\" button when you're ready to write it to a foler!";
            }
            else
            {
                instructionsTextBox.Text = "Awesome! Be sure to add some images to your timeline as well!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void musicLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            // TODO swap soundtracks
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            CheckBox validationBox = new CheckBox();

            foreach (Panel cb in musicLayoutPanel.Controls)
            {
                foreach (CheckBox c in cb.Controls)
                {
                    if (c.Checked == true)
                    {
                        string path = c.Text;
                        // Remove selected track to slideshow
                        SoundTrack selectedTrack = sh.SlideshowSoundTrackList.Find(x => x.Path.Contains(path));
                        sh.removeSoundTrackFromSlideshow(selectedTrack);
                    }

                }
            }

            //update music panel with new list
            updateMusicPanel();
        }

        private void updateMusicPanel()
        {
            //clear panel before redraw
            musicLayoutPanel.Controls.Clear();

            foreach(SoundTrack track in sh.SlideshowSoundTrackList)
            {
                //build new panel
                Panel newSoundTrackPanel = new Panel();
                CheckBox newSoundTrackBox = new CheckBox();
                newSoundTrackBox.AutoSize = true;
                //newSoundTrackBox.Width = newSoundTrackPanel.Width - 5;
                newSoundTrackBox.Text = track.Path;
                newSoundTrackPanel.Controls.Add(newSoundTrackBox);
                musicLayoutPanel.Controls.Add(newSoundTrackPanel);


                foreach (Panel panel in musicLayoutPanel.Controls)
                {
                    //format each panel

                    panel.BackColor = System.Drawing.Color.LightGreen;
                    panel.Width = (musicLayoutPanel.Width - 5) / musicLayoutPanel.Controls.Count - 5;
                    panel.Height = musicLayoutPanel.Height - 5;
                }
            }

            //Update Panel with new drawn panels based on current list
            musicLayoutPanel.Update();
        }

        

        private void slideLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.slideLayoutPanel.AutoScroll = true;
            this.slideLayoutPanel.WrapContents = false;
            this.slideLayoutPanel.HorizontalScroll.Enabled = true;
        }

        private void produceSlideShow_Click(object sender, EventArgs e)
        {
            //add code for obtaining directory name here
            var svdlg = new SaveFileDialog();

            if (svdlg.ShowDialog() == DialogResult.OK)
            {
                saveFileLocation = svdlg.FileName.ToString();
            }
            // saveFileLocation now holds name of desired file name in desired folder
            //Console.WriteLine(saveFileLocation);

            //Make a new directory at the location specified by the user
            //call the directory what the user entered
            if (!Directory.Exists(saveFileLocation))
            {
                Directory.CreateDirectory(saveFileLocation);
            }


            //write sound tracks to directory created by user save
            en.WriteSoundTracksToFile(sh.SlideshowSoundTrackList, saveFileLocation);

            //write slides to file 
            en.WriteSlidesToFile(sh.slideList, saveFileLocation);

            //Update the user 
            instructionsTextBox.Text = "Your project was saved here:\n" + saveFileLocation +
                "\n\n Please use the SlidebySide Player Application to view your project!";

            //TESTING PURPOSES ONLY*************???????????????????????????
            // REMOVE BEFORE FINAL PRODUCTION ?????????????????????????????
            //List<SoundTrack> testList = de.ImportSoundTracksFromFile();

            //foreach(SoundTrack x in testList)
            //{
            //    Console.WriteLine(x.Path);
            //    Console.WriteLine(x.Duration);
            //}

            //List<Slide> testSlideList = de.ImportSlidesFromFile();

            //foreach (Slide x in testSlideList)
            //{
            //    Console.WriteLine(x.Path);
            //    Console.WriteLine(x.Duration);
            //}

            ////END TESTING CODE***********????????????????????????????????
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void instructionsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
