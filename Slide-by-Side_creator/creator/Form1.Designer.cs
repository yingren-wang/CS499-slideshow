namespace formNamespace
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableSoundtracksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AvailSoundTrackListBox = new System.Windows.Forms.ListBox();
            this.AvialableImagesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTrackToShow_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.SwapTracksButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.browseDirectoryDropDown.SuspendLayout();
            this.AvailableSoundtracksPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.dirTextbox.Location = new System.Drawing.Point(6, 19);
            this.dirTextbox.Name = "dirTextbox";
            this.dirTextbox.Size = new System.Drawing.Size(1111, 20);
            this.dirTextbox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(1123, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(115, 134);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = "Import Images";
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
            this.thumbnailLayoutPanel.Location = new System.Drawing.Point(6, 57);
            this.thumbnailLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.thumbnailLayoutPanel.Name = "thumbnailLayoutPanel";
            this.thumbnailLayoutPanel.Size = new System.Drawing.Size(1111, 240);
            this.thumbnailLayoutPanel.TabIndex = 10;
            this.thumbnailLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailLayoutPanel_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 631);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1114, 16);
            this.progressBar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1123, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Import Music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Music_Select_Button_Click);
            // 
            // musicLayoutPanel
            // 
            this.musicLayoutPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.musicLayoutPanel.Location = new System.Drawing.Point(17, 564);
            this.musicLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicLayoutPanel.Name = "musicLayoutPanel";
            this.musicLayoutPanel.Size = new System.Drawing.Size(1114, 63);
            this.musicLayoutPanel.TabIndex = 13;
            this.musicLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.musicLayoutPanel_DragDrop);
            // 
            // slideLayoutPanel
            // 
            this.slideLayoutPanel.BackColor = System.Drawing.Color.LightBlue;
            this.slideLayoutPanel.Location = new System.Drawing.Point(17, 454);
            this.slideLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.slideLayoutPanel.Name = "slideLayoutPanel";
            this.slideLayoutPanel.Size = new System.Drawing.Size(1114, 93);
            this.slideLayoutPanel.TabIndex = 14;
            this.slideLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slideLayoutPanel_Paint);
            // 
            // browseDirectoryDropDown
            // 
            this.browseDirectoryDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPictureToSlideshowToolStripMenuItem,
            this.removePictureFromSlideshowToolStripMenuItem});
            this.browseDirectoryDropDown.Name = "contextMenuStrip1";
            this.browseDirectoryDropDown.Size = new System.Drawing.Size(242, 48);
            // 
            // addPictureToSlideshowToolStripMenuItem
            // 
            this.addPictureToSlideshowToolStripMenuItem.Name = "addPictureToSlideshowToolStripMenuItem";
            this.addPictureToSlideshowToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.addPictureToSlideshowToolStripMenuItem.Text = "Add picture to slideshow";
            this.addPictureToSlideshowToolStripMenuItem.Click += new System.EventHandler(this.addPictureToSlideshowToolStripMenuItem_Click);
            // 
            // removePictureFromSlideshowToolStripMenuItem
            // 
            this.removePictureFromSlideshowToolStripMenuItem.Name = "removePictureFromSlideshowToolStripMenuItem";
            this.removePictureFromSlideshowToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.removePictureFromSlideshowToolStripMenuItem.Text = "Remove picture from slideshow";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1140, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Test Tracks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Music_Test_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soundtracks in Slideshow:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AvailableSoundtracksPanel
            // 
            this.AvailableSoundtracksPanel.Controls.Add(this.AvailSoundTrackListBox);
            this.AvailableSoundtracksPanel.Location = new System.Drawing.Point(6, 315);
            this.AvailableSoundtracksPanel.Name = "AvailableSoundtracksPanel";
            this.AvailableSoundtracksPanel.Size = new System.Drawing.Size(1111, 100);
            this.AvailableSoundtracksPanel.TabIndex = 16;
            // 
            // AvailSoundTrackListBox
            // 
            this.AvailSoundTrackListBox.FormattingEnabled = true;
            this.AvailSoundTrackListBox.Location = new System.Drawing.Point(3, 3);
            this.AvailSoundTrackListBox.Name = "AvailSoundTrackListBox";
            this.AvailSoundTrackListBox.Size = new System.Drawing.Size(1108, 95);
            this.AvailSoundTrackListBox.TabIndex = 20;
            // 
            // AvialableImagesLabel
            // 
            this.AvialableImagesLabel.AutoSize = true;
            this.AvialableImagesLabel.Location = new System.Drawing.Point(3, 42);
            this.AvialableImagesLabel.Name = "AvialableImagesLabel";
            this.AvialableImagesLabel.Size = new System.Drawing.Size(90, 13);
            this.AvialableImagesLabel.TabIndex = 17;
            this.AvialableImagesLabel.Text = "Available Images:";
            this.AvialableImagesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Available Sound Tracks:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Timeline:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddTrackToShow_Button
            // 
            this.AddTrackToShow_Button.Location = new System.Drawing.Point(1123, 367);
            this.AddTrackToShow_Button.Name = "AddTrackToShow_Button";
            this.AddTrackToShow_Button.Size = new System.Drawing.Size(115, 48);
            this.AddTrackToShow_Button.TabIndex = 20;
            this.AddTrackToShow_Button.Text = "Add Track to Slideshow";
            this.AddTrackToShow_Button.UseVisualStyleBackColor = true;
            this.AddTrackToShow_Button.Click += new System.EventHandler(this.AddTrackToShow_Button_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1140, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = "PRODUCE SLIDESHOW";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Imported Images Directory:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1123, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 134);
            this.button5.TabIndex = 23;
            this.button5.Text = "Add Image to Slideshow";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1140, 513);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 24);
            this.button6.TabIndex = 24;
            this.button6.Text = "Test Images";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dirTextbox);
            this.panel1.Controls.Add(this.AvialableImagesLabel);
            this.panel1.Controls.Add(this.AddTrackToShow_Button);
            this.panel1.Controls.Add(this.AvailableSoundtracksPanel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.thumbnailLayoutPanel);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 421);
            this.panel1.TabIndex = 25;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1140, 454);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 24);
            this.button7.TabIndex = 26;
            this.button7.Text = "Swap Images";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // SwapTracksButton
            // 
            this.SwapTracksButton.Location = new System.Drawing.Point(1140, 543);
            this.SwapTracksButton.Name = "SwapTracksButton";
            this.SwapTracksButton.Size = new System.Drawing.Size(113, 24);
            this.SwapTracksButton.TabIndex = 27;
            this.SwapTracksButton.Text = "Swap Tracks";
            this.SwapTracksButton.UseVisualStyleBackColor = true;
            this.SwapTracksButton.Click += new System.EventHandler(this.SwapTracksButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1140, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Remove Image";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(1140, 564);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(113, 23);
            this.RemoveButton.TabIndex = 29;
            this.RemoveButton.Text = "Remove Track";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SwapTracksButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.slideLayoutPanel);
            this.Controls.Add(this.musicLayoutPanel);
            this.Controls.Add(this.progressBar);

            this.Name = "Form1";
            this.Text = "SlideBySide Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.browseDirectoryDropDown.ResumeLayout(false);
            this.AvailableSoundtracksPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel AvailableSoundtracksPanel;
        private System.Windows.Forms.Label AvialableImagesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AvailSoundTrackListBox;
        private System.Windows.Forms.Button AddTrackToShow_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SwapTracksButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RemoveButton;
    }
}

