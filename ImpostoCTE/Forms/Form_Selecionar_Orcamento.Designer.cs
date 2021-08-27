
namespace ImpostoCTE.Forms
{
    partial class Form_Selecionar_Orcamento
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
            this.listViewOrcamentos = new MetroFramework.Controls.MetroListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAbrirOrcamento = new MetroFramework.Controls.MetroButton();
            this.btPesquisar = new MetroSet_UI.Controls.MetroSetButton();
            this.btPesquisarOrcamento = new MetroFramework.Controls.MetroButton();
            this.tbPesquisarOrcamento = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listViewOrcamentos
            // 
            this.listViewOrcamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmCliente,
            this.clmPlaca,
            this.clmModelo,
            this.clmStatus});
            this.listViewOrcamentos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewOrcamentos.FullRowSelect = true;
            this.listViewOrcamentos.Location = new System.Drawing.Point(23, 116);
            this.listViewOrcamentos.Name = "listViewOrcamentos";
            this.listViewOrcamentos.OwnerDraw = true;
            this.listViewOrcamentos.Size = new System.Drawing.Size(539, 295);
            this.listViewOrcamentos.TabIndex = 0;
            this.listViewOrcamentos.UseCompatibleStateImageBehavior = false;
            this.listViewOrcamentos.UseSelectable = true;
            this.listViewOrcamentos.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            this.clmId.Width = 40;
            // 
            // clmCliente
            // 
            this.clmCliente.Text = "Cliente";
            this.clmCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCliente.Width = 156;
            // 
            // clmPlaca
            // 
            this.clmPlaca.Text = "Placa";
            this.clmPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPlaca.Width = 132;
            // 
            // clmModelo
            // 
            this.clmModelo.Text = "Modelo";
            this.clmModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmModelo.Width = 112;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStatus.Width = 93;
            // 
            // btAbrirOrcamento
            // 
            this.btAbrirOrcamento.Location = new System.Drawing.Point(23, 417);
            this.btAbrirOrcamento.Name = "btAbrirOrcamento";
            this.btAbrirOrcamento.Size = new System.Drawing.Size(130, 41);
            this.btAbrirOrcamento.TabIndex = 1;
            this.btAbrirOrcamento.Text = "Abrir";
            this.btAbrirOrcamento.UseSelectable = true;
            this.btAbrirOrcamento.Click += new System.EventHandler(this.btAbrirOrcamento_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btPesquisar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btPesquisar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btPesquisar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btPesquisar.HoverTextColor = System.Drawing.Color.White;
            this.btPesquisar.IsDerivedStyle = true;
            this.btPesquisar.Location = new System.Drawing.Point(487, 74);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btPesquisar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btPesquisar.NormalTextColor = System.Drawing.Color.White;
            this.btPesquisar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btPesquisar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btPesquisar.PressTextColor = System.Drawing.Color.White;
            this.btPesquisar.Size = new System.Drawing.Size(75, 36);
            this.btPesquisar.Style = MetroSet_UI.Enums.Style.Light;
            this.btPesquisar.StyleManager = null;
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Novo";
            this.btPesquisar.ThemeAuthor = "Narwin";
            this.btPesquisar.ThemeName = "MetroLite";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btPesquisarOrcamento
            // 
            this.btPesquisarOrcamento.Location = new System.Drawing.Point(197, 85);
            this.btPesquisarOrcamento.Name = "btPesquisarOrcamento";
            this.btPesquisarOrcamento.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarOrcamento.TabIndex = 3;
            this.btPesquisarOrcamento.Text = "Pesquisar";
            this.btPesquisarOrcamento.UseSelectable = true;
            this.btPesquisarOrcamento.Click += new System.EventHandler(this.btPesquisarOrcamento_Click);
            // 
            // tbPesquisarOrcamento
            // 
            // 
            // 
            // 
            this.tbPesquisarOrcamento.CustomButton.Image = null;
            this.tbPesquisarOrcamento.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.tbPesquisarOrcamento.CustomButton.Name = "";
            this.tbPesquisarOrcamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisarOrcamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisarOrcamento.CustomButton.TabIndex = 1;
            this.tbPesquisarOrcamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisarOrcamento.CustomButton.UseSelectable = true;
            this.tbPesquisarOrcamento.CustomButton.Visible = false;
            this.tbPesquisarOrcamento.Lines = new string[0];
            this.tbPesquisarOrcamento.Location = new System.Drawing.Point(24, 85);
            this.tbPesquisarOrcamento.MaxLength = 32767;
            this.tbPesquisarOrcamento.Name = "tbPesquisarOrcamento";
            this.tbPesquisarOrcamento.PasswordChar = '\0';
            this.tbPesquisarOrcamento.PromptText = "FONT";
            this.tbPesquisarOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisarOrcamento.SelectedText = "";
            this.tbPesquisarOrcamento.SelectionLength = 0;
            this.tbPesquisarOrcamento.SelectionStart = 0;
            this.tbPesquisarOrcamento.ShortcutsEnabled = true;
            this.tbPesquisarOrcamento.Size = new System.Drawing.Size(167, 23);
            this.tbPesquisarOrcamento.TabIndex = 4;
            this.tbPesquisarOrcamento.UseSelectable = true;
            this.tbPesquisarOrcamento.WaterMark = "FONT";
            this.tbPesquisarOrcamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisarOrcamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form_Selecionar_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 463);
            this.Controls.Add(this.tbPesquisarOrcamento);
            this.Controls.Add(this.btPesquisarOrcamento);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btAbrirOrcamento);
            this.Controls.Add(this.listViewOrcamentos);
            this.Name = "Form_Selecionar_Orcamento";
            this.Text = "Selecionar Orçamento";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewOrcamentos;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clmPlaca;
        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private MetroFramework.Controls.MetroButton btAbrirOrcamento;
        private MetroSet_UI.Controls.MetroSetButton btPesquisar;
        private MetroFramework.Controls.MetroButton btPesquisarOrcamento;
        private MetroFramework.Controls.MetroTextBox tbPesquisarOrcamento;
    }
}