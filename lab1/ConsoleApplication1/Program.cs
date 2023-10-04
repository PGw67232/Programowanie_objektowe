using System;
//Zadanie 1.Napisz program, który sprawdzi, czy podana przez użytkownika liczba jest
//parzysta czy nieparzysta.
//Zadanie 2. Napisz program, który wypisze na konsoli wszystkie parzyste liczby od 1 do N,
//gdzie N jest liczbą wprowadzoną przez użytkownika.
//Zadanie 3. Napisz program, który wyświetli „menu” użytkownika. Po wybraniu pozycji z
//menu (poprzez podanie odpowiedniej liczby) program wykona odpowiednio przypisaną
//funkcję z pozostałych zadań.
//Zadanie 4. Napisz program, który obliczy silnie ze wskazanej przez użytkownika liczby.
//Zadanie 5. Napisz grę, w której komputer losuje liczbę, a użytkownik próbuje odgadnąć ją w
//jak najmniejszej liczbie prób.
//Zadanie 6. Napisz program, które umożliwia przeliczanie jednostek miar, takich jak
//przeliczanie temperatury między stopniami Celsiusza a stopniami Fahrenheita lub między
//jednostkami długości, np. metrami i centymetrami.
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad3();
            Console.ReadLine();
        }
        static void Zad1()
        {
            Console.Write("Wpisz liczbę: ");
            int x = int.Parse(Console.ReadLine());
            if (x%2==0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
            
        }
        static void Zad2()
        {
            Console.Write("Wpisz n: ");
            int n = int.Parse(Console.ReadLine());
            if (n>1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void Zad3()
        {
            Console.WriteLine("Które zadanie chcesz zobaczyć");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Zad1(); break;
                case 2: Zad2(); break;
                case 4:
                    Console.Write("Wpisz n: ");
                    int n = int.Parse(Console.ReadLine());
                    Zad4(n);
                    break;
                case 5: Zad5(); break;
                case 6: Zad6(); break;
                default: return;
                    
            }

        }
        static int Zad4(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Zad4(n - 1);
        }
        static void Zad5()
        {
            Random rnd = new Random();
            int computerChoice = rnd.Next(0, 10);
            Console.Write("Zgadnij liczbę: ");
            int input = int.Parse(Console.ReadLine());
            int count;
            do
            {
                if (input>computerChoice)
                {
                    Console.WriteLine("Wieksza");
                }
                else if (input < computerChoice)
                {
                    Console.WriteLine("Mniejsza");
                }
            }
            while (input != computerChoice)
                Console.WriteLine($"Zgadłeś, liczbs to:{computerChoice}");
        }
        static void Zad6()
        {

        }
    }

}