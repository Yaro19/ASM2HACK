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
            this.AssembleBtn = new System.Windows.Forms.Button();
            this.outPutTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UserASMCode_TextBox = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssembleBtn
            // 
            this.AssembleBtn.Enabled = false;
            this.AssembleBtn.Font = new System.Drawing.Font("Gotham Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AssembleBtn.Location = new System.Drawing.Point(296, 333);
            this.AssembleBtn.Name = "AssembleBtn";
            this.AssembleBtn.Size = new System.Drawing.Size(175, 71);
            this.AssembleBtn.TabIndex = 0;
            this.AssembleBtn.Text = "Assemble";
            this.AssembleBtn.UseVisualStyleBackColor = true;
            this.AssembleBtn.Click += new System.EventHandler(this.AssembleBtn_Click);
            // 
            // outPutTextBox
            // 
            this.outPutTextBox.Location = new System.Drawing.Point(502, 54);
            this.outPutTextBox.Multiline = true;
            this.outPutTextBox.Name = "outPutTextBox";
            this.outPutTextBox.ReadOnly = true;
            this.outPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outPutTextBox.Size = new System.Drawing.Size(238, 350);
            this.outPutTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trova il tuo file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserASMCode_TextBox
            // 
            this.UserASMCode_TextBox.Location = new System.Drawing.Point(29, 54);
            this.UserASMCode_TextBox.Multiline = true;
            this.UserASMCode_TextBox.Name = "UserASMCode_TextBox";
            this.UserASMCode_TextBox.ReadOnly = true;
            this.UserASMCode_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserASMCode_TextBox.Size = new System.Drawing.Size(238, 350);
            this.UserASMCode_TextBox.TabIndex = 1;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(554, 419);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(136, 57);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Salva";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 521);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outPutTextBox);
            this.Controls.Add(this.UserASMCode_TextBox);
            this.Controls.Add(this.AssembleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AssembleBtn;
        private TextBox outPutTextBox;
        private Button button1;
        private TextBox UserASMCode_TextBox;
        private Button Save_btn;
    }
}