using System.Diagnostics;
using System.Globalization;

namespace TrabalhandoComDatas
{
    class Program
    {
        public static void Main(string[] args)
        {
            var tabulacao = "{0}\t{1}\t{2}\t{3}\t{4}";

            DateTime data = new DateTime(2017, 9, 23);
            Debug.WriteLine(data);                                          //data e hora
            Debug.WriteLine(data.ToString("d"));                            //Data
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));  //data no formato pt-br
            Debug.WriteLine(data.ToString("dd/MM"));                        //Somente dia e mês
            Debug.WriteLine(data.ToString("dd/MM/yy"));                     //Dia, mês e ano

            Debug.WriteLine("====================================================================");

            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
            Debug.WriteLine(data);                                          //data e hora
            Debug.WriteLine(data.ToString("HH:mm"));                        //hora e minuto
            Debug.WriteLine(data.ToString("HH:mm:ss.fff"));                 //Somente hora, minuto, segundo e milissegundo da data

            Debug.WriteLine("====================================================================");

            Debug.WriteLine(data.ToString("D"));                            //Data por extenso
            Debug.WriteLine(data.ToString("m"));                            //Dia e mês por extenso
            Debug.WriteLine(data.ToString("Y"));                            //Mês e ano por extenso

            Debug.WriteLine("====================================================================");

            Debug.WriteLine(data.ToString("f"));                            //Data Completa
            Debug.WriteLine(data.ToString("g"));                            //Data, Minuto e segundos

            Debug.WriteLine("====================================================================");

            Debug.WriteLine(data.ToString("O"));                            //Formato de data "viajem de ida e volta", usado para converter data e string sem perda de percisão
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff")); //gerando um formato de data Universal que poderá ser convertido de volta para DateTime sem perda deprecisão

            Debug.WriteLine("====================================================================");

            Debug.WriteLine(data.ToString("t"));                            //Hora e Minutos
            Debug.WriteLine(data.ToString("T"));                            ///Hora, Minutos e segundos
        }
    }
}