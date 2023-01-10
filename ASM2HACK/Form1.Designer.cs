namespace ASM2HACK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AssembleBtn = new System.Windows.Forms.Button();
            this.outPutTextBox = new System.Windows.Forms.TextBox();
            this.FindFile_btn = new System.Windows.Forms.Button();
            this.UserASMCode_TextBox = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AssembleBtn
            // 
            this.AssembleBtn.Enabled = false;
            this.AssembleBtn.Font = new System.Drawing.Font("Gotham Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AssembleBtn.ForeColor = System.Drawing.Color.Black;
            this.AssembleBtn.Location = new System.Drawing.Point(282, 333);
            this.AssembleBtn.Name = "AssembleBtn";
            this.AssembleBtn.Size = new System.Drawing.Size(175, 71);
            this.AssembleBtn.TabIndex = 0;
            this.AssembleBtn.Text = "Assemble";
            this.AssembleBtn.UseVisualStyleBackColor = true;
            this.AssembleBtn.Click += new System.EventHandler(this.AssembleBtn_Click);
            // 
            // outPutTextBox
            // 
            this.outPutTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outPutTextBox.Location = new System.Drawing.Point(487, 54);
            this.outPutTextBox.MaxLength = 1000000000;
            this.outPutTextBox.Multiline = true;
            this.outPutTextBox.Name = "outPutTextBox";
            this.outPutTextBox.ReadOnly = true;
            this.outPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outPutTextBox.Size = new System.Drawing.Size(238, 350);
            this.outPutTextBox.TabIndex = 2;
            // 
            // FindFile_btn
            // 
            this.FindFile_btn.Location = new System.Drawing.Point(53, 430);
            this.FindFile_btn.Name = "FindFile_btn";
            this.FindFile_btn.Size = new System.Drawing.Size(136, 57);
            this.FindFile_btn.TabIndex = 3;
            this.FindFile_btn.Text = "Trova il tuo file";
            this.FindFile_btn.UseVisualStyleBackColor = true;
            this.FindFile_btn.Click += new System.EventHandler(this.FindFile_btn_Click);
            // 
            // UserASMCode_TextBox
            // 
            this.UserASMCode_TextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UserASMCode_TextBox.Location = new System.Drawing.Point(12, 54);
            this.UserASMCode_TextBox.MaxLength = 100000000;
            this.UserASMCode_TextBox.Multiline = true;
            this.UserASMCode_TextBox.Name = "UserASMCode_TextBox";
            this.UserASMCode_TextBox.ReadOnly = true;
            this.UserASMCode_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserASMCode_TextBox.Size = new System.Drawing.Size(238, 350);
            this.UserASMCode_TextBox.TabIndex = 1;
            // 
            // Save_btn
            // 
            this.Save_btn.Enabled = false;
            this.Save_btn.Location = new System.Drawing.Point(542, 430);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(136, 57);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Salva";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Location = new System.Drawing.Point(12, 493);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ReadOnly = true;
            this.DebugTextBox.Size = new System.Drawing.Size(713, 27);
            this.DebugTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.DebugTextBox);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.FindFile_btn);
            this.Controls.Add(this.outPutTextBox);
            this.Controls.Add(this.UserASMCode_TextBox);
            this.Controls.Add(this.AssembleBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASM2HACK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AssembleBtn;
        private TextBox outPutTextBox;
        private Button FindFile_btn;
        private TextBox UserASMCode_TextBox;
        private Button Save_btn;
        private TextBox DebugTextBox;
    }
}