
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLucroFrete));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btFecharTelaLucro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbValorFreteLucro
            // 
            this.tbValorFreteLucro.Location = new System.Drawing.Point(136, 16);
            this.tbValorFreteLucro.Name = "tbValorFreteLucro";
            this.tbValorFreteLucro.Size = new System.Drawing.Size(93, 20);
            this.tbValorFreteLucro.TabIndex = 1;
            this.tbValorFreteLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbDiariaLucro
            // 
            this.tbDiariaLucro.Location = new System.Drawing.Point(136, 60);
            this.tbDiariaLucro.Name = "tbDiariaLucro";
            this.tbDiariaLucro.Size = new System.Drawing.Size(93, 20);
            this.tbDiariaLucro.TabIndex = 2;
            this.tbDiariaLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbImpostoLucro
            // 
            this.tbImpostoLucro.Location = new System.Drawing.Point(136, 104);
            this.tbImpostoLucro.Name = "tbImpostoLucro";
            this.tbImpostoLucro.Size = new System.Drawing.Size(93, 20);
            this.tbImpostoLucro.TabIndex = 3;
            this.tbImpostoLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbCombustivelLucro
            // 
            this.tbCombustivelLucro.Location = new System.Drawing.Point(136, 149);
            this.tbCombustivelLucro.Name = "tbCombustivelLucro";
            this.tbCombustivelLucro.Size = new System.Drawing.Size(93, 20);
            this.tbCombustivelLucro.TabIndex = 4;
            this.tbCombustivelLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(14, 17);
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
            this.label2.Location = new System.Drawing.Point(14, 57);
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
            this.label3.Location = new System.Drawing.Point(14, 105);
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
            this.label4.Location = new System.Drawing.Point(14, 150);
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
            this.label5.Location = new System.Drawing.Point(14, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Outras Despesas:";
            // 
            // tbOutrasDespesasLucro
            // 
            this.tbOutrasDespesasLucro.Location = new System.Drawing.Point(136, 192);
            this.tbOutrasDespesasLucro.Name = "tbOutrasDespesasLucro";
            this.tbOutrasDespesasLucro.Size = new System.Drawing.Size(93, 20);
            this.tbOutrasDespesasLucro.TabIndex = 9;
            this.tbOutrasDespesasLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // btCalcularLucro
            // 
            this.btCalcularLucro.Location = new System.Drawing.Point(137, 225);
            this.btCalcularLucro.Name = "btCalcularLucro";
            this.btCalcularLucro.Size = new System.Drawing.Size(93, 23);
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
            this.panel3.Location = new System.Drawing.Point(0, 466);
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
            this.label22.Location = new System.Drawing.Point(248, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Valor Total de Lucro:";
            // 
            // lbValorTotalLucro
            // 
            this.lbValorTotalLucro.AutoSize = true;
            this.lbValorTotalLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalLucro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbValorTotalLucro.Location = new System.Drawing.Point(430, 37);
            this.lbValorTotalLucro.Name = "lbValorTotalLucro";
            this.lbValorTotalLucro.Size = new System.Drawing.Size(38, 24);
            this.lbValorTotalLucro.TabIndex = 0;
            this.lbValorTotalLucro.Text = "0.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbValorFreteLucro);
            this.panel1.Controls.Add(this.btCalcularLucro);
            this.panel1.Controls.Add(this.tbDiariaLucro);
            this.panel1.Controls.Add(this.tbImpostoLucro);
            this.panel1.Controls.Add(this.tbOutrasDespesasLucro);
            this.panel1.Controls.Add(this.tbCombustivelLucro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(89, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 261);
            this.panel1.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Cyan;
            this.label16.Location = new System.Drawing.Point(137, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Lucro de Frete";
            // 
            // btFecharTelaLucro
            // 
            this.btFecharTelaLucro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btFecharTelaLucro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btFecharTelaLucro.FlatAppearance.BorderSize = 0;
            this.btFecharTelaLucro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharTelaLucro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.btFecharTelaLucro.Image = ((System.Drawing.Image)(resources.GetObject("btFecharTelaLucro.Image")));
            this.btFecharTelaLucro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFecharTelaLucro.Location = new System.Drawing.Point(0, 433);
            this.btFecharTelaLucro.Name = "btFecharTelaLucro";
            this.btFecharTelaLucro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btFecharTelaLucro.Size = new System.Drawing.Size(480, 33);
            this.btFecharTelaLucro.TabIndex = 18;
            this.btFecharTelaLucro.Text = "EXIT";
            this.btFecharTelaLucro.UseVisualStyleBackColor = false;
            this.btFecharTelaLucro.Click += new System.EventHandler(this.btFecharTelaLucro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(229)))), ((int)(((byte)(190)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(118, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormLucroFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btFecharTelaLucro);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLucroFrete";
            this.Text = "FormLucroFrete";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btFecharTelaLucro;
        private System.Windows.Forms.Button button1;
    }
}