using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoURL
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestaManipulacaoDaURL();

            Console.ReadLine();
        
        }
            public static void TestaManipulacaoDaURL() {
                string URL = "https://www.netshoes.com.br/busca?nsCat=Natural&q=vasco";

                ExtratorValorDeArgumentos extratorValorDeArgumentos = new ExtratorValorDeArgumentos(URL);

                string valor = extratorValorDeArgumentos.getValor("q");

                Console.WriteLine(valor);
            }
    }
}
