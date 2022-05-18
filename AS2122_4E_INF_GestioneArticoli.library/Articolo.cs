using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AS2122_4E_INF_FerraroDomenico_GestioneArticoli
{
    public class Articolo
    {
        private string codice;
        private string descrizione;
        private string unitaMisura;
        private double prezzo;

        

        public Articolo(string codice, string descrizione, string unitaMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }
        public string Codice { get; }
        public string Descrizione { get; }
        public string UnitaMisura { get; }
        public double Prezzo { get; }

        public string Visualizza()
        {
            return $"{Descrizione} {UnitaMisura} {Prezzo}";
        }
    }
}
