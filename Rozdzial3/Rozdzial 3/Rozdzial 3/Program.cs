using System;
using System.Data;

namespace ProgramowanieObiektowe
{
    class Rozdzial3
    {
        static void Main()
        {
            string pierwsze_menu, drugie_menu, tekst_drugiego_menu = "";

            Console.WriteLine("Wybierz typ zadań: ");
            Console.WriteLine("1. Zadania z rozwiązaniami.\n2. Zadania do samodzielnego rozwiązania.\n");
            Console.WriteLine("Podaj numer: ");
            pierwsze_menu = Console.ReadLine();

            if (pierwsze_menu == "1")
            {
                Console.WriteLine("1. Zadanie A.\n2. Zadanie B.\n3. Zadanie C.\n4. Zadanie C.\n");
                Console.WriteLine("Podaj numer: ");
                drugie_menu = Console.ReadLine();
                if (drugie_menu == "1")
                {
                    Console.WriteLine("\nZad A:\n");
                    Rozdzial3.ZadanieA();
                }
                else if (drugie_menu == "2")
                {
                    Console.WriteLine("\nZad B:\n");
                    Rozdzial3.ZadanieB();
                }
                else if (drugie_menu == "3")
                {
                    Console.WriteLine("\nZad C:\n");
                    Rozdzial3.ZadanieC();
                }
                else if (drugie_menu == "4")
                {
                    Console.WriteLine("\nZad D:\n");
                    Rozdzial3.ZadanieD();
                }
                else
                {
                    Console.WriteLine("\nNie ma takiego zadania.");
                }

            }
            else if (pierwsze_menu == "2")
            {
                for (int i = 1; i <= 15; i++)
                    tekst_drugiego_menu += $"{i}. Zadanie 3.{i}.\n";
                Console.WriteLine(tekst_drugiego_menu);
                Console.WriteLine("Podaj numer: ");
                drugie_menu = Console.ReadLine();

                switch (drugie_menu)
                {
                    case "1":
                        {
                            Console.WriteLine("\nZad 1:\n");
                            Rozdzial3.Zadanie1();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\nZad 2:\n");
                            Rozdzial3.Zadanie2();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\nZad 3:\n");
                            Rozdzial3.Zadanie3();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nZad 4:\n");
                            Rozdzial3.Zadanie4();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\nZad 5:\n");
                            Rozdzial3.Zadanie5();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nZad 6:\n");
                            Rozdzial3.Zadanie6();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("\nZad 7:\n");
                            Rozdzial3.Zadanie7();
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("\nZad 8:\n");
                            Rozdzial3.Zadanie8();
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine("\nZad 9:\n");
                            Rozdzial3.Zadanie9();
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine("\nZad 10:\n");
                            Rozdzial3.Zadanie10();
                            break;
                        }
                    case "11":
                        {
                            Console.WriteLine("\nZad 11:\n");
                            Rozdzial3.Zadanie11();
                            break;
                        }
                    case "12":
                        {
                            Console.WriteLine("\nZad 12:\n");
                            Rozdzial3.Zadanie12();
                            break;
                        }
                    case "13":
                        {
                            Console.WriteLine("\nZad 13:\n");
                            Rozdzial3.Zadanie13();
                            break;
                        }
                    case "14":
                        {
                            Console.WriteLine("\nZad 14:\n");
                            Rozdzial3.Zadanie14();
                            break;
                        }
                    case "15":
                        {
                            Console.WriteLine("\nZad 15:\n");
                            Rozdzial3.Zadanie15();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nNie ma takiego zadania.");
                            break;
                        }
                    
                }

            }
            else
            {
                Console.WriteLine("\nNie ma takiego polecenia.");
            }
        }

        static void ZadanieA()
        {
            /* Napisz program, który dla podanej przez użytkownika liczby całkowitej sprawdza, czy 
             * jest parzysta oraz czy jest ujemna.*/
            int liczba;
            string parzystosc=" jest parzysta.", nieujemnosc=" jest ujemna.";

            Console.WriteLine("Podaj liczbę całkowitą: ");
            
            liczba = int.Parse(Console.ReadLine());

            if (liczba%2!=0)
            {
                parzystosc = " jest nieparzysta.";
            }

            if (liczba>=0)
            {
                nieujemnosc = " jest dodatnia.";    
            }

            Console.WriteLine($"Liczba {liczba} {parzystosc} Oraz {nieujemnosc}");
        }
        static void ZadanieB()
        {
            /*Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien 
             * wypisać parzyste liczby znajdujące się pomiędzy podanymi wartościami.*/

            int liczba1, liczba2, min, max;

            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę całkowitą: ");
            liczba2 = int.Parse(Console.ReadLine());

            max = liczba2;
            min = liczba1;

            if (liczba2 < liczba1)
            {
                max = liczba1;
                min = liczba2;
            }

            Console.WriteLine("\nLiczby parzyste z podanego przedziału: ");
            for (; min <= max; min++)
            {
                if (min % 2 == 0)
                {
                    Console.WriteLine(min);
                }
            }
        }
        static void ZadanieC()
            {
                /*Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
                 * nich codziennie będzie odkładał na spłatę zadłużenia 20% swojego dziennego zarobku, Janek
                 * zarabia dziennie 50 zł, a Karol 40 zł. Napisz program, który przy pomocy pętli do..while
                 * sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną do spłaty swojego długu oraz
                 * wypisze wartość uzbieranej kwoty w każdym dniu.*/

                int zarobki = 90, zadluzenie=80, dniSplaty=0;
                float oszczednosciDzienne = zarobki * 0.2f, oszczednosci=0f;

                while(oszczednosci < zadluzenie)
                {
                    dniSplaty++;
                    oszczednosci += oszczednosciDzienne;
                }
                Console.WriteLine($"Janek i Karol pozbyli się długu w : {dniSplaty} dni.");
            }
        static void ZadanieD()
        {
            /*Napisz program, który wyświetla na ekranie konsoli „kwadrat” zbudowany ze znaku 
             * „*”. Liczbę wierszy (a tym samym kolumn) ma podać użytkownik.*/

            int wiersze;

            Console.WriteLine("Podaj a: ");
            wiersze = int.Parse(Console.ReadLine());

            for (int i = 0; i < wiersze; i++)
            {
                for (int k = 0; k < wiersze; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Zadanie1()
        {
            /*Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
             * przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych
             * przez 400).*/

            int rok;

            rok = DateTime.Now.Year;
            Console.WriteLine($"Mamy aktualnie {rok} rok.");

            if (rok%4==0 && (rok%400==0 || rok%100!=0))
            {
                Console.WriteLine("Rok jest przestępny.");
            }
            Console.WriteLine("Rok nie jest przestępny.");

        }
        static void Zadanie2()
        {
            /*Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
             * wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.*/

            int liczba1, liczba2;

            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę całkowitą: ");
            liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 % liczba2 == 0)
                Console.WriteLine("Liczba 2 jest dzielnikiem liczby 1.");
            else
                Console.WriteLine("Liczba 2 nie jest dzielnikiem liczby 1.");
        }
        static void Zadanie3()
        {
            /*Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość
             * największej z nich.*/

            int liczba1, liczba2, liczba3, max;

            Console.WriteLine("Podaj liczbę 1: ");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę 2: ");
            liczba2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę 3: ");
            liczba3 = int.Parse(Console.ReadLine());

            max = Math.Max(liczba1, Math.Max(liczba2, liczba3));

            Console.WriteLine($"Największą liczbą z podanych jest liczba {max}");
        }
        static void Zadanie4()
        {
            /*Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
             * zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik
             * operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5
             * oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.*/

            double zmienna1, zmienna2;
            string znak;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            zmienna1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj znak działania: ");
            znak = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę:");
            zmienna2 = double.Parse(Console.ReadLine());

            DataTable dt = new DataTable();
            var v = dt.Compute($"{zmienna1}{znak}{zmienna2}", "");

            Console.WriteLine($"\nWynik działania: {v}");
        }
        static void Zadanie5()
        {
            /*Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma
             * prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić
             * stosowny komunikat.*/

            int a, b, c, delta, pierwiastki=0;

            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta > 0)
                pierwiastki = 2;
            else if (delta==0)
                pierwiastki = 1;

            Console.WriteLine($"Liczba pierwiastków równania kwadratowego o zadanych parametrach wynosi: {pierwiastki}.");
        }
        static void Zadanie6()
        {
            /*Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić użytkownika o 
             * podanie wagi w kilogramach oraz wzrostu w metrach. Po obliczeniu wskaźnika BMI program
             * powinien wyświetlać stosowną informację w zależności od wartości wskaźnika:
             * < 18,5 – niedowaga, 18,5–24,99 – wartość prawidłowa, ≥ 25,0 – nadwaga.*/

            float masa, wzrost, bmi;
            string wynik = "niedowaga";

            Console.WriteLine("Podaj masę w kg: ");
            masa = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = float.Parse(Console.ReadLine())/100;

            bmi = masa / wzrost;

            if (bmi >= 18.5)
                {
                wynik = "wartość prawidłowa";
                if (bmi >= 25)
                    wynik = "nadwaga";
            }

            Console.WriteLine("Twój wskaźnik BMI wynosi: {0:F2}. Zatem ocena twojej sylwetki to: {1}", bmi, wynik);

        }
        static void Zadanie7()
        {
            /*Wykonaj program z przykładu 3.8 (str. 63) z użyciem instrukcji switch..case (zamiast if..else).*/

            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    {
                        Console.WriteLine("Poniedziałek");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Wtorek");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Środa");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Czwartek");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Piątek");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Sobota");
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Niedziela");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiego dnia tygodnia");
                        break;
                    }
            }            
            Console.ReadKey();
        }
        static void Zadanie8()
        {
            /*Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o
             * wysokości przysługującego stypendium.*/

            float srednia_ocen, naleznosc;

            Console.WriteLine("Podaj średnią ocen: ");
            srednia_ocen = float.Parse(Console.ReadLine());

            if (srednia_ocen >= 4 && srednia_ocen < 4.80)
                naleznosc = 350;
            else
                naleznosc = 550;

            Console.WriteLine($"Za twoją średnią należy się sypendium w wysokości: {naleznosc}");
        }
        static void Zadanie9()
        {
            /*Napisz program w czterech wariantach (a, b, c i d), którego efektem działania będzie
             * „figura” utworzona ze znaku gwiazdki (*).*/

            int wiersze, wiersze_c;
            string wariant, figura, spacje;

            Console.Write("Podaj liczbę wierszy: ");
            wiersze = int.Parse(Console.ReadLine());
            Console.Write("Wybierz jaka figura ma być zaprezentowana: a, b, c, d: ");
            wariant = Console.ReadLine();

            if (wariant == "a" || wariant == "c")
            {
                wiersze_c = wariant == "c" ? wiersze : -wiersze;
        
                for (int i = 1; i <= wiersze; i++)
                {
                    figura = String.Concat(Enumerable.Repeat("*", i));
                 
                    Console.WriteLine("{0," + wiersze_c + "}", figura);
                }
            }
            else if (wariant == "b")
            {
                for (int i = wiersze; i > 0; i--)
                {
                    figura = String.Concat(Enumerable.Repeat("*", i));

                    Console.WriteLine("{0," + -wiersze + "}", figura);
                }
            }
            else if (wariant == "d")
            {
                figura = String.Concat(Enumerable.Repeat("*", wiersze));
                Console.WriteLine(figura);
                for (int i = 2; i < wiersze; i++)
                {
                    spacje = String.Concat(Enumerable.Repeat(" ", wiersze - 2));
                    Console.WriteLine("*" + spacje + "*");
                }
                Console.WriteLine(figura);
            }
        }
        static void Zadanie10()
        {
            /*Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.*/

            int n, silnia=1;

            Console.Write("Podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                silnia *= i;

            Console.WriteLine($"Silnia wynosi: {silnia}");
        }
        static void Zadanie11()
        {
            /*Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 
             * 1) należy dodać do siebie, aby suma przekroczyła wartość 100.*/

            int counter = 0, suma = 1;

            for (int i = 2; suma < 100; i++, counter++)
                suma += i; 
            Console.WriteLine($"Potrzeba {counter} liczb.");
        }
        static void Zadanie12()
        {
            /*Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te
             * liczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero). Wynikiem działania programu
             * ma być informacja o sumie wprowadzonych przez użytkownika liczb.*/

            int liczba, suma=0;

            Console.WriteLine("Podawaj liczby całkowite, aby je zsumować. Podanie 0 zakończy program: ");
            
            do
            {
                liczba = int.Parse(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);

            Console.WriteLine($"Suma wynosi: {suma}");
        }
        static void Zadanie13()
        {
            /*Napisz program obliczający sumę szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest
             * dowolną liczbą naturalną, którą program ma wczytać.*/

            int n, suma = 0;

            Console.Write("Podaj liczbę naturalną n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                if (i % 2 == 0)
                    n *= -1;
                suma += n;
            }

            Console.WriteLine($"Suma szeregu wynosi: {suma}");
        }
        static void Zadanie14()
        {
            /*Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych od niej
             * samej np. 6=1+2+3=6 – jest liczbą doskonałą. Napisz program znajdujący liczby doskonałe w
             * przedziale <1,n>, gdzie n podaje użytkownik.*/

            int n, counter;
            string liczby = "";

            Console.Write("Podaj liczbę całkowitą n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                counter = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                        counter += k;
                }

                if (counter == i)
                    liczby += $" {i}";
            }

            Console.WriteLine($"Liczby doskonałe to: {liczby}.");
        }
        static void Zadanie15()
        {
            /*Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów można
             * wypłacić 10 zł. Napisz program, który wyświetli w oknie konsoli wszystkie możliwe
             * kombinacje.*/

            int suma;
            string liczba;

            Console.WriteLine(String.Concat(Enumerable.Repeat(" 1zł", 10)));
            for (int i = 1; i <=5; i++)
            {
                suma = 2*i;
                liczba = "\n";
                liczba += String.Concat(Enumerable.Repeat(" 2zł", i));
                for (int j = 0; suma < 10; j++)
                {
                    suma += 1;
                    liczba += " 1zł";
                }
                Console.Write(liczba);
            }

            

            for (int k = 1; k <= 2; k++)
            {
                suma = 5;
                liczba = "\n 5zł";
                suma += 2*k;
                liczba += String.Concat(Enumerable.Repeat(" 2zł", k));
                for (int j = 0; suma < 10; j++)
                {
                    suma += 1;
                    liczba += " 1zł";
                }
                Console.Write(liczba);
            }          
            
            Console.WriteLine("\n 5zł 5zł");

        }
    }
}