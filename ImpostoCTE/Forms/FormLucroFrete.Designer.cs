
namespace ImpostoCTE
{
    partial class FormLucroFrete
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
            this.btFecharTelaLucro = new System.Windows.Forms.Button();
            this.tbValorFreteLucro = new System.Windows.Forms.TextBox();
            this.tbDiariaLucro = new System.Windows.Forms.TextBox();
            this.tbImpostoLucro = new System.Windows.Forms.TextBox();
            this.tbCombustivelLucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOutrasDespesasLucro = new System.Windows.Forms.TextBox();
            this.btCalcularLucro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbValorTotalLucro = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFecharTelaLucro
            // 
            this.btFecharTelaLucro.Location = new System.Drawing.Point(393, 280);
            this.btFecharTelaLucro.Name = "btFecharTelaLucro";
            this.btFecharTelaLucro.Size = new System.Drawing.Size(75, 23);
            this.btFecharTelaLucro.TabIndex = 0;
            this.btFecharTelaLucro.Text = "Fechar";
            this.btFecharTelaLucro.UseVisualStyleBackColor = true;
            this.btFecharTelaLucro.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbValorFreteLucro
            // 
            this.tbValorFreteLucro.Location = new System.Drawing.Point(125, 71);
            this.tbValorFreteLucro.Name = "tbValorFreteLucro";
            this.tbValorFreteLucro.Size = new System.Drawing.Size(100, 20);
            this.tbValorFreteLucro.TabIndex = 1;
            this.tbValorFreteLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbDiariaLucro
            // 
            this.tbDiariaLucro.Location = new System.Drawing.Point(125, 115);
            this.tbDiariaLucro.Name = "tbDiariaLucro";
            this.tbDiariaLucro.Size = new System.Drawing.Size(100, 20);
            this.tbDiariaLucro.TabIndex = 2;
            this.tbDiariaLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbImpostoLucro
            // 
            this.tbImpostoLucro.Location = new System.Drawing.Point(125, 159);
            this.tbImpostoLucro.Name = "tbImpostoLucro";
            this.tbImpostoLucro.Size = new System.Drawing.Size(100, 20);
            this.tbImpostoLucro.TabIndex = 3;
            this.tbImpostoLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbCombustivelLucro
            // 
            this.tbCombustivelLucro.Location = new System.Drawing.Point(125, 204);
            this.tbCombustivelLucro.Name = "tbCombustivelLucro";
            this.tbCombustivelLucro.Size = new System.Drawing.Size(100, 20);
            this.tbCombustivelLucro.TabIndex = 4;
            this.tbCombustivelLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Frete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diaria Motorista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Impostos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(3, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Combustivel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Outras Despesas:";
            // 
            // tbOutrasDespesasLucro
            // 
            this.tbOutrasDespesasLucro.Location = new System.Drawing.Point(125, 247);
            this.tbOutrasDespesasLucro.Name = "tbOutrasDespesasLucro";
            this.tbOutrasDespesasLucro.Size = new System.Drawing.Size(100, 20);
            this.tbOutrasDespesasLucro.TabIndex = 9;
            this.tbOutrasDespesasLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // btCalcularLucro
            // 
            this.btCalcularLucro.Location = new System.Drawing.Point(126, 280);
            this.btCalcularLucro.Name = "btCalcularLucro";
            this.btCalcularLucro.Size = new System.Drawing.Size(100, 23);
            this.btCalcularLucro.TabIndex = 11;
            this.btCalcularLucro.Text = "Calcular";
            this.btCalcularLucro.UseVisualStyleBackColor = true;
            this.btCalcularLucro.Click += new System.EventHandler(this.btCalcularLucro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lbValorTotalLucro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 100);
            this.panel3.TabIndex = 12;
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
            this.label22.Location = new System.Drawing.Point(6, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Valor Total de Lucro:";
            // 
            // lbValorTotalLucro
            // 
            this.lbValorTotalLucro.AutoSize = true;
            this.lbValorTotalLucro.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalLucro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbValorTotalLucro.Location = new System.Drawing.Point(264, 38);
            this.lbValorTotalLucro.Name = "lbValorTotalLucro";
            this.lbValorTotalLucro.Size = new System.Drawing.Size(38, 23);
            this.lbValorTotalLucro.TabIndex = 0;
            this.lbValorTotalLucro.Text = "0.0";
            // 
            // FormLucroFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btCalcularLucro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOutrasDespesasLucro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCombustivelLucro);
            this.Controls.Add(this.tbImpostoLucro);
            this.Controls.Add(this.tbDiariaLucro);
            this.Controls.Add(this.tbValorFreteLucro);
            this.Controls.Add(this.btFecharTelaLucro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLucroFrete";
            this.Text = "FormLucroFrete";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFecharTelaLucro;
        private System.Windows.Forms.TextBox tbValorFreteLucro;
        private System.Windows.Forms.TextBox tbDiariaLucro;
        private System.Windows.Forms.TextBox tbImpostoLucro;
        private System.Windows.Forms.TextBox tbCombustivelLucro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOutrasDespesasLucro;
        private System.Windows.Forms.Button btCalcularLucro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbValorTotalLucro;
    }
}