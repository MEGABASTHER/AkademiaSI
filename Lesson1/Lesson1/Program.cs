using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Ćwiczenie 1
             *  Napisz program, który przyjmuje imię i wyświetla powitanie.

                Console.WriteLine("Podaj swoje Imię");
                    String imie = Console.ReadLine();
                Console.WriteLine("Witaj " + imie + "!");

            */

            /*  Ćwiczenie 2
             *  Napisz program, który na wejściu przyjmuje 3 liczby (całkowite lub nie), a na wyjściu wyświetla ich iloczyn.

                Console.WriteLine("Podaj trzy liczby:");
                    decimal a = decimal.Parse(Console.ReadLine());
                    decimal b = decimal.Parse(Console.ReadLine());
                    decimal c = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Iloczyn podanych liczb wynosi: " + (a * b * c));
                
            */

            /*  Ćwiczenie 3
             *  Napisz program, który obliczy powierzchnię i objętość kuli o promieniu R (parametr wejściowy) i je wyświetli.

                Console.WriteLine("Podaj promień kuli:");
                    double r = double.Parse(Console.ReadLine());
                                    
                Console.WriteLine("Powierzchnia kuli o podanym promieniu wynosi " + (4 * PI * r) + ", a jej objętość, to " + (4 / 3 * PI * (r * r * r)));
            */

            /*  Ćwiczenie 4
             *  Napisz program, który przyjmie trzy liczby (całkowite lub nie): x, y i z. I wyświetli informacje czy y jest pomiędzy x i z.
                
                Console.WriteLine("Podaj liczbę X:");
                    int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbę Y:");
                    int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbę Z:");
                    int z = int.Parse(Console.ReadLine());

                if (y < z && y > x)
                {
                    Console.WriteLine("Liczba Y znajduje się pomiędzy liczbami X i Z");
                }
                else
                {
                     Console.WriteLine("Liczba Y nie znajduje się pomiędzy liczbami X i Z");
                }
            */

            /*  Ćwiczenie 5
             *  Napisz program, który na wejściu przyjmuje 2 liczby całkowite, a na wyjściu wyświetla ich iloraz.

                Console.WriteLine("Podaj dwie liczby:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Iloraz podanych liczb, to: " + ((decimal)a / (decimal)b));
            */

            /*  Ćwiczenie 6
             *  Napisz program, który na wejściu przyjmuje 2 liczby całkowite, a na wyjściu wyświetla wynik ich dzielenia całkowitego (z resztą). Np. 1 / 2 = 0 r. 1 lub 10 / 3 = 3 r. 1, lub 9 / 3 = 3 r. 0

                 Console.WriteLine("Podaj dwie liczby do podzielenia:");

                     decimal a = decimal.Parse(Console.ReadLine());
                     decimal b = decimal.Parse(Console.ReadLine());

                 Console.WriteLine("Wyniz z dzielenia podanych liczb, to: " + (a / b));
             */
        }
    }
}
