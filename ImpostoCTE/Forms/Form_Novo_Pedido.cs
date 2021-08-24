using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.Forms
{
    public partial class Form_Novo_Pedido : MetroFramework.Forms.MetroForm
    {
        public Form_Novo_Pedido()
        {
            InitializeComponent();
        }

        public Form_Novo_Pedido(string nome, string veiculo, string placa, string data)
        {
            InitializeComponent();
        }

    }
}
