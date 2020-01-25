using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ano ano = new Ano();
            var resultado = ano.CalcularAno(2011);
            Console.WriteLine(resultado.ToString());
            Console.ReadKey();
        }
    }
}
