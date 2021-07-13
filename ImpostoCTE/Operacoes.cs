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
            double total = icms + pis + cofins + irt + cs;
            return total;
        }

        public static void impedirLetrasTextBox(object sender, KeyPressEventArgs e) 
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

    }
}
