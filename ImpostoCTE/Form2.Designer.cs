
namespace ImpostoCTE
{
    partial class Form2
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
            this.btFecharPainel = new System.Windows.Forms.Button();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.cHCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHIpi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbAplicacao = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFecharPainel
            // 
            this.btFecharPainel.Location = new System.Drawing.Point(399, 321);
            this.btFecharPainel.Name = "btFecharPainel";
            this.btFecharPainel.Size = new System.Drawing.Size(75, 23);
            this.btFecharPainel.TabIndex = 0;
            this.btFecharPainel.Text = "Fechar";
            this.btFecharPainel.UseVisualStyleBackColor = true;
            this.btFecharPainel.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHCodigo,
            this.cHDescricao,
            this.cHPreco,
            this.cHIpi});
            this.listViewProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(3, 12);
            this.listViewProdutos.MultiSelect = false;
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(471, 303);
            this.listViewProdutos.TabIndex = 1;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProdutos_MouseClick);
            // 
            // cHCodigo
            // 
            this.cHCodigo.Text = "Código";
            this.cHCodigo.Width = 69;
            // 
            // cHDescricao
            // 
            this.cHDescricao.Text = "Descrição";
            this.cHDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHDescricao.Width = 258;
            // 
            // cHPreco
            // 
            this.cHPreco.Text = "Preço";
            this.cHPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHPreco.Width = 75;
            // 
            // cHIpi
            // 
            this.cHIpi.Text = "IPI";
            this.cHIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHIpi.Width = 29;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(197, 321);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(3, 323);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(188, 20);
            this.tbPesquisar.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lbAplicacao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 100);
            this.panel3.TabIndex = 13;
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
            this.label22.Location = new System.Drawing.Point(4, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Aplicações";
            // 
            // lbAplicacao
            // 
            this.lbAplicacao.AutoSize = true;
            this.lbAplicacao.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAplicacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAplicacao.Location = new System.Drawing.Point(12, 49);
            this.lbAplicacao.Name = "lbAplicacao";
            this.lbAplicacao.Size = new System.Drawing.Size(28, 23);
            this.lbAplicacao.TabIndex = 0;
            this.lbAplicacao.Text = "...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.btFecharPainel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFecharPainel;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader cHCodigo;
        private System.Windows.Forms.ColumnHeader cHDescricao;
        private System.Windows.Forms.ColumnHeader cHPreco;
        private System.Windows.Forms.ColumnHeader cHIpi;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbAplicacao;
    }
}