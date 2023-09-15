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
            listView.Size = new Size(779, 383);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.Visible = false;
            // 
            // buttonIndebitati
            // 
            buttonIndebitati.BackColor = Color.Honeydew;
            buttonIndebitati.Location = new Point(119, 32);
            buttonIndebitati.Name = "buttonIndebitati";
            buttonIndebitati.Size = new Size(101, 27);
            buttonIndebitati.TabIndex = 7;
            buttonIndebitati.Text = "Indebitati";
            buttonIndebitati.UseVisualStyleBackColor = false;
            buttonIndebitati.Visible = false;
            // 
            // buttonTuttiUtenti
            // 
            buttonTuttiUtenti.BackColor = Color.Honeydew;
            buttonTuttiUtenti.Location = new Point(12, 32);
            buttonTuttiUtenti.Name = "buttonTuttiUtenti";
            buttonTuttiUtenti.Size = new Size(101, 27);
            buttonTuttiUtenti.TabIndex = 8;
            buttonTuttiUtenti.Text = "Tutti";
            buttonTuttiUtenti.UseVisualStyleBackColor = false;
            buttonTuttiUtenti.Visible = false;
            buttonTuttiUtenti.Click += buttonTuttiUtenti_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 586);
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
    }
}