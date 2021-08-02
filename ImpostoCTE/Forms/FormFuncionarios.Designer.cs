
namespace ImpostoCTE.Forms
{
    partial class FormFuncionarios
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbDescontoAviso = new System.Windows.Forms.Label();
            this.lbValorTotalImpostos = new System.Windows.Forms.Label();
            this.btCadastrarFuncionario = new System.Windows.Forms.Button();
            this.metroSetListBox1 = new MetroSet_UI.Controls.MetroSetListBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lbDescontoAviso);
            this.panel3.Controls.Add(this.lbValorTotalImpostos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(12, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 100);
            this.panel3.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(456, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 7);
            this.label17.TabIndex = 1;
            this.label17.Text = "V 1.0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(6, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(205, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Valor Total de Impostos:";
            // 
            // lbDescontoAviso
            // 
            this.lbDescontoAviso.AutoSize = true;
            this.lbDescontoAviso.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbDescontoAviso.Location = new System.Drawing.Point(265, 67);
            this.lbDescontoAviso.Name = "lbDescontoAviso";
            this.lbDescontoAviso.Size = new System.Drawing.Size(56, 22);
            this.lbDescontoAviso.TabIndex = 2;
            this.lbDescontoAviso.Text = "NULL";
            // 
            // lbValorTotalImpostos
            // 
            this.lbValorTotalImpostos.AutoSize = true;
            this.lbValorTotalImpostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalImpostos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbValorTotalImpostos.Location = new System.Drawing.Point(264, 38);
            this.lbValorTotalImpostos.Name = "lbValorTotalImpostos";
            this.lbValorTotalImpostos.Size = new System.Drawing.Size(38, 24);
            this.lbValorTotalImpostos.TabIndex = 0;
            this.lbValorTotalImpostos.Text = "0.0";
            // 
            // btCadastrarFuncionario
            // 
            this.btCadastrarFuncionario.Location = new System.Drawing.Point(12, 399);
            this.btCadastrarFuncionario.Name = "btCadastrarFuncionario";
            this.btCadastrarFuncionario.Size = new System.Drawing.Size(118, 34);
            this.btCadastrarFuncionario.TabIndex = 3;
            this.btCadastrarFuncionario.Text = "Cadastrar";
            this.btCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btCadastrarFuncionario.Click += new System.EventHandler(this.btCadastrarFuncionario_Click);
            // 
            // metroSetListBox1
            // 
            this.metroSetListBox1.BackColor = System.Drawing.Color.White;
            this.metroSetListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.metroSetListBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetListBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetListBox1.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroSetListBox1.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroSetListBox1.IsDerivedStyle = true;
            this.metroSetListBox1.ItemHeight = 30;
            this.metroSetListBox1.Items.Add("Nome");
            this.metroSetListBox1.Items.Add("Salário");
            this.metroSetListBox1.Location = new System.Drawing.Point(15, 96);
            this.metroSetListBox1.MultiSelect = false;
            this.metroSetListBox1.Name = "metroSetListBox1";
            this.metroSetListBox1.SelectedIndex = -1;
            this.metroSetListBox1.SelectedItem = null;
            this.metroSetListBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetListBox1.SelectedItemColor = System.Drawing.Color.White;
            this.metroSetListBox1.SelectedText = null;
            this.metroSetListBox1.SelectedValue = null;
            this.metroSetListBox1.ShowBorder = true;
            this.metroSetListBox1.ShowScrollBar = true;
            this.metroSetListBox1.Size = new System.Drawing.Size(412, 77);
            this.metroSetListBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetListBox1.StyleManager = null;
            this.metroSetListBox1.TabIndex = 4;
            this.metroSetListBox1.ThemeAuthor = "Narwin";
            this.metroSetListBox1.ThemeName = "MetroLite";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 566);
            this.Controls.Add(this.metroSetListBox1);
            this.Controls.Add(this.btCadastrarFuncionario);
            this.Controls.Add(this.panel3);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDescontoAviso;
        private System.Windows.Forms.Label lbValorTotalImpostos;
        private System.Windows.Forms.Button btCadastrarFuncionario;
        private MetroSet_UI.Controls.MetroSetListBox metroSetListBox1;
    }
}