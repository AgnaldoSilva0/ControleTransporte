
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAbrirOrcamento = new MetroFramework.Controls.MetroButton();
            this.btPesquisar = new MetroSet_UI.Controls.MetroSetButton();
            this.Pesquisar = new MetroFramework.Controls.MetroButton();
            this.tbPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmCliente,
            this.clmPlaca,
            this.clmModelo,
            this.clmStatus});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(23, 116);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(539, 295);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
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
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(197, 85);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 3;
            this.Pesquisar.Text = "btPesquisar";
            this.Pesquisar.UseSelectable = true;
            // 
            // tbPesquisar
            // 
            // 
            // 
            // 
            this.tbPesquisar.CustomButton.Image = null;
            this.tbPesquisar.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.tbPesquisar.CustomButton.Name = "";
            this.tbPesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisar.CustomButton.TabIndex = 1;
            this.tbPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisar.CustomButton.UseSelectable = true;
            this.tbPesquisar.CustomButton.Visible = false;
            this.tbPesquisar.Lines = new string[0];
            this.tbPesquisar.Location = new System.Drawing.Point(24, 85);
            this.tbPesquisar.MaxLength = 32767;
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.PasswordChar = '\0';
            this.tbPesquisar.PromptText = "FONT";
            this.tbPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisar.SelectedText = "";
            this.tbPesquisar.SelectionLength = 0;
            this.tbPesquisar.SelectionStart = 0;
            this.tbPesquisar.ShortcutsEnabled = true;
            this.tbPesquisar.Size = new System.Drawing.Size(167, 23);
            this.tbPesquisar.TabIndex = 4;
            this.tbPesquisar.UseSelectable = true;
            this.tbPesquisar.WaterMark = "FONT";
            this.tbPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form_Selecionar_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 463);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btAbrirOrcamento);
            this.Controls.Add(this.metroListView1);
            this.Name = "Form_Selecionar_Orcamento";
            this.Text = "Selecionar Orçamento";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clmPlaca;
        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private MetroFramework.Controls.MetroButton btAbrirOrcamento;
        private MetroSet_UI.Controls.MetroSetButton btPesquisar;
        private MetroFramework.Controls.MetroButton Pesquisar;
        private MetroFramework.Controls.MetroTextBox tbPesquisar;
    }
}