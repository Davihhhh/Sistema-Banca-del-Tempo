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
        public int Tempo { get; private set; }

        //costruttori
        public Prestazione(string nome, int tempo)
        {
            if (string.IsNullOrEmpty(nome) || tempo < 0)
                throw new Exception("Valori prestazione invalidi");
            Nome = nome;
            Tempo = tempo;
        }

        //funzioni
        public bool Equals(Prestazione obj)
        {
            if(obj == null) return false;
            if(obj == this) return true;
            if (obj.Nome == this.Nome)
                if (obj.Tempo == this.Tempo)
                    return true;
                else return false;
            else return false;            
        }
        public override string ToString()
        {
            return Nome + ';' + Tempo;
        }
    }
}
