using System;

namespace SintaxisBásica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer programa

            //Este es mi primer programa
            //Console.WriteLine("Welcome to C#!");

            //int edad = 12;
            //Console.WriteLine(edad);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Inicialización de varias variables con el mismo valor

            //string nombrePersona1;
            //string nombrePersona2;
            //string nombrePersona3;
            //string nombrePersona4;

            //nombrePersona1 = nombrePersona2 = nombrePersona3 = nombrePersona4 = "Kevin";
            //string nombreAnimal1, nombreAnimal2, nombreAnimal3, nombreAnimal4 = "Tigre";

            //Console.WriteLine(nombrePersona1);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Conversión explícita / Casting


            //1er ejemplo
            //double tempGlobal = 27.6;
            //int tempStoDgo;

            //tempStoDgo = (int) tempGlobal;
            //Console.WriteLine(tempStoDgo);


            //2do ejemplo
            //Console.WriteLine("Introduce un número: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Introduce otro número: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"La suma de los números ingresados anteriormente es: {num1 + num2}");
            //Console.ReadKey();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Constantes

            //1er ejemplo
            //const int VALOR = 10;
            //Console.WriteLine("El valor de la constante es: {0}", VALOR);


            //2do ejemplo
            //const double PI = 3.14;

            //Console.WriteLine("Introduce la medida del radio: " );
            //double radio = double.Parse(Console.ReadLine());
            //double area = (radio * radio) * PI;
            ////double area = Math.Pow(radio, 2) * PI;
            //Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
