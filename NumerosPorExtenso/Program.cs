using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

namespace NumerosPorExtenso
{
    class Program
    {
        public static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1337;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            Debug.WriteLine("==========================================");

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 1337.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
        }
    }
}