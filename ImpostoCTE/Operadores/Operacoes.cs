using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    class Operacoes
    {
        public static Double calcularTotalImposto(double icms, double pis, double cofins, double irt, double cs)
        {
            return icms + pis + cofins + irt + cs;
        }

        public static Double calcularLucroFrete(double valorFrete, double imposto, double diaria, double combustivel, double outrasDespesas)
        {
            return valorFrete - (imposto + diaria + combustivel + outrasDespesas);
        }

        public static void impedirLetrasTextBox(object sender, KeyPressEventArgs e) 
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != '.')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        public static void validator(MetroSet_UI.Controls.MetroSetTextBox textBox, string label)
        {
            textBox.BorderColor = System.Drawing.Color.Crimson;
            textBox.Focus();
            MessageBox.Show(label);
        }

        public static void validator(MetroSet_UI.Controls.MetroSetTextBox textBox, string label, MetroSet_UI.Controls.MetroSetTextBox textBoxAnterior)
        {
            textBoxAnterior.BorderColor = System.Drawing.Color.Black;
            textBox.BorderColor = System.Drawing.Color.Crimson;
            textBox.Focus();
            MessageBox.Show(label);
        }

        public static void validator(MetroSet_UI.Controls.MetroSetComboBox textBox, string label, MetroSet_UI.Controls.MetroSetTextBox textBoxAnterior)
        {
            textBoxAnterior.BorderColor = System.Drawing.Color.Black;
            textBox.BorderColor = System.Drawing.Color.Crimson;
            textBox.Focus();
            MessageBox.Show(label);
        }

    }
}
