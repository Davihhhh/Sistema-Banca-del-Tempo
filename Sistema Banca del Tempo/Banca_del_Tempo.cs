using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Linq;
using System.Net.Http.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace Sistema_Banca_del_Tempo
{
    internal class Banca_del_Tempo
    {
        private List<Prestazione> _prestazioni;
        private string[] _mappa;
        private List<Utente> _utenti;
        private List<Utente> _admin;
        private Utente _utenteAttuale;
        private string _password;

        private const string frase = "Non sei un amministratore!";
        private Utente empty = new Utente("aaaa", "bbbb", "0000000000", "cccc");
        private string prestazioniPath = @"Prestazioni.json";
        private string utentiPath = @"Utenti.json";        
        private string mappaPath = @"Mappa.json";
        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public List<Prestazione> Prestazioni
        {
            get { return _prestazioni; }
            private set { _prestazioni = value; }
        }
        public string[] Mappa
        {
            get { return _mappa; }
            private set { _mappa = value; }
        }
        public List<Utente> Utenti
        {
            get { return _utenti; }
            private set { _utenti = value; }
        }
        private List<Utente> Admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        public Utente UtenteAttuale { get { return _utenteAttuale; } private set { _utenteAttuale = value; } }
        private string Password { get { return _password; } set { _password = value; } }

        private const int size = 100;

        //costruttori
        public Banca_del_Tempo()
        {
            /*Prestazioni = letturaPrestazioni();
            Mappa = letturaMappa();
            Utenti = letturaUtenti();
            Admin = letturaAdmin(Utenti);*/
            UtenteAttuale = empty;
        }

        //funzioni
        public void login(Utente u)
        {
            if (UtenteAttuale.Equals(empty))
                try
                {
                    UtenteAttuale = u;
                }
                catch (Exception)
                {
                    return;
                }        
            else throw new Exception("Banca occupata");
        }
        public void logout()
        {
            if (UtenteAttuale.Equals(empty))
                throw new Exception("Banca vuota");
            else UtenteAttuale = empty;
        }

        private List<Prestazione> letturaPrestazioni()
        {           
            var json = File.ReadAllText(prestazioniPath);
            
            List<Prestazione> prestazioni = new List<Prestazione>();
            //prestazioni = JsonSerializer.Deserialize<List<Prestazione>>(json);
           
            return prestazioni;
        }
        private string[] letturaMappa()
        {
            var json = File.ReadAllText(mappaPath);

            string[] mappa= new string[1];
            mappa = JsonSerializer.Deserialize<string[]>(json);

            return mappa;
        }
        private List<Utente> letturaUtenti()
        {
            var json = File.ReadAllText(utentiPath);

            List<Utente> lista = new List<Utente>();
            //List<Utente> lista = JsonSerializer.Deserialize<List<Utente>>(json);

            return lista;
        }
        private List<Utente> letturaAdmin(List<Utente> utenti)
        {
            List<Utente> admins = new List<Utente>();
            foreach(Utente u in utenti)
            {
                if(u.isAdmin())
                {  admins.Add(u); }
            }

            return admins;
        }
        public void aggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
            string json = JsonSerializer.Serialize(utente);
            File.WriteAllText(@"Utenti.json", json);
        }


        public List<Utente> listaUtentiIndebitati()
        {
            List<Utente> indebitati = new List<Utente>();
            foreach (Utente profilo in Utenti)
            {
                if (profilo.ottieniDebito())
                    indebitati.Add(profilo);
            }
            return indebitati;
        }
        public void confermaPrestazione(Utente utente, Prestazione prestazione)
        {
            if (UtenteAttuale.Equals(utente))
                throw new Exception("Non puoi accertare una tua prestazione!");
            else
            {
                utente.accertaPrestazione(prestazione);
                UtenteAttuale.debitoPrestazione(prestazione);
            }
        }
        public void offriPrestazione(Prestazione prestazione)
        {
            UtenteAttuale.offriPrestazione(prestazione);
        }
        public void richiediPrestazione(Prestazione prestazione)
        {
            UtenteAttuale.richiediPrestazione(prestazione); 
        }
        public List<Utente> cercaPrestazione(Prestazione prestazione)
        {
            List<Utente> lista = new List<Utente>();
            foreach(Utente u in Utenti)
            {
                if(u.PrestazioniOfferte.Contains(prestazione))
                    lista.Add(u); 
            }
            return lista;
        }
        public List<Utente>[] listaPerPrestazione()
        {
            List<Utente>[] liste = new List<Utente>[Prestazioni.Count];
            int cont = 0;
            foreach(Utente u in Utenti)
            {
                foreach(Prestazione p in u.PrestazioniOfferte)
                {
                    if (Prestazioni[cont].Equals(p))
                        liste[cont].Add(u);
                }
                cont++;
            }
            int cont2 = 0;
            foreach(List<Utente> u in liste)
            {
                quickSortUtenti(liste[cont2], 0, liste[cont2].Count);
                cont2++;
            }
            return liste;
        }
        private List<Utente> quickSortUtenti(List<Utente> utente, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = utente[leftIndex];

            while (i <= j)
            {
                while (utente[i].totaleOreEseguite() < pivot.totaleOreEseguite())
                {
                    i++;
                }

                while (utente[j].totaleOreEseguite() > pivot.totaleOreEseguite())
                {
                    j--;
                }

                if (i <= j)
                {
                    Utente temp = utente[i];
                    utente[i] = utente[j];
                    utente[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                quickSortUtenti(utente, leftIndex, j);

            if (i < rightIndex)
                quickSortUtenti(utente, i, rightIndex);

            return utente;
        }
        //public List<Utente> listaPrestazioneAltro()
        



        //admin functions
        public void addPrestazione(Prestazione prestazione)
        {
            if (UtenteAttuale.isAdmin())
            {
                if (Prestazioni.Contains(prestazione))
                    throw new Exception("Prestazione già esistente");
                else
                    Prestazioni[Prestazioni.Count] = prestazione;
            }
            else throw new Exception(frase);
        }
        public void deletePrestazione(Prestazione prestazione)
        {
            if (UtenteAttuale.isAdmin())
            {
                int cont = 0;
                foreach(Prestazione s in Prestazioni)
                {
                    if (s.Equals(prestazione))
                        break;
                    else cont++;
                }
                for(int i = cont; i < Prestazioni.Count; i++)
                    Prestazioni[i] = Prestazioni[i+1];
            }
            else throw new Exception(frase);
        }
    }
}
