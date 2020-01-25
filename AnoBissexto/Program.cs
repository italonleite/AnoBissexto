using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ano ano = new Ano();
     
            var resultado = ano.CalcularAno(1900);
           
            Console.WriteLine(resultado.ToString());
            Console.ReadKey();
        }
    }
}
