using System;
using System.Collections.Generic;
using System.Text;

namespace AnoBissexto
{
    public class Ano
    {
        private int Numero { get; set; }

        public Ano()
        {

        }

        public string CalcularAno(int numero) {
            if (numero % 4 == 0) {
                int NumeroDivisivelPorQuatro = numero / 4;

                if (NumeroDivisivelPorQuatro % 100 == 0)
                {

                    string ebissexto = "O ANO É BISSEXTO";
                    return ebissexto;
                }
                else {
                    string ebissexto = "O ANO É BISSEXTO";
                    return ebissexto;
                }
               

            }
            string naoebissexto = "O ANO NÃO É BISSEXTO";
            return naoebissexto;
            
        }
    }
}
