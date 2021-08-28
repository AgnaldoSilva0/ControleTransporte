using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class ItensPedido
    {
        string codigo, descricao;
        double precoUni, precoTotal;
        int quantidade;

        public ItensPedido(string codigo, string descricao, double precoUni, double precoTotal, int quantidade)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.precoUni = precoUni;
            this.precoTotal = precoTotal;
            this.quantidade = quantidade;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double PrecoUni { get => precoUni; set => precoUni = value; }
        public double PrecoTotal { get => precoUni * quantidade; set => precoTotal = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
