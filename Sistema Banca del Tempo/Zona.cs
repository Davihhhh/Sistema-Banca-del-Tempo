using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banca_del_Tempo
{
    public class Zona
    {
        //properties
        public string Nome { get; private set; }

        //costruttori
        public Zona(string nome) { Nome = nome; }

        //funzioni
        public bool Equals(Zona z)
        {
            if(z == null) return false;
            else if(z == this) return true;
            else if(z.Nome.Equals(Nome)) return true;
            else return false;
        }
    }
}
