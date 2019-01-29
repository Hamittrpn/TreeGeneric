namespace TreeGeneric.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölgelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tbtnDonation = new System.Windows.Forms.ToolStripButton();
            this.tbtnPlanting = new System.Windows.Forms.ToolStripButton();
            this.tbtnUser = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlDonation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlanting = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlDonation.SuspendLayout();
            this.pnlPlanting.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölgelerToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ayarlarToolStripMenuItem.Text = "Options";
            // 
            // bölgelerToolStripMenuItem
            // 
            this.bölgelerToolStripMenuItem.Name = "bölgelerToolStripMenuItem";
            this.bölgelerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bölgelerToolStripMenuItem.Text = "Regions";
            this.bölgelerToolStripMenuItem.Click += new System.EventHandler(this.bölgelerToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnHome,
            this.tbtnDonation,
            this.tbtnPlanting,
            this.tbtnUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnHome
            // 
            this.tbtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnHome.Image = ((System.Drawing.Image)(resources.GetObject("tbtnHome.Image")));
            this.tbtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHome.Name = "tbtnHome";
            this.tbtnHome.Size = new System.Drawing.Size(23, 22);
            this.tbtnHome.Text = "Home";
            this.tbtnHome.Click += new System.EventHandler(this.tbtnHome_Click);
            // 
            // tbtnDonation
            // 
            this.tbtnDonation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDonation.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDonation.Image")));
            this.tbtnDonation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDonation.Name = "tbtnDonation";
            this.tbtnDonation.Size = new System.Drawing.Size(23, 22);
            this.tbtnDonation.Text = "Donation";
            this.tbtnDonation.Click += new System.EventHandler(this.tbtnDonation_Click);
            // 
            // tbtnPlanting
            // 
            this.tbtnPlanting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPlanting.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPlanting.Image")));
            this.tbtnPlanting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPlanting.Name = "tbtnPlanting";
            this.tbtnPlanting.Size = new System.Drawing.Size(23, 22);
            this.tbtnPlanting.Text = "Planting";
            this.tbtnPlanting.Click += new System.EventHandler(this.tbtnPlanting_Click);
            // 
            // tbtnUser
            // 
            this.tbtnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnUser.Image = ((System.Drawing.Image)(resources.GetObject("tbtnUser.Image")));
            this.tbtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUser.Name = "tbtnUser";
            this.tbtnUser.Size = new System.Drawing.Size(23, 22);
            this.tbtnUser.Text = "User";
            this.tbtnUser.Click += new System.EventHandler(this.tbtnUser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(508, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHome
            // 
            this.pnlHome.AutoScroll = true;
            this.pnlHome.Controls.Add(this.pictureBox2);
            this.pnlHome.Controls.Add(this.pictureBox1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 49);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(525, 475);
            this.pnlHome.TabIndex = 5;
            // 
            // pnlDonation
            // 
            this.pnlDonation.Controls.Add(this.label1);
            this.pnlDonation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonation.Location = new System.Drawing.Point(0, 49);
            this.pnlDonation.Name = "pnlDonation";
            this.pnlDonation.Size = new System.Drawing.Size(525, 475);
            this.pnlDonation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donation";
            // 
            // pnlPlanting
            // 
            this.pnlPlanting.Controls.Add(this.label2);
            this.pnlPlanting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlanting.Location = new System.Drawing.Point(0, 49);
            this.pnlPlanting.Name = "pnlPlanting";
            this.pnlPlanting.Size = new System.Drawing.Size(525, 475);
            this.pnlPlanting.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Planting";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.label3);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 49);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(525, 475);
            this.pnlUser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 524);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlDonation);
            this.Controls.Add(this.pnlPlanting);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlDonation.ResumeLayout(false);
            this.pnlDonation.PerformLayout();
            this.pnlPlanting.ResumeLayout(false);
            this.pnlPlanting.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölgelerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnHome;
        private System.Windows.Forms.ToolStripButton tbtnDonation;
        private System.Windows.Forms.ToolStripButton tbtnPlanting;
        private System.Windows.Forms.ToolStripButton tbtnUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPlanting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDonation;
        private System.Windows.Forms.Label label1;
    }
}