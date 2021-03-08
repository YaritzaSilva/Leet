using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoPadrão;

            Console.Write("Texto a ser traduzido: ");
            textoPadrão= Console.ReadLine();

            string textoModificado= textoPadrão.Replace("A","4");
            textoModificado=textoModificado.Replace("a","4");
            textoModificado=textoModificado.Replace("E","3");
            textoModificado=textoModificado.Replace("e","3");
            textoModificado=textoModificado.Replace("I","1");
            textoModificado=textoModificado.Replace("i","1");
            textoModificado=textoModificado.Replace("L","1");
            textoModificado=textoModificado.Replace("l","1");
            textoModificado=textoModificado.Replace("O","0");
            textoModificado=textoModificado.Replace("o","0");
            textoModificado=textoModificado.Replace("T","7");
            textoModificado=textoModificado.Replace("t","7");
            textoModificado=textoModificado.Replace("S","5");
            textoModificado=textoModificado.Replace("s","5");


           Console.WriteLine($"Seu texto:{textoModificado}");
        }
    }
}
