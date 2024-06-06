using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }

        public Contato(int id, string nome, string numero)
        {
            this.id = id;
            this.nome = nome;
            this.numero = numero;
        }
    }
}
