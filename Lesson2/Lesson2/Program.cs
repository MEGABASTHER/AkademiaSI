using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Cwiczenie 1
             *  Stwórz metodę która przyjmuje w argumencie string, podzieli go na osobne wyrazy (wykorzystując metodę Split) i wydrukuje w konsoli
             *  wyłącznie te wyrazy, których dlugosc jest wieksza niz 5.
            
                Console.WriteLine("Podaj zdanie:");
                    String zdanie = Console.ReadLine();

                String[] podzieloneZdanie = zdanie.Split(' ');

                foreach(var ciag in podzieloneZdanie)
                {
                    if (ciag.Length > 5)
                    {
                        Console.WriteLine(ciag);                        
                    }
                }

                Console.ReadKey();
            */

            /*  Ćwiczenie 2
             *  Napisz metodę, która przyjmuje w argumencie tablice dowolnego typu I zwraca liste złozona z elementow tej tablicy.
            
                int range = 10;
                int[] table = new int[range];
                    for (int i = 0; i < range; i++)
                    {
                        table[i] = i + 1;
                    }

                var exampleList = table.ToList();

                foreach(var elements in exampleList)
                {
                    Console.WriteLine(elements);
                }
                Console.ReadKey();
                
            */

            /*  Ćwiczenie 3
             *  Stwórz klasę o nazwie Building. Ma ona posiadać conajmniej 4 pola o dowolnym typie, konstruktor przyjmujacy conajmniej jeden argument
             *  oraz kilka metod, ktore odzwierciedlają czynnosci wykonywane na budynkach. Dla uproszczenia metody mogą drukowac do konsoli opis
             *  wykonywanej czynności.
            
                Building palacKultury = new Building("Pałac Kultury", "Warszawa", "PlacDefilad", "1", "237");

                Building.AktualizujDane();

                Building.Info();

                Console.ReadKey();
            }

                public class Building
                {
                    static String name, localityName, streetName, height, buildingNumber;

                    public Building(string name, string localityName, string height, string streetName, string buildingNumber)
                    {
                        name = name;
                        localityName = localityName;
                        streetName = streetName;
                        buildingNumber = buildingNumber;
                        height = height;
                        Console.WriteLine($"Nazwa budynku: {name}");
                        Console.WriteLine($"Nazwa miejscowości: {localityName}");
                        Console.WriteLine($"Nazwa ulicy: {streetName}");
                        Console.WriteLine($"Numer budynku: {buildingNumber}");
                        Console.WriteLine($"Wysokość budynku: {height}");
                    }

                    public static void Info()
                    {
                        Console.WriteLine($"Nazwa budynku: {name}");
                        Console.WriteLine($"Nazwa miejscowości: {localityName}");
                        Console.WriteLine($"Nazwa ulicy: {streetName}");
                        Console.WriteLine($"Numer budynku: {buildingNumber}");
                        Console.WriteLine($"Wysokość budynku: {height}");
                    }

                    public static void Zburz()
                    {
                    Console.WriteLine("Budynek został zniszczony!");
                    }

                    public static void AktualizujDane()
                    {
                        Console.WriteLine("Podaj nazwę budynku");
                            name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwę miejscowości");
                            localityName = Console.ReadLine();
                        Console.WriteLine("Podaj nazwę ulicy");
                            streetName = Console.ReadLine();
                        Console.WriteLine("Podaj numer budynku");
                            buildingNumber = Console.ReadLine();
                        Console.WriteLine("Podaj wysokość budynku");
                            height = Console.ReadLine();
                    }
                }

        */

            /*  Ćwiczenie 4
             *  Stwórz interface IConnectable, który definiuje 2 metody Connect I Disconnect oraz 1 pole IsConnected (bool). Stwórz conajmniej 2
             *  klasy, które rozszerzają ten interface I definiują wymagane przez interface metody w specyficzny dla siebie sposob. Dla uproszczenia
             *  metody moga drukować w konsoli opis wykonywanej czynnosci
            
                Collector Zebra = new Collector();

                Zebra.Connect();

                Console.ReadKey();
        }
    }
            public interface IConnectable
            {
                void Connect();
                void Disconnect();

                bool IsConnected();
            }

            public class Collector: IConnectable
            {
                public void Connect()
                {
                    Console.WriteLine("Collector is connected");
                    _status = true;
                }

                public void Disconnect()
                {
                    Console.WriteLine("Collector is disonnected");
                    _status = false;
                }

                private bool _status;

                public bool IsConnected()
                {
                    return _status;
                }
            }
            public class Printer: IConnectable
            {
                public void Connect()
                {
                    Console.WriteLine("Printer is connected");
                    _status = true;
                }

                public void Disconnect()
                {
                    Console.WriteLine("Printer is disonnected");
                    _status = false;
                }

                private bool _status;

                public bool IsConnected()
                {
                    return _status;
                }
            }
            */

            /* Ćwiczenie 5
             * Wykorzystując interface I klasy, które go implementuja z poprzedniego zadania stwórz metode, która zwraca listę generyczna o typie
             * elementów Iconnectable zawierająca obiekty różnych klas. Napisz drugą metodę o nazwie SwitchAll, ktora uzyje Connect na odlączonych
             * obiektach, a Disconnect na podlączonych. Dla sprawdzenia stanu podlączenia obiektu wykorzystac pole IsConnected.
            
            Collector Zebra = new Collector();
            Printer Cannon = new Printer();
            Printer Posnet = new Printer();

            Zebra.Connect();
            Cannon.Connect();
            Posnet.Disconnect();

            List();
            Console.ReadKey();

            SwitchAll();
            Console.ReadKey();

            void List()
            {
                var ConnectableList = new List<IConnectable>();
                ConnectableList.Add(Zebra);
                ConnectableList.Add(Cannon);
                ConnectableList.Add(Posnet);

                foreach (var device in ConnectableList)
                {
                    Console.WriteLine(device);
                }
            }
            Console.ReadKey();

            void SwitchAll()
            {
                var ConnectableList = new List<IConnectable>();
                ConnectableList.Add(Zebra);
                ConnectableList.Add(Cannon);
                ConnectableList.Add(Posnet);
                foreach (var device in ConnectableList)
                {
                    if ((device.IsConnected()) == true)
                    {
                        device.Disconnect();
                    }
                    else if((device.IsConnected()) == false)
                    {
                        device.Connect();
                    }
                }

            }
            Console.ReadKey();

        }
    }
            public interface IConnectable
            {
                void Connect();
                void Disconnect();

                bool IsConnected();
            }

        public class Collector : IConnectable
        {
            public void Connect()
            {
                Console.WriteLine("Collector is connected");
                _status = true;
            }

            public void Disconnect()
            {
                Console.WriteLine("Collector is disonnected");
                _status = false;
            }

            private bool _status;
            public bool IsConnected()
            {
                return _status;
            }
        }
        public class Printer : IConnectable
        {
            public void Connect()
            {
                Console.WriteLine("Printer is connected");
                _status = true;
                
            }

            public void Disconnect()
            {
                Console.WriteLine("Printer is disonnected");
                _status = false;
            }

            private bool _status;

            public bool IsConnected()
            {
                return _status;
            }
        }
            */

            /*  Ćwiczenie 6
             *  Napisz metode statyczna, która porównuje stringi wzgledem ich kolejności alfabetycznej.
             *  Weź pod uwage nastepujace informacje:
             *  - obiekty typu string maja metode ELementAt(int), ktora zwraca znak (char) o danym indeksie w stringu
             *  - porównując znaki (char) porównywana jest ich wartosc liczbowa
             *  - metoda ElementAt rzuci wyjatek jesli sprobujemy zwrocic element o indeksie wykraczajacym poza dlugosc stringa
             *  - w przykładowych stringach "kot" i "kota" pierwszenstwo ma wyraz "kot"
             *  - litera "A" i "a" to inne znaki o innej wartosci wiec nalezy podniesc porownywane stringi do jednej wielkosci wszystkich liter
             *    wewnatrz metody porownujacej
             *  - metoda powinna sprawdzic czy porownywane stringi sa puste lub null i potraktowac je w takim wypadku jako pierwsze w kolejnosci
             *    alfabetycznej
            
            Console.WriteLine("Podaj dwa wyrazy do porównania");
                string a = Console.ReadLine();
                string b = Console.ReadLine();

            Equal(a, b);

            Console.ReadKey();        
        
            void Equal(string string1, string string2)
            {
              
                char znak1 = string1.ElementAt(0);
                char znak2 = string2.ElementAt(0);

                Console.WriteLine($"\nKopejność alfabetyczna wyrazów:");

                int i = 0;
                do
                {
                    if((i + 1) > string1.Length | (i + 1) > string2.Length)
                    {
                        break;
                    }

                if (string1.ToLower().ElementAt(i) < string2.ToLower().ElementAt(i))
                {
                    Console.WriteLine(string1);
                    Console.WriteLine(string2);

                    break;
                }
                else if (string1.ToLower().ElementAt(i) > string2.ToLower().ElementAt(i))
                {
                    Console.WriteLine(string2);
                    Console.WriteLine(string1);

                    break;
                }
                else if ((((i + 1) == string1.Length) | ((i + 1) == string2.Length)) & ((string1.ToLower().ElementAt(i)) == (string2.ToLower().ElementAt(i))))
                {
                    if(string1.Length > string2.Length)
                    {
                        Console.WriteLine(string2);
                        Console.WriteLine(string1);

                        break;
                    }
                    else if(string1.Length < string2.Length)
                    {
                        Console.WriteLine(string1);
                        Console.WriteLine(string2);

                        break;
                    }
                }
                else
                {
                    i++;
                }

                }
                while(true);
            }
            */
        }
    }
}
