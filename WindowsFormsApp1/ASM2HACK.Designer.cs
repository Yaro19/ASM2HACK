namespace WindowsFormsApp1
{
    partial class ASM2HACK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASM2HACK));
            this.ASSEMBLE = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // ASSEMBLE
            // 
            this.ASSEMBLE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ASSEMBLE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ASSEMBLE.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASSEMBLE.ForeColor = System.Drawing.Color.Transparent;
            this.ASSEMBLE.Image = ((System.Drawing.Image)(resources.GetObject("ASSEMBLE.Image")));
            this.ASSEMBLE.Location = new System.Drawing.Point(286, 325);
            this.ASSEMBLE.Name = "ASSEMBLE";
            this.ASSEMBLE.Size = new System.Drawing.Size(204, 69);
            this.ASSEMBLE.TabIndex = 0;
            this.ASSEMBLE.Text = "ASSEMBLE";
            this.ASSEMBLE.UseVisualStyleBackColor = false;
            this.ASSEMBLE.Click += new System.EventHandler(this.button1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ASM2HACK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ASSEMBLE);
            this.Name = "ASM2HACK";
            this.Opacity = 0.7D;
            this.Text = "ASM2HACK";
            this.Load += new System.EventHandler(this.ASM2HACK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ASSEMBLE;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

