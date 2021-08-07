
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
            this.listViewFunc = new MetroFramework.Controls.MetroListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbAdmissaoClick = new MetroFramework.Controls.MetroLabel();
            this.btCadastrarFunc = new MetroFramework.Controls.MetroButton();
            this.btPesquisarFunc = new MetroFramework.Controls.MetroButton();
            this.tbPesquisarFun = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFunc
            // 
            this.listViewFunc.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewFunc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmNome,
            this.clmTelefone,
            this.clmSalario});
            this.listViewFunc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewFunc.FullRowSelect = true;
            this.listViewFunc.Location = new System.Drawing.Point(1, 71);
            this.listViewFunc.Name = "listViewFunc";
            this.listViewFunc.OwnerDraw = true;
            this.listViewFunc.Size = new System.Drawing.Size(494, 256);
            this.listViewFunc.TabIndex = 3;
            this.listViewFunc.UseCompatibleStateImageBehavior = false;
            this.listViewFunc.UseSelectable = true;
            this.listViewFunc.View = System.Windows.Forms.View.Details;
            this.listViewFunc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFunc_MouseClick);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 114;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmNome.Width = 171;
            // 
            // clmTelefone
            // 
            this.clmTelefone.Text = "Telefone";
            this.clmTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTelefone.Width = 110;
            // 
            // clmSalario
            // 
            this.clmSalario.Text = "Salário";
            this.clmSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSalario.Width = 94;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Admissão:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroPanel1.Controls.Add(this.lbAdmissaoClick);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(15, 417);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(467, 84);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbAdmissaoClick
            // 
            this.lbAdmissaoClick.AutoSize = true;
            this.lbAdmissaoClick.Location = new System.Drawing.Point(79, 16);
            this.lbAdmissaoClick.Name = "lbAdmissaoClick";
            this.lbAdmissaoClick.Size = new System.Drawing.Size(75, 19);
            this.lbAdmissaoClick.TabIndex = 3;
            this.lbAdmissaoClick.Text = "00/00/0000";
            // 
            // btCadastrarFunc
            // 
            this.btCadastrarFunc.Location = new System.Drawing.Point(19, 334);
            this.btCadastrarFunc.Name = "btCadastrarFunc";
            this.btCadastrarFunc.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarFunc.TabIndex = 5;
            this.btCadastrarFunc.Text = "Cadastrar";
            this.btCadastrarFunc.UseSelectable = true;
            this.btCadastrarFunc.Click += new System.EventHandler(this.btCadastrarFunc_Click);
            // 
            // btPesquisarFunc
            // 
            this.btPesquisarFunc.Location = new System.Drawing.Point(405, 334);
            this.btPesquisarFunc.Name = "btPesquisarFunc";
            this.btPesquisarFunc.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarFunc.TabIndex = 6;
            this.btPesquisarFunc.Text = "Pesquisar";
            this.btPesquisarFunc.UseSelectable = true;
            this.btPesquisarFunc.Click += new System.EventHandler(this.btPesquisarFunc_Click);
            // 
            // tbPesquisarFun
            // 
            // 
            // 
            // 
            this.tbPesquisarFun.CustomButton.Image = null;
            this.tbPesquisarFun.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tbPesquisarFun.CustomButton.Name = "";
            this.tbPesquisarFun.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisarFun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisarFun.CustomButton.TabIndex = 1;
            this.tbPesquisarFun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisarFun.CustomButton.UseSelectable = true;
            this.tbPesquisarFun.CustomButton.Visible = false;
            this.tbPesquisarFun.Lines = new string[0];
            this.tbPesquisarFun.Location = new System.Drawing.Point(301, 333);
            this.tbPesquisarFun.MaxLength = 32767;
            this.tbPesquisarFun.Name = "tbPesquisarFun";
            this.tbPesquisarFun.PasswordChar = '\0';
            this.tbPesquisarFun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisarFun.SelectedText = "";
            this.tbPesquisarFun.SelectionLength = 0;
            this.tbPesquisarFun.SelectionStart = 0;
            this.tbPesquisarFun.ShortcutsEnabled = true;
            this.tbPesquisarFun.Size = new System.Drawing.Size(98, 23);
            this.tbPesquisarFun.TabIndex = 7;
            this.tbPesquisarFun.UseSelectable = true;
            this.tbPesquisarFun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisarFun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 517);
            this.Controls.Add(this.tbPesquisarFun);
            this.Controls.Add(this.btPesquisarFunc);
            this.Controls.Add(this.btCadastrarFunc);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.listViewFunc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFuncionarios";
            this.Padding = new System.Windows.Forms.Padding(12, 60, 12, 13);
            this.Text = "Funcionarios";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewFunc;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmSalario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbAdmissaoClick;
        private MetroFramework.Controls.MetroButton btCadastrarFunc;
        private MetroFramework.Controls.MetroButton btPesquisarFunc;
        private MetroFramework.Controls.MetroTextBox tbPesquisarFun;
    }
}