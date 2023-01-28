using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico_progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos

            // Datos para numeros
            int num1 = 0;
            int num2 = 66, num3 = 3;
            long numslargos = 1231087381739187312;
            uint numsolopositivos = 1230123;
            ulong numLargosSoloPositivos = 1230813981012382211;
            byte numscortos = 255;
            sbyte numsmascortos = 127;
            int total = new int();

            // variable nula osea no da nada que no es igual a 0
            int? abcd = null;

            // Datos para decimales

            float decCortas = 3.50f;
            double declargos = 451.21312d;
            decimal mayordecimales = 2132.747612323m;

            //Datos booleanos

            bool bol = false;

            // datos para palabras o numeros que no vamos a sumar 

            string nombre = "guillermo";
            string apellido = "diaz";
            string relleno = "Maria Luisa";
            char soloLetra = 'A';
            char let = 'b';

            //var y dinamic 

            var variable = "hoy es un buen dia";
            var variable2 = 20 + 20;

            dynamic dinamico = "hoy es un gran dia para programar ";

            //variable tipo objeto

            var persona = new { NOMBRE = "Guillermo", APELLIDO = "Diaz", Edad = 36 };


            // para pedir cosas que pasan a variables
            Console.WriteLine("Digite el salario por hora");
            Double salario = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite un numero");
            num2 = int.Parse(Console.ReadLine());
            int todo = num1 + num2;

            // Para correr o mostrar en consola es este comando 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("la suma de las variables es de: " + todo);
            Console.WriteLine($"{persona.NOMBRE} {persona.APELLIDO} {persona.Edad}");

            Console.WriteLine(relleno);
            Console.WriteLine("total: " + total + " " + bol);
            Console.WriteLine(variable);

            // desplegar con parametros
            Console.WriteLine("la estudiante se llama{0}{1} ", relleno, soloLetra);

            // desplegar con interpolacion
            Console.WriteLine($"la estudiante se llama {relleno} {soloLetra} ");
            Console.ReadLine();
        }
    }
}
