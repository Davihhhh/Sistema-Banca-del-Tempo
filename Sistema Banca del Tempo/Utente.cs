using System;
using System.CodeDom;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Resources.Extensions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_Banca_del_Tempo
{
    public class Utente
    {
        private string _nome;
        private string _cognome;
        private string _telefono;
        private string _password;
        private string _id;

        private List<Prestazione> _prestazioniOfferte;
        private List<Prestazione> _prestazioniRichieste;
        private List<Prestazione> _prestazioniEseguite;
        private List<Prestazione> _prestazioniRicevute;

        private bool admin;

        public string Nome { 
            get { return _nome; } 
            private set { 
                if (value.Length < 2) 
                    throw new Exception("Nome invalido"); 
                else _nome = value; } }
        public string Cognome { get { return _cognome; } private set { if (value.Length < 2) throw new Exception("Cognome invalido"); else _cognome = value; } }
        public string Telefono { get { return _telefono; } private set { 
                if (value.Length < 10) throw new Exception("Telefono invalido"); 
                try { Convert.ToInt32(value); } catch { throw new Exception("Telefono invalido"); }; _telefono = value; } 
        }
        private string Password { get { return _password; } set { if (value.Length < 4) throw new Exception("Password invalida"); else _password = value; } }
        public string Id { get { return _id; } private set { _id = value; } }

        public List<Prestazione> PrestazioniOfferte { get { return _prestazioniOfferte; } private set { _prestazioniOfferte = value; } }
        public List<Prestazione> PrestazioniRichieste { get { return _prestazioniRichieste; } private set { _prestazioniRichieste = value; } }
        public List<Prestazione> PrestazioniEseguite { get { return _prestazioniEseguite; } private set { _prestazioniEseguite = value; } }
        public List<Prestazione> PrestazioniRicevute { get { return _prestazioniRicevute; } private set { _prestazioniRicevute = value; } }

        private const char s = ';';

        public Utente(string nome, string cognome, string telefono, string password)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Password = password;
            Id = generateID(password);
            admin = false;
        }
        public string generateID(string url_add)
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            return number;
        }

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
        public override string ToString()
        {
            return Nome + s + Cognome + s + Telefono + s;
        }
        public bool isAdmin()
        {
            return admin;
        }
    }
}
