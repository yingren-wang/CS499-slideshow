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

namespace test
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog d = new FolderBrowserDialog();      // create the folder broswer dialog 'd'
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        browseDirectoryDropDown.Show(item, new Point(e.X, e.Y));    //places the menu at the pointer position
                    }
                break;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            d.SelectedPath = dirTextbox.Text;                                 // add the selected path from the folder broswer dialog to the text box
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
                dirTextbox.Text = d.SelectedPath;                             // make the path show up on the textbox

            
            string[] images = Directory.GetFiles(d.SelectedPath, "*.JPG");  // make an array that consists of the path to each .JPG file in the selected path

            foreach (string image in images)                            // loop for each file in the array
            {
                PictureBox pb = new PictureBox();                       // create a new picture box 'pb'
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);    //Add handler for a dropdown menu on each picture box 

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

        private void musicButton_Click_1(object sender, EventArgs e)
        {
            DialogResult drResult = d.ShowDialog();
            //if ()
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
