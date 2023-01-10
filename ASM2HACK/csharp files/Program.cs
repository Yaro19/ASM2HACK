using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2HACK.csharp_files
{
    //TODO: risolvere il bug del Pong.asm
    //TODO: realizzare l'avviso di sovrascrittura del file (se e' presente)
    //TODO: se l'utente seleziona uno nuvo file allora svuota la textbox e hack_textbox

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
