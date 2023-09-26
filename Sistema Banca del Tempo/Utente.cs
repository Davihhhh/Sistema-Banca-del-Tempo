using System;
using System.CodeDom;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Resources.Extensions;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_Banca_del_Tempo
{
    public class Utente
    {
        //variabili
        private string _nome;
        private string _cognome;
        private string _telefono;
        private string _password;
        private string _id;
        private Zona _residenza;
        private bool _admin;
        private List<Prestazione> _prestazioniOfferte;
        private List<Prestazione> _prestazioniRichieste;
        private List<Prestazione> _prestazioniEseguite;
        private List<Prestazione> _prestazioniRicevute;             

        //properties
        public string Nome { 
            get { return _nome; } 
            private set { 
                if (value.Length < 2) 
                    throw new Exception("Nome invalido"); 
                else _nome = value; } }
        public string Cognome { get { return _cognome; } private set { if (value.Length < 2) throw new Exception("Cognome invalido"); else _cognome = value; } }
        public string Telefono { get { return _telefono; } private set { 
                if (value.Length < 2) 
                    throw new Exception("Telefono invalido"); 
                else
                    _telefono = value;                
            } 
                }
        public string Password { get { return _password; } private set { if (value.Length < 4) throw new Exception("Password invalida"); else _password = value; } }
        public string Id { get { return _id; } private set { _id = value; } }
        public Zona Residenza
        {
            get { return _residenza; }
            private set
            {
                if (value.Equals(null))
                    throw new Exception("Zona invalida");
                else
                    _residenza = value;
            }
        } 
        public bool Admin { get { return _admin; } private set { _admin = value; } }
        public List<Prestazione> PrestazioniOfferte { get { return _prestazioniOfferte; } private set { _prestazioniOfferte = value; } }
        public List<Prestazione> PrestazioniRichieste { get { return _prestazioniRichieste; } private set { _prestazioniRichieste = value; } }
        public List<Prestazione> PrestazioniEseguite { get { return _prestazioniEseguite; } private set { _prestazioniEseguite = value; } }
        public List<Prestazione> PrestazioniRicevute { get { return _prestazioniRicevute; } private set { _prestazioniRicevute = value; } }

        //variabili interne
        private const char s = ';';
        private const string any = "Qualsiasi";
        private Utente Qualsiasi;
        private Prestazione empty;
        private Zona zona = new Zona("dddd");
        private static Zona z = new Zona(any);
        private static Utente u = new Utente("aaaa", "bbbb", "0000000000", "cccc", z);



        //costruttori
        public Utente(string nome, string cognome, string telefono, string password, Zona residenza)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Password = password;
            Id = generateID(nome, cognome, telefono, password);
            Residenza = residenza;
            Admin = false;
            PrestazioniOfferte = new List<Prestazione>();
            PrestazioniRichieste = new List<Prestazione>();
            PrestazioniEseguite = new List<Prestazione>();
            PrestazioniRicevute = new List<Prestazione>();

            empty = new Prestazione("abcd1234", u, 100000);

            PrestazioniOfferte.Add(empty);
            PrestazioniRichieste.Add(empty);
            PrestazioniEseguite.Add(empty);
            PrestazioniRicevute.Add(empty);
           
        }

        //funzioni private
        private string generateID(string nome, string cognome, string telefono, string password)
        {            
            return nome + cognome + telefono + password;
        }

        //funzioni pubbliche
        public bool ottieniDebito()
        {
            if(totaleOreEseguite() < totaleOreRicevute())
                return true;
            else return false;
        }
        public void offriPrestazione(Prestazione prestazione)
        {
            if (PrestazioniOfferte.Equals(empty))
            {
                PrestazioniOfferte.Remove(empty);
                PrestazioniOfferte.Add(prestazione);
            }
            else
            {
                foreach (Prestazione p in PrestazioniOfferte)
                {
                    if (p.Equals(prestazione))
                    {
                        throw new Exception("Prestazione già offerta!");
                    }
                }
                PrestazioniOfferte.Add(prestazione);
            }          
        }
        public void richiediPrestazione(Prestazione prestazione)
        {
            if (PrestazioniRichieste.Equals(empty))
            {
                PrestazioniRichieste.Remove(empty);
                PrestazioniRichieste.Add(prestazione);              
            }
            else
            {
                foreach (Prestazione p in PrestazioniRichieste)
                {
                    if (p.Equals(prestazione))
                    {
                        throw new Exception("Prestazione già richiesta!");
                    }
                    PrestazioniRichieste.Add(prestazione);
                }
            }            
        }
        public void accertaPrestazione(Prestazione prestazione)
        {
            if (PrestazioniOfferte.Equals(empty))
                throw new Exception("L'utente non ha prestazioni offerte");
            else if (PrestazioniOfferte.Contains(prestazione))
                PrestazioniEseguite.Add(prestazione);
            else throw new Exception("Nessuna prestazione offerta coincide"); 
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
            return Nome + s + Cognome + s + Telefono + s + Residenza.Nome;
        }
        public bool Equals(Utente u)
        {
            if (u == null) return false;
            else if (u == this) return true;
            else if (u.Id == this.Id && u.Residenza.Nome.Equals(this.Residenza.Nome)) 
                return true;
            else return false;
            //&& u.PrestazioniEseguite.Equals(this.PrestazioniEseguite) && u.PrestazioniRichieste.Equals(this.PrestazioniRichieste) && u.PrestazioniOfferte.Equals(this.PrestazioniOfferte) && u.PrestazioniRicevute.Equals(this.PrestazioniRicevute)
        }
        public Utente getUtenteQualsiasi()
        {            
            Qualsiasi = new Utente(any, any, any, any, zona);
            return Qualsiasi;
        }
    }
}
