namespace Sistema_Banca_del_Tempo
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSignIn = new Button();
            buttonSignUp = new Button();
            textBoxNome = new TextBox();
            textBoxCognome = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxPassord = new TextBox();
            listView = new ListView();
            buttonIndebitati = new Button();
            buttonTuttiUtenti = new Button();
            buttonOrePerPrestazione = new Button();
            buttonLogout = new Button();
            textBoxNomePrestazione = new TextBox();
            textBoxTempo = new TextBox();
            buttonCercaPrestazione = new Button();
            buttonOffriPrestaione = new Button();
            buttonRichiediPrestazione = new Button();
            buttonMiePrestazioniEseguite = new Button();
            buttonMiePrestazioniRicevute = new Button();
            buttonConfermaPrestazione = new Button();
            SuspendLayout();
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.PapayaWhip;
            buttonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignIn.Location = new Point(320, 321);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(126, 41);
            buttonSignIn.TabIndex = 0;
            buttonSignIn.Text = "SIGN IN";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.PapayaWhip;
            buttonSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(574, 321);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(126, 41);
            buttonSignUp.TabIndex = 1;
            buttonSignUp.Text = "SIGN UP";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(320, 123);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.PlaceholderText = "Nome";
            textBoxNome.Size = new Size(380, 29);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxCognome
            // 
            textBoxCognome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCognome.Location = new Point(320, 158);
            textBoxCognome.Name = "textBoxCognome";
            textBoxCognome.PlaceholderText = "Cognome";
            textBoxCognome.Size = new Size(380, 29);
            textBoxCognome.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.Location = new Point(320, 193);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(380, 29);
            textBoxTelefono.TabIndex = 4;
            // 
            // textBoxPassord
            // 
            textBoxPassord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassord.Location = new Point(320, 228);
            textBoxPassord.Name = "textBoxPassord";
            textBoxPassord.PlaceholderText = "Password";
            textBoxPassord.Size = new Size(380, 29);
            textBoxPassord.TabIndex = 5;
            // 
            // listView
            // 
            listView.BackColor = Color.White;
            listView.Location = new Point(12, 65);
            listView.Name = "listView";
            listView.Size = new Size(779, 509);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.Visible = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // buttonIndebitati
            // 
            buttonIndebitati.BackColor = Color.Honeydew;
            buttonIndebitati.Location = new Point(119, 12);
            buttonIndebitati.Name = "buttonIndebitati";
            buttonIndebitati.Size = new Size(101, 47);
            buttonIndebitati.TabIndex = 7;
            buttonIndebitati.Text = "Indebitati";
            buttonIndebitati.UseVisualStyleBackColor = false;
            buttonIndebitati.Visible = false;
            buttonIndebitati.Click += buttonIndebitati_Click;
            // 
            // buttonTuttiUtenti
            // 
            buttonTuttiUtenti.BackColor = Color.Honeydew;
            buttonTuttiUtenti.Location = new Point(12, 12);
            buttonTuttiUtenti.Name = "buttonTuttiUtenti";
            buttonTuttiUtenti.Size = new Size(101, 47);
            buttonTuttiUtenti.TabIndex = 8;
            buttonTuttiUtenti.Text = "Tutti";
            buttonTuttiUtenti.UseVisualStyleBackColor = false;
            buttonTuttiUtenti.Visible = false;
            buttonTuttiUtenti.Click += buttonTuttiUtenti_Click;
            // 
            // buttonOrePerPrestazione
            // 
            buttonOrePerPrestazione.BackColor = Color.Honeydew;
            buttonOrePerPrestazione.Location = new Point(226, 12);
            buttonOrePerPrestazione.Name = "buttonOrePerPrestazione";
            buttonOrePerPrestazione.Size = new Size(101, 47);
            buttonOrePerPrestazione.TabIndex = 9;
            buttonOrePerPrestazione.Text = "Ore per prestazione";
            buttonOrePerPrestazione.UseVisualStyleBackColor = false;
            buttonOrePerPrestazione.Visible = false;
            buttonOrePerPrestazione.Click += buttonOrePerPrestazione_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Location = new Point(1007, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 32);
            buttonLogout.TabIndex = 10;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Visible = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // textBoxNomePrestazione
            // 
            textBoxNomePrestazione.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomePrestazione.Location = new Point(806, 193);
            textBoxNomePrestazione.Name = "textBoxNomePrestazione";
            textBoxNomePrestazione.PlaceholderText = "Nome";
            textBoxNomePrestazione.Size = new Size(276, 29);
            textBoxNomePrestazione.TabIndex = 13;
            textBoxNomePrestazione.Visible = false;
            // 
            // textBoxTempo
            // 
            textBoxTempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTempo.Location = new Point(806, 228);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.PlaceholderText = "Tempo";
            textBoxTempo.Size = new Size(276, 29);
            textBoxTempo.TabIndex = 14;
            textBoxTempo.Visible = false;
            // 
            // buttonCercaPrestazione
            // 
            buttonCercaPrestazione.BackColor = Color.Honeydew;
            buttonCercaPrestazione.Location = new Point(806, 123);
            buttonCercaPrestazione.Name = "buttonCercaPrestazione";
            buttonCercaPrestazione.Size = new Size(85, 47);
            buttonCercaPrestazione.TabIndex = 15;
            buttonCercaPrestazione.Text = "Cerca prestazine";
            buttonCercaPrestazione.UseVisualStyleBackColor = false;
            buttonCercaPrestazione.Visible = false;
            buttonCercaPrestazione.Click += buttonCercaPrestazione_Click;
            // 
            // buttonOffriPrestaione
            // 
            buttonOffriPrestaione.BackColor = Color.Honeydew;
            buttonOffriPrestaione.Location = new Point(806, 65);
            buttonOffriPrestaione.Name = "buttonOffriPrestaione";
            buttonOffriPrestaione.Size = new Size(85, 47);
            buttonOffriPrestaione.TabIndex = 16;
            buttonOffriPrestaione.Text = "Offri prestazione";
            buttonOffriPrestaione.UseVisualStyleBackColor = false;
            buttonOffriPrestaione.Visible = false;
            buttonOffriPrestaione.Click += buttonOffriPrestaione_Click;
            // 
            // buttonRichiediPrestazione
            // 
            buttonRichiediPrestazione.BackColor = Color.Honeydew;
            buttonRichiediPrestazione.Location = new Point(897, 65);
            buttonRichiediPrestazione.Name = "buttonRichiediPrestazione";
            buttonRichiediPrestazione.Size = new Size(85, 47);
            buttonRichiediPrestazione.TabIndex = 17;
            buttonRichiediPrestazione.Text = "Richiedi prestazine";
            buttonRichiediPrestazione.UseVisualStyleBackColor = false;
            buttonRichiediPrestazione.Visible = false;
            buttonRichiediPrestazione.Click += buttonRichiediPrestazione_Click;
            // 
            // buttonMiePrestazioniEseguite
            // 
            buttonMiePrestazioniEseguite.BackColor = Color.Honeydew;
            buttonMiePrestazioniEseguite.Location = new Point(333, 12);
            buttonMiePrestazioniEseguite.Name = "buttonMiePrestazioniEseguite";
            buttonMiePrestazioniEseguite.Size = new Size(101, 47);
            buttonMiePrestazioniEseguite.TabIndex = 18;
            buttonMiePrestazioniEseguite.Text = "Prestazioni eseguite";
            buttonMiePrestazioniEseguite.UseVisualStyleBackColor = false;
            buttonMiePrestazioniEseguite.Visible = false;
            buttonMiePrestazioniEseguite.Click += buttonMiePrestazioniEseguite_Click;
            // 
            // buttonMiePrestazioniRicevute
            // 
            buttonMiePrestazioniRicevute.BackColor = Color.Honeydew;
            buttonMiePrestazioniRicevute.Location = new Point(440, 12);
            buttonMiePrestazioniRicevute.Name = "buttonMiePrestazioniRicevute";
            buttonMiePrestazioniRicevute.Size = new Size(101, 47);
            buttonMiePrestazioniRicevute.TabIndex = 19;
            buttonMiePrestazioniRicevute.Text = "Prestazioni ricevute";
            buttonMiePrestazioniRicevute.UseVisualStyleBackColor = false;
            buttonMiePrestazioniRicevute.Visible = false;
            buttonMiePrestazioniRicevute.Click += buttonMiePrestazioniRicevute_Click;
            // 
            // buttonConfermaPrestazione
            // 
            buttonConfermaPrestazione.BackColor = Color.Honeydew;
            buttonConfermaPrestazione.Location = new Point(547, 12);
            buttonConfermaPrestazione.Name = "buttonConfermaPrestazione";
            buttonConfermaPrestazione.Size = new Size(85, 47);
            buttonConfermaPrestazione.TabIndex = 20;
            buttonConfermaPrestazione.Text = "Conferma prestazione";
            buttonConfermaPrestazione.UseVisualStyleBackColor = false;
            buttonConfermaPrestazione.Visible = false;
            buttonConfermaPrestazione.Click += buttonConfermaPrestazione_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 586);
            Controls.Add(buttonConfermaPrestazione);
            Controls.Add(buttonMiePrestazioniRicevute);
            Controls.Add(buttonMiePrestazioniEseguite);
            Controls.Add(buttonRichiediPrestazione);
            Controls.Add(buttonOffriPrestaione);
            Controls.Add(buttonCercaPrestazione);
            Controls.Add(textBoxTempo);
            Controls.Add(textBoxNomePrestazione);
            Controls.Add(buttonLogout);
            Controls.Add(buttonOrePerPrestazione);
            Controls.Add(buttonTuttiUtenti);
            Controls.Add(buttonIndebitati);
            Controls.Add(textBoxPassord);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxCognome);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonSignIn);
            Controls.Add(listView);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            Load += Index_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignIn;
        private Button buttonSignUp;
        private TextBox textBoxNome;
        private TextBox textBoxCognome;
        private TextBox textBoxTelefono;
        private TextBox textBoxPassord;
        private ListView listView;
        private Button buttonIndebitati;
        private Button buttonTuttiUtenti;
        private Button buttonOrePerPrestazione;
        private Button buttonLogout;
        private TextBox textBoxNomePrestazione;
        private TextBox textBoxTempo;
        private Button buttonCercaPrestazione;
        private Button buttonOffriPrestaione;
        private Button buttonRichiediPrestazione;
        private Button buttonMiePrestazioniEseguite;
        private Button buttonMiePrestazioniRicevute;
        private Button buttonConfermaPrestazione;
    }
}