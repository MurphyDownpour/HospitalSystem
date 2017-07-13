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
            Sobe some = new Sobe();
        }
    }
    class Sobe
    {
        public List<string> shobeName = new List<string>() {
            "Pediatriya", "Stomatologiya", "Terapiya"
        };
        public List<string> pediatriyaDoctors = new List<string>()
        {
            "Fikret Hesenov", "Ruslan Bedelov", "Murad Tagiyev"
        };
        public List<string> stomatologiyaDoctors = new List<string>()
        {
            "Nusret Orucov", "Tamerlan Allahverdiyev", "Aleksey Kuznetsov"
        };
        public List<string> terapiyaDoctors = new List<string>()
        {
            "Michael Connor", "William Shapes", "Andrew Lincoln"
        };

        public Sobe()
        {
            ShowMenu();
        }

        public void ShowShobeler()
        {
            foreach (var item in shobeName)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowDoctors(List<string> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Shobeleri goster");
            Console.WriteLine("2. Shobe elave et");
            Console.WriteLine("3. Shobe sil");
            Console.WriteLine("4. Shobe melumatlarini deyis");
            Console.WriteLine("5. Hekim goster");
            Console.WriteLine("6. Hekim elave et");
            Console.WriteLine("7. Hekim sil");
            Console.WriteLine("8. Hekim melumatlarini deyis");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    show
                    break;
                case "2":
                    Console.Write("Shobenin adini daxil edin: ");
                    string newShobe = Console.ReadLine();
                    shobeName.Add(newShobe);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowShobeler();
                    break;
                case "3":
                    Console.WriteLine("Hansi shobe?");
                    int whichToDelete = Convert.ToInt32(Console.ReadLine());
                    if (whichToDelete > 0 && whichToDelete <= shobeName.Count)
                    {
                        shobeName.RemoveAt(--whichToDelete);
                    }
                    else
                    {
                        Console.WriteLine("Duzgun deyer girmemisiniz.");
                        goto case "3";
                    }
                    ShowShobeler();
                    break;
                case "4":
                    Console.WriteLine("Hansi shobe?");
                    int whichToUpdate = Convert.ToInt32(Console.ReadLine());
                    if (whichToUpdate > 0 && whichToUpdate <= shobeName.Count)
                    {
                        shobeName.RemoveAt(--whichToUpdate);
                        Console.WriteLine("Shobeye yeni ad yazin.");
                        newShobe = Console.ReadLine();
                        shobeName.Add(newShobe);
                        Console.WriteLine("Emeliyyat ugurla kecdi.");
                        ShowShobeler();
                    }
                    else
                    {
                        Console.WriteLine("Duzgun deyer girmemisiniz.");
                        goto case "4";
                    }
                    break;
                case "5":
                    Console.WriteLine("Hansi shobenin hekimlerini?");
                    ShowShobeler();
                    int addDoctors = Convert.ToInt32(Console.ReadLine());
                    switch (shobeName[--addDoctors])
                    {
                        case "Pediatriya":
                            ShowDoctors(pediatriyaDoctors);
                            break;
                        case "Stomatologiya":
                            ShowDoctors(stomatologiyaDoctors);
                            break;
                        case "Terapiya":
                            ShowDoctors(terapiyaDoctors);
                            break;
                        default:
                            Console.WriteLine("Duzgun deyer girmemisiniz.");
                            break;
                    }
                    break;
                case "6":
                    Console.WriteLine("Hansi shobeye?");
                    ShowShobeler();
                    addDoctors = Convert.ToInt32(Console.ReadLine());
                    string doctorName;
                    switch (shobeName[--addDoctors])
                    {
                        case "Pediatriya":
                            Console.WriteLine("Hekimin adini ve soyadini yazin.");
                            doctorName = Console.ReadLine();
                            pediatriyaDoctors.Add(doctorName);
                            Console.WriteLine("Emeliyyet ugurla kecdi.");
                            ShowDoctors(pediatriyaDoctors);
                            break;
                        case "Stomatologiya":
                            Console.WriteLine("Hekimin adini ve soyadini yazin.");
                            doctorName = Console.ReadLine();
                            stomatologiyaDoctors.Add(doctorName);
                            Console.WriteLine("Emeliyyet ugurla kecdi.");
                            ShowDoctors(stomatologiyaDoctors);
                            break;
                        case "Terapiya":
                            Console.WriteLine("Hekimin adini ve soyadini yazin.");
                            doctorName = Console.ReadLine();
                            terapiyaDoctors.Add(doctorName);
                            Console.WriteLine("Emeliyyet ugurla kecdi.");
                            ShowDoctors(terapiyaDoctors);
                            break;
                        default:
                            break;
                    }
                    break;
                case "7":
                    Console.WriteLine("Hansi shobeden?");
                    ShowShobeler();
                    whichToDelete = Convert.ToInt32(Console.ReadLine());
                    switch (shobeName[--whichToDelete])
                    {
                        case "Pediatriya":
                            ShowDoctors(pediatriyaDoctors);
                            Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                            whichToDelete = Convert.ToInt32(Console.ReadLine());
                            pediatriyaDoctors.RemoveAt(--whichToDelete);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(pediatriyaDoctors);
                            break;
                        case "Stomatologiya":
                            ShowDoctors(stomatologiyaDoctors);
                            Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                            whichToDelete = Convert.ToInt32(Console.ReadLine());
                            stomatologiyaDoctors.RemoveAt(--whichToDelete);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(stomatologiyaDoctors);
                            break;
                        case "Terapiya":
                            ShowDoctors(terapiyaDoctors);
                            Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                            whichToDelete = Convert.ToInt32(Console.ReadLine());
                            terapiyaDoctors.RemoveAt(--whichToDelete);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(terapiyaDoctors);
                            break;
                    }
                    break;
                case "8":
                    Console.WriteLine("Hansi sobeden?");
                    ShowShobeler();
                    whichToUpdate = Convert.ToInt32(Console.ReadLine());
                    switch (shobeName[--whichToUpdate])
                    {
                        case "Pediatriya":
                            ShowDoctors(pediatriyaDoctors);
                            Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                            whichToUpdate = Convert.ToInt32(Console.ReadLine());
                            pediatriyaDoctors.RemoveAt(--whichToUpdate);
                            Console.WriteLine("Yeni ad soyad verin.");
                            string pediatriyaDoctorName = Console.ReadLine();
                            pediatriyaDoctors.Insert(whichToUpdate, pediatriyaDoctorName);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(pediatriyaDoctors);
                            break;
                        case "Stomatologiya":
                            ShowDoctors(stomatologiyaDoctors);
                            Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                            whichToUpdate = Convert.ToInt32(Console.ReadLine());
                            stomatologiyaDoctors.RemoveAt(--whichToUpdate);
                            Console.WriteLine("Yeni ad soyad verin.");
                            string stomatologiyaDoctorName = Console.ReadLine();
                            stomatologiyaDoctors.Insert(whichToUpdate, stomatologiyaDoctorName);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(stomatologiyaDoctors);
                            break;
                        case "Terapiya":
                            ShowDoctors(terapiyaDoctors);
                            Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                            whichToUpdate = Convert.ToInt32(Console.ReadLine());
                            terapiyaDoctors.RemoveAt(--whichToUpdate);
                            Console.WriteLine("Yeni ad soyad verin.");
                            string terapiyaDoctorName = Console.ReadLine();
                            terapiyaDoctors.Insert(whichToUpdate, terapiyaDoctorName);
                            Console.WriteLine("Emeliyyat ugurla kecdi.");
                            ShowDoctors(terapiyaDoctors);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun deyer girmemisiniz.");
                    break;
            }
        }
    }
}
