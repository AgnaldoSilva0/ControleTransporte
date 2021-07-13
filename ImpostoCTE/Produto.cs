using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE
{
    class Produto
    {
        private String codigo, descricao;
        private double preco;
        private int ipi;

        public Produto(string codigo, string descricao, double preco, int ipi)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.ipi = ipi;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Ipi { get => ipi; set => ipi = value; }
    }
}
