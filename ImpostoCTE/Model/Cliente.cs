using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class Cliente
    {
        private int idCliente;
        private string nome, telefone;

        public Cliente(int idCliente, string nome, string telefone)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.telefone = telefone;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
