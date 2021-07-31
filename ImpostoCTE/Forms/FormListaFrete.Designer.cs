
namespace ImpostoCTE.Forms
{
    partial class FormListaFrete
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
            this.lbObservacao = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbVeiculo = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbMdfe = new System.Windows.Forms.Label();
            this.lbCte = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbTomador = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbDescontoAviso = new System.Windows.Forms.Label();
            this.listViewFrete = new System.Windows.Forms.ListView();
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTomador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPesquisarFrete = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastrarFrete = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.lbObservacao);
            this.panel3.Controls.Add(this.lbPlaca);
            this.panel3.Controls.Add(this.lbVeiculo);
            this.panel3.Controls.Add(this.lbValor);
            this.panel3.Controls.Add(this.lbCidade);
            this.panel3.Controls.Add(this.lbMdfe);
            this.panel3.Controls.Add(this.lbCte);
            this.panel3.Controls.Add(this.lbData);
            this.panel3.Controls.Add(this.lbTomador);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lbDescontoAviso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 100);
            this.panel3.TabIndex = 2;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbObservacao.Location = new System.Drawing.Point(3, 82);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(93, 16);
            this.lbObservacao.TabIndex = 11;
            this.lbObservacao.Text = "Observacao";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPlaca.Location = new System.Drawing.Point(273, 58);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(50, 18);
            this.lbPlaca.TabIndex = 10;
            this.lbPlaca.Text = "Placa";
            // 
            // lbVeiculo
            // 
            this.lbVeiculo.AutoSize = true;
            this.lbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVeiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbVeiculo.Location = new System.Drawing.Point(273, 40);
            this.lbVeiculo.Name = "lbVeiculo";
            this.lbVeiculo.Size = new System.Drawing.Size(63, 18);
            this.lbVeiculo.TabIndex = 9;
            this.lbVeiculo.Text = "Veiculo";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbValor.Location = new System.Drawing.Point(273, 22);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(47, 18);
            this.lbValor.TabIndex = 8;
            this.lbValor.Text = "Valor";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCidade.Location = new System.Drawing.Point(3, 67);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(58, 16);
            this.lbCidade.TabIndex = 7;
            this.lbCidade.Text = "Cidade";
            // 
            // lbMdfe
            // 
            this.lbMdfe.AutoSize = true;
            this.lbMdfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdfe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMdfe.Location = new System.Drawing.Point(3, 49);
            this.lbMdfe.Name = "lbMdfe";
            this.lbMdfe.Size = new System.Drawing.Size(50, 16);
            this.lbMdfe.TabIndex = 6;
            this.lbMdfe.Text = "MDFE";
            // 
            // lbCte
            // 
            this.lbCte.AutoSize = true;
            this.lbCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCte.Location = new System.Drawing.Point(3, 31);
            this.lbCte.Name = "lbCte";
            this.lbCte.Size = new System.Drawing.Size(38, 16);
            this.lbCte.TabIndex = 5;
            this.lbCte.Text = "CTE";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbData.Location = new System.Drawing.Point(3, 13);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(41, 16);
            this.lbData.TabIndex = 4;
            this.lbData.Text = "Data";
            // 
            // lbTomador
            // 
            this.lbTomador.AutoSize = true;
            this.lbTomador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTomador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTomador.Location = new System.Drawing.Point(196, 0);
            this.lbTomador.Name = "lbTomador";
            this.lbTomador.Size = new System.Drawing.Size(76, 18);
            this.lbTomador.TabIndex = 3;
            this.lbTomador.Text = "Tomador";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(437, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 7);
            this.label17.TabIndex = 1;
            this.label17.Text = "V 1.0";
            // 
            // lbDescontoAviso
            // 
            this.lbDescontoAviso.AutoSize = true;
            this.lbDescontoAviso.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbDescontoAviso.Location = new System.Drawing.Point(3, 0);
            this.lbDescontoAviso.Name = "lbDescontoAviso";
            this.lbDescontoAviso.Size = new System.Drawing.Size(52, 13);
            this.lbDescontoAviso.TabIndex = 2;
            this.lbDescontoAviso.Text = "Detalhes:";
            // 
            // listViewFrete
            // 
            this.listViewFrete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chData,
            this.chCte,
            this.chTomador,
            this.chValor});
            this.listViewFrete.FullRowSelect = true;
            this.listViewFrete.GridLines = true;
            this.listViewFrete.HideSelection = false;
            this.listViewFrete.Location = new System.Drawing.Point(0, 71);
            this.listViewFrete.MultiSelect = false;
            this.listViewFrete.Name = "listViewFrete";
            this.listViewFrete.Size = new System.Drawing.Size(480, 295);
            this.listViewFrete.TabIndex = 3;
            this.listViewFrete.UseCompatibleStateImageBehavior = false;
            this.listViewFrete.View = System.Windows.Forms.View.Details;
            this.listViewFrete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFrete_MouseClick);
            // 
            // chData
            // 
            this.chData.Text = "Data";
            // 
            // chCte
            // 
            this.chCte.Text = "CTE";
            this.chCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chTomador
            // 
            this.chTomador.Text = "Tomador";
            this.chTomador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTomador.Width = 264;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor";
            this.chValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chValor.Width = 87;
            // 
            // tbPesquisarFrete
            // 
            this.tbPesquisarFrete.Location = new System.Drawing.Point(0, 45);
            this.tbPesquisarFrete.Name = "tbPesquisarFrete";
            this.tbPesquisarFrete.Size = new System.Drawing.Size(182, 20);
            this.tbPesquisarFrete.TabIndex = 4;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(188, 44);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(161, 21);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(379, 372);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(101, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir Registro";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastrarFrete
            // 
            this.btCadastrarFrete.Location = new System.Drawing.Point(0, 372);
            this.btCadastrarFrete.Name = "btCadastrarFrete";
            this.btCadastrarFrete.Size = new System.Drawing.Size(126, 23);
            this.btCadastrarFrete.TabIndex = 7;
            this.btCadastrarFrete.Text = "Cadastrar Frete";
            this.btCadastrarFrete.UseVisualStyleBackColor = true;
            this.btCadastrarFrete.Click += new System.EventHandler(this.btCadastrarFrete_Click);
            // 
            // FormListaFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 566);
            this.Controls.Add(this.btCadastrarFrete);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbPesquisarFrete);
            this.Controls.Add(this.listViewFrete);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaFrete";
            this.Text = "FormListaFrete";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbDescontoAviso;
        private System.Windows.Forms.ListView listViewFrete;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chCte;
        private System.Windows.Forms.ColumnHeader chTomador;
        private System.Windows.Forms.ColumnHeader chValor;
        private System.Windows.Forms.TextBox tbPesquisarFrete;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbVeiculo;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbMdfe;
        private System.Windows.Forms.Label lbCte;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbTomador;
        private System.Windows.Forms.Button btCadastrarFrete;
    }
}