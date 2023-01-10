using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASM2HACK
{
    public class Assembler
    {
        #region Fields and properties

        //il path del file .asm
        private string filePath;

        private List<string> hack_file, uncommented_File;

        public List<string> Uncommented_File
        {
            get
            {
                return this.uncommented_File;
            }
        }

        public List<string> Hack_file
        {
            get 
            { 
                if(this.hack_file != null)
                {
                    return this.hack_file;
                }
                else
                {
                    var temp = new List<string>();
                    temp.Add("Call Assemble()");
                    return temp;
                }
            }    
        }

        //Deve contenere le lables con il loro rispettivo indice
        private Dictionary<string, int> labelsDictionary = new Dictionary<string, int>();

        #endregion

        #region Constructors

        private Assembler()
        {

        }

        public Assembler(string filePath)
        {
            //Inizializzazione con le labels di default
            labelsDictionary.Add("R0", 0);
            labelsDictionary.Add("R1", 1);
            labelsDictionary.Add("R2", 2);
            labelsDictionary.Add("R3", 3);
            labelsDictionary.Add("R4", 4);
            labelsDictionary.Add("R5", 5);
            labelsDictionary.Add("R6", 6);
            labelsDictionary.Add("R7", 7);
            labelsDictionary.Add("R8", 8);
            labelsDictionary.Add("R9", 9);
            labelsDictionary.Add("R10", 10);
            labelsDictionary.Add("R11", 11);
            labelsDictionary.Add("R12", 12);
            labelsDictionary.Add("R13", 13);
            labelsDictionary.Add("R14", 14);
            labelsDictionary.Add("R15", 15);            
            labelsDictionary.Add("SCREEN", 16384);
            labelsDictionary.Add("KBD", 24576);

            this.filePath = filePath;
            this.uncommented_File = CleanCommentsAndSpaces();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Il metodo che genera il file con 
        /// le istruzioni in hack
        /// </summary>
        /// 
        public List<string> Assemble()
        {
            List<string> uncommentedFile = CleanCommentsAndSpaces();

            List<string> fileWithoutLabels = CleanAndReplaceLabels(uncommentedFile);

            List<string> outputFile = ConvertToBinInstrucions(fileWithoutLabels);

            return hack_file;
        }


        #endregion

        #region Private methods
        /// <summary>
        /// Questo metodo prende il file del filePath
        /// e toglie tutti i commenti. Alla fine restituisce 
        /// la stringa path che indica la posizione del file
        /// decommentato
        /// </summary>
        /// <returns></returns>
        private List<string> CleanCommentsAndSpaces()
        {
            List<string> uncommentededProgram = new List<string>();

            List<string> programWithoutSpaces = new List<string>();

            try
            {
                //Leva i commenti
                foreach (var item in File.ReadLines(this.filePath))
                {
                    string temp = item.Trim();

                    //Se il rigo del file non inizia con '/', '\n' oppure e' vuoto allora
                    //aggiungilo alla lista del programma
                    if (!temp.StartsWith('/') && temp.Length >= 1) 
                    {
                        if (temp.Contains('/'))
                        {
                            uncommentededProgram.Add(temp.RemoveAfter('/'));
                        }
                        else
                        {
                            uncommentededProgram.Add(temp);
                        }
                    }
                }

                //Leva gli spazi
                foreach (string item in uncommentededProgram)
                {
                    programWithoutSpaces.Add(item.Trim());
                }

                //Debug
                //File.WriteAllLines(filePath, programWithoutSpaces);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Il file non e' stato trovato");
            }

            return programWithoutSpaces;
        }

        /// <summary>
        /// Questo metodo prende il file decommentato 
        /// e toglie e sostituisce tutte le labels in esso
        /// presenti con i numeri delle istruzioni corrispondenti
        /// </summary>
        /// <param name="uncommentFile"></param>
        /// <returns></returns>
        private List<string> CleanAndReplaceLabels(List<string> uncommentFile)
        {
            List<string> programWithoutLabels = new List<string>();

            //Cleaning and adding labels to the labels' list
            CleanLabels(uncommentFile, programWithoutLabels);

            //Replacing labels
            List<string> programWithReplacedLabels = ReplaceLabels(programWithoutLabels);

            return programWithReplacedLabels;
        }

        /// <summary>
        /// Cleaning and adding labels to the labels' list
        /// </summary>
        /// <param name="uncommentFile"></param>
        /// <param name="programWithoutLabels"></param>
        private void CleanLabels(List<string> uncommentFile, List<string> programWithoutLabels)
        {
            int instructionAddress = 0;

            foreach (var item in uncommentFile)
            { 

                if (item.StartsWith('('))
                {
                    string label = "";

                    //cleaning the brackets
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] != '(' && item[i] != ')')
                        {
                            label = label + item[i];
                        }
                    }

                    //Check for twins value
                    if (!this.labelsDictionary.ContainsKey(label))
                    {
                        this.labelsDictionary.Add(label, instructionAddress);
                    }
                }
                else
                {
                    programWithoutLabels.Add(item);
                    instructionAddress++;
                }
            }
        }

        private List<string> ReplaceLabels(List<string> programWithoutLabels)
        {
            List<string> programWithReplacedLabels = new List<string>();

            foreach (var item in programWithoutLabels)
            {
                //Check if A-instruction
                if (item.StartsWith("@") && !Char.IsDigit(item[1]))
                {
                    string itemLabel = item.Remove(0, 1);

                    if (labelsDictionary.ContainsKey(itemLabel))
                    {
                        programWithReplacedLabels.Add("@" + this.labelsDictionary.GetValueOrDefault(itemLabel));
                    }
                    else
                    {
                        RAM ram = RAM.Instance;

                        int freeCell = ram.GetFreeCell();

                        programWithReplacedLabels.Add("@" + freeCell.ToString());

                        //Debug
                        //Console.WriteLine(item + "=> " + freeCell.ToString());

                        this.labelsDictionary.Add(itemLabel, freeCell);
                    }
                }
                else
                {
                    programWithReplacedLabels.Add(item);
                }
            }

            //Debug
            //File.WriteAllLines(directoryPath+ @"\programWithReplacedLabels.txt", programWithReplacedLabels);

            return programWithReplacedLabels;
        }

        private List<string> ConvertToBinInstrucions(List<string> fileWithoutLabels)
        {
            List<string> outputFile = new List<string>();

            foreach (var item in fileWithoutLabels)
            {
                //Remove @ and shift
                if (item.StartsWith("@"))
                {
                    string binItem = item.Remove(0, 1);

                    binItem = binItem.ToBinary();

                    binItem = binItem.LogicANDstring(new string('1', 15));

                    outputFile.Add("0" + binItem);
                }
                else
                {
                    C_instruction c_Instruction = new C_instruction(item);
                    outputFile.Add(c_Instruction.HackInstruction);
                }         
            }

            ////Debug
            //foreach (var item in outputFile)
            //{
            //    Console.WriteLine(item);
            //}

            return outputFile;
        }

        #endregion
    }
}
