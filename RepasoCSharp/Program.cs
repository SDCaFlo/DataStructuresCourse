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

Console.WriteLine("Ingrese un número.");
int num = int.Parse(Console.ReadLine());

for(int i=1; i <= num; i++)
{
    Console.WriteLine(i);
}