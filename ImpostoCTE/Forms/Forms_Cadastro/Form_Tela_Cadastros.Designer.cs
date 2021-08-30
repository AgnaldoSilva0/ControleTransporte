
namespace ImpostoCTE.Forms.Forms_Cadastro
{
    partial class Form_Tela_Cadastros
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
            this.btCadastrarProduto = new System.Windows.Forms.Button();
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.btCadastrarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarProduto
            // 
            this.btCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrarProduto.Location = new System.Drawing.Point(75, 45);
            this.btCadastrarProduto.Name = "btCadastrarProduto";
            this.btCadastrarProduto.Size = new System.Drawing.Size(323, 54);
            this.btCadastrarProduto.TabIndex = 0;
            this.btCadastrarProduto.Text = "Cadastrar Produto";
            this.btCadastrarProduto.UseVisualStyleBackColor = false;
            this.btCadastrarProduto.Click += new System.EventHandler(this.btCadastrarProduto_Click);
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrarCliente.Location = new System.Drawing.Point(75, 119);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(323, 54);
            this.btCadastrarCliente.TabIndex = 1;
            this.btCadastrarCliente.Text = "Cadastrar Cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = false;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // btCadastrarFuncionario
            // 
            this.btCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrarFuncionario.Location = new System.Drawing.Point(75, 196);
            this.btCadastrarFuncionario.Name = "btCadastrarFuncionario";
            this.btCadastrarFuncionario.Size = new System.Drawing.Size(323, 54);
            this.btCadastrarFuncionario.TabIndex = 2;
            this.btCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btCadastrarFuncionario.Click += new System.EventHandler(this.btCadastrarFuncionario_Click);
            // 
            // Form_Tela_Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btCadastrarFuncionario);
            this.Controls.Add(this.btCadastrarCliente);
            this.Controls.Add(this.btCadastrarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Tela_Cadastros";
            this.Text = "Form_Tela_Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarProduto;
        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.Button btCadastrarFuncionario;
    }
}