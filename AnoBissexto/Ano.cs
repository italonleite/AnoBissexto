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

        public string CalcularAno(int ano)
        {
            if (ano % 4 == 0 && ano % 100 != 0)
            {
                string ebissexto = "O ANO É BISSEXTO";
                return ebissexto;
            }
            else if (ano % 400 == 0)
            {
                string ebissexto = "O ANO É BISSEXTO";
                return ebissexto;
            }
            else {
                string naoebissexto = "O ANO NAO É BISSEXTO";
                return naoebissexto;
            }
           

        }
    }
}
