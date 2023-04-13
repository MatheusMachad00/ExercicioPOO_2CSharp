using ExercicioPOO_2;
using System;
using System.Globalization;


//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Employee x, y;

            x = new Employee();
            y = new Employee();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            x.name = Console.ReadLine();
            Console.WriteLine("Salário: ");
            x.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            y.name = Console.ReadLine();
            Console.WriteLine("Salário: ");
            y.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avarage = (x.salary + y.salary) / 2;

            Console.WriteLine("O salário médio dos dois funcionários é: " + avarage.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}