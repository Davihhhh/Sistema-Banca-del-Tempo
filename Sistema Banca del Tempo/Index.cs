using System.Collections.Generic;
using System.Text;

namespace Sistema_Banca_del_Tempo
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            start();
            try
            {
                btd = new Banca_del_Tempo();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); this.Close(); };
            btd = new Banca_del_Tempo();

        }
        private void start()
        {
            textBoxNome.Visible = true;
            textBoxCognome.Visible = true;
            textBoxTelefono.Visible = true;
            textBoxPassord.Visible = true;
            textBoxNomePrestazione.Visible = false;
            textBoxTempo.Visible = false;
            buttonSignIn.Visible = true;
            buttonSignUp.Visible = true;
            buttonLogout.Visible = false;
            listView.Visible = false;
            buttonTuttiUtenti.Visible = false;
            buttonIndebitati.Visible = false;
            buttonOrePerPrestazione.Visible = false;
            listView.Clear();
        }
        private void logged()
        {
            textBoxNome.Visible = false;
            textBoxCognome.Visible = false;
            textBoxTelefono.Visible = false;
            textBoxPassord.Visible = false;
            textBoxNomePrestazione.Visible = false;
            textBoxTempo.Visible = false;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            buttonLogout.Visible = true;
            listView.Visible = true;
            buttonTuttiUtenti.Visible = true;
            buttonIndebitati.Visible = true;
            buttonOrePerPrestazione.Visible = true;
            listView.Clear();
        }
        private void loggedAdmin()
        {
            textBoxNome.Visible = false;
            textBoxCognome.Visible = false;
            textBoxTelefono.Visible = false;
            textBoxPassord.Visible = false;
            textBoxNomePrestazione.Visible = true;
            textBoxTempo.Visible = true;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            buttonLogout.Visible = true;
            listView.Visible = true;
            buttonTuttiUtenti.Visible = true;
            buttonIndebitati.Visible = true;
            buttonOrePerPrestazione.Visible = true;
            listView.Clear();
        }

        private Banca_del_Tempo btd;
        private string nome, cognome, telefono, password;
        private Prestazione prestazioneAttuale;

        private string[] nomitest = new string[] { "mario", "luigi", "alessia" };
        private string[] cognomitest = new string[] { "rossi", "verdi", "brown" };
        private string[] telefonotest = new string[] { "1234567890", "3216540987", "0987654321" };
        private string[] passwordtest = new string[] { "fsj9823", "wg225wf", "e3ff2fqewo" };

        private const string eccezione = "Valori invalidi";

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Utente utente = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0]);
            try
            {
                utente = getDataTextBox();
                btd.login(utente);
                if (utente.isAdmin())
                    loggedAdmin();
                else logged();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonIndebitati_Click(object sender, EventArgs e)
        {
            nuoveColonne();
            List<Utente> list = btd.listaUtentiIndebitati();
            ListViewItem item = new ListViewItem();

            foreach (Utente u in list)
            {
                item = new ListViewItem(u.ToString().Trim(';'));
                listView.Items.Add(item);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Utente utente = new Utente(nomitest[0], cognomitest[0], telefonotest[0], passwordtest[0]);
            try
            {
                utente = getDataTextBox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            btd.aggiungiUtente(utente);
            logged();
        }

        private void buttonOrePerPrestazione_Click(object sender, EventArgs e)
        {
            listView.Clear();
            List<Utente>[] list = btd.listaPerPrestazione();
            List<Prestazione> p = btd.Prestazioni;
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < list.Length; i++)
            {
                listView.Columns.Add(p[i].Nome);
                foreach (Utente u in list[i])
                {
                    item = new ListViewItem(u.ToString().Trim(';'));
                    listView.Items.Add(item);
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            btd.logout();
            start();
        }

        private void buttonAggiungiPrestazione_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomePrestazione.Text;
            int tempo = Convert.ToInt32(textBoxTempo.Text);
            try
            {
                Prestazione p = new Prestazione(nome, tempo);
                btd.addPrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonRimuoviPrestazione_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomePrestazione.Text;
            int tempo = Convert.ToInt32(textBoxTempo.Text);
            try
            {
                Prestazione p = new Prestazione(nome, tempo);
                btd.deletePrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Utente getDataTextBox()
        {
            nome = textBoxNome.Text;
            cognome = textBoxCognome.Text;
            telefono = textBoxPassord.Text;
            password = textBoxTelefono.Text;

            Utente utente = new Utente(nome, cognome, telefono, password);

            return utente;
        }

        private void buttonTuttiUtenti_Click(object sender, EventArgs e)
        {
            nuoveColonne();
            List<Utente> list = btd.Utenti;
            ListViewItem item = new ListViewItem();

            foreach (Utente u in list)
            {
                item = new ListViewItem(u.ToString().Trim(';'));
                listView.Items.Add(item);
            }
        }
        private void nuoveColonne()
        {
            listView.Clear();
            listView.Columns.Add("Nome");
            listView.Columns.Add("Cognome");
            listView.Columns.Add("Telefono");
        }

        private void buttonCercaPrestazione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            List<Utente> list = new List<Utente>();
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, Convert.ToInt32(textBoxTempo.Text));
                list = btd.cercaPrestazione(p);
                nuoveColonne();
                ListViewItem item = new ListViewItem();
                foreach (Utente u in list)
                {
                    item = new ListViewItem(u.ToString().Trim(';'));
                    listView.Items.Add(item);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonRichiediPrestazione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, Convert.ToInt32(textBoxTempo.Text));
                btd.UtenteAttuale.richiediPrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonOffriPrestaione_Click(object sender, EventArgs e)
        {
            Prestazione p;
            try
            {
                p = new Prestazione(textBoxNomePrestazione.Text, Convert.ToInt32(textBoxTempo.Text));
                btd.UtenteAttuale.offriPrestazione(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void nuoveColonnePrestazione()
        {
            listView.Clear();
            listView.Columns.Add("Nome");
            listView.Columns.Add("Durata");
            listView.Columns.Add("Confermato");
        }
        private void buttonMiePrestazioniEseguite_Click(object sender, EventArgs e)
        {
            List<Prestazione> list = btd.UtenteAttuale.PrestazioniEseguite;
            nuoveColonnePrestazione();
            int a = 0;
            int x = 100;
            int y = 50;
            foreach (Prestazione p in list)
            {
                generaButton(p, a, x, y);
                a++;
                x += 30;
            }
        }
        private void generaButton(Prestazione prestazione, int cont, int x, int y)
        {
            Button Button = new Button();

            Button.Height = 20;
            Button.Width = 50;
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
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] str = btn.Name.Split(' ');
            if (btn != null)
            {
                prestazioneAttuale = new Prestazione(str[0], Convert.ToInt32(str[1]));
            }
        }

        private void buttonConfermaPrestazione_Click(object sender, EventArgs e)
        {
            prestazioneAttuale.confermaPrestazione();
        }

        private void buttonMiePrestazioniRicevute_Click(object sender, EventArgs e)
        {

        }
    }
}