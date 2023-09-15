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

        }
        private void start()
        {
            textBoxNome.Visible = true;
            textBoxCognome.Visible = true;
            textBoxTelefono.Visible = true;
            textBoxPassord.Visible = true;
            buttonSignIn.Visible = true;
            buttonSignUp.Visible = true;
            listView.Visible = false;
            buttonTuttiUtenti.Visible = false;
            buttonIndebitati.Visible = false;
        }
        private void logged()
        {
            textBoxNome.Visible = false;
            textBoxCognome.Visible = false;
            textBoxTelefono.Visible = false;
            textBoxPassord.Visible = false;
            buttonSignIn.Visible = false;
            buttonSignUp.Visible = false;
            listView.Visible = true;
            buttonTuttiUtenti.Visible = true;
            buttonIndebitati.Visible = true;
        }

        private Banca_del_Tempo btd = new Banca_del_Tempo();
        private string nome, cognome, telefono, password;

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
                utente = getData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            btd.login(utente);
            logged();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Utente utente;
            try
            {
                utente = getData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            btd.aggiungiUtente(utente);
            logged();
        }

        private Utente getData()
        {
            nome = textBoxNome.Text;
            cognome = textBoxCognome.Text;
            telefono = textBoxPassord.Text;
            password = textBoxTelefono.Text;

            Utente utente = new Utente("", "", "", "");
            try
            {
                Utente utente2 = new Utente(nome, cognome, telefono, password);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return utente; }

            utente = new Utente(nome, cognome, telefono, password);

            return utente;
        }

        private void buttonTuttiUtenti_Click(object sender, EventArgs e)
        {
            List<Utente> list = btd.Utenti;
            ListViewItem item = new ListViewItem();

            foreach (Utente u in list)
            {
                item = new ListViewItem(u.ToString().Trim(';'));
                listView.Items.Add(item);
            }

        }
    }
}