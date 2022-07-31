using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System.Diagnostics;

namespace Documentos
{
    class Program
    {
        private static void Main(string[] args)
        {
            Debug.WriteLine("\nValidando CPF =========================\n");

            string cpf1 = "15524732609";
            string cpf2 = "98745366797";
            ValidarCPF(cpf1);
            ValidarCPF(cpf2);

            Debug.WriteLine("\nValidando Cnpj =========================\n");

            string cnpj1 = "18745109000113";
            string cnpj2 = "11050622000141";
            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            Debug.WriteLine("\nValidando Titulo Eleitoral =========================\n");

            string titulo1 = "917684410191";
            string titulo2 = "271126250167";
            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Debug.WriteLine("\nFormatando Documentos =========================\n");

            Debug.WriteLine("CPF: "+ new CPFFormatter().Unformat(cpf1));
            Debug.WriteLine("CPF Formatado: " + new CPFFormatter().Format(cpf1));

            Debug.WriteLine("\nCnpj: " + new CNPJFormatter().Unformat(cnpj1));
            Debug.WriteLine("Cnpj Formatado: " + new CNPJFormatter().Format(cnpj1));

            Debug.WriteLine("\nTituloEleitoral: " + new TituloEleitoralFormatter().Unformat(titulo1));
            Debug.WriteLine("TituloEleitoral Formatado: " + new TituloEleitoralFormatter().Format(titulo1) +"\n");


            Debug.WriteLine("\n=============================================================================================\n");

            
        }

        private static void ValidarCPF(string cpf)
        {
            if(new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF válido " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido " + cpf);
            }
        }

        public static void ValidarCNPJ(string cnpj)
        {
            try
            {
                new CNPJValidator().AssertValid(cnpj);
                Debug.WriteLine("Cnpj válido " + cnpj);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cnpj válido " + cnpj + ":" + ex.Message);
            }
        }

        public static void ValidarTitulo(string titulo)
        {
            if(new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Titulo Válido " + titulo);
            }
            else
            {
                Debug.WriteLine("Titulo inválido "+ titulo);
            }
        }
    }
}