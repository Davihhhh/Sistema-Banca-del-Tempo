namespace Sistema_Banca_del_Tempo
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private Banca_del_Tempo btd = new Banca_del_Tempo();
        private string nome, cognome, telefono, password;

        private const string eccezione = "Valori invalidi";

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            nome = textBoxNome.Text;
            cognome = textBoxCognome.Text;
            telefono = textBoxPassord.Text;
            password = textBoxTelefono.Text;

            try
            {
                Utente utente = new Utente(nome, cognome, telefono, password);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            Utente utente2 = new Utente(nome, cognome, telefono, password);

            btd.login(utente2);
        }
    }
}