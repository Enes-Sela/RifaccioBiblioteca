using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGitHub
{
    //Commento
    class BranchLibro
    {
        internal string Autore { get; set; }
        internal string Titolo { get; set; }
        internal string Editore { get; set; }
        internal int AnnoPubblicazione { get; set; }
        internal int NumeroPagine { get; set; }

        public string ToString(string autore,string titolo,string editore,int annopubblicazione,int numeropagine) 
        {
            return "Il titolo è : " + titolo + "\n" + "Scritto da : " + autore + "\n" + "Pubblicato da : " + editore + "\n" + "Pubblicato nel : " + annopubblicazione + "\n" + "Lungo : " + numeropagine + "pagine";
        }

        public int ReadingTime(int numeropagine) 
        {
            int tempo = 0;

            if (numeropagine < 100)
            {
                tempo = 60;
            }
            else if (numeropagine > 100 && numeropagine < 200)
            {
                tempo = 120;
            }
            else if (numeropagine > 200)
            {
                tempo = 180;
            }

            return tempo;
        }
    }
}
