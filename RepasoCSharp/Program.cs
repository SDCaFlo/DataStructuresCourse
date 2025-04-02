// See https://aka.ms/new-console-template for more information


//****** Repaso ***********//
//int numero2;
//numero2 = 11;

//double decimal1 = 5.5;
//float decimal2 = 5.5F;  // Indicar que el valor es de float con un sufijo
//float decimal3 = (float)5.5; // 'CASTEO': Indicamos que tipo de valor es.

//Console.WriteLine(decimal3);
//Console.WriteLine(decimal2);
//Console.WriteLine(decimal1); //Todos los valores se observan


using System;

namespace RepasoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Código");
            LinkedList lista = new LinkedList();
            lista.AppendNode(1);
            lista.AppendNode(2);
            lista.PrintValues();
            Console.WriteLine("éxito");
        }
    }
}
