using Caelum.Stella.CSharp.Http;
using System.Diagnostics;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "38440120";

            //string enderecoJson = new ViaCEP().GetEnderecoJson(cep);

            ViaCEP viaCEP = new ViaCEP();

            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            string enderecoXml = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXml);

            Debug.WriteLine("============================================");

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            Debug.WriteLine("============================================");

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}", endereco.Logradouro, endereco.Bairro));
        }

        public static void BuscaCEP(string cep) 
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";
            string result = new HttpClient().GetStringAsync(url).Result;
            Debug.WriteLine(result);
        }
    }
}