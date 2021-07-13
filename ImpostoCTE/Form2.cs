using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listaTeste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Produto> listProduto = new List<Produto>();
        private void listaTeste()
        {
            listProduto.Add(new Produto("5000", "Parabrisa", 500, 5));
            listProduto.Add(new Produto("500", "Parabrisa", 700, 3));
            listProduto.Add(new Produto("50", "Parabrisa", 600, 1));
            listProduto.Add(new Produto("502", "Parabrisa", 400, 4));

            foreach (var item in listProduto)
            {
                listViewProdutos.Items.Add(new ListViewItem(new string[] { item.Codigo, item.Descricao, "R$ " + Convert.ToString(item.Preco), Convert.ToString( item.Preco) }));
            }

        }

    }
}
