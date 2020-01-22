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

        private void button3_Click(object sender, EventArgs e)
        {
            d.SelectedPath = textBox1.Text;                                 // add the selected path from the folder broswer dialog to the text box
            DialogResult drResult = d.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)           // make sure the path is ok
                textBox1.Text = d.SelectedPath;                             // make the path show up on the textbox

            
            string[] images = Directory.GetFiles(d.SelectedPath, "*.JPG");  // make an array that consists of the path to each .JPG file in the selected path

            foreach (string image in images)                        // loop for each file in the array
            {
                PictureBox pb = new PictureBox();                   // create a new picture box 'pb'

                pb.Image = new Bitmap(image);                       // set the image to be the current path in the images array
                pb.SizeMode = PictureBoxSizeMode.StretchImage;      // stretch the image

                flowLayoutPanel1.Controls.Add(pb);                  // add the picturebox to the flowLayoutPanel
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.flowLayoutPanel1.AutoScroll = true;                            // add the scrollbar to the layout panel
        }
    }
}
