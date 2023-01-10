using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

            int counter = 0;

            foreach (var item in assembler.Hack_file)
            {
                if (counter > 500)
                {
                    outPutTextBox.Text += "...\r\n";
                    break;
                }

                outPutTextBox.Text += counter + " | " + item + "\r\n";

                counter++;
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

                int counter = 0;

                foreach (var item in assembler.Uncommented_File)
                {
                    if (counter > 500)
                    {
                        UserASMCode_TextBox.Text += "...\r\n";
                        break;
                    }

                    UserASMCode_TextBox.Text += counter + " | " + item + "\r\n";
                    counter++;
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFilePath = folderBrowserDialog.SelectedPath + @"\output.hack";

                DebugTextBox.Text = "Il tuo file .hack e' stato salvato con successo";

                File.WriteAllLines(outputFilePath, assembler.Hack_file);
            }

            Save_btn.Enabled = false;

        }
    }
}
