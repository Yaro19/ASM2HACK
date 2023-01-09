using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2HACK
{
    public class C_instruction
    {
        #region Fields and properties
        private string hackInstruction;

        Dictionary<string, string> compInstructions = new Dictionary<string, string>();
        Dictionary<string, string> destInstructions = new Dictionary<string, string>();
        Dictionary<string, string> jumpInstructions = new Dictionary<string, string>();

        public string HackInstruction { get => hackInstruction; }
        #endregion

        #region Constructors
        private C_instruction()
        {

        }
        //Prende una C-istruzione e la converte in hack
        public C_instruction(string instruction)
        {
            //Inizializzazione compInstructions
            compInstructions.Add("M", "1110000");
            compInstructions.Add("D|M", "1010101");
            compInstructions.Add("D&M", "1000000");
            compInstructions.Add("M-D", "1000111");
            compInstructions.Add("D-M", "1010011");
            compInstructions.Add("D+M", "1000010");
            compInstructions.Add("M-1", "1110010");
            compInstructions.Add("M+1", "1110111");
            compInstructions.Add("!M", "1110001");
            compInstructions.Add("-M", "1110011");
            compInstructions.Add("!D", "0001101");
            compInstructions.Add("!A", "0110001");
            compInstructions.Add("-D", "0001111");
            compInstructions.Add("-A", "0110011");
            compInstructions.Add("D+1", "0011111");
            compInstructions.Add("A+1", "0110111");
            compInstructions.Add("D-1", "0001110");
            compInstructions.Add("A-1", "0110010");
            compInstructions.Add("D+A", "0000010");
            compInstructions.Add("D-A", "0010011");
            compInstructions.Add("A-D", "0000111");
            compInstructions.Add("D&A", "0000000");
            compInstructions.Add("D|A", "0010101");
            compInstructions.Add("0", "0101010");
            compInstructions.Add("1", "0111111");
            compInstructions.Add("-1", "0111010");
            compInstructions.Add("D", "0001100");
            compInstructions.Add("A", "0110000");

            //Inizializzazione destInstructions
            destInstructions.Add("null", "000");
            destInstructions.Add("M", "001");
            destInstructions.Add("D", "010");
            destInstructions.Add("MD", "011");
            destInstructions.Add("A", "100");
            destInstructions.Add("AM", "101");
            destInstructions.Add("AD", "110");
            destInstructions.Add("AMD", "111");

            //Inizializzazione jumpInstructions
            jumpInstructions.Add("null", "000");
            jumpInstructions.Add("JGT", "001");
            jumpInstructions.Add("JEQ", "010");
            jumpInstructions.Add("JGE", "011");
            jumpInstructions.Add("JLT", "100");
            jumpInstructions.Add("JNE", "101");
            jumpInstructions.Add("JLE", "110");
            jumpInstructions.Add("JMP", "111");

            this.hackInstruction = ConvertC_InstructionToHack(instruction);

            //Debug
            //Console.WriteLine(instruction + "  => \t" + this.hackInstruction);

        }

        #endregion

        #region Private methods

        private string ConvertC_InstructionToHack(string instruction)
        {
            //bits 12..6
            string comp = GetComp(SplitInstruction(instruction)[0]);

            //bits 5..3
            string dest = GetDest(SplitInstruction(instruction)[1]);

            //bits 2..0
            string jump = GetJump(SplitInstruction(instruction)[2]);

            return "111" + comp + dest + jump;
        }

        private string[] SplitInstruction(string instruction)
        {
            string[] splitInstruction = new string[3];

            //comp
            if (instruction.Contains('='))
            {
                splitInstruction[0] = instruction.RemoveBefore('=');
            }

            if (instruction.Contains(';'))
            {
                splitInstruction[0] += instruction.RemoveAfter(';');
            }

            if (!instruction.Contains('=') && !instruction.Contains(';'))
            {
                splitInstruction[0] = instruction;
            }

            //dest
            if (instruction.Contains('='))
            {
                splitInstruction[1] = instruction.RemoveAfter('=');
            }
            else
            {
                splitInstruction[1] = "null";
            }

            //jump
            if (instruction.Contains(';'))
            {
                splitInstruction[2] = instruction.RemoveBefore(';');
            }
            else
            {
                splitInstruction[2] = "null";
            }


            return splitInstruction;
        }

        private string GetComp(string instruction)
        {
            string compInstruction = "";

            foreach (var item in compInstructions.Keys)
            {
                if (item == instruction)
                {
                    compInstruction = compInstructions.GetValueOrDefault(item);
                    break;
                }
            }

            return compInstruction;
        }

        private string GetDest(string instruction)
        {
            string destInstruction = "";

            foreach (var item in destInstructions.Keys)
            {
                if (item == instruction)
                {
                    destInstruction = destInstructions.GetValueOrDefault(item);
                    break;
                }
            }

            return destInstruction;
        }

        private string GetJump(string instruction)
        {
            string jumpInstruction = "";

            foreach (var item in jumpInstructions.Keys)
            {
                if (item == instruction)
                {
                    jumpInstruction = jumpInstructions.GetValueOrDefault(item);
                    break;
                }
            }

            return jumpInstruction;
        }

        #endregion
    }

}
