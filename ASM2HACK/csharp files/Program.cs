using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2HACK.csharp_files
{
    //TODO: realizzare l'avviso di sovrascrittura del file (se e' presente)
	//TODO: quando l'utente salva il file, il deve avere il nome del file di input
    //TODO: segnalazione errori + rigo errore

	
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
