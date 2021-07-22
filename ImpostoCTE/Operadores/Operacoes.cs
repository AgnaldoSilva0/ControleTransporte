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
            return valorFrete + imposto + diaria + combustivel + outrasDespesas;
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

    }
}
