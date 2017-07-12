using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sobeler = new List<string>() {
                "1. Kardiologiya",
                "2. Travmatologiya",
                "3. Radiologiya"
            };
            List<string> kardiologiya = new List<string>()
            {
                "Memmed Memmedov", "Hikmet Hikmetov", "Filankes Filankesov"
            };
            List<string> tramvatologiya = new List<string>() {
                "Semed Vurgunov", "Fexreddin Zeynalov", "Gulcicek Israfilova"
            };
            List<string> radiologiya = new List<string>()
            {
                "Sevgi Toppusova", "Refiqe Filova", "Gulbahar Qarisqaova"
            };

            Console.WriteLine("Sobeler siyahisini gormek ucun 1 duymesini basin.");
            string prompt = Console.ReadLine();
            Console.WriteLine(new string('-', 30));

            if (prompt == "1")
            {
                foreach (var item in sobeler)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Duzgun deyer girmemisiniz.");
            }
            Console.WriteLine("Sobe secmek ucun 1 ve 3 arasinda reqem daxil edin: ");
            string prompt2 = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            if (prompt2 == "1")
            {
                foreach (var item in kardiologiya)
                {
                    Console.WriteLine(item);
                }
                EmeliyyatSecimi(kardiologiya);
            }
            else if (prompt2 == "2")
            {
                foreach (var item in tramvatologiya)
                {
                    Console.WriteLine(item);
                }
                EmeliyyatSecimi(tramvatologiya);
            }
            else if (prompt2 == "3")
            {
                foreach (var item in radiologiya)
                {
                    Console.WriteLine(item);
                }
                EmeliyyatSecimi(radiologiya);
            }
            else
            {
                Console.WriteLine("Duzgun deyer girmemisiniz.");
            }

            


            void EmeliyyatSecimi(List<string> some)
            {
                Console.WriteLine();
                Console.WriteLine("Emeliyyat secin: ");
                Console.Write("1. Hekim elave et ");
                Console.WriteLine("2. Hekimi sec ");
                string prompt3 = Console.ReadLine();
                Console.WriteLine(new string('-', 30));
                if (prompt3 == "1")
                {
                    Console.WriteLine("Hekimin adini ve soyadini daxil edin.");
                    some.Add(Console.ReadLine());
                    Console.WriteLine(new string('-', 30));
                    foreach (var item in some)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (prompt3 == "2")
                {
                    Console.WriteLine("Hansi hekim?");
                    int prompt4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(new string('-', 30));
                    if (prompt4 > 0 && prompt4 <= 3)
                    {
                        Console.WriteLine(some[--prompt4]);
                        Console.WriteLine("Hekimi silmek ucun delete yazin");
                        string prompt5 = Console.ReadLine();
                        Console.WriteLine(new string('-', 30));
                        if (prompt5 == "delete")
                        {
                            some.RemoveAt(prompt4);
                            foreach (var item in some)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Duzgun deyer girmemisiniz.");
                    }
                    
                }
            }
        }
    }
}
