
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
            this.label17 = new System.Windows.Forms.Label();
            this.lbDescontoAviso = new System.Windows.Forms.Label();
            this.listViewFrete = new System.Windows.Forms.ListView();
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTomador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPesquisarFrete = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lbDescontoAviso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 100);
            this.panel3.TabIndex = 2;
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
            this.listViewFrete.HideSelection = false;
            this.listViewFrete.Location = new System.Drawing.Point(0, 71);
            this.listViewFrete.Name = "listViewFrete";
            this.listViewFrete.Size = new System.Drawing.Size(464, 295);
            this.listViewFrete.TabIndex = 3;
            this.listViewFrete.UseCompatibleStateImageBehavior = false;
            this.listViewFrete.View = System.Windows.Forms.View.Details;
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
            this.chValor.Width = 73;
            // 
            // tbPesquisarFrete
            // 
            this.tbPesquisarFrete.Location = new System.Drawing.Point(0, 373);
            this.tbPesquisarFrete.Name = "tbPesquisarFrete";
            this.tbPesquisarFrete.Size = new System.Drawing.Size(182, 20);
            this.tbPesquisarFrete.TabIndex = 4;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(188, 372);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(161, 21);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // FormListaFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(464, 527);
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
    }
}