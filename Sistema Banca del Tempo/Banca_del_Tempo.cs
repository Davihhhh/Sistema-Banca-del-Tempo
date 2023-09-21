using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Net.Http.Json;
using static System.Windows.Forms.Design.AxImporter;
using System.Security.Principal;
using System.Collections;

namespace Sistema_Banca_del_Tempo
{
    public class Banca_del_Tempo
    {
        //variabili 
        private List<Prestazione> _prestazioni;
        private List<Zona> _mappa;
        private List<Utente> _utenti;
        private List<Utente> _admin;
        private Utente _utenteAttuale;
        private string _password;

        //variabili interne
        private const string frase = "Non sei un amministratore!";
        private Zona zona = new Zona("dddd");
        private Utente empty;
        private const string prestazioniPath = @"Prestazioni.json";
        private const string utentiPath = @"Utenti.json";        
        private const string mappaPath = @"Mappa.json";
        
        //properties
        public List<Prestazione> Prestazioni
        {
            get { return _prestazioni; }
            private set { _prestazioni = value; }
        }
        public List<Zona> Mappa
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
       
        //costruttori
        public Banca_del_Tempo()
        {
            Prestazioni = letturaPrestazioni();
            Mappa = letturaMappa();
            Utenti = letturaUtenti();
            Admin = letturaAdmin(Utenti);
            empty = new Utente("aaaa", "bbbb", "0000000000", "cccc", zona);
            UtenteAttuale = empty;
        }

        //funzioni private
        private List<Prestazione> letturaPrestazioni()
        {
            List<Prestazione> prestazioni;

            string json = File.ReadAllText(prestazioniPath);
            prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(json);

            return prestazioni;
        }
        private List<Zona> letturaMappa()
        {
            List<Zona> mappa;

            string json = File.ReadAllText(mappaPath);
            mappa = JsonConvert.DeserializeObject<List<Zona>>(json);

            return mappa;
        }
        private List<Utente> letturaUtenti()
        {
            List<Utente> lista;

            string json = File.ReadAllText(utentiPath);
            lista = JsonConvert.DeserializeObject<List<Utente>>(json);

            return lista;
        }
        private List<Utente> letturaAdmin(List<Utente> utenti)
        {
            List<Utente> admins = new List<Utente>();
            foreach(Utente u in utenti)
            {
                if(u.Admin)
                {  admins.Add(u); }
            }
            return admins;
        }


        //funzioni pubbliche
        public void login(Utente u)
        {            
            foreach (Utente x in Utenti)
            {               
                if (x.Equals(u))
                    UtenteAttuale = u;
            }
            if (UtenteAttuale.Equals(empty))
                throw new Exception("Utente inesistente o dati errati");
        }
        public void logout()
        {
            UtenteAttuale = empty;
        }
        public void register(Utente utente)
        {
            foreach (Utente x in Utenti)
            {
                if (x.Equals(utente))
                    throw new Exception("Utente già esistente");
            }
            Utenti.Add(utente);
            login(utente);
        }
        public void exit()
        {
            string json1, json2, json3;

            List<Utente> list1 = new List<Utente>();
            json1 = JsonConvert.SerializeObject(list1);
            System.IO.File.WriteAllText(utentiPath, json1);

            List<Prestazione> list2 = new List<Prestazione>();          
            json2 = JsonConvert.SerializeObject(list2);
            System.IO.File.WriteAllText(prestazioniPath, json2);

            List<Zona> list3 = new List<Zona>();            
            json3 = JsonConvert.SerializeObject(list3);
            System.IO.File.WriteAllText(mappaPath, json3);                 
        }
        public void addPrestazione(Prestazione prestazione)
        {
            if (Prestazioni.Contains(prestazione))
                throw new Exception("Prestazione già esistente");
            else
            {
                Prestazioni.Add(prestazione);
                string json = JsonConvert.SerializeObject(prestazione);
                System.IO.File.WriteAllText(prestazioniPath, json);
            }
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
        public List<Utente> cercaUtentiConPrestazione(Prestazione prestazione)
        {
            List<Utente> lista = new List<Utente>();
            foreach(Utente u in Utenti)
            {
                foreach (Prestazione p in u.PrestazioniOfferte)
                {
                    if (prestazione.Equals(p))
                    {
                        lista.Add(u);
                        break;
                    }
                }
            }
            throw new Exception(lista[0].ToString());
            return lista;
        }
        /*public List<Utente>[] listaPerPrestazione()
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
        } */
        /*private List<Utente> quickSortUtenti(List<Utente> utente, int leftIndex, int rightIndex)
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
        }*/
        //public List<Utente> listaPrestazioneAltro()       

    }
}
