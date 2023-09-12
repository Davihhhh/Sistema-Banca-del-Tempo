using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banca_del_Tempo
{
    public class Prestazione
    {
        private string _nome;
        private int _tempo;
        private bool _completato;

        public string Nome { get; private set; }
        public int Tempo { get; private set; }
        public bool Completato { get; private set; }

        public Prestazione(string nome, int tempo)
        {
            if (string.IsNullOrEmpty(nome) || tempo < 0)
                throw new Exception("Valori prestazione invalidi");
            Nome = nome;
            Tempo = tempo;
            Completato = false;
        }

        public void confermaPrestazione()
        {
            Completato = true;
        }

    }
}
