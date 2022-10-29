using System;
using System.Security.Cryptography.X509Certificates;

class Rozdzial5
{
    static void Main()
    {
        Console.WriteLine("Zad 1");
        Console.WriteLine(Zadanie1(50));

        Console.WriteLine("\nZad 2");
        bool zadanie2 = Zadanie2(1, 3, 3);
        if (zadanie2)
            Console.WriteLine("PRAWDA");
        else
            Console.WriteLine("FAŁSZ");

        Console.WriteLine("\nZad 3");
        Zadanie3(2.2, 1.1);

        Console.WriteLine("\nZad 4a");
        int[] zad_4 = { 1, 2, 3 }, zad_4_a;
        zad_4_a = Zadanie4_a(zad_4, 5);
        foreach(int i in zad_4_a)
            Console.WriteLine(i);
        Console.WriteLine("\nZad 4b");
        Zadanie4_b(ref zad_4, 5);
        foreach (int i in zad_4)
            Console.WriteLine(i);

        Console.WriteLine("\nZad 5");
        Zadanie5();

        Console.WriteLine("\nZad 6");
        Zadanie6();

        Console.WriteLine("\nZad 7");
        Console.WriteLine("Podaj x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wynik to {Zadanie7(x=x, n=n)}");

        Console.WriteLine("\nZad 8");
        Zadanie8();
        
        Console.WriteLine("\nZad 9a");
        Console.WriteLine("Podaj n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wynik Fibonacciego to: {Zadanie9a(n)}");
        Console.WriteLine("\nZad 9b");
        Zadanie9b(n);
        
        Console.WriteLine("\nOblicz");
        Console.WriteLine(Oblicz(5));
    }

    static double Zadanie1(double farenhajty)
    {
        /*Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach
         * Fahrenheita na temperaturę w stopniach Celsjusza. Metoda ma przyjmować jeden argument
         * (temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.*/

        return ((double)5 / 9) * (farenhajty - 32);
    }
    static bool Zadanie2(int a, int b, int x)
    {
        /*Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący
         * metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego (a, b).
         * Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie
         * Main() z podaniem stosownego komunikatu.*/

        return x > a && x < b;
    }
    static void Zadanie3(double x, double y)
    {
        /*Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor.
         * W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj
         * współrzędne wektora wek [3, 2], a następnie wywołaj metodę o nazwie Przesun(), która ma
         * przesunąć punkt A o wektor wek (dodać odpowiednie współrzędne). Współrzędne punktu
         * (jako dwie zmienne typu double) mają zostać przesłane do tej metody przez referencję, a
         * współrzędne wektora (także jako dwie zmienne typu double) przez wartość. Metoda
         * Przesun() ma nic nie zwracać (void), aktualne współrzędne punktu mają być pamiętane dzięki
         * użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne
         * punktu po przesunięciu o wektor wek. Przykładowo, gdyby użytkownik podał początkowe
         * współrzędne punktu A (2, 1), to wówczas program znajdzie położenie punktu A po
         * przesunięciu w miejscu o współrzędnych (5, 3) (czyli 2+3, 1+2).*/
        Console.WriteLine($"Zmienne przed metodą: x={x}, y={y}");
        Przesuniecie(ref x,ref y);
        Console.WriteLine($"Zmienne po metodzie: x={x}, y={y}");
    }
    static void Przesuniecie(ref double x, ref double y)
    {
        x += 3;
        y += 2;
    }
    static int[] Zadanie4_a(int[] tab, int a)
    {
        /*Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę.
         * Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
         * int oraz liczbę całkowitą (mnożnik).Wykonaj zadanie w dwóch wariantach:
         * a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona przez metodę.
         * b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej
         * argumentem metody (w tym wariancie metoda ma niczego nie zwracać).
         * Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien
         * wyświetlić tablicę {2,8,12,16,4}.*/
        int[] new_tab = new int[tab.Length];

        for (int i = 0; i < tab.Length; i++)
        {
            new_tab[i] = tab[i]*a;
        }

        return new_tab;
    }
    static void Zadanie4_b(ref int[] tab, int a)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] *= a;
        }
    }
    static void Rysuj(int dlugosc, int szerokosc, string znak)
    {
        for (int i=0; i < dlugosc; i++)
        {
            for (int j = 0; j < szerokosc; j++)
                Console.Write(znak);
            Console.Write('\n');
        }
        
    }
    static void Zadanie5()
    {
        /*Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma
         * prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak,
         * którym ma być zapełniony prostokąt. Napisz metodę Rysuj(), która wypisze na konsoli
         * prostokąt, przesyłając jako argument długość, szerokość oraz znak wypełnienia. Wywołaj
         * metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości.
         * W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący”
         * oraz drugi „stojący”. Przykładowy przebieg działania programu na rysunku:*/

        int dlugosc, szerokosc;
        string znak;

        Console.WriteLine("Podaj szerokosc: ");
        szerokosc = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj dlugosc: ");
        dlugosc = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj znak: ");
        znak = Console.ReadLine();

        Rysuj(dlugosc = dlugosc, szerokosc = szerokosc, znak = znak);

    }
    static string[] Zadanie4_a(string[] tab, int a)
    {
        string[] new_tab = new string[tab.Length];

        for (int i = 0; i < tab.Length; i++)
        {
            for(int j= 0; j < a; j++)
                new_tab[i] = String.Concat(new_tab[i], tab[i]);
        }

        return new_tab;
    }
    static void Zadanie6()
    {
        /*Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną
         * przyjmującą tablicę typu string oraz mnożnik typu int. W tym przypadku metoda ma powielać
         * łańcuch znaków (konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o
         * elementach {"ala", "kot", "dom"} oraz mnożniku 2 program powinien wyświetlić tablicę
         * {"alaala", "kotkot", "domdom"}.*/

        string[] zad_6 = { "ala", "kot", "dom" };
        zad_6 = Zadanie4_a(zad_6, 5);
        foreach (string i in zad_6)
            Console.WriteLine(i);
    }
    static int Zadanie7(int x, int n)
    {
        /*Napisz statyczną metodę, która oblicza wyrażenie:
         * W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywołaj funkcję dla x i n
         * (liczb naturalnych) wczytanych z klawiatury.*/

        int w = 0;

        for (int i=1; i<=n; i++)
        {
            w += (x + i);
        }

        return w;
    }
    static void Zadanie8()
    {
        /*Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym
         * wywołaj funkcję dla x wczytanego z klawiatury. Przykładowo jeśli użytkownik wpisze 125,
         * to metoda powinna zwrócić wartość 8 (1+2+5=8).*/

        Console.WriteLine("Podaj liczbę naturalną: ");
        string x = Console.ReadLine();
        int suma_cyfr = 0;

        foreach (char cyfra in x)
            suma_cyfr += cyfra - '0';

        Console.WriteLine($"Suma cyfr liczby {x} wynosi {suma_cyfr}.");
    }

    static int Zadanie9a(int n)
    {
        /*Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego według wzoru.
         * Wykonaj program w dwóch wariantach:
         * w jednym metoda znajdująca wyraz ciągu ma być rekurencyjna,
         * a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli).*/
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        return Zadanie9a(n - 1) + Zadanie9a(n - 2) +1;
    }
    static void Zadanie9b(int n)
    {
        /*Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego według wzoru.
         * Wykonaj program w dwóch wariantach:
         * w jednym metoda znajdująca wyraz ciągu ma być rekurencyjna,
         * a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli).*/

        int[] fibb_arr = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            if (i == 0 || i == 1)
            {
                fibb_arr[i] = i;
            }
            else
            {
                fibb_arr[i] = fibb_arr[i - 1] + fibb_arr[i - 2];
            }
        }
        Console.WriteLine($"Wynik Fibonacciego to: {fibb_arr.Sum()}");
    }

    static int Oblicz(int n)
    {
        if (n <= 1) return (1);
        else return (n + Oblicz(n - 1));
    }
}
