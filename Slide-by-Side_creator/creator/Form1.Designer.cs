﻿namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dirTextbox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.thumbnailLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.musicLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.slideLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.browseDirectoryDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPictureToSlideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePictureFromSlideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDirectoryDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dirTextbox
            // 
            this.dirTextbox.Location = new System.Drawing.Point(17, 12);
            this.dirTextbox.Name = "dirTextbox";
            this.dirTextbox.Size = new System.Drawing.Size(1195, 20);
            this.dirTextbox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(1216, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(41, 24);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = ". . .";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // thumbnailLayoutPanel
            // 
            this.thumbnailLayoutPanel.Location = new System.Drawing.Point(17, 45);
            this.thumbnailLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thumbnailLayoutPanel.Name = "thumbnailLayoutPanel";
            this.thumbnailLayoutPanel.Size = new System.Drawing.Size(1240, 382);
            this.thumbnailLayoutPanel.TabIndex = 10;
            this.thumbnailLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailLayoutPanel_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 631);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1241, 16);
            this.progressBar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1188, 578);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.musicButton_Click_1);
            // 
            // musicLayoutPanel
            // 
            this.musicLayoutPanel.Location = new System.Drawing.Point(17, 564);
            this.musicLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musicLayoutPanel.Name = "musicLayoutPanel";
            this.musicLayoutPanel.Size = new System.Drawing.Size(1167, 53);
            this.musicLayoutPanel.TabIndex = 13;
            // 
            // slideLayoutPanel
            // 
            this.slideLayoutPanel.Location = new System.Drawing.Point(17, 440);
            this.slideLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.slideLayoutPanel.Name = "slideLayoutPanel";
            this.slideLayoutPanel.Size = new System.Drawing.Size(1240, 107);
            this.slideLayoutPanel.TabIndex = 14;
            // 
            // browseDirectoryDropDown
            // 
            this.browseDirectoryDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPictureToSlideshowToolStripMenuItem,
            this.removePictureFromSlideshowToolStripMenuItem});
            this.browseDirectoryDropDown.Name = "browseDirectoryDropDown";
            this.browseDirectoryDropDown.Size = new System.Drawing.Size(243, 70);
            // 
            // addPictureToSlideshowToolStripMenuItem
            // 
            this.addPictureToSlideshowToolStripMenuItem.Name = "addPictureToSlideshowToolStripMenuItem";
            this.addPictureToSlideshowToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.addPictureToSlideshowToolStripMenuItem.Text = "Add Picture to Slideshow";
            // 
            // removePictureFromSlideshowToolStripMenuItem
            // 
            this.removePictureFromSlideshowToolStripMenuItem.Name = "removePictureFromSlideshowToolStripMenuItem";
            this.removePictureFromSlideshowToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.removePictureFromSlideshowToolStripMenuItem.Text = "Remove Picture from Slideshow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.slideLayoutPanel);
            this.Controls.Add(this.musicLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.thumbnailLayoutPanel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dirTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.browseDirectoryDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox dirTextbox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel thumbnailLayoutPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel musicLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel slideLayoutPanel;
        private System.Windows.Forms.ContextMenuStrip browseDirectoryDropDown;
        private System.Windows.Forms.ToolStripMenuItem addPictureToSlideshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePictureFromSlideshowToolStripMenuItem;
    }
}
