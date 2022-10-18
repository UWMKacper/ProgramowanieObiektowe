using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ProgramowanieObiektowe
{
    class Rozdzial2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad 1. Przeliczanie temperatury z stopni C na stopnie F:\n");
            Rozdzial2.Zadanie1();
            Console.WriteLine("\nZad 2. Obliczenie delty równiania kwadratowego:\n");
            Rozdzial2.Zadanie2();
            Console.WriteLine("\nZad 3. Obliczenie wartości BMI:\n");
            Rozdzial2.Zadanie3();
        }

        static void Zadanie1()
        {
            /*Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w 
             * stopniach Fahrenheita. Program ma prosić użytkownika o podanie temperatury w stopniach
             * Celsjusza.*/

            float tempInCelsius, tempInFarenheit;

            Console.WriteLine("Podaj wartość temperatury w C: ");
            tempInCelsius = float.Parse(Console.ReadLine());
            tempInFarenheit = 32 + ((float)9 / 5) * tempInCelsius;
            Console.WriteLine("{0:F2}C to {1:F2}F.", tempInCelsius, tempInFarenheit);
        }

        static void Zadanie2()
        {
            /*Napisz program, który oblicza deltę dla równania kwadratowego ax^2 + b + c = 0. Program ma
             * prosić użytkownika o podanie współczynników równania a, b oraz c.*/

            int a, b, c, delta;

            Console.WriteLine("Podaj wartość a (int): ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość b (int): ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość c (int): ");
            c = int.Parse(Console.ReadLine());

            delta = (int)Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(delta);
        }

        static void Zadanie3()
        {
            /*Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić użytkownika o 
             * podanie wagi w kilogramach oraz wzrostu w metrach.*/

            float masa, wzrost, bmi;

            Console.WriteLine("Podaj masę w kg: ");
            masa = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = float.Parse(Console.ReadLine());

            bmi = masa / wzrost;
            Console.WriteLine("Twój wskaźnik BMI wynosi: {0:F2}", bmi);
        }

    }
}