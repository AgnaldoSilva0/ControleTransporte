
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
            this.tbVeiculoEdit = new MetroFramework.Controls.MetroTextBox();
            this.btPlacaEdit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btCriar = new MetroFramework.Controls.MetroButton();
            this.dtDataEdit = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // tbVeiculoEdit
            // 
            // 
            // 
            // 
            this.tbVeiculoEdit.CustomButton.Image = null;
            this.tbVeiculoEdit.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbVeiculoEdit.CustomButton.Name = "";
            this.tbVeiculoEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbVeiculoEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbVeiculoEdit.CustomButton.TabIndex = 1;
            this.tbVeiculoEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbVeiculoEdit.CustomButton.UseSelectable = true;
            this.tbVeiculoEdit.CustomButton.Visible = false;
            this.tbVeiculoEdit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbVeiculoEdit.Lines = new string[0];
            this.tbVeiculoEdit.Location = new System.Drawing.Point(112, 113);
            this.tbVeiculoEdit.MaxLength = 32767;
            this.tbVeiculoEdit.Name = "tbVeiculoEdit";
            this.tbVeiculoEdit.PasswordChar = '\0';
            this.tbVeiculoEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVeiculoEdit.SelectedText = "";
            this.tbVeiculoEdit.SelectionLength = 0;
            this.tbVeiculoEdit.SelectionStart = 0;
            this.tbVeiculoEdit.ShortcutsEnabled = true;
            this.tbVeiculoEdit.Size = new System.Drawing.Size(214, 23);
            this.tbVeiculoEdit.TabIndex = 1;
            this.tbVeiculoEdit.UseSelectable = true;
            this.tbVeiculoEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbVeiculoEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPlacaEdit
            // 
            // 
            // 
            // 
            this.btPlacaEdit.CustomButton.Image = null;
            this.btPlacaEdit.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.btPlacaEdit.CustomButton.Name = "";
            this.btPlacaEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.btPlacaEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btPlacaEdit.CustomButton.TabIndex = 1;
            this.btPlacaEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btPlacaEdit.CustomButton.UseSelectable = true;
            this.btPlacaEdit.CustomButton.Visible = false;
            this.btPlacaEdit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.btPlacaEdit.Lines = new string[0];
            this.btPlacaEdit.Location = new System.Drawing.Point(112, 142);
            this.btPlacaEdit.MaxLength = 32767;
            this.btPlacaEdit.Name = "btPlacaEdit";
            this.btPlacaEdit.PasswordChar = '\0';
            this.btPlacaEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btPlacaEdit.SelectedText = "";
            this.btPlacaEdit.SelectionLength = 0;
            this.btPlacaEdit.SelectionStart = 0;
            this.btPlacaEdit.ShortcutsEnabled = true;
            this.btPlacaEdit.Size = new System.Drawing.Size(214, 23);
            this.btPlacaEdit.TabIndex = 2;
            this.btPlacaEdit.UseSelectable = true;
            this.btPlacaEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btPlacaEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(11, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Cliente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Veiculo: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Placa:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Data:";
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(112, 213);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(142, 32);
            this.btCriar.TabIndex = 8;
            this.btCriar.Text = "Criar";
            this.btCriar.UseSelectable = true;
            // 
            // dtDataEdit
            // 
            this.dtDataEdit.Location = new System.Drawing.Point(112, 169);
            this.dtDataEdit.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataEdit.Name = "dtDataEdit";
            this.dtDataEdit.Size = new System.Drawing.Size(214, 29);
            this.dtDataEdit.TabIndex = 9;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(112, 78);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(214, 29);
            this.metroComboBox1.TabIndex = 10;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Form_Novo_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 268);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.dtDataEdit);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btPlacaEdit);
            this.Controls.Add(this.tbVeiculoEdit);
            this.Name = "Form_Novo_Pedido";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbVeiculoEdit;
        private MetroFramework.Controls.MetroTextBox btPlacaEdit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btCriar;
        private MetroFramework.Controls.MetroDateTime dtDataEdit;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}