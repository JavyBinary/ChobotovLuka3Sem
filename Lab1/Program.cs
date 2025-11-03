using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            if (args.Length == 3 &&
                double.TryParse(args[0], out a) &&
                double.TryParse(args[1], out b) &&
                double.TryParse(args[2], out c))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Коэффициенты получены из командной строки:");
                Console.WriteLine($"A: {a} \nB: {b} \nC: {c}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Введите коэффициенты биквадратного уравнения (A*x^4 + B*x^2 + C = 0):");
                a = ReadCoefficient("A");
                b = ReadCoefficient("B");
                c = ReadCoefficient("C");
            }

            Console.WriteLine($"Уравнение: {a}x^4 + {b}x^2 + {c} = 0");
            SolveEquation(a, b, c);
        }

        private static double ReadCoefficient(string name)
        {
            double value;
            while (true)
            {
                Console.Write($"Введите коэффициент {name}: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите действительное число.");
                Console.ResetColor();
            }
        }

        private static void SolveEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Коэффициент A равен 0!");
                Console.ResetColor();
                return;
            }

            double D = b * b - 4 * a * c;
            bool hasRoots = false;

            if (D >= 0)
            {
                double t1 = (-b + Math.Sqrt(D)) / (2 * a);
                double t2 = (-b - Math.Sqrt(D)) / (2 * a);

                if (t1 >= 0)
                {
                    hasRoots = true;
                    double x1 = Math.Sqrt(t1);
                    double x2 = -x1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1: {x1} \nx2: {x2}");
                }

                if (t2 >= 0 && t1 != t2)
                {
                    hasRoots = true;
                    double x3 = Math.Sqrt(t2);
                    double x4 = -x3;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x3: {x3} \nx4: {x4}");
                }
            }

            if (!hasRoots)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Действительных корней нет!");
            }

            Console.ResetColor();
        }
    }
}
