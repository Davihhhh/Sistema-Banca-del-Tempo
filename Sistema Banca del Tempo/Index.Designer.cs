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
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonIndebitati = new System.Windows.Forms.Button();
            this.buttonTuttiUtenti = new System.Windows.Forms.Button();
            this.buttonOrePerPrestazione = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxNomePrestazione = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.buttonCercaPrestazione = new System.Windows.Forms.Button();
            this.buttonOffriPrestaione = new System.Windows.Forms.Button();
            this.buttonRichiediPrestazione = new System.Windows.Forms.Button();
            this.buttonMiePrestazioniEseguite = new System.Windows.Forms.Button();
            this.buttonMiePrestazioniRicevute = new System.Windows.Forms.Button();
            this.buttonConfermaPrestazione = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonRimuoviUtente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignIn.Location = new System.Drawing.Point(320, 360);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(126, 41);
            this.buttonSignIn.TabIndex = 0;
            this.buttonSignIn.Text = "SIGN IN";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignUp.Location = new System.Drawing.Point(574, 360);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(126, 41);
            this.buttonSignUp.TabIndex = 1;
            this.buttonSignUp.Text = "SIGN UP";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(320, 123);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome";
            this.textBoxNome.Size = new System.Drawing.Size(380, 29);
            this.textBoxNome.TabIndex = 2;
            this.textBoxNome.Text = "mario";
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCognome.Location = new System.Drawing.Point(320, 158);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.PlaceholderText = "Cognome";
            this.textBoxCognome.Size = new System.Drawing.Size(380, 29);
            this.textBoxCognome.TabIndex = 3;
            this.textBoxCognome.Text = "rossi";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefono.Location = new System.Drawing.Point(320, 193);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.PlaceholderText = "Telefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(380, 29);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.Text = "1234567890";
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(320, 228);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(380, 29);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "fsj9823";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Location = new System.Drawing.Point(12, 65);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(359, 509);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Visible = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // buttonIndebitati
            // 
            this.buttonIndebitati.BackColor = System.Drawing.Color.Honeydew;
            this.buttonIndebitati.Location = new System.Drawing.Point(119, 12);
            this.buttonIndebitati.Name = "buttonIndebitati";
            this.buttonIndebitati.Size = new System.Drawing.Size(101, 47);
            this.buttonIndebitati.TabIndex = 7;
            this.buttonIndebitati.Text = "Indebitati";
            this.buttonIndebitati.UseVisualStyleBackColor = false;
            this.buttonIndebitati.Visible = false;
            this.buttonIndebitati.Click += new System.EventHandler(this.buttonIndebitati_Click);
            // 
            // buttonTuttiUtenti
            // 
            this.buttonTuttiUtenti.BackColor = System.Drawing.Color.Honeydew;
            this.buttonTuttiUtenti.Location = new System.Drawing.Point(12, 12);
            this.buttonTuttiUtenti.Name = "buttonTuttiUtenti";
            this.buttonTuttiUtenti.Size = new System.Drawing.Size(101, 47);
            this.buttonTuttiUtenti.TabIndex = 8;
            this.buttonTuttiUtenti.Text = "Tutti";
            this.buttonTuttiUtenti.UseVisualStyleBackColor = false;
            this.buttonTuttiUtenti.Visible = false;
            this.buttonTuttiUtenti.Click += new System.EventHandler(this.buttonTuttiUtenti_Click);
            // 
            // buttonOrePerPrestazione
            // 
            this.buttonOrePerPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonOrePerPrestazione.Location = new System.Drawing.Point(226, 12);
            this.buttonOrePerPrestazione.Name = "buttonOrePerPrestazione";
            this.buttonOrePerPrestazione.Size = new System.Drawing.Size(101, 47);
            this.buttonOrePerPrestazione.TabIndex = 9;
            this.buttonOrePerPrestazione.Text = "Ore per prestazione";
            this.buttonOrePerPrestazione.UseVisualStyleBackColor = false;
            this.buttonOrePerPrestazione.Visible = false;
            this.buttonOrePerPrestazione.Click += new System.EventHandler(this.buttonOrePerPrestazione_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.MistyRose;
            this.buttonLogout.Location = new System.Drawing.Point(942, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 32);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxNomePrestazione
            // 
            this.textBoxNomePrestazione.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomePrestazione.Location = new System.Drawing.Point(738, 123);
            this.textBoxNomePrestazione.Name = "textBoxNomePrestazione";
            this.textBoxNomePrestazione.PlaceholderText = "Nome prestazione";
            this.textBoxNomePrestazione.Size = new System.Drawing.Size(358, 29);
            this.textBoxNomePrestazione.TabIndex = 13;
            this.textBoxNomePrestazione.Visible = false;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTempo.Location = new System.Drawing.Point(738, 158);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.PlaceholderText = "Durata";
            this.textBoxTempo.Size = new System.Drawing.Size(358, 29);
            this.textBoxTempo.TabIndex = 14;
            this.textBoxTempo.Visible = false;
            // 
            // buttonCercaPrestazione
            // 
            this.buttonCercaPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonCercaPrestazione.Location = new System.Drawing.Point(920, 65);
            this.buttonCercaPrestazione.Name = "buttonCercaPrestazione";
            this.buttonCercaPrestazione.Size = new System.Drawing.Size(85, 47);
            this.buttonCercaPrestazione.TabIndex = 15;
            this.buttonCercaPrestazione.Text = "Cerca prestazione";
            this.buttonCercaPrestazione.UseVisualStyleBackColor = false;
            this.buttonCercaPrestazione.Visible = false;
            this.buttonCercaPrestazione.Click += new System.EventHandler(this.buttonCercaPrestazione_Click);
            // 
            // buttonOffriPrestaione
            // 
            this.buttonOffriPrestaione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonOffriPrestaione.Location = new System.Drawing.Point(738, 65);
            this.buttonOffriPrestaione.Name = "buttonOffriPrestaione";
            this.buttonOffriPrestaione.Size = new System.Drawing.Size(85, 47);
            this.buttonOffriPrestaione.TabIndex = 16;
            this.buttonOffriPrestaione.Text = "Offri prestazione";
            this.buttonOffriPrestaione.UseVisualStyleBackColor = false;
            this.buttonOffriPrestaione.Visible = false;
            this.buttonOffriPrestaione.Click += new System.EventHandler(this.buttonOffriPrestaione_Click);
            // 
            // buttonRichiediPrestazione
            // 
            this.buttonRichiediPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRichiediPrestazione.Location = new System.Drawing.Point(829, 65);
            this.buttonRichiediPrestazione.Name = "buttonRichiediPrestazione";
            this.buttonRichiediPrestazione.Size = new System.Drawing.Size(85, 47);
            this.buttonRichiediPrestazione.TabIndex = 17;
            this.buttonRichiediPrestazione.Text = "Richiedi prestazine";
            this.buttonRichiediPrestazione.UseVisualStyleBackColor = false;
            this.buttonRichiediPrestazione.Visible = false;
            this.buttonRichiediPrestazione.Click += new System.EventHandler(this.buttonRichiediPrestazione_Click);
            // 
            // buttonMiePrestazioniEseguite
            // 
            this.buttonMiePrestazioniEseguite.BackColor = System.Drawing.Color.Honeydew;
            this.buttonMiePrestazioniEseguite.Location = new System.Drawing.Point(333, 12);
            this.buttonMiePrestazioniEseguite.Name = "buttonMiePrestazioniEseguite";
            this.buttonMiePrestazioniEseguite.Size = new System.Drawing.Size(101, 47);
            this.buttonMiePrestazioniEseguite.TabIndex = 18;
            this.buttonMiePrestazioniEseguite.Text = "Prestazioni eseguite";
            this.buttonMiePrestazioniEseguite.UseVisualStyleBackColor = false;
            this.buttonMiePrestazioniEseguite.Visible = false;
            this.buttonMiePrestazioniEseguite.Click += new System.EventHandler(this.buttonMiePrestazioniEseguite_Click);
            // 
            // buttonMiePrestazioniRicevute
            // 
            this.buttonMiePrestazioniRicevute.BackColor = System.Drawing.Color.Honeydew;
            this.buttonMiePrestazioniRicevute.Location = new System.Drawing.Point(440, 12);
            this.buttonMiePrestazioniRicevute.Name = "buttonMiePrestazioniRicevute";
            this.buttonMiePrestazioniRicevute.Size = new System.Drawing.Size(101, 47);
            this.buttonMiePrestazioniRicevute.TabIndex = 19;
            this.buttonMiePrestazioniRicevute.Text = "Prestazioni ricevute";
            this.buttonMiePrestazioniRicevute.UseVisualStyleBackColor = false;
            this.buttonMiePrestazioniRicevute.Visible = false;
            this.buttonMiePrestazioniRicevute.Click += new System.EventHandler(this.buttonMiePrestazioniRicevute_Click);
            // 
            // buttonConfermaPrestazione
            // 
            this.buttonConfermaPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonConfermaPrestazione.Location = new System.Drawing.Point(1011, 65);
            this.buttonConfermaPrestazione.Name = "buttonConfermaPrestazione";
            this.buttonConfermaPrestazione.Size = new System.Drawing.Size(85, 47);
            this.buttonConfermaPrestazione.TabIndex = 20;
            this.buttonConfermaPrestazione.Text = "Conferma prestazione";
            this.buttonConfermaPrestazione.UseVisualStyleBackColor = false;
            this.buttonConfermaPrestazione.Visible = false;
            this.buttonConfermaPrestazione.Click += new System.EventHandler(this.buttonConfermaPrestazione_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Location = new System.Drawing.Point(1023, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.BackColor = System.Drawing.Color.White;
            this.comboBoxZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Location = new System.Drawing.Point(320, 263);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(380, 29);
            this.comboBoxZone.TabIndex = 22;
            this.comboBoxZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxZone_SelectedIndexChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(740, 193);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "Id utente";
            this.textBoxId.Size = new System.Drawing.Size(358, 29);
            this.textBoxId.TabIndex = 23;
            this.textBoxId.Visible = false;
            // 
            // buttonRimuoviUtente
            // 
            this.buttonRimuoviUtente.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRimuoviUtente.Location = new System.Drawing.Point(547, 12);
            this.buttonRimuoviUtente.Name = "buttonRimuoviUtente";
            this.buttonRimuoviUtente.Size = new System.Drawing.Size(101, 47);
            this.buttonRimuoviUtente.TabIndex = 24;
            this.buttonRimuoviUtente.Text = "Rimuovi utente";
            this.buttonRimuoviUtente.UseVisualStyleBackColor = false;
            this.buttonRimuoviUtente.Visible = false;
            this.buttonRimuoviUtente.Click += new System.EventHandler(this.buttonRimuoviUtente_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 586);
            this.Controls.Add(this.buttonRimuoviUtente);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.comboBoxZone);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfermaPrestazione);
            this.Controls.Add(this.buttonMiePrestazioniRicevute);
            this.Controls.Add(this.buttonMiePrestazioniEseguite);
            this.Controls.Add(this.buttonRichiediPrestazione);
            this.Controls.Add(this.buttonOffriPrestaione);
            this.Controls.Add(this.buttonCercaPrestazione);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.textBoxNomePrestazione);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonOrePerPrestazione);
            this.Controls.Add(this.buttonTuttiUtenti);
            this.Controls.Add(this.buttonIndebitati);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.listView);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Index_Load_1);
            this.Click += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSignIn;
        private Button buttonSignUp;
        private TextBox textBoxNome;
        private TextBox textBoxCognome;
        private TextBox textBoxTelefono;
        private TextBox textBoxPassword;
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
        private Button buttonExit;
        private ComboBox comboBoxZone;
        private TextBox textBoxId;
        private Button buttonRimuoviUtente;
    }
}