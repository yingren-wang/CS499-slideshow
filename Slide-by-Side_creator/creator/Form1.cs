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

namespace formNamespace
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog d = new FolderBrowserDialog();      // create the folder broswer dialog 'd'
        
        //Variable Declaration

        //Temp Music Track Handling Variables///////////////////////////////////////////////////////////
        OpenFileDialog ofd = new OpenFileDialog();
        private readonly string currentTrackName = "No Track Selected";
        private string currentMusicPathName = "";
        bool musicPlaying = false;
        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        //END OF TEMP VARIABLES/////////////////////////////////////////////////////////////////////////

        


        public Form1()
        {

            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            d.SelectedPath = dirTextbox.Text;                                 // add the selected path from the folder broswer dialog to the text box
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
                dirTextbox.Text = d.SelectedPath;                             // make the path show up on the textbox

            
            string[] images = Directory.GetFiles(d.SelectedPath, "*.JPG");  // make an array that consists of the path to each .JPG file in the selected path

            foreach (string image in images)                        // loop for each file in the array
            {
                PictureBox pb = new PictureBox();                   // create a new picture box 'pb'

                pb.Image = new Bitmap(image);                       // set the image to be the current path in the images array
                pb.SizeMode = PictureBoxSizeMode.StretchImage;      // stretch the image

                thumbnailLayoutPanel.Controls.Add(pb);                  // add the picturebox to the flowLayoutPanel
            }
            
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
                string[] v = Directory.GetFiles(d.SelectedPath, "*.wav");
                currentMusicPathName = v[0];  // make a variable for object with .wav file in the selected path
            }

            //@TODO: Set Track Name
            //musicNameBox1.Text = currentTrackName;
            string PathPrinted = currentMusicPathName;
            musicNameBox1.Text = PathPrinted;

            //@TODO: Set Track Duration
            progressBar.Value = progressBar.Minimum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Music_Test_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = currentMusicPathName;
            if (musicPlaying == false)
            {
                player.Play(); //start music
                musicPlaying = true; 
                progressBar.Value = 0; //reset progress bar
                MusicTimer(); //start progress bar timer
            }
            else
            {
                player.Stop();
                musicPlaying = false;
                time.Stop();
                progressBar.Value = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no action (its just a label)
        }

        private void musicNameBox1_TextChanged(object sender, EventArgs e)
        {
            //do nothing (i.e. this box just holds the track name)
        }

        private void MusicTimer()
        {
            // Set the interval to 1000 ms for the timer.
            time.Interval = 1000;
            // Connect the Tick event of the timer to its event handler.
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar a value of one each time.
            progressBar.Increment(1);

            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (progressBar.Value == progressBar.Maximum)
                // Stop the timer.
                time.Stop();
        }
    }
}
