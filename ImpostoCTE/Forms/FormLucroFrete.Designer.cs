
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.tbValorFrete = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.tbMdfe = new System.Windows.Forms.TextBox();
            this.tbCte = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btFecharTelaLucro = new System.Windows.Forms.Button();
            this.btArmazenarFrete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTomador = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.lbValorTotalLucro.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalLucro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbValorTotalLucro.Location = new System.Drawing.Point(430, 37);
            this.lbValorTotalLucro.Name = "lbValorTotalLucro";
            this.lbValorTotalLucro.Size = new System.Drawing.Size(38, 23);
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
            this.panel1.Location = new System.Drawing.Point(251, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 261);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.cbTomador);
            this.panel2.Controls.Add(this.tbPlaca);
            this.panel2.Controls.Add(this.dtData);
            this.panel2.Controls.Add(this.tbObservacao);
            this.panel2.Controls.Add(this.tbValorFrete);
            this.panel2.Controls.Add(this.tbCidade);
            this.panel2.Controls.Add(this.cbVeiculo);
            this.panel2.Controls.Add(this.tbMdfe);
            this.panel2.Controls.Add(this.tbCte);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 261);
            this.panel2.TabIndex = 14;
            // 
            // tbPlaca
            // 
            this.tbPlaca.HidePromptOnLeave = true;
            this.tbPlaca.Location = new System.Drawing.Point(93, 125);
            this.tbPlaca.Mask = "aaa0a00";
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(121, 20);
            this.tbPlaca.TabIndex = 31;
            this.tbPlaca.Click += new System.EventHandler(this.tbPlaca_Click);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(91, 12);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(123, 20);
            this.dtData.TabIndex = 30;
            this.dtData.Value = new System.DateTime(2021, 7, 21, 16, 57, 38, 0);
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(93, 231);
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(121, 20);
            this.tbObservacao.TabIndex = 29;
            // 
            // tbValorFrete
            // 
            this.tbValorFrete.Location = new System.Drawing.Point(93, 205);
            this.tbValorFrete.Name = "tbValorFrete";
            this.tbValorFrete.Size = new System.Drawing.Size(121, 20);
            this.tbValorFrete.TabIndex = 28;
            this.tbValorFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(93, 151);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(121, 20);
            this.tbCidade.TabIndex = 26;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Items.AddRange(new object[] {
            "MB",
            "MB 1620",
            "MB 710",
            "MB ATEGO",
            "MB ACCELO 815",
            "MB ACCELO 915",
            "MB ACCELO 1016",
            "VW Worker",
            "VW Delivery",
            "VW 8-120",
            "VW 8-150",
            "VW 9-160",
            "VW Constellation",
            "VW Constellation 24-250",
            "VW Constellation 24-280",
            "VW Constellation 13-190",
            "Ford Cargo",
            "VOLVO"});
            this.cbVeiculo.Location = new System.Drawing.Point(93, 97);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cbVeiculo.TabIndex = 24;
            // 
            // tbMdfe
            // 
            this.tbMdfe.Location = new System.Drawing.Point(93, 70);
            this.tbMdfe.Name = "tbMdfe";
            this.tbMdfe.Size = new System.Drawing.Size(121, 20);
            this.tbMdfe.TabIndex = 23;
            this.tbMdfe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // tbCte
            // 
            this.tbCte.Location = new System.Drawing.Point(93, 43);
            this.tbCte.Name = "tbCte";
            this.tbCte.Size = new System.Drawing.Size(121, 20);
            this.tbCte.TabIndex = 22;
            this.tbCte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedirLetrasTextBox);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(3, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tomador:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Cyan;
            this.label13.Location = new System.Drawing.Point(3, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Valor Frete:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(3, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Observação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Cyan;
            this.label11.Location = new System.Drawing.Point(3, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Placa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(3, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Veiculo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "MDFE: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "CTE: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Cyan;
            this.label15.Location = new System.Drawing.Point(21, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Armazenar Frete";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Cyan;
            this.label16.Location = new System.Drawing.Point(281, 33);
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
            // btArmazenarFrete
            // 
            this.btArmazenarFrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btArmazenarFrete.FlatAppearance.BorderSize = 0;
            this.btArmazenarFrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btArmazenarFrete.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArmazenarFrete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(229)))), ((int)(((byte)(190)))));
            this.btArmazenarFrete.Image = ((System.Drawing.Image)(resources.GetObject("btArmazenarFrete.Image")));
            this.btArmazenarFrete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btArmazenarFrete.Location = new System.Drawing.Point(0, 352);
            this.btArmazenarFrete.Name = "btArmazenarFrete";
            this.btArmazenarFrete.Size = new System.Drawing.Size(173, 45);
            this.btArmazenarFrete.TabIndex = 19;
            this.btArmazenarFrete.Text = "Armazenar";
            this.btArmazenarFrete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btArmazenarFrete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btArmazenarFrete.UseVisualStyleBackColor = false;
            this.btArmazenarFrete.Click += new System.EventHandler(this.btArmazenarFrete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(229)))), ((int)(((byte)(190)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(307, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbTomador
            // 
            this.cbTomador.AutoCompleteCustomSource.AddRange(new string[] {
            "Central do Adubo"});
            this.cbTomador.FormattingEnabled = true;
            this.cbTomador.Items.AddRange(new object[] {
            "MB",
            "MB 1620",
            "MB 710",
            "MB ATEGO",
            "MB ACCELO 815",
            "MB ACCELO 915",
            "MB ACCELO 1016",
            "VW Worker",
            "VW Delivery",
            "VW 8-120",
            "VW 8-150",
            "VW 9-160",
            "VW Constellation",
            "VW Constellation 24-250",
            "VW Constellation 24-280",
            "VW Constellation 13-190",
            "Ford Cargo",
            "VOLVO"});
            this.cbTomador.Location = new System.Drawing.Point(93, 177);
            this.cbTomador.Name = "cbTomador";
            this.cbTomador.Size = new System.Drawing.Size(121, 21);
            this.cbTomador.TabIndex = 32;
            // 
            // FormLucroFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btArmazenarFrete);
            this.Controls.Add(this.btFecharTelaLucro);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLucroFrete";
            this.Text = "FormLucroFrete";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox tbPlaca;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.TextBox tbValorFrete;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.TextBox tbMdfe;
        private System.Windows.Forms.TextBox tbCte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btFecharTelaLucro;
        private System.Windows.Forms.Button btArmazenarFrete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTomador;
    }
}