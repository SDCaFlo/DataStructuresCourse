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
            lista.AppendNode(3);
            lista.AppendNode(4);
            lista.AppendNode(5);
            lista.AppendNode(6);
            lista.AppendNode(7);
            lista.AppendNode(8);
            lista.PrintValues();
            //buscamos el valor -1
            if (lista.SearchValue(-1)){
                Console.WriteLine("Se encontró el valor");
            }
            else
            {
                Console.WriteLine("No se encontró el valor");
            }
                Console.WriteLine("éxito");

            lista.DeleteElement(8);
            lista.DeleteElement(1);
            lista.DeleteElement(-3);
            lista.DeleteElement(3);
            lista.PrintValues();
        }
    }
}
