using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE
{
    class Produto
    {
        private String codigo, descricao, aplicacao;
        private double preco;
        private int ipi, estoque;
        public static int validator;

        public Produto(string codigo, string descricao, double preco, int ipi)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.ipi = ipi;
        }

        public Produto(string codigo, string descricao, double preco, int ipi, int estoque)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.ipi = ipi;
            this.estoque = estoque;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Ipi { get => ipi; set => ipi = value; }
        public string Aplicacao { get => aplicacao; set => aplicacao = value; }
        public int Estoque { get => estoque; set => estoque = value; }
    }
}
