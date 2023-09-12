using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources.Extensions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banca_del_Tempo
{
    public class Utente
    {
        private string _nome;
        private string _cognome;
        private string _telefono;
        private string _password;
        private int _oreOfferte;
        private int _oreRicevute;

        private List<Prestazione> _prestazioniOfferte;
        private List<Prestazione> _prestazioniRichieste;
        private List<Prestazione> _prestazioniEseguite;
        private List<Prestazione> _prestazioniRicevute;

        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public string Telefono { get; private set; }
        private string Password { get; set; }

        public List<Prestazione> PrestazioniOfferte { get; private set; }
        public List<Prestazione> PrestazioniRichieste { get; private set; }
        public List<Prestazione> PrestazioniEseguite { get; private set; }
        public List<Prestazione> PrestazioniRicevute { get; private set; }

        public bool ottieniDebito()
        {
            if(totaleOreEseguite() < totaleOreRicevute())
                return true;
            else return false;
        }
        public void offriPrestazione(Prestazione prestazione)
        {
            foreach(Prestazione p in PrestazioniOfferte)
            {
                if(p.Equals(prestazione))
                {
                    throw new Exception("Prestazione già offerta!");
                }
            }
            PrestazioniOfferte.Add(prestazione);
        }
        public void richiediPrestazione(Prestazione prestazione)
        {
            foreach (Prestazione p in PrestazioniRichieste)
            {
                if (p.Equals(prestazione))
                {
                    throw new Exception("Prestazione già richiesta!");
                }
            }
            PrestazioniRichieste.Add(prestazione);
        }
        public void accertaPrestazione(Prestazione prestazione)
        {
            if (PrestazioniOfferte.Contains(prestazione))
            {
                PrestazioniEseguite.Add(prestazione);
            }
        }
        public void debitoPrestazione(Prestazione prestazione)
        {
            PrestazioniRicevute.Add(prestazione);           
        }

        public int totaleOreEseguite()
        {
            int totale = 0;
            foreach(Prestazione p in PrestazioniEseguite) { totale += p.Tempo;}
            return totale;
        }
        public int totaleOreRicevute()
        {
            int totale = 0;
            foreach (Prestazione p in PrestazioniRicevute) { totale += p.Tempo; }
            return totale;
        }
    }
}
