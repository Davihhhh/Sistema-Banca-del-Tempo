using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banca_del_Tempo
{
    public class Prestazione
    {     
        //properties
        public string Nome { get; private set; }
        public Utente Utente_Che_Esegue { get; private set; }
        public int Tempo { get; private set; }
        
        //costruttori
        public Prestazione(string nome, Utente che_esegue, int tempo)
        {
            if (string.IsNullOrEmpty(nome) || tempo < 0)
                throw new Exception("Valori prestazione invalidi");
            Nome = nome;
            Utente_Che_Esegue = che_esegue;
            Tempo = tempo;
        }

        //funzioni
        public bool Equals(Prestazione obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.Nome == this.Nome && obj.Tempo == this.Tempo && obj.Utente_Che_Esegue == this.Utente_Che_Esegue)
                return true;
            else return false;
        }
        public override string ToString()
        {
            return Nome + ';' + Utente_Che_Esegue.ToString() + ';' + Tempo;
        }
    }
}
