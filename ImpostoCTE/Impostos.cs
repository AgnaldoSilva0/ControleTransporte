using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE
{
    class Impostos
    {
        double icms, pis, cofins, impTri, conSocial, valorFrete;

        public Impostos(double icms, double pis, double cofins, double impTri, double conSocial)
        {
            this.icms = icms;
            this.pis = pis;
            this.cofins = cofins;
            this.impTri = impTri;
            this.conSocial = conSocial;
        }

        public Impostos()
        {
        }

        public double Icms { get => (18.0 / 100) * valorFrete; set => icms = value; }
        public double Pis { get => (0.65 / 100) * valorFrete; set => pis = value; }
        public double Cofins { get => (3.0 / 100) * valorFrete; set => cofins = value; }
        public double ImpTri { get => (1.2 / 100) * valorFrete; set => impTri = value; }
        public double ConSocial { get => (1.08 / 100) * valorFrete; set => conSocial = value; }
        public double ValorFrete { get => valorFrete; set => valorFrete = value; }
    }
}
