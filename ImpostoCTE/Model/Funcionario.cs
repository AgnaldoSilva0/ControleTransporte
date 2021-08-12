using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE.Model
{
    class Funcionario
    {
        private int id;
        private string nome, admissao, telefone;
        private double salarioSemanal;
        private string funcao;

        public Funcionario(int id, string nome, string admissao, string telefone, double salarioSemanal, string funcao)
        {
            this.id = id;
            this.nome = nome;
            this.admissao = admissao;
            this.telefone = telefone;
            this.salarioSemanal = salarioSemanal;
            this.funcao = funcao;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Admissao { get => admissao; set => admissao = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public double SalarioSemanal { get => salarioSemanal; set => salarioSemanal = value; }
        public string Funcao { get => funcao; set => funcao = value; }
    }
}
