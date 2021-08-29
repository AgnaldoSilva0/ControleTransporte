
namespace ImpostoCTE.Forms
{
    partial class Form_Cad_Prod
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbCodigo = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbDescricao = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbPreco = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbIpi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btCadastrarProduto = new MetroSet_UI.Controls.MetroSetButton();
            this.lbResultado = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbEstoque = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(3, 94);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Código:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(3, 123);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Descrição:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(3, 152);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 2;
            this.metroSetLabel3.Text = "Preço:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(3, 181);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 3;
            this.metroSetLabel4.Text = "IPI:";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoCompleteCustomSource = null;
            this.tbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbCodigo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbCodigo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbCodigo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCodigo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbCodigo.Image = null;
            this.tbCodigo.IsDerivedStyle = true;
            this.tbCodigo.Lines = null;
            this.tbCodigo.Location = new System.Drawing.Point(95, 94);
            this.tbCodigo.MaxLength = 32767;
            this.tbCodigo.Multiline = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = false;
            this.tbCodigo.Size = new System.Drawing.Size(217, 23);
            this.tbCodigo.Style = MetroSet_UI.Enums.Style.Light;
            this.tbCodigo.StyleManager = null;
            this.tbCodigo.TabIndex = 4;
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.ThemeAuthor = "Narwin";
            this.tbCodigo.ThemeName = "MetroLite";
            this.tbCodigo.UseSystemPasswordChar = false;
            this.tbCodigo.WatermarkText = "Código";
            // 
            // tbDescricao
            // 
            this.tbDescricao.AutoCompleteCustomSource = null;
            this.tbDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbDescricao.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbDescricao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbDescricao.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDescricao.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbDescricao.Image = null;
            this.tbDescricao.IsDerivedStyle = true;
            this.tbDescricao.Lines = null;
            this.tbDescricao.Location = new System.Drawing.Point(95, 123);
            this.tbDescricao.MaxLength = 32767;
            this.tbDescricao.Multiline = false;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = false;
            this.tbDescricao.Size = new System.Drawing.Size(217, 23);
            this.tbDescricao.Style = MetroSet_UI.Enums.Style.Light;
            this.tbDescricao.StyleManager = null;
            this.tbDescricao.TabIndex = 5;
            this.tbDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescricao.ThemeAuthor = "Narwin";
            this.tbDescricao.ThemeName = "MetroLite";
            this.tbDescricao.UseSystemPasswordChar = false;
            this.tbDescricao.WatermarkText = "Descrição";
            // 
            // tbPreco
            // 
            this.tbPreco.AutoCompleteCustomSource = null;
            this.tbPreco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbPreco.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPreco.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbPreco.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPreco.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbPreco.Image = null;
            this.tbPreco.IsDerivedStyle = true;
            this.tbPreco.Lines = null;
            this.tbPreco.Location = new System.Drawing.Point(95, 152);
            this.tbPreco.MaxLength = 32767;
            this.tbPreco.Multiline = false;
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.ReadOnly = false;
            this.tbPreco.Size = new System.Drawing.Size(217, 23);
            this.tbPreco.Style = MetroSet_UI.Enums.Style.Light;
            this.tbPreco.StyleManager = null;
            this.tbPreco.TabIndex = 6;
            this.tbPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPreco.ThemeAuthor = "Narwin";
            this.tbPreco.ThemeName = "MetroLite";
            this.tbPreco.UseSystemPasswordChar = false;
            this.tbPreco.WatermarkText = "Preço";
            this.tbPreco.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.noTextOnTextBox);
            // 
            // tbIpi
            // 
            this.tbIpi.AutoCompleteCustomSource = null;
            this.tbIpi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbIpi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbIpi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbIpi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbIpi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbIpi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbIpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbIpi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbIpi.Image = null;
            this.tbIpi.IsDerivedStyle = true;
            this.tbIpi.Lines = null;
            this.tbIpi.Location = new System.Drawing.Point(95, 181);
            this.tbIpi.MaxLength = 32767;
            this.tbIpi.Multiline = false;
            this.tbIpi.Name = "tbIpi";
            this.tbIpi.ReadOnly = false;
            this.tbIpi.Size = new System.Drawing.Size(217, 23);
            this.tbIpi.Style = MetroSet_UI.Enums.Style.Light;
            this.tbIpi.StyleManager = null;
            this.tbIpi.TabIndex = 7;
            this.tbIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbIpi.ThemeAuthor = "Narwin";
            this.tbIpi.ThemeName = "MetroLite";
            this.tbIpi.UseSystemPasswordChar = false;
            this.tbIpi.WatermarkText = "IPI";
            this.tbIpi.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.noTextOnTextBox);
            // 
            // btCadastrarProduto
            // 
            this.btCadastrarProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarProduto.DisabledForeColor = System.Drawing.Color.Gray;
            this.btCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCadastrarProduto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btCadastrarProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btCadastrarProduto.HoverTextColor = System.Drawing.Color.White;
            this.btCadastrarProduto.IsDerivedStyle = true;
            this.btCadastrarProduto.Location = new System.Drawing.Point(3, 274);
            this.btCadastrarProduto.Name = "btCadastrarProduto";
            this.btCadastrarProduto.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarProduto.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarProduto.NormalTextColor = System.Drawing.Color.White;
            this.btCadastrarProduto.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btCadastrarProduto.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btCadastrarProduto.PressTextColor = System.Drawing.Color.White;
            this.btCadastrarProduto.Size = new System.Drawing.Size(309, 30);
            this.btCadastrarProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.btCadastrarProduto.StyleManager = null;
            this.btCadastrarProduto.TabIndex = 8;
            this.btCadastrarProduto.Text = "Cadastrar";
            this.btCadastrarProduto.ThemeAuthor = "Narwin";
            this.btCadastrarProduto.ThemeName = "MetroLite";
            this.btCadastrarProduto.Click += new System.EventHandler(this.btCadastrarProduto_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbResultado.IsDerivedStyle = true;
            this.lbResultado.Location = new System.Drawing.Point(56, 363);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(100, 23);
            this.lbResultado.Style = MetroSet_UI.Enums.Style.Light;
            this.lbResultado.StyleManager = null;
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "........";
            this.lbResultado.ThemeAuthor = "Narwin";
            this.lbResultado.ThemeName = "MetroLite";
            // 
            // tbEstoque
            // 
            this.tbEstoque.AutoCompleteCustomSource = null;
            this.tbEstoque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbEstoque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbEstoque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbEstoque.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbEstoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbEstoque.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEstoque.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbEstoque.Image = null;
            this.tbEstoque.IsDerivedStyle = true;
            this.tbEstoque.Lines = null;
            this.tbEstoque.Location = new System.Drawing.Point(95, 210);
            this.tbEstoque.MaxLength = 32767;
            this.tbEstoque.Multiline = false;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.ReadOnly = false;
            this.tbEstoque.Size = new System.Drawing.Size(217, 23);
            this.tbEstoque.Style = MetroSet_UI.Enums.Style.Light;
            this.tbEstoque.StyleManager = null;
            this.tbEstoque.TabIndex = 11;
            this.tbEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEstoque.ThemeAuthor = "Narwin";
            this.tbEstoque.ThemeName = "MetroLite";
            this.tbEstoque.UseSystemPasswordChar = false;
            this.tbEstoque.WatermarkText = "Estoque";
            this.tbEstoque.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.noTextOnTextBox);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(3, 210);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 10;
            this.metroSetLabel5.Text = "Estoque:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // Form_Cad_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 409);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btCadastrarProduto);
            this.Controls.Add(this.tbIpi);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Cad_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetTextBox tbCodigo;
        private MetroSet_UI.Controls.MetroSetTextBox tbDescricao;
        private MetroSet_UI.Controls.MetroSetTextBox tbPreco;
        private MetroSet_UI.Controls.MetroSetTextBox tbIpi;
        private MetroSet_UI.Controls.MetroSetButton btCadastrarProduto;
        private MetroSet_UI.Controls.MetroSetLabel lbResultado;
        private MetroSet_UI.Controls.MetroSetTextBox tbEstoque;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
    }
}