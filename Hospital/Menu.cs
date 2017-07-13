using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    partial class Sobe
    {
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
                    ShowShobeler();
                    break;
                case "2":
                    AddShobe();
                    break;
                case "3":
                    DeleteShobe();
                    break;
                case "4":
                    UpdateShobe();
                    break;
                case "5":
                    ShowDoctorsInShobe();
                    break;
                case "6":
                    AddDoctor();
                    break;
                case "7":
                    DeleteDoctor();
                    break;
                case "8":
                    UpdateDoctor();
                    break;
                default:
                    Console.WriteLine("Duzgun deyer girmemisiniz.");
                    break;
            }
        }
    }
}
