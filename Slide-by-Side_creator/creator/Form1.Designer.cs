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
            this.slideshowDropDown.SuspendLayout();
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
            this.noneToolStripMenuItem.CheckOnClick = true;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // crossFadeToolStripMenuItem
            // 
            this.crossFadeToolStripMenuItem.CheckOnClick = true;
            this.crossFadeToolStripMenuItem.Name = "crossFadeToolStripMenuItem";
            this.crossFadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.crossFadeToolStripMenuItem.Text = "Cross Fade";
            // 
            // wipeUpToolStripMenuItem
            // 
            this.wipeUpToolStripMenuItem.CheckOnClick = true;
            this.wipeUpToolStripMenuItem.Name = "wipeUpToolStripMenuItem";
            this.wipeUpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.wipeUpToolStripMenuItem.Text = "Wipe Up";
            // 
            // wipeDownToolStripMenuItem
            // 
            this.wipeDownToolStripMenuItem.CheckOnClick = true;
            this.wipeDownToolStripMenuItem.Name = "wipeDownToolStripMenuItem";
            this.wipeDownToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.wipeDownToolStripMenuItem.Text = "Wipe Down";
            // 
            // wipeLeftToolStripMenuItem
            // 
            this.wipeLeftToolStripMenuItem.CheckOnClick = true;
            this.wipeLeftToolStripMenuItem.Name = "wipeLeftToolStripMenuItem";
            this.wipeLeftToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.wipeLeftToolStripMenuItem.Text = "Wipe Left";
            // 
            // wipeRightToolStripMenuItem
            // 
            this.wipeRightToolStripMenuItem.CheckOnClick = true;
            this.wipeRightToolStripMenuItem.Name = "wipeRightToolStripMenuItem";
            this.wipeRightToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
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
            this.toolStripMenuItem12});
            this.slideDurationToolStripMenuItem.Name = "slideDurationToolStripMenuItem";
            this.slideDurationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.slideDurationToolStripMenuItem.Text = "Slide Duration (in seconds)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "5";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.CheckOnClick = true;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "10";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.CheckOnClick = true;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "15";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.CheckOnClick = true;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "20";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.CheckOnClick = true;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "25";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.CheckOnClick = true;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem12.Text = "30";
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
            this.slideshowDropDown.ResumeLayout(false);
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

