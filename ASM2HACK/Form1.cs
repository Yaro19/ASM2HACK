using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2HACK
{
    public partial class Form1 : Form
    {
        Assembler assembler;
        string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AssembleBtn_Click(object sender, EventArgs e)
        {
            assembler.Assemble();
            DebugTextBox.Text = "Done!";

            foreach (var item in assembler.Hack_file)
            {
                outPutTextBox.Text += item + "\r\n";
            }

            AssembleBtn.Enabled = false;

            Save_btn.Enabled = true;
        }

        private void FindFile_btn_Click(object sender, EventArgs e)
        {       
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "asm files (*.asm)|*.asm";

            //Cleaning
            UserASMCode_TextBox.Text = "";

            outPutTextBox.Text = "";

            RAM ram = RAM.Instance;

            ram.Clean();
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AssembleBtn.Enabled = true;

                filePath = openFileDialog.FileName;

                assembler = new Assembler(filePath);

                foreach (var item in assembler.Uncommented_File)
                {
                    UserASMCode_TextBox.Text += item + "\r\n";
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {       
                string outputFilePath = folderBrowserDialog.SelectedPath + @"\output.hack";

                DebugTextBox.Text = "Il tuo file .hack e' stato salvato con successo";       

                File.WriteAllLines(outputFilePath, assembler.Hack_file);
            }

            Save_btn.Enabled = false;

        }
    }
}
