using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASM2HACK
{
    public class RAM
    {
        private static RAM _instance;

        private Dictionary<int, bool> cells = new Dictionary<int, bool>();

        private int numberOfCells = (int)MathF.Pow(2, 14);

        //Singleton pattern
        public static RAM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RAM();
                }
                return _instance;
            }
        }

        private RAM()
        {
            //Inizializzazione della struttura dati che
            //rappresenta la RAM.
            //Se value == true, significa che la cella non 
            //puo' essere usata
            Fill();
        }

        public int GetFreeCell()
        {
            int result = 16;

            for (int i = 16; i < numberOfCells; i++)
            {
                if (!cells[i])
                {
                    result = i;
                    cells[i] = true;
                    break;
                }
            }

            return result;
        }

        public void Clean()
        {
            foreach (var item in cells.Keys)
            {
                cells.Remove(item);
            }

            Fill();
        }

        private void Fill()
        {
            for (int i = 0; i < numberOfCells; i++)
            {
                if (i < 16)
                {
                    cells.Add(i, true);
                }
                else
                {
                    cells.Add(i, false);
                }

            }
        }
    }
}
