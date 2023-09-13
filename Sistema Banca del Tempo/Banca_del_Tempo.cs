using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banca_del_Tempo
{
    internal class Banca_del_Tempo
    {
        private List<Prestazione> _prestazioni;
        private string[] _mappa;
        private List<Utente> _utenti;
        private string[] _adminPasswordList;
        private Utente? _utenteAttuale;
        private string _password;

        private string frase = "Non sei un amministratore!";

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
        private string[] AdminPasswordList
        {
            get { return _adminPasswordList; }
            set { _adminPasswordList = value; }
        }
        public Utente? UtenteAttuale { get; private set; }
        private string Password { get; set; }

        private const int size = 100;

        //costruttori
        public Banca_del_Tempo()
        {
            Prestazioni = letturaPrestazioni();
            Mappa = letturaMappa();
            Utenti = letturaUtenti();
            AdminPasswordList = letturaAdminPassword();
        }

        //funzioni
        public void login(Utente u)
        {
            if (UtenteAttuale.Equals(null))
                UtenteAttuale = u;
            else throw new Exception("Banca occupata");
        }
        public void logout()
        {
            if (!UtenteAttuale.Equals(null))
                UtenteAttuale = null;
            else throw new Exception("Banca vuota");
        }

        private List<Prestazione> letturaPrestazioni()
        {
            List<Prestazione> prestazioni = new List<Prestazione>();

            return prestazioni;
        }
        private string[] letturaMappa()
        {
            string[] mappa = new string[size];

            return mappa;
        }
        private List<Utente> letturaUtenti()
        {
            List<Utente> lista = new List<Utente>();

            return lista;
        }
        private string[] letturaAdminPassword()
        {
            string[] password = new string[size];

            return password;
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
            try { UtenteAttuale.offriPrestazione(prestazione); }
            catch { Exception exception; }
        }
        public void richiediPrestazione(Prestazione prestazione)
        {
            try { UtenteAttuale.richiediPrestazione(prestazione); }
            catch { Exception exception; }
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
                cont++;
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
            if (checkAdminPassword(Password))
            {
                if (Prestazioni.Contains(prestazione))
                    throw new Exception("Prestazione già esistente");
                else
                    Prestazioni[Prestazioni.Count] = prestazione;
            }
            else throw new Exception(frase);
        }
        public void addPrestazioni(List<Prestazione> prestazioni)
        {
            if (checkAdminPassword(Password))
            {
                foreach (Prestazione s in prestazioni)
                {
                    if (Prestazioni.Contains(s))
                        throw new Exception("Prestazione già esistente");
                    else
                        Prestazioni[Prestazioni.Count] = s;
                }
            }
            else throw new Exception(frase);
        }
        public void deletePrestazione(string prestazione)
        {
            if (checkAdminPassword(Password))
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



        private bool checkAdminPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            else if (password.Length < 4)
                return false;
            else if (AdminPasswordList.Contains(password))
                return true;
            else return false;
        }
    }
}
