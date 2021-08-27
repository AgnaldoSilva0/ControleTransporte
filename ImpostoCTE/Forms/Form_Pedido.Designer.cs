
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
            this.components = new System.ComponentModel.Container();
            this.listViewProdutos = new MetroFramework.Controls.MetroListView();
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
            this.tbPesquisarProduto = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisarProduto = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.btAlterarCliente = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbIDCliente = new MetroFramework.Controls.MetroLabel();
            this.lbPlaca = new MetroFramework.Controls.MetroLabel();
            this.lbData = new MetroFramework.Controls.MetroLabel();
            this.lbVeiculo = new MetroFramework.Controls.MetroLabel();
            this.lbCliente = new MetroFramework.Controls.MetroLabel();
            this.lbIdOrcamento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btFecharTelaPedido = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lbEstoqueAlterado = new MetroFramework.Controls.MetroLabel();
            this.btDiminuirProduto = new MetroSet_UI.Controls.MetroSetButton();
            this.btAdicionarProduto = new MetroSet_UI.Controls.MetroSetButton();
            this.lbEstoqueAtual = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbDescricaoDetalhe = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbCodigoDetalhe = new MetroSet_UI.Controls.MetroSetLabel();
            this.timerEstoqueAlterado = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodigo,
            this.clmDescricao,
            this.clmPreço,
            this.clmEstoque});
            this.listViewProdutos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.Location = new System.Drawing.Point(11, 90);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.OwnerDraw = true;
            this.listViewProdutos.Size = new System.Drawing.Size(433, 258);
            this.listViewProdutos.TabIndex = 0;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.UseSelectable = true;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProdutos_MouseClick);
            this.listViewProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProdutos_MouseDoubleClick);
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
            // tbPesquisarProduto
            // 
            // 
            // 
            // 
            this.tbPesquisarProduto.CustomButton.Image = null;
            this.tbPesquisarProduto.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.tbPesquisarProduto.CustomButton.Name = "";
            this.tbPesquisarProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisarProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisarProduto.CustomButton.TabIndex = 1;
            this.tbPesquisarProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisarProduto.CustomButton.UseSelectable = true;
            this.tbPesquisarProduto.CustomButton.Visible = false;
            this.tbPesquisarProduto.Lines = new string[0];
            this.tbPesquisarProduto.Location = new System.Drawing.Point(11, 61);
            this.tbPesquisarProduto.MaxLength = 32767;
            this.tbPesquisarProduto.Name = "tbPesquisarProduto";
            this.tbPesquisarProduto.PasswordChar = '\0';
            this.tbPesquisarProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisarProduto.SelectedText = "";
            this.tbPesquisarProduto.SelectionLength = 0;
            this.tbPesquisarProduto.SelectionStart = 0;
            this.tbPesquisarProduto.ShortcutsEnabled = true;
            this.tbPesquisarProduto.Size = new System.Drawing.Size(163, 23);
            this.tbPesquisarProduto.TabIndex = 2;
            this.tbPesquisarProduto.UseSelectable = true;
            this.tbPesquisarProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisarProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisarProduto
            // 
            this.btPesquisarProduto.Location = new System.Drawing.Point(180, 61);
            this.btPesquisarProduto.Name = "btPesquisarProduto";
            this.btPesquisarProduto.Size = new System.Drawing.Size(90, 23);
            this.btPesquisarProduto.TabIndex = 3;
            this.btPesquisarProduto.Text = "Pesquisar";
            this.btPesquisarProduto.UseSelectable = true;
            this.btPesquisarProduto.Click += new System.EventHandler(this.btPesquisarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente: ";
            this.label1.UseCustomBackColor = true;
            this.label1.UseCustomForeColor = true;
            this.label1.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Veiculo: ";
            this.label2.UseCustomBackColor = true;
            this.label2.UseCustomForeColor = true;
            this.label2.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(297, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Placa: ";
            this.label4.UseCustomBackColor = true;
            this.label4.UseCustomForeColor = true;
            this.label4.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(297, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data: ";
            this.label3.UseCustomBackColor = true;
            this.label3.UseCustomForeColor = true;
            this.label3.UseStyleColors = true;
            // 
            // btAlterarCliente
            // 
            this.btAlterarCliente.Location = new System.Drawing.Point(478, 12);
            this.btAlterarCliente.Name = "btAlterarCliente";
            this.btAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCliente.TabIndex = 8;
            this.btAlterarCliente.Text = "Alterar";
            this.btAlterarCliente.UseSelectable = true;
            this.btAlterarCliente.Click += new System.EventHandler(this.btAlterarCliente_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.Controls.Add(this.lbIDCliente);
            this.metroPanel1.Controls.Add(this.lbPlaca);
            this.metroPanel1.Controls.Add(this.lbData);
            this.metroPanel1.Controls.Add(this.lbVeiculo);
            this.metroPanel1.Controls.Add(this.lbCliente);
            this.metroPanel1.Controls.Add(this.lbIdOrcamento);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btAlterarCliente);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.label2);
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
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbIDCliente.Location = new System.Drawing.Point(3, 12);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(12, 19);
            this.lbIDCliente.TabIndex = 15;
            this.lbIDCliente.Text = ".";
            this.lbIDCliente.UseCustomBackColor = true;
            this.lbIDCliente.UseCustomForeColor = true;
            this.lbIDCliente.UseStyleColors = true;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPlaca.Location = new System.Drawing.Point(333, 47);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(40, 19);
            this.lbPlaca.TabIndex = 14;
            this.lbPlaca.Text = "NULL";
            this.lbPlaca.UseCustomBackColor = true;
            this.lbPlaca.UseCustomForeColor = true;
            this.lbPlaca.UseStyleColors = true;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbData.Location = new System.Drawing.Point(333, 12);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(40, 19);
            this.lbData.TabIndex = 13;
            this.lbData.Text = "NULL";
            this.lbData.UseCustomBackColor = true;
            this.lbData.UseCustomForeColor = true;
            this.lbData.UseStyleColors = true;
            // 
            // lbVeiculo
            // 
            this.lbVeiculo.AutoSize = true;
            this.lbVeiculo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbVeiculo.Location = new System.Drawing.Point(70, 47);
            this.lbVeiculo.Name = "lbVeiculo";
            this.lbVeiculo.Size = new System.Drawing.Size(40, 19);
            this.lbVeiculo.TabIndex = 12;
            this.lbVeiculo.Text = "NULL";
            this.lbVeiculo.UseCustomBackColor = true;
            this.lbVeiculo.UseCustomForeColor = true;
            this.lbVeiculo.UseStyleColors = true;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCliente.Location = new System.Drawing.Point(70, 12);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(40, 19);
            this.lbCliente.TabIndex = 11;
            this.lbCliente.Text = "NULL";
            this.lbCliente.UseCustomBackColor = true;
            this.lbCliente.UseCustomForeColor = true;
            this.lbCliente.UseStyleColors = true;
            // 
            // lbIdOrcamento
            // 
            this.lbIdOrcamento.AutoSize = true;
            this.lbIdOrcamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbIdOrcamento.ForeColor = System.Drawing.Color.Navy;
            this.lbIdOrcamento.Location = new System.Drawing.Point(495, 47);
            this.lbIdOrcamento.Name = "lbIdOrcamento";
            this.lbIdOrcamento.Size = new System.Drawing.Size(16, 19);
            this.lbIdOrcamento.TabIndex = 10;
            this.lbIdOrcamento.Text = "0";
            this.lbIdOrcamento.UseCustomBackColor = true;
            this.lbIdOrcamento.UseCustomForeColor = true;
            this.lbIdOrcamento.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(446, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Nº:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(626, 517);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(309, 24);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
            this.metroSetLabel1.Text = "Preço Total:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // btFecharTelaPedido
            // 
            this.btFecharTelaPedido.BackColor = System.Drawing.Color.Red;
            this.btFecharTelaPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.btFecharTelaPedido.Location = new System.Drawing.Point(976, 516);
            this.btFecharTelaPedido.Name = "btFecharTelaPedido";
            this.btFecharTelaPedido.Size = new System.Drawing.Size(41, 23);
            this.btFecharTelaPedido.TabIndex = 11;
            this.btFecharTelaPedido.Text = "X";
            this.btFecharTelaPedido.UseCustomBackColor = true;
            this.btFecharTelaPedido.UseCustomForeColor = true;
            this.btFecharTelaPedido.UseSelectable = true;
            this.btFecharTelaPedido.Click += new System.EventHandler(this.btFecharTelaPedido_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel2.Controls.Add(this.lbEstoqueAlterado);
            this.metroPanel2.Controls.Add(this.btDiminuirProduto);
            this.metroPanel2.Controls.Add(this.btAdicionarProduto);
            this.metroPanel2.Controls.Add(this.lbEstoqueAtual);
            this.metroPanel2.Controls.Add(this.lbDescricaoDetalhe);
            this.metroPanel2.Controls.Add(this.metroSetLabel3);
            this.metroPanel2.Controls.Add(this.lbCodigoDetalhe);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(11, 367);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(433, 143);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lbEstoqueAlterado
            // 
            this.lbEstoqueAlterado.AutoSize = true;
            this.lbEstoqueAlterado.Location = new System.Drawing.Point(13, 111);
            this.lbEstoqueAlterado.Name = "lbEstoqueAlterado";
            this.lbEstoqueAlterado.Size = new System.Drawing.Size(18, 19);
            this.lbEstoqueAlterado.TabIndex = 8;
            this.lbEstoqueAlterado.Text = "...";
            // 
            // btDiminuirProduto
            // 
            this.btDiminuirProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDiminuirProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDiminuirProduto.DisabledForeColor = System.Drawing.Color.Gray;
            this.btDiminuirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiminuirProduto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btDiminuirProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btDiminuirProduto.HoverTextColor = System.Drawing.Color.White;
            this.btDiminuirProduto.IsDerivedStyle = true;
            this.btDiminuirProduto.Location = new System.Drawing.Point(345, 81);
            this.btDiminuirProduto.Name = "btDiminuirProduto";
            this.btDiminuirProduto.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDiminuirProduto.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDiminuirProduto.NormalTextColor = System.Drawing.Color.White;
            this.btDiminuirProduto.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btDiminuirProduto.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btDiminuirProduto.PressTextColor = System.Drawing.Color.White;
            this.btDiminuirProduto.Size = new System.Drawing.Size(60, 50);
            this.btDiminuirProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.btDiminuirProduto.StyleManager = null;
            this.btDiminuirProduto.TabIndex = 7;
            this.btDiminuirProduto.Text = "-";
            this.btDiminuirProduto.ThemeAuthor = "Narwin";
            this.btDiminuirProduto.ThemeName = "MetroLite";
            this.btDiminuirProduto.Click += new System.EventHandler(this.btDiminuirProduto_Click);
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAdicionarProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAdicionarProduto.DisabledForeColor = System.Drawing.Color.Gray;
            this.btAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarProduto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btAdicionarProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btAdicionarProduto.HoverTextColor = System.Drawing.Color.White;
            this.btAdicionarProduto.IsDerivedStyle = true;
            this.btAdicionarProduto.Location = new System.Drawing.Point(345, 16);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAdicionarProduto.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAdicionarProduto.NormalTextColor = System.Drawing.Color.White;
            this.btAdicionarProduto.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btAdicionarProduto.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btAdicionarProduto.PressTextColor = System.Drawing.Color.White;
            this.btAdicionarProduto.Size = new System.Drawing.Size(60, 50);
            this.btAdicionarProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.btAdicionarProduto.StyleManager = null;
            this.btAdicionarProduto.TabIndex = 6;
            this.btAdicionarProduto.Text = "+";
            this.btAdicionarProduto.ThemeAuthor = "Narwin";
            this.btAdicionarProduto.ThemeName = "MetroLite";
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // lbEstoqueAtual
            // 
            this.lbEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstoqueAtual.IsDerivedStyle = true;
            this.lbEstoqueAtual.Location = new System.Drawing.Point(270, 55);
            this.lbEstoqueAtual.Name = "lbEstoqueAtual";
            this.lbEstoqueAtual.Size = new System.Drawing.Size(69, 23);
            this.lbEstoqueAtual.Style = MetroSet_UI.Enums.Style.Light;
            this.lbEstoqueAtual.StyleManager = null;
            this.lbEstoqueAtual.TabIndex = 5;
            this.lbEstoqueAtual.Text = "0";
            this.lbEstoqueAtual.ThemeAuthor = "Narwin";
            this.lbEstoqueAtual.ThemeName = "MetroLite";
            // 
            // lbDescricaoDetalhe
            // 
            this.lbDescricaoDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescricaoDetalhe.IsDerivedStyle = true;
            this.lbDescricaoDetalhe.Location = new System.Drawing.Point(12, 68);
            this.lbDescricaoDetalhe.Name = "lbDescricaoDetalhe";
            this.lbDescricaoDetalhe.Size = new System.Drawing.Size(262, 23);
            this.lbDescricaoDetalhe.Style = MetroSet_UI.Enums.Style.Light;
            this.lbDescricaoDetalhe.StyleManager = null;
            this.lbDescricaoDetalhe.TabIndex = 4;
            this.lbDescricaoDetalhe.Text = "Descrição: ";
            this.lbDescricaoDetalhe.ThemeAuthor = "Narwin";
            this.lbDescricaoDetalhe.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(12, 5);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(151, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 3;
            this.metroSetLabel3.Text = "Gerenciar Estoque";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // lbCodigoDetalhe
            // 
            this.lbCodigoDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigoDetalhe.IsDerivedStyle = true;
            this.lbCodigoDetalhe.Location = new System.Drawing.Point(13, 36);
            this.lbCodigoDetalhe.Name = "lbCodigoDetalhe";
            this.lbCodigoDetalhe.Size = new System.Drawing.Size(100, 23);
            this.lbCodigoDetalhe.Style = MetroSet_UI.Enums.Style.Light;
            this.lbCodigoDetalhe.StyleManager = null;
            this.lbCodigoDetalhe.TabIndex = 2;
            this.lbCodigoDetalhe.Text = "Código: ";
            this.lbCodigoDetalhe.ThemeAuthor = "Narwin";
            this.lbCodigoDetalhe.ThemeName = "MetroLite";
            // 
            // timerEstoqueAlterado
            // 
            this.timerEstoqueAlterado.Interval = 1000;
            this.timerEstoqueAlterado.Tick += new System.EventHandler(this.timerEstoqueAlterado_Tick);
            // 
            // Form_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.btFecharTelaPedido);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btPesquisarProduto);
            this.Controls.Add(this.tbPesquisarProduto);
            this.Controls.Add(this.metroListView2);
            this.Controls.Add(this.listViewProdutos);
            this.Name = "Form_Pedido";
            this.Text = "Orçamento";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewProdutos;
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
        private MetroFramework.Controls.MetroTextBox tbPesquisarProduto;
        private MetroFramework.Controls.MetroButton btPesquisarProduto;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroButton btAlterarCliente;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroFramework.Controls.MetroButton btFecharTelaPedido;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroSet_UI.Controls.MetroSetButton btDiminuirProduto;
        private MetroSet_UI.Controls.MetroSetButton btAdicionarProduto;
        private MetroSet_UI.Controls.MetroSetLabel lbEstoqueAtual;
        private MetroSet_UI.Controls.MetroSetLabel lbDescricaoDetalhe;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel lbCodigoDetalhe;
        private MetroFramework.Controls.MetroLabel lbEstoqueAlterado;
        private System.Windows.Forms.Timer timerEstoqueAlterado;
        private MetroFramework.Controls.MetroLabel lbPlaca;
        private MetroFramework.Controls.MetroLabel lbData;
        private MetroFramework.Controls.MetroLabel lbVeiculo;
        private MetroFramework.Controls.MetroLabel lbCliente;
        private MetroFramework.Controls.MetroLabel lbIdOrcamento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbIDCliente;
    }
}