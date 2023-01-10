using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string fileDir;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "asm files (*.asm)|*.asm";

           

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AssembleBtn.Enabled = true;
                filePath = openFileDialog.FileName;

                assembler = new Assembler(filePath);

                UserASMCode_TextBox.Text = "***Il tuo asm***";


            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string fileName = folderBrowserDialog.Description;

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                fileDir = folderBrowserDialog.SelectedPath + @"\"+fileName+".hack";
                //TODO: risolvere questo
                File.WriteAllLines(filePath, assembler.Hack_file);
            }

        }
    }
}
