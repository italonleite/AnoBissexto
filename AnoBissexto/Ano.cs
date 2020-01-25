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

        public string CalcularAno(int numero)
        {
            if (numero % 4 == 0)
            {
                if (numero % 100 == 0)
                {
                    string ebissexto = "O ANO É BISSEXTO";
                    return ebissexto;
                }
                else{
                    string ebissexto = "O ANO É BISSEXTO";
                    return ebissexto;
                }


            }
            else if (numero % 400 == 0)
            {
                string naoebissextou = "O ANO NAO É BISSEXTO";
                return naoebissextou;
            }
            else {
                string naoebissexto = "O ANO NAO É BISSEXTO";
                return naoebissexto;
            }

           
        }
    }
}
