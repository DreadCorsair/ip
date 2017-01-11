namespace ImageProcessing
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankOrderFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteredImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoTitle = new System.Windows.Forms.Label();
            this.XPos = new System.Windows.Forms.Label();
            this.YPos = new System.Windows.Forms.Label();
            this.PixelColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediToolStripMenuItem,
            this.rankOrderFilterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mediToolStripMenuItem
            // 
            this.mediToolStripMenuItem.Name = "mediToolStripMenuItem";
            this.mediToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.mediToolStripMenuItem.Text = "Median Filter";
            // 
            // rankOrderFilterToolStripMenuItem
            // 
            this.rankOrderFilterToolStripMenuItem.Name = "rankOrderFilterToolStripMenuItem";
            this.rankOrderFilterToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rankOrderFilterToolStripMenuItem.Text = "Rank Order Filter";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalImageToolStripMenuItem,
            this.filteredImageToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // originalImageToolStripMenuItem
            // 
            this.originalImageToolStripMenuItem.Name = "originalImageToolStripMenuItem";
            this.originalImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.originalImageToolStripMenuItem.Text = "Original Image";
            // 
            // filteredImageToolStripMenuItem
            // 
            this.filteredImageToolStripMenuItem.Name = "filteredImageToolStripMenuItem";
            this.filteredImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filteredImageToolStripMenuItem.Text = "Filtered Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // InfoTitle
            // 
            this.InfoTitle.AutoSize = true;
            this.InfoTitle.Location = new System.Drawing.Point(13, 28);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(98, 13);
            this.InfoTitle.TabIndex = 1;
            this.InfoTitle.Text = "Selected Pixel Info:";
            // 
            // XPos
            // 
            this.XPos.AutoSize = true;
            this.XPos.Location = new System.Drawing.Point(12, 46);
            this.XPos.Name = "XPos";
            this.XPos.Size = new System.Drawing.Size(46, 13);
            this.XPos.TabIndex = 2;
            this.XPos.Text = "X: None";
            // 
            // YPos
            // 
            this.YPos.AutoSize = true;
            this.YPos.Location = new System.Drawing.Point(12, 59);
            this.YPos.Name = "YPos";
            this.YPos.Size = new System.Drawing.Size(46, 13);
            this.YPos.TabIndex = 3;
            this.YPos.Text = "Y: None";
            // 
            // PixelColor
            // 
            this.PixelColor.AutoSize = true;
            this.PixelColor.Location = new System.Drawing.Point(12, 72);
            this.PixelColor.Name = "PixelColor";
            this.PixelColor.Size = new System.Drawing.Size(59, 13);
            this.PixelColor.TabIndex = 4;
            this.PixelColor.Text = "Pixel Color:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 13);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PixelColor);
            this.Controls.Add(this.YPos);
            this.Controls.Add(this.XPos);
            this.Controls.Add(this.InfoTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image Processing Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankOrderFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteredImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label InfoTitle;
        private System.Windows.Forms.Label XPos;
        private System.Windows.Forms.Label YPos;
        private System.Windows.Forms.Label PixelColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

