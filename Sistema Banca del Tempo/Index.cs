using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Newtonsoft.Json;

namespace Sistema_Banca_del_Tempo
{
    public partial class Index : Form
    {
        //variabili
        private Banca_del_Tempo btd;
        private string nome, cognome, telefono, password;
        private Prestazione prestazioneAttuale;
        private Zona residenza;

        private string[] nomitest = new string[] { "mario", "luigi", "alessia" };
        private string[] cognomitest = new string[] { "rossi", "verdi", "brown" };
        private string[] telefonotest = new string[] { "1234567890", "3216540987", "0987654321" };
        private string[] passwordtest = new string[] { "fsj9823", "wg225wf", "e3ff2fqewo" };
        private Zona zonatest = new Zona("Bergamo");

        private string[] prestazionitest = new string[] { "Giardiniere", "Contadino", "Pesce" };
        private int[] tempitest = new int[] { 2, 3, 4 };

        private string[] residenzetest = new string[] { "Bergamo", "Longuelo", "Loreto" };

        private Utente invalid;

        private const string eccezione = "Valori invalidi";

        private const string prestazioniPath = @"Prestazioni.json";
        private const string utentiPath = @"Utenti.json";
        private const string mappaPath = @"Mappa.json";

        //costruttori
        public Index()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            test();
            start();
            try
            {
                btd = new Banca_del_Tempo();
                List<Zona> mappa = btd.Mappa;
                foreach (Zona z in mappa)
                {
                    comboBoxZone.Items.Add(z.Nome);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
            
            invalid = new Utente("aaaa", "bbbb", "1234567890", "cccc", zonatest);

            //z check();
        }


        //funzioni
        private void check()
        {
            string str = "";
            foreach(Utente u in btd.Utenti) { str += u.Nome; }
            MessageBox.Show(str);
            str = "";
            foreach (Prestazione p in btd.Prestazioni) { str += p.Nome; }
            MessageBox.Show(str);
            MessageBox.Show(btd.UtenteAttuale.Residenza.Nome);
        }
        private void Index_Load(object sender, EventArgs e)
        {
            
        }
        private void test()
        {
            string json1, json2, json3;

            //MessageBox.Show("test");
            Zona zona = new Zona(residenzetest[0]);
            Utente utente = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0], zona);

            List<Prestazione> list2 = new List<Prestazione>();
            Prestazione prestazione1 = new Prestazione(prestazionitest[0], utente ,tempitest[0]);
            Prestazione prestazione2 = new Prestazione(prestazionitest[1], utente, tempitest[1]);
            Prestazione prestazione3 = new Prestazione(prestazionitest[2], utente, tempitest[2]);
            list2.Add(prestazione1);
            list2.Add(prestazione2);           
            list2.Add(prestazione3);
            json2 = JsonConvert.SerializeObject(list2);
            System.IO.File.WriteAllText(prestazioniPath, json2);

            List<Zona> list3 = new List<Zona>();
            Zona zona1 = new Zona(residenzetest[0]);
            Zona zona2 = new Zona(residenzetest[1]);
            Zona zona3 = new Zona(residenzetest[2]);
            list3.Add(zona1);
            list3.Add(zona2);
            list3.Add(zona3);
            json3 = JsonConvert.SerializeObject(list3);
            System.IO.File.WriteAllText(mappaPath, json3);

            List<Utente> list1 = new List<Utente>();
            Utente utente1 = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0], zona1);
            //utente1.offriPrestazione(prestazione1);
            //utente1.richiediPrestazione(prestazione2);
            Utente utente2 = new Utente(nomitest[1], cognomitest[1], telefonotest[1], passwordtest[1], zona2);
            //utente2.offriPrestazione(prestazione2);
            //utente1.richiediPrestazione(prestazione3);
            Utente utente3 = new Utente(nomitest[2], cognomitest[2], telefonotest[2], passwordtest[2], zona3);
            //utente3.offriPrestazione(prestazione3);
            //utente1.richiediPrestazione(prestazione1);
            list1.Add(utente1);
            list1.Add(utente2);
            list1.Add(utente3);
            json1 = JsonConvert.SerializeObject(list1);
            System.IO.File.WriteAllText(utentiPath, json1);
        }

        private void start()
        {
            textBoxNome.Visible = true;
            textBoxCognome.Visible = true;
            textBoxTelefono.Visible = true;
            textBoxPassword.Visible = true;
            textBoxNomePrestazione.Visible = false;
            textBoxId.Visible = false;
            textBoxTempo.Visible = false;
            buttonSignIn.Visible = true;
            buttonSignUp.Visible = true;
            buttonLogout.Visible = false;
            listView.Visible = false;
            buttonTuttiUtenti.Visible = false;
            buttonIndebitati.Visible = false;
            buttonOrePerPrestazione.Visible = false;
            comboBoxZone.Visible = true;
            buttonMiePrestazioniEseguite.Visible = false;
            buttonMiePrestazioniRicevute.Visible = false;
            buttonCercaPrestazione.Visible = false;
            buttonConfermaPrestazione.Visible = false;
            buttonOffriPrestaione.Visible = false;
            buttonRichiediPrestazione.Visible = false;
            buttonRimuoviUtente.Visible = false;
            listView.Clear();
        }
        private void logged()
        {
            textBoxNome.Visible = false;
            textBoxCognome.Visible = false;
            textBoxTelefono.Visible = false;
            textBoxPassword.Visible = false;
            textBoxNomePrestazione.Visible = true;
            textBoxTempo.Visible = true;
            textBoxId.Visible = true;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            buttonLogout.Visible = true;
            listView.Visible = true;
            buttonTuttiUtenti.Visible = true;
            buttonIndebitati.Visible = true;
            buttonOrePerPrestazione.Visible = true;
            comboBoxZone.Visible = false;
            buttonMiePrestazioniEseguite.Visible = true;
            buttonMiePrestazioniRicevute.Visible = true;
            buttonCercaPrestazione.Visible = true;
            buttonConfermaPrestazione.Visible = true;
            buttonOffriPrestaione.Visible = true;
            buttonRichiediPrestazione.Visible = true;
            listView.Clear();
        }
        private void loggedAdmin()
        {
            logged();
            buttonRimuoviUtente.Visible = true;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Utente utente = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0], zonatest);
            try
            {
                utente = getDataTextBox();
                if(utente.Equals(invalid))
                {
                    return;
                }
                btd.login(utente);  
                
                if (utente.Admin)
                    loggedAdmin();
                else logged();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Utente utente = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0], zonatest);
            try
            {
                utente = getDataTextBox();
                if (utente.Equals(invalid))
                {
                    return;
                }
                btd.register(utente);
                logged();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            
        }
        private void buttonIndebitati_Click(object sender, EventArgs e)
        {
            List<Utente> list = btd.listaUtentiIndebitati();
            stampaUtenti(list);
        }
        private void buttonOrePerPrestazione_Click(object sender, EventArgs e)
        {
            nuoveColonnePrestazione();

            ListViewItem item = new ListViewItem();
            List<string> strs = new List<string>();
            Dictionary<string, List<Prestazione>> d = new Dictionary<string, List<Prestazione>>();
            List<Prestazione> list = new List<Prestazione>();
            int cont = 0;
            string[] str = new string[2];
            foreach (Prestazione p in btd.UtenteAttuale.PrestazioniEseguite)
            {
                if (!strs.Contains(p.Nome))
                    strs.Add(p.Nome);
            }
            foreach (string s in strs)
            {                
                list = new List<Prestazione>();
                foreach (Prestazione p in btd.UtenteAttuale.PrestazioniEseguite)
                {
                    if (p.Nome.Equals(s))
                        list.Add(p);
                }
                d.Add(s, list);
            }
            foreach (KeyValuePair<string, List<Prestazione>> coppia in d)
            {
                list = new List<Prestazione>(coppia.Value);
                foreach (Prestazione p in list)
                {
                    cont += p.Tempo;
                }
                str[0] = coppia.Key;
                str[1] = cont.ToString(); 
                item = new ListViewItem(str);
                listView.Items.Add(item);
                cont = 0;
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                btd.logout();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            start();
        }       
        private void buttonTuttiUtenti_Click(object sender, EventArgs e)
        {
            List<Utente> list = btd.Utenti;
            stampaUtenti(list);
        }       
        private void buttonCercaPrestazione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            List<Utente> list = new List<Utente>();
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, btd.UtenteAttuale.getUtenteQualsiasi(), Convert.ToInt32(textBoxTempo.Text));
                list = btd.cercaUtentiConPrestazione(p);
                stampaUtenti(list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonRichiediPrestazione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, btd.UtenteAttuale.getUtenteQualsiasi(), Convert.ToInt32(textBoxTempo.Text));
                btd.UtenteAttuale.richiediPrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonOffriPrestaione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, btd.UtenteAttuale, Convert.ToInt32(textBoxTempo.Text));
                btd.UtenteAttuale.offriPrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }        
        private void buttonMiePrestazioniEseguite_Click(object sender, EventArgs e)
        {
            try
            {
                List<Prestazione> list = btd.UtenteAttuale.PrestazioniEseguite;
                stampaPrestazioni(list);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }          
        }
        private void buttonMiePrestazioniRicevute_Click(object sender, EventArgs e)
        {
            try
            {
                List<Prestazione> list = btd.UtenteAttuale.PrestazioniRicevute;
                stampaPrestazioni(list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void stampaUtenti(List<Utente> list)
        {
            nuoveColonne();
            ListViewItem item = new ListViewItem();
            foreach (Utente u in list)
            {
                item = new ListViewItem(u.ToString().Split(';'));
                listView.Items.Add(item);
            }
        }
        private void stampaPrestazioni(List<Prestazione> list)
        {
            nuoveColonnePrestazione();
            ListViewItem item = new ListViewItem();
            foreach (Prestazione p in list)
            {
                item = new ListViewItem(p.ToString().Split(';'));
                listView.Items.Add(item);
            }
        }
        /*private void generaButton(Prestazione prestazione, int cont, int x, int y)
        {
            //risolvere
            Button Button = new Button();

            Button.Height = 30;
            Button.Width = 60;
            Button.BackColor = Color.White;
            Button.ForeColor = Color.Black;
            Button.Location = new Point(x, y);
            Button.Enabled = true;
            Button.Text = prestazione.Nome + " " + prestazione.Tempo.ToString();
            Button.Visible = true;

            Button.Name = "Button" + cont;

            Button.Font = new Font("Segoe UI", 9);

            Button.Click += new EventHandler(Button_Click);
            Controls.Add(Button);
        }*/
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] str = btn.Name.Split(' ');
            if (btn != null)
            {
                prestazioneAttuale = new Prestazione(str[0], btd.UtenteAttuale.getUtenteQualsiasi(), Convert.ToInt32(str[1]));
            }
        }
        private void buttonConfermaPrestazione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            string str, id;
            int i;
            try
            {
                str = textBoxNomePrestazione.Text;
                id = textBoxId.Text;                
                Utente u = btd.cercaUtente(id);
                
                i = Convert.ToInt32(textBoxTempo.Text);               
                p = new Prestazione(str, u, i);
                foreach(Prestazione x in btd.UtenteAttuale.PrestazioniRicevute)
                {
                    if(x.Equals(p))
                    {
                        p.Utente_Che_Esegue.PrestazioniEseguite.Add(p);
                        break;
                    }
                }
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        private void nuoveColonne()
        {
            listView.Clear();
            listView.Columns.Add("Nome");
            listView.Columns.Add("Cognome");
            listView.Columns.Add("Telefono");
            listView.Columns.Add("Residenza");
        }

        private void comboBoxZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void Index_Load_1(object sender, EventArgs e)
        {

        }
        private void buttonRimuoviUtente_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBoxId.Text;
                btd.rimuoviUtente(str);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void nuoveColonnePrestazione()
        {
            try
            {
                listView.Clear();
                listView.Columns.Add("Nome");
                listView.Columns.Add("Durata");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            btd.exit();
            this.Close();            
        }
        private Utente getDataTextBox()
        {
            nome = textBoxNome.Text;
            cognome = textBoxCognome.Text;
            telefono = textBoxTelefono.Text;
            password = textBoxPassword.Text; 
            if(comboBoxZone.SelectedIndex == -1 )
            {
                MessageBox.Show("Seleziona una zona!");
                return invalid;
            }
            residenza = new Zona(comboBoxZone.SelectedItem.ToString());
            //MessageBox.Show(nome + cognome + telefono + password + residenza.Nome);
            Utente utente = new Utente(nome, cognome, telefono, password, residenza);

            return utente;
        }
    }
}