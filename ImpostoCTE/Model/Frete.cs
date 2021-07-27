using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class Frete
    {
        private string data, veiculo, placa, cidade, tomador, observacao;
        private int cte, mdfe;
        private double valorFrete;

        public Frete(string data, string veiculo, string placa, string cidade, string tomador, string observacao, int cte, int mdfe, double valorFrete)
        {
            this.data = data;
            this.veiculo = veiculo;
            this.placa = placa;
            this.cidade = cidade;
            this.tomador = tomador;
            this.observacao = observacao;
            this.cte = cte;
            this.mdfe = mdfe;
            this.valorFrete = valorFrete;
        }

        public Frete()
        {
        }

        public string Data { get => data; set => data = value; }
        public string Veiculo { get => veiculo; set => veiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Tomador { get => tomador; set => tomador = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public int Cte { get => cte; set => cte = value; }
        public int Mdfe { get => mdfe; set => mdfe = value; }
        public double ValorFrete { get => valorFrete; set => valorFrete = value; }
    }
}
