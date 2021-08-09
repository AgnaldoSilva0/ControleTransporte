using ImpostoCTE.Forms;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        int X = 0;
        int Y = 0;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }



        #region Customização Botão
        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
            panelSubMenuProduto.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btMenuProduto_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuProduto);
        }

        private Form activeForm = null;
        private void openChieldForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        #region MudarCorImpostosCheckBox
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbIcms, lbIcmsAtivado, checkBox5);
            if (checkBox5.Checked == false)
            {
                Impostos.icms = 0;
            } else
            {
                Impostos.icms = 18.0;
            }
            //PerformClick pra executar o botão calcular imposto
            button6.PerformClick();
         }

        private void cbPis_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbPis, lbPisAtivado, cbPis);
            if (cbPis.Checked == false)
            {
                Impostos.pis = 0;
            }
            else
            {
                Impostos.pis = 0.65;
            }
            //PerformClick pra executar o botão calcular imposto
            button6.PerformClick();
        }

        private void cbCofins_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbCofins, lbCofinsAtivado, cbCofins);
            if (cbCofins.Checked == false)
            {
                Impostos.cofins = 0;
            }
            else
            {
                Impostos.cofins = 3.0;
            }
            //PerformClick pra executar o botão calcular imposto
            button6.PerformClick();
        }

        private void cbImpTrim_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbImpTri, lbIrtAtivado, cbImpTrim);
            if (cbImpTrim.Checked == false)
            {
                Impostos.impTri = 0;
            }
            else
            {
                Impostos.impTri = 1.2;
            }
            //PerformClick pra executar o botão calcular imposto
            button6.PerformClick();
        }

        private void cbConSocial_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbConSocial, lbCsAtivado, cbConSocial);
            if (cbConSocial.Checked == false)
            {
                Impostos.conSocial = 0;
            }
            else
            {
                Impostos.conSocial = 1.08;
            }
            //PerformClick pra executar o botão calcular imposto
            button6.PerformClick();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.ForeColor = Color.FromArgb(26, 229, 190);
            }
            else
            {
                checkBox6.ForeColor = Color.FromArgb(93, 93, 91);
            }
        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Impostos imp = new Impostos();
                imp.ValorFrete = Convert.ToDouble(mtbValorFrete.Text);

                lbIcmsResult.Text = "R$ " + Convert.ToString(imp.Icms);
                lbPisResult.Text = "R$ " + Convert.ToString(imp.Pis);
                lbCofinsResult.Text = "R$ " + Convert.ToString(imp.Cofins);
                lbIrtResult.Text = "R$ " + Convert.ToString(imp.ImpTri);
                lbCsResult.Text = "R$ " + Convert.ToString(imp.ConSocial);

                if (checkBox6.Checked == true)
                {
                    double icms = imp.Icms - (imp.Icms * 20 / 100);
                    lbIcmsResult.Text = "R$ " + Convert.ToString(icms);
                    lbValorTotalImpostos.Text = "R$ " + Convert.ToString(Operacoes.calcularTotalImposto(icms, imp.Pis, imp.Cofins, imp.ImpTri, imp.ConSocial));
                    lbDescontoAviso.Text = "Desconto aplicado no valor total";
                    lbDescontoAviso.ForeColor = Color.FromArgb(26, 229, 190);

                    return;
                }

                lbValorTotalImpostos.Text = "R$ " + Convert.ToString(Operacoes.calcularTotalImposto(imp.Icms, imp.Pis, imp.Cofins, imp.ImpTri, imp.ConSocial));
                lbDescontoAviso.Text = "Desconto não aplicado no valor total";
                lbDescontoAviso.ForeColor = Color.FromArgb(93, 93, 91);
            } catch (Exception)
            {
                MessageBox.Show("Insira um valor");
            }
            
        }

        private void mtbValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void testando(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChieldForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChieldForm(new FormLucroFrete());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Cad_Prod formCadProd = new Form_Cad_Prod();
            formCadProd.ShowDialog();
        }

        private void btListaFrete_Click(object sender, EventArgs e)
        {
            openChieldForm(new Forms.FormListaFrete());
        }

    }

   


}
