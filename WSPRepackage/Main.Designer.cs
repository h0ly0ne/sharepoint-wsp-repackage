namespace WSPRepackage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseSourceDirectory = new System.Windows.Forms.Button();
            this.btnBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.btnRepackage = new System.Windows.Forms.Button();
            this.tbSourceDirectory = new System.Windows.Forms.TextBox();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.tbWSPFilename = new System.Windows.Forms.TextBox();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.lblWSPFilename = new System.Windows.Forms.Label();
            this.lnkPromotionURL = new System.Windows.Forms.LinkLabel();
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.cbCompressionLevel = new System.Windows.Forms.ComboBox();
            this.lblCompression = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseSourceDirectory
            // 
            this.btnBrowseSourceDirectory.Location = new System.Drawing.Point(434, 96);
            this.btnBrowseSourceDirectory.Name = "btnBrowseSourceDirectory";
            this.btnBrowseSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSourceDirectory.TabIndex = 0;
            this.btnBrowseSourceDirectory.Text = "Browse";
            this.btnBrowseSourceDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseSourceDirectory.Click += new System.EventHandler(this.btn_src_Click);
            // 
            // btnBrowseOutputDirectory
            // 
            this.btnBrowseOutputDirectory.Location = new System.Drawing.Point(434, 136);
            this.btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            this.btnBrowseOutputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutputDirectory.TabIndex = 1;
            this.btnBrowseOutputDirectory.Text = "Browse";
            this.btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDirectory.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // btnRepackage
            // 
            this.btnRepackage.Location = new System.Drawing.Point(432, 226);
            this.btnRepackage.Name = "btnRepackage";
            this.btnRepackage.Size = new System.Drawing.Size(75, 23);
            this.btnRepackage.TabIndex = 2;
            this.btnRepackage.Text = "Repackage";
            this.btnRepackage.UseVisualStyleBackColor = true;
            this.btnRepackage.Click += new System.EventHandler(this.btn_repackage_Click);
            // 
            // tbSourceDirectory
            // 
            this.tbSourceDirectory.Location = new System.Drawing.Point(107, 98);
            this.tbSourceDirectory.Name = "tbSourceDirectory";
            this.tbSourceDirectory.Size = new System.Drawing.Size(321, 20);
            this.tbSourceDirectory.TabIndex = 3;
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(107, 138);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(321, 20);
            this.tbOutputDirectory.TabIndex = 4;
            // 
            // tbWSPFilename
            // 
            this.tbWSPFilename.Location = new System.Drawing.Point(107, 175);
            this.tbWSPFilename.Name = "tbWSPFilename";
            this.tbWSPFilename.Size = new System.Drawing.Size(252, 20);
            this.tbWSPFilename.TabIndex = 5;
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(15, 101);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(86, 13);
            this.lblSourceDirectory.TabIndex = 6;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(14, 140);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(84, 13);
            this.lblOutputDirectory.TabIndex = 7;
            this.lblOutputDirectory.Text = "Output Directory";
            // 
            // lblWSPFilename
            // 
            this.lblWSPFilename.AutoSize = true;
            this.lblWSPFilename.Location = new System.Drawing.Point(14, 178);
            this.lblWSPFilename.Name = "lblWSPFilename";
            this.lblWSPFilename.Size = new System.Drawing.Size(77, 13);
            this.lblWSPFilename.TabIndex = 8;
            this.lblWSPFilename.Text = "WSP Filename";
            // 
            // lnkPromotionURL
            // 
            this.lnkPromotionURL.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPromotionURL.AutoSize = true;
            this.lnkPromotionURL.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPromotionURL.Location = new System.Drawing.Point(15, 236);
            this.lnkPromotionURL.Name = "lnkPromotionURL";
            this.lnkPromotionURL.Size = new System.Drawing.Size(119, 13);
            this.lnkPromotionURL.TabIndex = 9;
            this.lnkPromotionURL.TabStop = true;
            this.lnkPromotionURL.Text = "HANDS ON SharePoint";
            this.lnkPromotionURL.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPromotionURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // imgHeader
            // 
            this.imgHeader.Image = global::WSPRepackage.Properties.Resources.Header;
            this.imgHeader.Location = new System.Drawing.Point(12, 9);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(497, 68);
            this.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgHeader.TabIndex = 10;
            this.imgHeader.TabStop = false;
            // 
            // cbCompressionLevel
            // 
            this.cbCompressionLevel.FormattingEnabled = true;
            this.cbCompressionLevel.Location = new System.Drawing.Point(434, 175);
            this.cbCompressionLevel.Name = "cbCompressionLevel";
            this.cbCompressionLevel.Size = new System.Drawing.Size(73, 21);
            this.cbCompressionLevel.TabIndex = 11;
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Location = new System.Drawing.Point(365, 178);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(67, 13);
            this.lblCompression.TabIndex = 12;
            this.lblCompression.Text = "Compression";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.lblCompression);
            this.Controls.Add(this.cbCompressionLevel);
            this.Controls.Add(this.imgHeader);
            this.Controls.Add(this.lnkPromotionURL);
            this.Controls.Add(this.lblWSPFilename);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.tbWSPFilename);
            this.Controls.Add(this.tbOutputDirectory);
            this.Controls.Add(this.tbSourceDirectory);
            this.Controls.Add(this.btnRepackage);
            this.Controls.Add(this.btnBrowseOutputDirectory);
            this.Controls.Add(this.btnBrowseSourceDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharePoint WSP Repackage";
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowseSourceDirectory;
        private System.Windows.Forms.Button btnBrowseOutputDirectory;
        private System.Windows.Forms.Button btnRepackage;
        private System.Windows.Forms.TextBox tbSourceDirectory;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.TextBox tbWSPFilename;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Label lblWSPFilename;
        private System.Windows.Forms.LinkLabel lnkPromotionURL;
        private System.Windows.Forms.PictureBox imgHeader;
        private System.Windows.Forms.ComboBox cbCompressionLevel;
        private System.Windows.Forms.Label lblCompression;
    }
}

