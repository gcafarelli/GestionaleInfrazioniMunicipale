using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliziaMunicipale
{
    public class Griglia
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cognome;

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        private DateTime dataViolazione;

        public DateTime DataViolazione
        {
            get { return Convert.ToDateTime(dataViolazione.ToShortDateString()); }
            set { dataViolazione = Convert.ToDateTime(value.ToShortDateString()); }
        }

        private decimal importo;

        public decimal Importo
        {
            get { return importo; }
            set { importo = value; }
        }

        private int punti;

        public int Punti
        {
            get { return punti; }
            set { punti = value; }
        }

        private int nVerbali;

        public int NVerbali
        {
            get { return nVerbali; }
            set { nVerbali = value; }
        }
    }

    public class Trasgressore
    {
        private int idTrasgressore;

        public int IdTrasgressore
        {
            get { return idTrasgressore; }
            set { idTrasgressore = value; }
        }

        private string cognome;

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string citta;

        public string Citta
        {
            get { return citta; }
            set { citta = value; }
        }

    }
}
//    IdTrasgressore,Cognome,Nome,Citta
//}