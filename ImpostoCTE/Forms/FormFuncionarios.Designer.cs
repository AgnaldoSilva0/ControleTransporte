
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
            this.listViewFuncionario = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdmissão = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbDescontoAviso = new System.Windows.Forms.Label();
            this.lbValorTotalImpostos = new System.Windows.Forms.Label();
            this.btCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btEditarFuncionario = new System.Windows.Forms.Button();
            this.btExcluirFuncionario = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFuncionario
            // 
            this.listViewFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chTelefone,
            this.chSalario,
            this.chAdmissão});
            this.listViewFuncionario.HideSelection = false;
            this.listViewFuncionario.Location = new System.Drawing.Point(0, 62);
            this.listViewFuncionario.Name = "listViewFuncionario";
            this.listViewFuncionario.Size = new System.Drawing.Size(477, 275);
            this.listViewFuncionario.TabIndex = 0;
            this.listViewFuncionario.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionario.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 23;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNome.Width = 128;
            // 
            // chTelefone
            // 
            this.chTelefone.Text = "Telefone";
            this.chTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTelefone.Width = 93;
            // 
            // chSalario
            // 
            this.chSalario.Text = "Salário";
            this.chSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSalario.Width = 93;
            // 
            // chAdmissão
            // 
            this.chAdmissão.Text = "Admissão";
            this.chAdmissão.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAdmissão.Width = 97;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lbDescontoAviso);
            this.panel3.Controls.Add(this.lbValorTotalImpostos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 100);
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
            this.lbDescontoAviso.Size = new System.Drawing.Size(35, 13);
            this.lbDescontoAviso.TabIndex = 2;
            this.lbDescontoAviso.Text = "NULL";
            // 
            // lbValorTotalImpostos
            // 
            this.lbValorTotalImpostos.AutoSize = true;
            this.lbValorTotalImpostos.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalImpostos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbValorTotalImpostos.Location = new System.Drawing.Point(264, 38);
            this.lbValorTotalImpostos.Name = "lbValorTotalImpostos";
            this.lbValorTotalImpostos.Size = new System.Drawing.Size(38, 23);
            this.lbValorTotalImpostos.TabIndex = 0;
            this.lbValorTotalImpostos.Text = "0.0";
            // 
            // btCadastrarFuncionario
            // 
            this.btCadastrarFuncionario.Location = new System.Drawing.Point(0, 344);
            this.btCadastrarFuncionario.Name = "btCadastrarFuncionario";
            this.btCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarFuncionario.TabIndex = 3;
            this.btCadastrarFuncionario.Text = "Cadastrar";
            this.btCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btCadastrarFuncionario.Click += new System.EventHandler(this.btCadastrarFuncionario_Click);
            // 
            // btEditarFuncionario
            // 
            this.btEditarFuncionario.Location = new System.Drawing.Point(81, 343);
            this.btEditarFuncionario.Name = "btEditarFuncionario";
            this.btEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btEditarFuncionario.TabIndex = 4;
            this.btEditarFuncionario.Text = "Editar";
            this.btEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btExcluirFuncionario
            // 
            this.btExcluirFuncionario.Location = new System.Drawing.Point(162, 343);
            this.btExcluirFuncionario.Name = "btExcluirFuncionario";
            this.btExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btExcluirFuncionario.TabIndex = 5;
            this.btExcluirFuncionario.Text = "Excluir";
            this.btExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 566);
            this.Controls.Add(this.btExcluirFuncionario);
            this.Controls.Add(this.btEditarFuncionario);
            this.Controls.Add(this.btCadastrarFuncionario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listViewFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFuncionario;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chTelefone;
        private System.Windows.Forms.ColumnHeader chSalario;
        private System.Windows.Forms.ColumnHeader chAdmissão;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDescontoAviso;
        private System.Windows.Forms.Label lbValorTotalImpostos;
        private System.Windows.Forms.Button btCadastrarFuncionario;
        private System.Windows.Forms.Button btEditarFuncionario;
        private System.Windows.Forms.Button btExcluirFuncionario;
    }
}