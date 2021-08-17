
namespace ImpostoCTE.Model
{
    partial class Form_Pedido
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.clmCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPreço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.clmCodigoOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescricaoOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrecoOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantidadeOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalItemOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisarProduto = new MetroFramework.Controls.MetroButton();
            this.lbCliente = new MetroFramework.Controls.MetroLabel();
            this.lbVeiculo = new MetroFramework.Controls.MetroLabel();
            this.lbPlaca = new MetroFramework.Controls.MetroLabel();
            this.lbData = new MetroFramework.Controls.MetroLabel();
            this.btAlterarCliente = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodigo,
            this.clmDescricao,
            this.clmPreço,
            this.clmEstoque});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(11, 90);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(433, 258);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Código";
            this.clmCodigo.Width = 75;
            // 
            // clmDescricao
            // 
            this.clmDescricao.Text = "Descrição";
            this.clmDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDescricao.Width = 204;
            // 
            // clmPreço
            // 
            this.clmPreço.Text = "Preço";
            this.clmPreço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPreço.Width = 90;
            // 
            // clmEstoque
            // 
            this.clmEstoque.Text = "Estoque";
            this.clmEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroListView2
            // 
            this.metroListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodigoOrcamento,
            this.clmDescricaoOrcamento,
            this.clmPrecoOrcamento,
            this.clmQuantidadeOrcamento,
            this.clmTotalItemOrcamento});
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(461, 90);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(556, 420);
            this.metroListView2.TabIndex = 1;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.View = System.Windows.Forms.View.Details;
            // 
            // clmCodigoOrcamento
            // 
            this.clmCodigoOrcamento.Text = "Código";
            this.clmCodigoOrcamento.Width = 66;
            // 
            // clmDescricaoOrcamento
            // 
            this.clmDescricaoOrcamento.Text = "Descrição";
            this.clmDescricaoOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDescricaoOrcamento.Width = 204;
            // 
            // clmPrecoOrcamento
            // 
            this.clmPrecoOrcamento.Text = "Preço Uni";
            this.clmPrecoOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPrecoOrcamento.Width = 90;
            // 
            // clmQuantidadeOrcamento
            // 
            this.clmQuantidadeOrcamento.Text = "Quantidade";
            this.clmQuantidadeOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmQuantidadeOrcamento.Width = 53;
            // 
            // clmTotalItemOrcamento
            // 
            this.clmTotalItemOrcamento.Text = "Total";
            this.clmTotalItemOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTotalItemOrcamento.Width = 138;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(11, 61);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(163, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisarProduto
            // 
            this.btPesquisarProduto.Location = new System.Drawing.Point(180, 61);
            this.btPesquisarProduto.Name = "btPesquisarProduto";
            this.btPesquisarProduto.Size = new System.Drawing.Size(90, 23);
            this.btPesquisarProduto.TabIndex = 3;
            this.btPesquisarProduto.Text = "Pesquisar";
            this.btPesquisarProduto.UseSelectable = true;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCliente.Location = new System.Drawing.Point(17, 12);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(56, 19);
            this.lbCliente.TabIndex = 4;
            this.lbCliente.Text = "Cliente: ";
            this.lbCliente.UseCustomBackColor = true;
            this.lbCliente.UseCustomForeColor = true;
            this.lbCliente.UseStyleColors = true;
            // 
            // lbVeiculo
            // 
            this.lbVeiculo.AutoSize = true;
            this.lbVeiculo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbVeiculo.Location = new System.Drawing.Point(17, 47);
            this.lbVeiculo.Name = "lbVeiculo";
            this.lbVeiculo.Size = new System.Drawing.Size(57, 19);
            this.lbVeiculo.TabIndex = 5;
            this.lbVeiculo.Text = "Veiculo: ";
            this.lbVeiculo.UseCustomBackColor = true;
            this.lbVeiculo.UseCustomForeColor = true;
            this.lbVeiculo.UseStyleColors = true;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPlaca.Location = new System.Drawing.Point(297, 47);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(47, 19);
            this.lbPlaca.TabIndex = 6;
            this.lbPlaca.Text = "Placa: ";
            this.lbPlaca.UseCustomBackColor = true;
            this.lbPlaca.UseCustomForeColor = true;
            this.lbPlaca.UseStyleColors = true;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbData.Location = new System.Drawing.Point(297, 12);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(43, 19);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Data: ";
            this.lbData.UseCustomBackColor = true;
            this.lbData.UseCustomForeColor = true;
            this.lbData.UseStyleColors = true;
            // 
            // btAlterarCliente
            // 
            this.btAlterarCliente.Location = new System.Drawing.Point(478, 12);
            this.btAlterarCliente.Name = "btAlterarCliente";
            this.btAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCliente.TabIndex = 8;
            this.btAlterarCliente.Text = "Alterar";
            this.btAlterarCliente.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.Controls.Add(this.btAlterarCliente);
            this.metroPanel1.Controls.Add(this.lbData);
            this.metroPanel1.Controls.Add(this.lbPlaca);
            this.metroPanel1.Controls.Add(this.lbCliente);
            this.metroPanel1.Controls.Add(this.lbVeiculo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(461, 7);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(556, 77);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(661, 519);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(356, 24);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
            this.metroSetLabel1.Text = "Preço Total:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // Form_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btPesquisarProduto);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroListView2);
            this.Controls.Add(this.metroListView1);
            this.Name = "Form_Pedido";
            this.Text = "Orçamento";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmPreço;
        private System.Windows.Forms.ColumnHeader clmEstoque;
        private MetroFramework.Controls.MetroListView metroListView2;
        private System.Windows.Forms.ColumnHeader clmCodigoOrcamento;
        private System.Windows.Forms.ColumnHeader clmDescricaoOrcamento;
        private System.Windows.Forms.ColumnHeader clmPrecoOrcamento;
        private System.Windows.Forms.ColumnHeader clmQuantidadeOrcamento;
        private System.Windows.Forms.ColumnHeader clmTotalItemOrcamento;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btPesquisarProduto;
        private MetroFramework.Controls.MetroLabel lbCliente;
        private MetroFramework.Controls.MetroLabel lbVeiculo;
        private MetroFramework.Controls.MetroLabel lbPlaca;
        private MetroFramework.Controls.MetroLabel lbData;
        private MetroFramework.Controls.MetroButton btAlterarCliente;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    }
}