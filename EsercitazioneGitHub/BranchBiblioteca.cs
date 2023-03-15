using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGitHub
{
    class BranchBiblioteca
    {
        Dictionary <string,List<BranchLibro>> elencoLibri = new Dictionary<string,List<BranchLibro>>();

        internal string NomeCliente { get; set; }
        internal string Indirizzo { get; set; }
        internal int OrarioApertura { get; set; }
        internal int OrarioChiusura { get; set; }

        internal BranchBiblioteca(string nomeCliente, string indirizzo, int orarioApertura, int orarioChiusura) 
        {
            this.NomeCliente = nomeCliente;
            this.Indirizzo = indirizzo;
            this.OrarioApertura = orarioApertura;
            this.OrarioChiusura = orarioChiusura;
        }

        public void AggiungiLibro(BranchLibro libro)
        {
            if (elencoLibri.ContainsKey(libro.Autore))
            {
                elencoLibri[libro.Autore].Add(libro);
            }
            else
            {
                elencoLibri[libro.Autore] = new List<BranchLibro> { libro };
            }
        }

        // Metodo per cercare tutti i libri di uno specifico autore nel catalogo della biblioteca
        public List<BranchLibro> CercaLibriPerAutore(string autore)
        {
            if (elencoLibri.ContainsKey(autore))
            {
                return elencoLibri[autore];
            }
            else
            {
                return new List<BranchLibro>();
            }
        }
    }
}
