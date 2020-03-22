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
            this.musicNameBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slideshowDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSlideFromSlideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSlideFromSlideshowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transistionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transistionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossFadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transsitionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.slideDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.customValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDirectoryDropDown.SuspendLayout();
            this.slideshowDropDown.SuspendLayout();
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
            this.thumbnailLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.thumbnailLayoutPanel.Name = "thumbnailLayoutPanel";
            this.thumbnailLayoutPanel.Size = new System.Drawing.Size(1240, 382);
            this.thumbnailLayoutPanel.TabIndex = 10;
            this.thumbnailLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailLayoutPanel_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 631);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1241, 16);
            this.progressBar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1189, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Music_Select_Button_Click);
            // 
            // musicLayoutPanel
            // 
            this.musicLayoutPanel.Location = new System.Drawing.Point(129, 564);
            this.musicLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicLayoutPanel.Name = "musicLayoutPanel";
            this.musicLayoutPanel.Size = new System.Drawing.Size(1052, 28);
            this.musicLayoutPanel.TabIndex = 13;
            // 
            // slideLayoutPanel
            // 
            this.slideLayoutPanel.Location = new System.Drawing.Point(17, 440);
            this.slideLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.slideLayoutPanel.Name = "slideLayoutPanel";
            this.slideLayoutPanel.Size = new System.Drawing.Size(1240, 107);
            this.slideLayoutPanel.TabIndex = 14;
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
            this.button2.Location = new System.Drawing.Point(1189, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Test Track";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Music_Test_Click);
            // 
            // musicNameBox1
            // 
            this.musicNameBox1.Location = new System.Drawing.Point(17, 597);
            this.musicNameBox1.Name = "musicNameBox1";
            this.musicNameBox1.Size = new System.Drawing.Size(1164, 20);
            this.musicNameBox1.TabIndex = 0;
            this.musicNameBox1.TextChanged += new System.EventHandler(this.musicNameBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Soundtrack:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // slideshowDropDown
            // 
            this.slideshowDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSlideFromSlideshowToolStripMenuItem,
            this.removeSlideFromSlideshowToolStripMenuItem1,
            this.transistionSettingsToolStripMenuItem,
            this.slideDurationToolStripMenuItem});
            this.slideshowDropDown.Name = "slideshowDropDown";
            this.slideshowDropDown.Size = new System.Drawing.Size(235, 114);
            // 
            // removeSlideFromSlideshowToolStripMenuItem
            // 
            this.removeSlideFromSlideshowToolStripMenuItem.Name = "removeSlideFromSlideshowToolStripMenuItem";
            this.removeSlideFromSlideshowToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.removeSlideFromSlideshowToolStripMenuItem.Text = "Move Slide to Other Position...";
            this.removeSlideFromSlideshowToolStripMenuItem.Click += new System.EventHandler(this.removeSlideFromSlideshowToolStripMenuItem_Click);
            // 
            // removeSlideFromSlideshowToolStripMenuItem1
            // 
            this.removeSlideFromSlideshowToolStripMenuItem1.Name = "removeSlideFromSlideshowToolStripMenuItem1";
            this.removeSlideFromSlideshowToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.removeSlideFromSlideshowToolStripMenuItem1.Text = "Remove Slide From Slideshow";
            // 
            // transistionSettingsToolStripMenuItem
            // 
            this.transistionSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transistionTypeToolStripMenuItem,
            this.transsitionSettingsToolStripMenuItem});
            this.transistionSettingsToolStripMenuItem.Name = "transistionSettingsToolStripMenuItem";
            this.transistionSettingsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.transistionSettingsToolStripMenuItem.Text = "Transistion Settings";
            // 
            // transistionTypeToolStripMenuItem
            // 
            this.transistionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.crossFadeToolStripMenuItem,
            this.wipeUpToolStripMenuItem,
            this.wipeDownToolStripMenuItem,
            this.wipeLeftToolStripMenuItem,
            this.wipeRightToolStripMenuItem});
            this.transistionTypeToolStripMenuItem.Name = "transistionTypeToolStripMenuItem";
            this.transistionTypeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.transistionTypeToolStripMenuItem.Text = "Transistion Type";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // crossFadeToolStripMenuItem
            // 
            this.crossFadeToolStripMenuItem.Name = "crossFadeToolStripMenuItem";
            this.crossFadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crossFadeToolStripMenuItem.Text = "Cross Fade";
            // 
            // wipeUpToolStripMenuItem
            // 
            this.wipeUpToolStripMenuItem.Name = "wipeUpToolStripMenuItem";
            this.wipeUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wipeUpToolStripMenuItem.Text = "Wipe Up";
            // 
            // wipeDownToolStripMenuItem
            // 
            this.wipeDownToolStripMenuItem.Name = "wipeDownToolStripMenuItem";
            this.wipeDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wipeDownToolStripMenuItem.Text = "Wipe Down";
            // 
            // wipeLeftToolStripMenuItem
            // 
            this.wipeLeftToolStripMenuItem.Name = "wipeLeftToolStripMenuItem";
            this.wipeLeftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wipeLeftToolStripMenuItem.Text = "Wipe Left";
            // 
            // wipeRightToolStripMenuItem
            // 
            this.wipeRightToolStripMenuItem.Name = "wipeRightToolStripMenuItem";
            this.wipeRightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wipeRightToolStripMenuItem.Text = "Wipe Right";
            // 
            // transsitionSettingsToolStripMenuItem
            // 
            this.transsitionSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.transsitionSettingsToolStripMenuItem.Name = "transsitionSettingsToolStripMenuItem";
            this.transsitionSettingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.transsitionSettingsToolStripMenuItem.Text = "Transition Time (in seconds)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "5";
            // 
            // slideDurationToolStripMenuItem
            // 
            this.slideDurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.customValueToolStripMenuItem});
            this.slideDurationToolStripMenuItem.Name = "slideDurationToolStripMenuItem";
            this.slideDurationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.slideDurationToolStripMenuItem.Text = "Slide Duration (in seconds)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "5";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "10";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "15";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "20";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "25";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem12.Text = "30";
            // 
            // customValueToolStripMenuItem
            // 
            this.customValueToolStripMenuItem.Name = "customValueToolStripMenuItem";
            this.customValueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customValueToolStripMenuItem.Text = "Custom Value...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musicNameBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.slideLayoutPanel);
            this.Controls.Add(this.musicLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.thumbnailLayoutPanel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dirTextbox);
            this.Name = "Form1";
            this.Text = "SlideBySide Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.browseDirectoryDropDown.ResumeLayout(false);
            this.slideshowDropDown.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox musicNameBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip slideshowDropDown;
        private System.Windows.Forms.ToolStripMenuItem removeSlideFromSlideshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSlideFromSlideshowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transistionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transistionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossFadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transsitionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem slideDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem customValueToolStripMenuItem;
    }
}

