using System;
using System.Globalization;

class Rozdzial4
{
    static void Main()
    {
        int przypadek;
        Console.WriteLine("Podaj numer zadania: ");
        przypadek = Convert.ToInt32(Console.ReadLine());

        switch (przypadek)
        {
            case 1:
                Rozdzial4.Zadanie1();
                break;
            case 2:
                Rozdzial4.Zadanie2();
                break;
            case 3:
                Rozdzial4.Zadanie3();
                break;
            case 4:
                Rozdzial4.Zadanie4();
                break;
            case 5:
                Rozdzial4.Zadanie5();
                break;
            case 6:
                Rozdzial4.Zadanie6();
                break;
            case 7:
                Rozdzial4.Zadanie7();
                break;
            case 8:
                Rozdzial4.Zadanie8();
                break;
            case 9:
                Rozdzial4.Zadanie9();
                break;
            case 10:
                Rozdzial4.Zadanie10();
                break;
            case 11:
                Rozdzial4.Zadanie11();
                break;
            case 12:
                Rozdzial4.Zadanie12();
                break;
            case 13:
                Rozdzial4.Zadanie13();
                break;
            case 14:
                Rozdzial4.Zadanie14();
                break;
            case 15:
                Rozdzial4.Zadanie15();
                break;
            default:
                Console.WriteLine("Błędny numer.");
                break;
        }
    }

    static bool isPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(number));

        for (int i = 2; i <= limit; ++i)
            if (number % i == 0)
                return false;
        return true;
    }
    static void Zadanie1()
    {
        /*Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
         * całkowitych wartościami podanymi przez użytkownika. Na początku działania programu
         * użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
         * elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.*/

        int elementNumber;

        Console.Write("Podaj liczbę elementów tablicy: ");
        elementNumber = Convert.ToInt32(Console.ReadLine());

        int[] intArray = new int[elementNumber];

        for (int i = 0; i < elementNumber; i++)
        {
            Console.WriteLine($"Podaj element numer {i+1}.");
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nPodane wartośc: ");
        foreach(int number in intArray)
            Console.WriteLine(number);
    }
    static void Zadanie2()
    {
        /*Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
         * wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10
         * (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji
         * tej tablicy.*/

        int[] tab1 = new int[10];
        int[] tab2 = new int[10];
        int liczba;

        for (int i=0; i<10; i++)
        {
            Console.WriteLine($"Podaj liczbę numer {i + 1} (liczba ma być >0): ");
            do
                liczba = Convert.ToInt32(Console.ReadLine());
            while (liczba < 0);

            tab1[i] = liczba;
        }

        for (int k = 0; k < tab1.Length; k++)
        {
            tab2[k] = tab1[k];
        }

        Console.WriteLine("Elementy tablicy nr 2: ");
        foreach (int i in tab2)
            Console.WriteLine(i);
    }
    static void Zadanie3()
    {
        /*Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy n-elementowej:
         * wartość i numer pozycji największego elementu,
         * wartość i numer pozycji najmniejszego elementu,
         * średnia wartości wszystkich elementów tablicy,
         * liczba dodatnich elementów tablicy.*/

        int liczbaElementow, podanyElement;
        Console.WriteLine("Podaj liczbę elementów tablicy: ");
        liczbaElementow = Convert.ToInt32(Console.ReadLine());

        int[] tab = new int[liczbaElementow];
        int maxWartosc = int.MinValue, maxIndex = 0, minWartosc = int.MaxValue, minIndex = 0, sumaElementow = 0, liczbaDodatnichElementow = 0;

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine($"Podaj element numer {i + 1}:");
            podanyElement = Convert.ToInt32(Console.ReadLine());
            tab[i] = podanyElement;

            if (podanyElement>maxWartosc)
            {
                maxWartosc = podanyElement;
                maxIndex = i;
            }
            if (podanyElement<minWartosc)
            {
                minWartosc = podanyElement;
                minIndex = i;
            }
            sumaElementow += podanyElement;
            if (podanyElement > 0)
                liczbaDodatnichElementow++;
        }

        Console.WriteLine($"Największy element ma wartość {maxWartosc} i znajduje się na pozycji {maxIndex}");
        Console.WriteLine($"Najmniejszy element ma wartość {minWartosc} i znajduje się na pozycji {minIndex}");
        Console.WriteLine("Wartość średnia elementów wynosi {0:F2}", sumaElementow/10);
        Console.WriteLine($"Liczba dodatnich elementów {liczbaDodatnichElementow}.");




    }
    static void Zadanie4()
    {
        /*Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
         * int. Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment
         * programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych) –
         * w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie
         * decydują argumenty podane w wywołaniu metody Next()).
         * Random rand = new Random();
         * for (int i = 0; i < 100; i++)
         * Console.Write("{0,8}", rand.Next(1, 1000));*/

        Random rand = new Random();
        int[] tab = new int[100];
        int element, primeCounter = 0;

        for (int i=0; i < tab.Length; i++)
        {
            element = rand.Next(1, 100);
            if (Rozdzial4.isPrime(element))
                primeCounter++;

            tab[i] = element;
        }
        Console.WriteLine($"W tabeli jest {primeCounter} liczb pierwszych.");
    }
    static void Zadanie5()
    {
        /*Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
         * wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o
         * jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
         * tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
         * indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
         * docelowej.*/

        int[] tab1 = { 1, 2, 3, 4, 5 };
        int[] tab2 = new int[5];

        for (int i=0; i<tab1.Length;i++)
        {
            if (i == tab1.Length - 1)
                tab2[i] = tab1[0];
            else
                tab2[i] = tab1[i + 1];
        }

        Console.WriteLine("\nElementy pierwszej tablicy:");
        foreach (int i in tab1)
            Console.Write(i + " ");
        
        Console.WriteLine("\nElementy drugiej tabliy:");
        foreach (int i in tab2)
            Console.Write(i + " ");
    }
    static void Zadanie6()
    {
        /*Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
         * rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po
         * wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej
         * tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).*/

        int[,] tablicaDwuWymiarowa = { {1,1,1,1,1}, { 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3 }, { 4, 4, 4, 4, 4 }, { 5, 5, 5, 5, 5 } };

        Console.WriteLine("Wyświetlenie liczb:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Wiersz numer {i}");
            for (int j=0; j < 5;j++)
                Console.WriteLine(tablicaDwuWymiarowa[i,j]);
        }

        Console.WriteLine("Liczby na przekątnych:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j)
                    Console.WriteLine(tablicaDwuWymiarowa[i, j]);
            }
        }

    }
    static void Zadanie7()
    {
        /*Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy
         * należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. Program ma wyświetlić
         * macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera
         * elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
         * element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o
         * tych samych indeksach macierzy B, element A [0,1] do B [0,1]... itd.*/

        int[,] tab1 = { { 1,1,1}, { 2,2,2} };
        int[,] tab2 = { { 3,3,3}, { 4,4,4} };
        int[,] tab3 = new int[2,3];

        for (int i=0; i<2; i++)
        {
            for(int j=0; j<3; j++)
            {
                tab3[i,j] = tab1[i, j] + tab2[i, j];
            }
        }

        Console.WriteLine("Macierz wynikowa:\n");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Wiersz {i}:");
            for (int j = 0; j < 3; j++)
                Console.WriteLine(tab3[i, j]);
        }
    }
    static void Zadanie8()
    {
        /*Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
         * zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim,
         * angielskim, niemieckim).*/
         
        string[,] dniTygodnia;
        dniTygodnia = new string[7, 3];
        
        dniTygodnia[0, 0] = "poniedzialek";
        dniTygodnia[0, 1] = "monday";
        dniTygodnia[0, 2] = "montag";

        dniTygodnia[1, 0] = "wtorek";
        dniTygodnia[1, 1] = "tuesday";
        dniTygodnia[1, 2] = "dienstag";

        dniTygodnia[2, 0] = "środa";
        dniTygodnia[2, 1] = "wednesday";
        dniTygodnia[2, 2] = "mittwoch";

        dniTygodnia[3, 0] = "czwartek";
        dniTygodnia[3, 1] = "thursday";
        dniTygodnia[3, 2] = "donnerstag";

        dniTygodnia[4, 0] = "piątek";
        dniTygodnia[4, 1] = "friday";
        dniTygodnia[4, 2] = "freitag";

        dniTygodnia[5, 0] = "sobota";
        dniTygodnia[5, 1] = "saturday";
        dniTygodnia[5, 2] = "samstag";

        dniTygodnia[6, 0] = "niedziela";
        dniTygodnia[6, 1] = "sunday";
        dniTygodnia[6, 2] = "sonntag";

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Dzień numer {i + 1}");
            Console.WriteLine($"\tPo polsku:    {dniTygodnia[i, 0]}");
            Console.WriteLine($"\tPo angielsku: {dniTygodnia[i, 1]}");
            Console.WriteLine($"\tPo niemiecku: {dniTygodnia[i, 2]}");
        }
    }
    static void Zadanie9()
    {
        /*Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
         * użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.*/

        Console.Write("Podaj łańcuch znaków: ");
        string ciagZnakow = Console.ReadLine();

        foreach (string i in ciagZnakow.Split())
            Console.WriteLine(i);

    }
    static void Zadanie10()
    {
        /*Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
         * miesiąc i wyświetli jego nazwę słownie.*/

        Console.WriteLine("Podaj datę w formacie DD-MM-RRRR:");
        string dataString = Console.ReadLine();
        string miesiac = dataString.Substring(3,2);

        switch (miesiac)
        {
            case "01":
                Console.WriteLine("Styczeń.");
                break;
            case "02":
                Console.WriteLine("Luty.");
                break;
            case "03":
                Console.WriteLine("Marzec.");
                break;
            case "04":
                Console.WriteLine("Kwiecień.");
                break;
            case "05":
                Console.WriteLine("Maj.");
                break;
            case "06":
                Console.WriteLine("Czerwiec.");
                break;
            case "07":
                Console.WriteLine("Lipiec.");
                break;
            case "08":
                Console.WriteLine("Sierpień.");
                break;
            case "09":
                Console.WriteLine("Wrzesień.");
                break;
            case "10":
                Console.WriteLine("Październik.");
                break;
            case "11":
                Console.WriteLine("Listopad.");
                break;
            case "12":
                Console.WriteLine("Grudzień.");
                break;
            default:
                Console.WriteLine("Błędny numer miesiąca.");
                break;
        }

    }
    static void Zadanie11()
    {
        /*Napisz program analizujący częstość występowania poszczególnych znaków w
         * łańcuchu znaków wprowadzonym przez użytkownika. Np. dla wprowadzonego tekstu
         * „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.*/

        Console.WriteLine("Podaj wyraz :");
        string tekst = Console.ReadLine();
        int counter;

        foreach (char i in tekst.Distinct())
        {
            counter = 0;
            foreach (char j in tekst)
            {
                if (i == j)
                    counter++;
            }
            Console.WriteLine($"{i} - {counter} ");
        }

            
    }
    static void Zadanie12()
    {
        /*Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej
         * zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.*/

        // fragment powieści A. A. Milne, "Kubuś Puchatek"
        string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
        "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
        "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
        "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
        "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

        Console.WriteLine("Zawartość zmiennej łańcuchowej:");
        Console.WriteLine(tekst);
        
        int liczbaWierszy=1;
        foreach(char i in tekst)
        {
            if (i == '\n')
                liczbaWierszy++;
        }
        Console.WriteLine("Liczba wierszy wynosi {0}", liczbaWierszy);

        Console.WriteLine("Kolejne wiersze mają następującą liczbę znaków:");
        foreach (string i in tekst.Split('\n'))
            Console.WriteLine(i.Length);
    }
    static void Zadanie13()
    {
        /*Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego
         * występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy
         * idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się
         * idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych
         * w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.*/

        string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
        int counter;
        string stringKontrolny="";
        
        foreach (string wyraz in tekst.Split())
        {
            counter = 0;
            
            if (stringKontrolny.Contains(wyraz))
                continue;

            foreach (string idk in tekst.Split())
            {
                if (idk == wyraz)
                    counter++;
            }
            if (counter>1)
                Console.WriteLine($"{wyraz} - {counter} razy");
            stringKontrolny += wyraz;
        }



    }
    static void Zadanie14()
    {
        /*W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz
         * czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. Przykładowe
         * identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową
         * tablicę typu string dla środków trwałych, którą należy zainicjalizować przykładowymi
         * identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę
         * lat, jakie upłynęły od jego zakupu.*/

        string[] tablica = {"KOMG-2002", "BH-2010", "DAW-2021", "DDAER-1993", "GTRG-1800"};
        int stringIndex, rok;
        foreach(string element in tablica)
        {
            stringIndex = element.IndexOf("-")+1;
            rok = int.Parse(element.Substring(stringIndex));
            Console.WriteLine($"Element {element} - {DateTime.Now.Year - rok}");
        }
    }
    static void Zadanie15()
    {
        /*Napisz program, który szyfruje podany przez użytkownika tekst prostym szyfrem
         * podstawieniowym zwanym „gaderypoluki”. Nazwa pochodzi od jednego z najczęściej
         * używanych kluczy GA-DE-RY-PO-LU-KI. Klucz ten zawiera pary znakowych zamienników
         * umieszczonych między myślnikami. Litery, których nie ma w kluczu pozostawia się w
         * szyfrowanym tekście bez zmian. Przykładowo tekst „DRZEWO” po zaszyfrowaniu ma postać
         * „EYZDWP”.*/

        string inputString = "drzewo";
        string outputString = "";

        inputString = inputString.ToUpper();

        foreach (char litera in inputString)
        {
            switch (litera)
            {
                case 'G':
                    outputString += 'A';
                    break;
                case 'A':
                    outputString += 'G';
                    break;
                case 'D':
                    outputString += 'E';
                    break;
                case 'E':
                    outputString += 'D';
                    break;
                case 'R':
                    outputString += 'Y';
                    break;
                case 'Y':
                    outputString += 'R';
                    break;
                case 'P':
                    outputString += 'O';
                    break;
                case 'O':
                    outputString += 'P';
                    break;
                case 'L':
                    outputString += 'U';
                    break;
                case 'U':
                    outputString += 'L';
                    break;
                case 'K':
                    outputString += 'I';
                    break;
                case 'I':
                    outputString += 'K';
                    break;
                default:
                    outputString += litera;
                    break;
            }
        }
        Console.WriteLine(outputString);
    }
}