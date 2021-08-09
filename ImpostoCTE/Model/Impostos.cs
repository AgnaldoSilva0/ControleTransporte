using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoCTE
{
    class Impostos
    {
        double valorFrete;
        public static double pis = 0.65;
        public static double icms = 18.0;
        public static double cofins = 3.0;
        public static double impTri = 1.2;
        public static double conSocial = 1.08;

        public Impostos()
        {
        }

        public double Icms { get => (icms / 100) * valorFrete; set => icms = value; }
        public double Pis { get => (pis / 100) * valorFrete; set => pis = value; }
        public double Cofins { get => (cofins / 100) * valorFrete; set => cofins = value; }
        public double ImpTri { get => (impTri / 100) * valorFrete; set => impTri = value; }
        public double ConSocial { get => (conSocial / 100) * valorFrete; set => conSocial = value; }
        public double ValorFrete { get => valorFrete; set => valorFrete = value; }
    }
}
