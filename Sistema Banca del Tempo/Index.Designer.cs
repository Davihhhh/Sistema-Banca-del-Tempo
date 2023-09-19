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
            this.textBoxPassord = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonIndebitati = new System.Windows.Forms.Button();
            this.buttonTuttiUtenti = new System.Windows.Forms.Button();
            this.buttonOrePerPrestazione = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRimuoviPrestazione = new System.Windows.Forms.Button();
            this.buttonAggiungiPrestazione = new System.Windows.Forms.Button();
            this.textBoxNomePrestazione = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignIn.Location = new System.Drawing.Point(320, 321);
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
            this.buttonSignUp.Location = new System.Drawing.Point(574, 321);
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
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCognome.Location = new System.Drawing.Point(320, 158);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.PlaceholderText = "Cognome";
            this.textBoxCognome.Size = new System.Drawing.Size(380, 29);
            this.textBoxCognome.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefono.Location = new System.Drawing.Point(320, 193);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.PlaceholderText = "Telefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(380, 29);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // textBoxPassord
            // 
            this.textBoxPassord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassord.Location = new System.Drawing.Point(320, 228);
            this.textBoxPassord.Name = "textBoxPassord";
            this.textBoxPassord.PlaceholderText = "Password";
            this.textBoxPassord.Size = new System.Drawing.Size(380, 29);
            this.textBoxPassord.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Location = new System.Drawing.Point(12, 65);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(779, 509);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
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
            this.buttonLogout.Location = new System.Drawing.Point(907, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 32);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRimuoviPrestazione
            // 
            this.buttonRimuoviPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRimuoviPrestazione.Location = new System.Drawing.Point(897, 65);
            this.buttonRimuoviPrestazione.Name = "buttonRimuoviPrestazione";
            this.buttonRimuoviPrestazione.Size = new System.Drawing.Size(83, 47);
            this.buttonRimuoviPrestazione.TabIndex = 11;
            this.buttonRimuoviPrestazione.Text = "Rimuovi prestazione";
            this.buttonRimuoviPrestazione.UseVisualStyleBackColor = false;
            this.buttonRimuoviPrestazione.Visible = false;
            this.buttonRimuoviPrestazione.Click += new System.EventHandler(this.buttonRimuoviPrestazione_Click);
            // 
            // buttonAggiungiPrestazione
            // 
            this.buttonAggiungiPrestazione.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAggiungiPrestazione.Location = new System.Drawing.Point(806, 65);
            this.buttonAggiungiPrestazione.Name = "buttonAggiungiPrestazione";
            this.buttonAggiungiPrestazione.Size = new System.Drawing.Size(85, 47);
            this.buttonAggiungiPrestazione.TabIndex = 12;
            this.buttonAggiungiPrestazione.Text = "Aggiungi prestazione";
            this.buttonAggiungiPrestazione.UseVisualStyleBackColor = false;
            this.buttonAggiungiPrestazione.Visible = false;
            this.buttonAggiungiPrestazione.Click += new System.EventHandler(this.buttonAggiungiPrestazione_Click);
            // 
            // textBoxNomePrestazione
            // 
            this.textBoxNomePrestazione.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomePrestazione.Location = new System.Drawing.Point(806, 118);
            this.textBoxNomePrestazione.Name = "textBoxNomePrestazione";
            this.textBoxNomePrestazione.PlaceholderText = "Nome";
            this.textBoxNomePrestazione.Size = new System.Drawing.Size(174, 29);
            this.textBoxNomePrestazione.TabIndex = 13;
            this.textBoxNomePrestazione.Visible = false;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTempo.Location = new System.Drawing.Point(806, 153);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.PlaceholderText = "Tempo";
            this.textBoxTempo.Size = new System.Drawing.Size(174, 29);
            this.textBoxTempo.TabIndex = 14;
            this.textBoxTempo.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 586);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.textBoxNomePrestazione);
            this.Controls.Add(this.buttonAggiungiPrestazione);
            this.Controls.Add(this.buttonRimuoviPrestazione);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonOrePerPrestazione);
            this.Controls.Add(this.buttonTuttiUtenti);
            this.Controls.Add(this.buttonIndebitati);
            this.Controls.Add(this.textBoxPassord);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.listView);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button buttonRimuoviPrestazione;
        private Button buttonAggiungiPrestazione;
        private TextBox textBoxNomePrestazione;
        private TextBox textBoxTempo;
    }
}