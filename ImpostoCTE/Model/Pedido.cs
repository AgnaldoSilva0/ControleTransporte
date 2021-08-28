using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class Pedido
    {
        #region Objeto Pedido para preencher tabela de cada pedido
        private int idCliente, idProduto, quantidade, idPedido;
        private string data, placa, modelo;

        public Pedido(int idCliente, int idProduto, int quantidade, string data, int idPedido, string placa, string modelo)
        {
            this.idCliente = idCliente;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.data = data;
            this.idPedido = idPedido;
            this.placa = placa;
            this.modelo = modelo;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Data { get => data; set => data = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        #endregion

        #region Variaveis staticas para uso de referencia
        //Variaveis de referência
        public static int idClienteRef, idOrcamentoRef;
        public static string nomeClienteRef, dataRef, veiculoRef, placaRef;
        #endregion


    }

}
