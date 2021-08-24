
namespace ImpostoCTE.Forms
{
    partial class Form_AddItemOrcamento
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
            this.lbDescricaoProduto = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbCodigoProduto = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbQuantidadeProduto = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btAddProduto = new MetroSet_UI.Controls.MetroSetButton();
            this.tbPrecoProduto = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btIncrementarQuant = new MetroSet_UI.Controls.MetroSetButton();
            this.btDecrementarItem = new MetroSet_UI.Controls.MetroSetButton();
            this.btFecharTelaAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // lbDescricaoProduto
            // 
            this.lbDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoProduto.IsDerivedStyle = true;
            this.lbDescricaoProduto.Location = new System.Drawing.Point(15, 86);
            this.lbDescricaoProduto.Name = "lbDescricaoProduto";
            this.lbDescricaoProduto.Size = new System.Drawing.Size(344, 23);
            this.lbDescricaoProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.lbDescricaoProduto.StyleManager = null;
            this.lbDescricaoProduto.TabIndex = 0;
            this.lbDescricaoProduto.Text = "NULL";
            this.lbDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDescricaoProduto.ThemeAuthor = "Narwin";
            this.lbDescricaoProduto.ThemeName = "MetroLite";
            // 
            // lbCodigoProduto
            // 
            this.lbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoProduto.IsDerivedStyle = true;
            this.lbCodigoProduto.Location = new System.Drawing.Point(15, 118);
            this.lbCodigoProduto.Name = "lbCodigoProduto";
            this.lbCodigoProduto.Size = new System.Drawing.Size(344, 23);
            this.lbCodigoProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.lbCodigoProduto.StyleManager = null;
            this.lbCodigoProduto.TabIndex = 1;
            this.lbCodigoProduto.Text = "NULL";
            this.lbCodigoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCodigoProduto.ThemeAuthor = "Narwin";
            this.lbCodigoProduto.ThemeName = "MetroLite";
            // 
            // tbQuantidadeProduto
            // 
            this.tbQuantidadeProduto.AutoCompleteCustomSource = null;
            this.tbQuantidadeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbQuantidadeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbQuantidadeProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbQuantidadeProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbQuantidadeProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbQuantidadeProduto.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidadeProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbQuantidadeProduto.Image = null;
            this.tbQuantidadeProduto.IsDerivedStyle = true;
            this.tbQuantidadeProduto.Lines = null;
            this.tbQuantidadeProduto.Location = new System.Drawing.Point(117, 184);
            this.tbQuantidadeProduto.MaxLength = 32767;
            this.tbQuantidadeProduto.Multiline = false;
            this.tbQuantidadeProduto.Name = "tbQuantidadeProduto";
            this.tbQuantidadeProduto.ReadOnly = false;
            this.tbQuantidadeProduto.Size = new System.Drawing.Size(60, 30);
            this.tbQuantidadeProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.tbQuantidadeProduto.StyleManager = null;
            this.tbQuantidadeProduto.TabIndex = 2;
            this.tbQuantidadeProduto.Text = "1";
            this.tbQuantidadeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuantidadeProduto.ThemeAuthor = "Narwin";
            this.tbQuantidadeProduto.ThemeName = "MetroLite";
            this.tbQuantidadeProduto.UseSystemPasswordChar = false;
            this.tbQuantidadeProduto.WatermarkText = "";
            this.tbQuantidadeProduto.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantidadeProduto_KeyPressed);
            // 
            // btAddProduto
            // 
            this.btAddProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAddProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAddProduto.DisabledForeColor = System.Drawing.Color.Gray;
            this.btAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btAddProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btAddProduto.HoverTextColor = System.Drawing.Color.White;
            this.btAddProduto.IsDerivedStyle = true;
            this.btAddProduto.Location = new System.Drawing.Point(117, 220);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAddProduto.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btAddProduto.NormalTextColor = System.Drawing.Color.White;
            this.btAddProduto.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btAddProduto.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btAddProduto.PressTextColor = System.Drawing.Color.White;
            this.btAddProduto.Size = new System.Drawing.Size(148, 37);
            this.btAddProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.btAddProduto.StyleManager = null;
            this.btAddProduto.TabIndex = 3;
            this.btAddProduto.Text = "Adicionar";
            this.btAddProduto.ThemeAuthor = "Narwin";
            this.btAddProduto.ThemeName = "MetroLite";
            this.btAddProduto.Click += new System.EventHandler(this.btAddProduto_Click);
            // 
            // tbPrecoProduto
            // 
            this.tbPrecoProduto.AutoCompleteCustomSource = null;
            this.tbPrecoProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPrecoProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPrecoProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbPrecoProduto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPrecoProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbPrecoProduto.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoProduto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbPrecoProduto.Image = null;
            this.tbPrecoProduto.IsDerivedStyle = true;
            this.tbPrecoProduto.Lines = null;
            this.tbPrecoProduto.Location = new System.Drawing.Point(117, 148);
            this.tbPrecoProduto.MaxLength = 32767;
            this.tbPrecoProduto.Multiline = false;
            this.tbPrecoProduto.Name = "tbPrecoProduto";
            this.tbPrecoProduto.ReadOnly = false;
            this.tbPrecoProduto.Size = new System.Drawing.Size(148, 30);
            this.tbPrecoProduto.Style = MetroSet_UI.Enums.Style.Light;
            this.tbPrecoProduto.StyleManager = null;
            this.tbPrecoProduto.TabIndex = 4;
            this.tbPrecoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrecoProduto.ThemeAuthor = "Narwin";
            this.tbPrecoProduto.ThemeName = "MetroLite";
            this.tbPrecoProduto.UseSystemPasswordChar = false;
            this.tbPrecoProduto.WatermarkText = "";
            this.tbPrecoProduto.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoProduto_KeyPressed);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 148);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(111, 30);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 5;
            this.metroSetLabel1.Text = "Preço Unitário:";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(0, 184);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(111, 30);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 6;
            this.metroSetLabel2.Text = "Quantidade:";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btIncrementarQuant
            // 
            this.btIncrementarQuant.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btIncrementarQuant.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btIncrementarQuant.DisabledForeColor = System.Drawing.Color.Gray;
            this.btIncrementarQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncrementarQuant.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btIncrementarQuant.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btIncrementarQuant.HoverTextColor = System.Drawing.Color.White;
            this.btIncrementarQuant.IsDerivedStyle = true;
            this.btIncrementarQuant.Location = new System.Drawing.Point(183, 184);
            this.btIncrementarQuant.Name = "btIncrementarQuant";
            this.btIncrementarQuant.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btIncrementarQuant.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btIncrementarQuant.NormalTextColor = System.Drawing.Color.White;
            this.btIncrementarQuant.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btIncrementarQuant.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btIncrementarQuant.PressTextColor = System.Drawing.Color.White;
            this.btIncrementarQuant.Size = new System.Drawing.Size(36, 30);
            this.btIncrementarQuant.Style = MetroSet_UI.Enums.Style.Light;
            this.btIncrementarQuant.StyleManager = null;
            this.btIncrementarQuant.TabIndex = 7;
            this.btIncrementarQuant.Text = "+";
            this.btIncrementarQuant.ThemeAuthor = "Narwin";
            this.btIncrementarQuant.ThemeName = "MetroLite";
            this.btIncrementarQuant.Click += new System.EventHandler(this.btIncrementarQuant_Click);
            // 
            // btDecrementarItem
            // 
            this.btDecrementarItem.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDecrementarItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDecrementarItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.btDecrementarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrementarItem.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btDecrementarItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btDecrementarItem.HoverTextColor = System.Drawing.Color.White;
            this.btDecrementarItem.IsDerivedStyle = true;
            this.btDecrementarItem.Location = new System.Drawing.Point(225, 184);
            this.btDecrementarItem.Name = "btDecrementarItem";
            this.btDecrementarItem.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDecrementarItem.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btDecrementarItem.NormalTextColor = System.Drawing.Color.White;
            this.btDecrementarItem.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btDecrementarItem.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btDecrementarItem.PressTextColor = System.Drawing.Color.White;
            this.btDecrementarItem.Size = new System.Drawing.Size(40, 30);
            this.btDecrementarItem.Style = MetroSet_UI.Enums.Style.Light;
            this.btDecrementarItem.StyleManager = null;
            this.btDecrementarItem.TabIndex = 8;
            this.btDecrementarItem.Text = "-";
            this.btDecrementarItem.ThemeAuthor = "Narwin";
            this.btDecrementarItem.ThemeName = "MetroLite";
            this.btDecrementarItem.Click += new System.EventHandler(this.btDecrementarItem_Click);
            // 
            // btFecharTelaAdd
            // 
            this.btFecharTelaAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btFecharTelaAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btFecharTelaAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btFecharTelaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharTelaAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btFecharTelaAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btFecharTelaAdd.HoverTextColor = System.Drawing.Color.White;
            this.btFecharTelaAdd.IsDerivedStyle = true;
            this.btFecharTelaAdd.Location = new System.Drawing.Point(331, 4);
            this.btFecharTelaAdd.Name = "btFecharTelaAdd";
            this.btFecharTelaAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btFecharTelaAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btFecharTelaAdd.NormalTextColor = System.Drawing.Color.White;
            this.btFecharTelaAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btFecharTelaAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btFecharTelaAdd.PressTextColor = System.Drawing.Color.White;
            this.btFecharTelaAdd.Size = new System.Drawing.Size(28, 24);
            this.btFecharTelaAdd.Style = MetroSet_UI.Enums.Style.Light;
            this.btFecharTelaAdd.StyleManager = null;
            this.btFecharTelaAdd.TabIndex = 9;
            this.btFecharTelaAdd.Text = "X";
            this.btFecharTelaAdd.ThemeAuthor = "Narwin";
            this.btFecharTelaAdd.ThemeName = "MetroLite";
            this.btFecharTelaAdd.Click += new System.EventHandler(this.btFecharTelaAdd_Click);
            // 
            // Form_AddItemOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(365, 272);
            this.Controls.Add(this.btFecharTelaAdd);
            this.Controls.Add(this.btDecrementarItem);
            this.Controls.Add(this.btIncrementarQuant);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.tbPrecoProduto);
            this.Controls.Add(this.btAddProduto);
            this.Controls.Add(this.tbQuantidadeProduto);
            this.Controls.Add(this.lbCodigoProduto);
            this.Controls.Add(this.lbDescricaoProduto);
            this.Name = "Form_AddItemOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Item Orçamento";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lbDescricaoProduto;
        private MetroSet_UI.Controls.MetroSetLabel lbCodigoProduto;
        private MetroSet_UI.Controls.MetroSetTextBox tbQuantidadeProduto;
        private MetroSet_UI.Controls.MetroSetButton btAddProduto;
        private MetroSet_UI.Controls.MetroSetTextBox tbPrecoProduto;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btIncrementarQuant;
        private MetroSet_UI.Controls.MetroSetButton btDecrementarItem;
        private MetroSet_UI.Controls.MetroSetButton btFecharTelaAdd;
    }
}