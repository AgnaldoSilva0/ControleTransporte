using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class Pedido
    {
        private int idCliente, idProduto, quantidade;
        private string data;

        public Pedido(int idCliente, int idProduto, int quantidade, string data)
        {
            this.idCliente = idCliente;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.data = data;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Data { get => data; set => data = value; }


        //Variaveis de referência
        public static int idClienteRef, idOrcamentoRef;
        public static string nomeClienteRef, dataRef, veiculoRef, placaRef;
    }

}
