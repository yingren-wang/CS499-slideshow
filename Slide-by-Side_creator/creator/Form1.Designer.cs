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
            this.slideShowDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowForSpecifyingSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSlideFromSlideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTransistionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noTransistionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossfadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transitionDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.slideDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDirectoryDropDown.SuspendLayout();
            this.slideShowDropDown.SuspendLayout();
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
            // slideShowDropDown
            // 
            this.slideShowDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToToolStripMenuItem,
            this.removeSlideFromSlideshowToolStripMenuItem,
            this.editTransistionToolStripMenuItem,
            this.slideDurationToolStripMenuItem});
            this.slideShowDropDown.Name = "slideShowDropDown";
            this.slideShowDropDown.Size = new System.Drawing.Size(233, 114);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowForSpecifyingSlotToolStripMenuItem});
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.moveToToolStripMenuItem.Text = "Move To...";
            // 
            // windowForSpecifyingSlotToolStripMenuItem
            // 
            this.windowForSpecifyingSlotToolStripMenuItem.Name = "windowForSpecifyingSlotToolStripMenuItem";
            this.windowForSpecifyingSlotToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.windowForSpecifyingSlotToolStripMenuItem.Text = "<Window for Specifying Slot>";
            // 
            // removeSlideFromSlideshowToolStripMenuItem
            // 
            this.removeSlideFromSlideshowToolStripMenuItem.Name = "removeSlideFromSlideshowToolStripMenuItem";
            this.removeSlideFromSlideshowToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.removeSlideFromSlideshowToolStripMenuItem.Text = "Remove Slide From Slideshow";
            // 
            // editTransistionToolStripMenuItem
            // 
            this.editTransistionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noTransistionToolStripMenuItem,
            this.wipeLeftToolStripMenuItem,
            this.wipeRightToolStripMenuItem,
            this.wipeUpToolStripMenuItem,
            this.wipeDownToolStripMenuItem,
            this.crossfadeToolStripMenuItem,
            this.transitionDurationToolStripMenuItem});
            this.editTransistionToolStripMenuItem.Name = "editTransistionToolStripMenuItem";
            this.editTransistionToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.editTransistionToolStripMenuItem.Text = "Edit Transistion";
            // 
            // noTransistionToolStripMenuItem
            // 
            this.noTransistionToolStripMenuItem.Name = "noTransistionToolStripMenuItem";
            this.noTransistionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noTransistionToolStripMenuItem.Text = "No Transistion";
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
            // crossfadeToolStripMenuItem
            // 
            this.crossfadeToolStripMenuItem.Name = "crossfadeToolStripMenuItem";
            this.crossfadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crossfadeToolStripMenuItem.Text = "Cross-fade";
            // 
            // transitionDurationToolStripMenuItem
            // 
            this.transitionDurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondToolStripMenuItem,
            this.secondsToolStripMenuItem,
            this.secondsToolStripMenuItem1,
            this.secondsToolStripMenuItem2,
            this.secondsToolStripMenuItem3});
            this.transitionDurationToolStripMenuItem.Name = "transitionDurationToolStripMenuItem";
            this.transitionDurationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transitionDurationToolStripMenuItem.Text = "Transition Duration";
            // 
            // secondToolStripMenuItem
            // 
            this.secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            this.secondToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondToolStripMenuItem.Text = "1 second";
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondsToolStripMenuItem.Text = "2 seconds";
            // 
            // secondsToolStripMenuItem1
            // 
            this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
            this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.secondsToolStripMenuItem1.Text = "3 seconds";
            // 
            // secondsToolStripMenuItem2
            // 
            this.secondsToolStripMenuItem2.Name = "secondsToolStripMenuItem2";
            this.secondsToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.secondsToolStripMenuItem2.Text = "4 seconds";
            // 
            // secondsToolStripMenuItem3
            // 
            this.secondsToolStripMenuItem3.Name = "secondsToolStripMenuItem3";
            this.secondsToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.secondsToolStripMenuItem3.Text = "5 seconds";
            // 
            // slideDurationToolStripMenuItem
            // 
            this.slideDurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.slideDurationToolStripMenuItem.Name = "slideDurationToolStripMenuItem";
            this.slideDurationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.slideDurationToolStripMenuItem.Text = "Slide Duration (seconds)";
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
            this.toolStripMenuItem3.Text = "5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "10";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "15";
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
            this.slideShowDropDown.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip slideShowDropDown;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowForSpecifyingSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSlideFromSlideshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTransistionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noTransistionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossfadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transitionDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem slideDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

