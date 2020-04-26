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
using NAudio;
using AxWMPLib;
using WMPLib;

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
        private bool isSwapping = false; //Boolean that tells program whether or not user is trying to swap slide
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
        private int showDuration = 0;

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

        private void deselectPicture(PictureBox selected)
        {
            selected.BorderStyle = BorderStyle.None;
            selected.BackColor = System.Drawing.Color.Transparent;
        }

        private void selectPicture(PictureBox selected)
        {
            selected.BorderStyle = BorderStyle.Fixed3D;
            selected.BackColor = System.Drawing.Color.Red;
        }

        //------------------------
        // slideshow functinality
        //------------------------


        private void browseButton_Click(object sender, EventArgs e)
        {
            d.SelectedPath = dirTextbox.Text;                               // add the selected path from the folder broswer dialog to the text box
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
                dirTextbox.Text = d.SelectedPath;                           // make the path show up on the textbox


            string[] images = Directory.GetFiles(d.SelectedPath, "*.JPG");  // make an array that consists of the path to each .JPG file in the selected path


            foreach (string image in images)        // loop for each file in the array
            {

                PictureBox pb = new PictureBox();
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);    //Add handler for a dropdown menu on each picture box 
                pb.BorderStyle = BorderStyle.None;
                pb.Image = new Bitmap(image);                   // apply the image to the picturebox
                pb.ImageLocation = image;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;  // make the picture fit the picturebox      
                
                thumbnailLayoutPanel.Controls.Add(pb);          // add the picturebox to the thumbnail flowlayoutpanel    
                sh.createSlide(image);
            }

        }

        // dropdown menu for pictureboxes in the preview panel
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            switch (e.Button)
            {
                case MouseButtons.Right:    // if it was right clicked
                    {
                        if (selectedImages.Count != 0) //If there has already been a picture box selected before
                        {
                            PictureBox oldPicture = selectedImages[0];
                            deselectPicture(oldPicture);
                        }
                        selectedImages.Clear();
                        // clicked picture box will be shown as clicked
                        selectPicture(item);
                        browseDirectoryDropDown.Show(item, new Point(e.X, e.Y));    //places the menu at the pointer position
                        selectedImages.Add(item);       // adds the selected image to the selectedImages list
                    }
                    break;
            }
            
        }

        //Function that controls functionality for swapping two slides
        private void swapSlidesFunc()
        {
            int a = 0;
            int b = 0;
            //Check to make sure there are only two images
            if(selectedImages.Count == 2)
            {
                //Get the two slides
                //First slide
                var tmp = selectedImages[0].ImageLocation;
                Slide firstSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
                a = sh.SlideshowSlideList.IndexOf(firstSlide);

                //Second slide
                tmp = selectedImages[1].ImageLocation;
                Slide secondSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
                b = sh.SlideshowSlideList.IndexOf(secondSlide);
                selectedImages[0].BorderStyle = BorderStyle.None;
                selectedImages[1].BorderStyle = BorderStyle.None;
                //Update list
                SlideShowHandler.Swap(sh.SlideshowSlideList, a, b);
                //Update view
                updateSlideTimeline();
                //Swap complete; reset flags and clear the selectedSlidelist
                isSwapping = false;
                
                selectedImages.Clear();
            }
        }

        private void updateSlideTimeline()
        {
            //clear panel before redraw
            slideLayoutPanel.Controls.Clear();
            //Clear text box properties
            transitionTypeTextBox.Text = "";
            transitionTimeTextBox.Text = "";
            slideDurationTextBox.Text = "";

            foreach (Slide slide in sh.SlideshowSlideList)
            {
                //build new pictureBoxes
                PictureBox pb = new PictureBox();


                pb.Image = new Bitmap(slide.Path);                   // apply the image to the picturebox
                pb.ImageLocation = slide.Path;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;  // make the picture fit the picturebox 
                pb.Click += new EventHandler(pb_Click);   // add the timeline right-click menu

                slideLayoutPanel.Controls.Add(pb);          // add the picturebox to the thumbnail flowlayoutpanel
            }
        }

        private void updateTextBoxes()
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;           // get the path of the image of the picturebox

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));     // find the instance of it in the slide list

            /**
             * 
             *  none,
            wipeLeft,
            wipeRight,
            wipeUp,
            wipeDown,
            crossFade
             */
             //Update the text box for the transition type
             switch (selectedSlide.transitionType)
             {
                case 0:
                    transitionTypeTextBox.Text = "None";
                    break;
                case 1:
                    transitionTypeTextBox.Text = "Wipe Left";
                    break;
                case 2:
                    transitionTypeTextBox.Text = "Wipe Right";
                    break;
                case 3:
                    transitionTypeTextBox.Text = "Wipe Up";
                    break;
                case 4:
                    transitionTypeTextBox.Text = "Wipe Down";
                    break;
                case 5:
                    transitionTypeTextBox.Text = "Cross Fade";
                    break;
                default:
                    transitionTypeTextBox.Text = "None";
                    break;
             }

            //Update transition time textbox
            transitionTimeTextBox.Text = selectedSlide.TransitionTime.ToString();
            //Update Slide Duration textbox
            slideDurationTextBox.Text = selectedSlide.Duration.ToString();
        }


        private void pb_Click(object sender, EventArgs e)
        {
            if(isSwapping == true)
            {
                PictureBox item = (PictureBox)sender;
                selectedImages.Add(item);
                //You are clicking the second slide, perform swap functionality
                //Error check to make sure you are not clicking on the same slide
                if(selectedImages[0] != selectedImages[1])
                {
                    swapSlidesFunc();
                }
                else
                {
                    Console.WriteLine("You selected the same image as the one you intially wanted to swap! Swapping mode has been disabled! Please try the swapping mode again, make sure to click on a different image!");
                    isSwapping = false;
                    selectedImages.Clear();
                }
            }
            //Else, normal functionality
            else
            {
                //clear selected previous selected picture box of it's selected indicator
                if(selectedImages.Count != 0) //If there has already been a picture box selected before
                {
                    PictureBox oldPicture = selectedImages[0];
                    deselectPicture(oldPicture);
                }
                selectedImages.Clear();
                PictureBox item = (PictureBox)sender;
                selectedImages.Add(item);                   // add the picturebox that was clicked on to the selectedImages list
                updateTextBoxes();
                var mouseEventArgs = e as MouseEventArgs;   // lets us use mouseevent stuff to get the proper mouse location to display the new dropdown menu
                selectPicture(item);
                slideshowDropDown.Show(item, new Point(mouseEventArgs.X, mouseEventArgs.Y));    //places the menu at the pointer position
            }
        }

        private void addPictureToSlideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;           // get the path of the image of the picturebox

            Slide selectedSlide = sh.ImportedSlideList.Find(x => x.Path.Contains(tmp));     // find the instance of it in the imported list
            sh.addSlideToSlideshow(selectedSlide);  // add it to the timeline list

            selected.MouseDown -= pb_MouseDown;             // remove the thumbnail right-click menu
            deselectPicture(selected);
            selected.Click += new EventHandler(pb_Click);   // add the timeline right-click menu

            slideLayoutPanel.Controls.Add(selected);    // add it to the timeline flowlayoutpanel
            selectedImages.Clear();

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
            // change the picturebox back to not selected once the add button is clicked
            // selected.BorderStyle = BorderStyle.None;
        }

        //Functionality for the swap button
        private void swapSlides_Click(object sender, EventArgs e)
        {
            //If only one thing is in selected images, toggle swapping mode
            if(selectedImages.Count == 1)
            {
                //Set isSwapping to true, if it isn't already
                if(!isSwapping)
                {
                    isSwapping = true;
                    Console.WriteLine("Swapping mode has been enabled\n\n");
                }
                else
                {
                    Console.WriteLine("Swapping was already enabled. You might have a problem.\n\n");
                }
            }
            else
            {
                Console.WriteLine("ERROR: THERE ARE TOO MANY ITEMS IN SELECTED IMAGES.\n\n");
            }
            // selectedImages.BorderStyle = BorderStyle.None;
        }

        private void removeSlideFromSlideshowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.ImportedSlideList.Find(x => x.Path.Contains(tmp));
            sh.removeSlideFromSlideshow(selectedSlide);

            selected.MouseDown += pb_MouseDown;
            selected.Click -= new EventHandler(pb_Click);

            thumbnailLayoutPanel.Controls.Add(selected);
            slideLayoutPanel.Controls.Remove(selected);

            selectedImages.Clear();
            deselectPicture(selected);
        }

        //This handler simply sets the selected slide so we are dealing with the right slide when changing the settings
        private void transitionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //update instructions text
            instructionsTextBox.Text = "Images Successfully Imported! Right click on an image to add it to the timeline";
        }

        //--------------------------
        // Handlers for Transition Type Buttons
        //--------------------------

        //The "none" button under Transistion Types, only this first one will be commented because all of these are similar
        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //get the right image from pb_Click
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            //Use the image location to find the right slide in saved data structure
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            //Set up a string to trigger the right case in changeSlideTransition's switch statement.
            string transitionSetting = "None";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //The "Cross Fade" button under Transistion Types
        private void crossFadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            string transitionSetting = "Cross Fade";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //The "Wipe Up" button under Transistion Types
        private void wipeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            string transitionSetting = "Wipe Up";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //The "Wipe Down" button under Transistion Types
        private void wipeDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            string transitionSetting = "Wipe Down";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //The "Wipe Left" button under Transistion Types
        private void wipeLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            string transitionSetting = "Wipe Left";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //The "Wipe Right" button under Transistion Types
        private void wipeRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));

            string transitionSetting = "Wipe Right";
            sh.changeSlideTransition(selectedSlide, transitionSetting);
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //--------------------------
        // Handlers for Slide Duration Buttons
        //--------------------------
        private void slideDuration5Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 5;
            updateTextBoxes();
            selectedImages.Clear();
            selected.BorderStyle = BorderStyle.None;
        }

        private void slideDuration10Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            int listIndex = sh.SlideshowSlideList.FindIndex(x => x.Path.Contains(tmp));
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 10;
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        private void slideDuration15Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            int listIndex = sh.SlideshowSlideList.FindIndex(x => x.Path.Contains(tmp));
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 15;
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected); 
        }

        private void slideDuration20Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            int listIndex = sh.SlideshowSlideList.FindIndex(x => x.Path.Contains(tmp));
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 20;
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        private void slideDuration25Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            int listIndex = sh.SlideshowSlideList.FindIndex(x => x.Path.Contains(tmp));
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 25;
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        private void slideDuration30Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            int listIndex = sh.SlideshowSlideList.FindIndex(x => x.Path.Contains(tmp));
            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.Duration = 30;
            updateTextBoxes();
            selectedImages.Clear();
            deselectPicture(selected);
        }

        //--------------------------
        // Handlers for Slide Duration Buttons
        //--------------------------
        private void transitionTime1Sec_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.TransitionTime = 1;
            updateTextBoxes();
            deselectPicture(selected);
        }

        private void transitionTime2Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.TransitionTime = 2;
            updateTextBoxes();
            deselectPicture(selected);
        }

        private void transitionTime3Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.TransitionTime = 3;
            updateTextBoxes();
            deselectPicture(selected);
        }

        private void transitionTime4Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.TransitionTime = 4;
            updateTextBoxes();
            deselectPicture(selected);
        }

        private void transitionTime5Secs_Click(object sender, EventArgs e)
        {
            PictureBox selected = selectedImages[0];
            var tmp = selected.ImageLocation;

            Slide selectedSlide = sh.SlideshowSlideList.Find(x => x.Path.Contains(tmp));
            selectedSlide.TransitionTime = 5;
            updateTextBoxes();
            deselectPicture(selected);
        }

        private void slideLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.slideLayoutPanel.AutoScroll = true;
            this.slideLayoutPanel.WrapContents = false;
            this.slideLayoutPanel.HorizontalScroll.Enabled = true;
        }

        

        //--------------------------
        // soundtrack functionality
        //--------------------------


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
                        //convert them to wav
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
                button2.Text = "STOP PLAYING";
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
                button2.Text = "PLAY TRACKS";
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
                        timeElapsed = 0;
                        currentTime = 0;
                        bgw.ReportProgress(timeElapsed + currentTime);
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
            if(AvailSoundTrackListBox.SelectedItem == null)
            {
                instructionsTextBox.Text = "No Tracks Selected";
                return;
            }
   
            var tmp = AvailSoundTrackListBox.SelectedItem.ToString();

            // Add selected track to slideshow
            SoundTrack selectedTrack = sh.ImportedSoundTrackList.Find(x => x.Path.Contains(tmp));

            //if the soundtrack was an aiff, convert to wav behind scenes before adding to show
            if (selectedTrack.Path.Contains(".aiff"))
            {
                string folderPath = Path.GetDirectoryName(selectedTrack.Path);
                string wavTrack = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(selectedTrack.Path) + ".wav");
                ConvertAiffToWav(selectedTrack.Path, wavTrack);
                selectedTrack.Path = wavTrack;
            }

            sh.addSoundTrackToSlideshow(selectedTrack);

            //update duration of show
            //reset duration first
            showDuration = 0;
            foreach (SoundTrack x in sh.SlideshowSoundTrackList)
            {
                showDuration = showDuration + x.Duration;
            }

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

            ///DEBUGGING////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            foreach (SoundTrack x in sh.SlideshowSoundTrackList)
            {
                Console.WriteLine(x.Duration + "\n\n");
            }
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
                        //update duration of show
                        showDuration = showDuration - selectedTrack.Duration;
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
                newSoundTrackBox.Font = new Font("Arial Black", 9);
                string trackName = Path.GetFileNameWithoutExtension(track.Path);
                newSoundTrackBox.Text = trackName;
                newSoundTrackPanel.Controls.Add(newSoundTrackBox);
                musicLayoutPanel.Controls.Add(newSoundTrackPanel);
            }
            //Iterator for trackLength percentages
            int trackLengthIterator = 0;
            foreach (Panel panel in musicLayoutPanel.Controls)
            {
                //format each panel
                //Handle division based on time of each track

                panel.BackColor = System.Drawing.Color.LightGreen;
                //panel.Width = (musicLayoutPanel.Width - 5) / musicLayoutPanel.Controls.Count - 5;
                double percentage = (double)(sh.SlideshowSoundTrackList.ElementAt(trackLengthIterator).Duration) / (double)(showDuration);
                panel.Width = (int)(percentage * ((double)musicLayoutPanel.Width - 5)) - 6;
                panel.Height = musicLayoutPanel.Height - 5;
                trackLengthIterator += 1;
            }
            //Update Panel with new drawn panels based on current list
            musicLayoutPanel.Update();
        }

        

        



        //-----------------------------------------------------------
        // all of the stuff from here on is just empty event handlers
        //-----------------------------------------------------------



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void thumbnailLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            this.thumbnailLayoutPanel.AutoScroll = true;                            // add the scrollbar to the layout panel
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
                if(saveFileLocation == null)
                {
                    saveTextBox.Text = "No Folder Selected. Try Again.";
                    return;
                }
                Directory.CreateDirectory(saveFileLocation);
            }


            //write sound tracks to directory created by user save
            en.WriteSoundTracksToFile(sh.SlideshowSoundTrackList, saveFileLocation);

            //write slides to file 
            en.WriteSlidesToFile(sh.SlideshowSlideList, saveFileLocation);

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

        public static void ConvertAiffToWav(string aiffFile, string wavFile)
        {
            using (NAudio.Wave.AiffFileReader reader = new NAudio.Wave.AiffFileReader(aiffFile))
            {
                using (NAudio.Wave.WaveFileWriter writer = new NAudio.Wave.WaveFileWriter(wavFile, reader.WaveFormat))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = 0;
                    do
                    {
                        bytesRead = reader.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, bytesRead);
                    } while (bytesRead > 0);
                }
            }
        }
    }
}
