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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.dirTextbox.Location = new System.Drawing.Point(25, 19);
            this.dirTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dirTextbox.Name = "dirTextbox";
            this.dirTextbox.Size = new System.Drawing.Size(1791, 26);
            this.dirTextbox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(1824, 14);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(61, 37);
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
            this.thumbnailLayoutPanel.Location = new System.Drawing.Point(25, 70);
            this.thumbnailLayoutPanel.Name = "thumbnailLayoutPanel";
            this.thumbnailLayoutPanel.Size = new System.Drawing.Size(1860, 587);
            this.thumbnailLayoutPanel.TabIndex = 10;
            this.thumbnailLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailLayoutPanel_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 971);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1861, 24);
            this.progressBar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1782, 889);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.musicButton_Click_1);
            // 
            // musicLayoutPanel
            // 
            this.musicLayoutPanel.Location = new System.Drawing.Point(25, 867);
            this.musicLayoutPanel.Name = "musicLayoutPanel";
            this.musicLayoutPanel.Size = new System.Drawing.Size(1751, 82);
            this.musicLayoutPanel.TabIndex = 13;
            // 
            // slideLayoutPanel
            // 
            this.slideLayoutPanel.Location = new System.Drawing.Point(25, 677);
            this.slideLayoutPanel.Name = "slideLayoutPanel";
            this.slideLayoutPanel.Size = new System.Drawing.Size(1860, 164);
            this.slideLayoutPanel.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.slideLayoutPanel);
            this.Controls.Add(this.musicLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.thumbnailLayoutPanel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dirTextbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

