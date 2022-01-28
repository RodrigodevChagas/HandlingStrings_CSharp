using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoURL
{
    internal class ExtratorValorDeArgumentos
    {
        public string URL { get; }
        public string _argumentos { get; }

        public ExtratorValorDeArgumentos(string url)
        {
            if (string.IsNullOrEmpty(url)) 
            {
                throw new ArgumentException("String nao pode ser nula ou estar vazia!!", nameof(url));
            }
            int indice = url.IndexOf('?');
            _argumentos = url.Substring(indice + 1);

            URL = url;
        }

        public string getValor(string parametro) 
        {
            parametro = parametro.ToUpper();
            string argumentosUpper = _argumentos.ToUpper();  
            
            string termo = parametro + "=" ;
            int indiceTermo = argumentosUpper.IndexOf(termo);
            
            string valor = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = valor.IndexOf('&');
            
            if (indiceEComercial == -1) 
            {
                return valor; 
            }

            return valor.Remove(indiceEComercial);
        }

    }
}

