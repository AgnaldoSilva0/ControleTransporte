
namespace ImpostoCTE.Forms
{
    partial class Form_Novo_Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.tbPlaca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btCriar = new MetroFramework.Controls.MetroButton();
            this.dtData = new MetroFramework.Controls.MetroDateTime();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbIdOrcamento = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tbVeiculo
            // 
            // 
            // 
            // 
            this.tbVeiculo.CustomButton.Image = null;
            this.tbVeiculo.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbVeiculo.CustomButton.Name = "";
            this.tbVeiculo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbVeiculo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbVeiculo.CustomButton.TabIndex = 1;
            this.tbVeiculo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbVeiculo.CustomButton.UseSelectable = true;
            this.tbVeiculo.CustomButton.Visible = false;
            this.tbVeiculo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbVeiculo.Lines = new string[0];
            this.tbVeiculo.Location = new System.Drawing.Point(112, 134);
            this.tbVeiculo.MaxLength = 32767;
            this.tbVeiculo.Name = "tbVeiculo";
            this.tbVeiculo.PasswordChar = '\0';
            this.tbVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVeiculo.SelectedText = "";
            this.tbVeiculo.SelectionLength = 0;
            this.tbVeiculo.SelectionStart = 0;
            this.tbVeiculo.ShortcutsEnabled = true;
            this.tbVeiculo.Size = new System.Drawing.Size(214, 23);
            this.tbVeiculo.TabIndex = 1;
            this.tbVeiculo.UseSelectable = true;
            this.tbVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbVeiculo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPlaca
            // 
            // 
            // 
            // 
            this.tbPlaca.CustomButton.Image = null;
            this.tbPlaca.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbPlaca.CustomButton.Name = "";
            this.tbPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlaca.CustomButton.TabIndex = 1;
            this.tbPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlaca.CustomButton.UseSelectable = true;
            this.tbPlaca.CustomButton.Visible = false;
            this.tbPlaca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPlaca.Lines = new string[0];
            this.tbPlaca.Location = new System.Drawing.Point(112, 163);
            this.tbPlaca.MaxLength = 32767;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.PasswordChar = '\0';
            this.tbPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlaca.SelectedText = "";
            this.tbPlaca.SelectionLength = 0;
            this.tbPlaca.SelectionStart = 0;
            this.tbPlaca.ShortcutsEnabled = true;
            this.tbPlaca.Size = new System.Drawing.Size(214, 23);
            this.tbPlaca.TabIndex = 2;
            this.tbPlaca.UseSelectable = true;
            this.tbPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(11, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Cliente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Veiculo: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Placa:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 192);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Data:";
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(112, 235);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(142, 32);
            this.btCriar.TabIndex = 8;
            this.btCriar.Text = "Criar";
            this.btCriar.UseSelectable = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(112, 190);
            this.dtData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(214, 29);
            this.dtData.TabIndex = 9;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 23;
            this.cbCliente.Location = new System.Drawing.Point(112, 99);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(214, 29);
            this.cbCliente.TabIndex = 10;
            this.cbCliente.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Nº Orçamento:";
            // 
            // tbIdOrcamento
            // 
            // 
            // 
            // 
            this.tbIdOrcamento.CustomButton.Image = null;
            this.tbIdOrcamento.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbIdOrcamento.CustomButton.Name = "";
            this.tbIdOrcamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIdOrcamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIdOrcamento.CustomButton.TabIndex = 1;
            this.tbIdOrcamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIdOrcamento.CustomButton.UseSelectable = true;
            this.tbIdOrcamento.CustomButton.Visible = false;
            this.tbIdOrcamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbIdOrcamento.Lines = new string[0];
            this.tbIdOrcamento.Location = new System.Drawing.Point(112, 70);
            this.tbIdOrcamento.MaxLength = 32767;
            this.tbIdOrcamento.Name = "tbIdOrcamento";
            this.tbIdOrcamento.PasswordChar = '\0';
            this.tbIdOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIdOrcamento.SelectedText = "";
            this.tbIdOrcamento.SelectionLength = 0;
            this.tbIdOrcamento.SelectionStart = 0;
            this.tbIdOrcamento.ShortcutsEnabled = true;
            this.tbIdOrcamento.Size = new System.Drawing.Size(214, 23);
            this.tbIdOrcamento.TabIndex = 11;
            this.tbIdOrcamento.UseSelectable = true;
            this.tbIdOrcamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIdOrcamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form_Novo_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 290);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbIdOrcamento);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.tbVeiculo);
            this.Name = "Form_Novo_Pedido";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbVeiculo;
        private MetroFramework.Controls.MetroTextBox tbPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btCriar;
        private MetroFramework.Controls.MetroDateTime dtData;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbIdOrcamento;
    }
}