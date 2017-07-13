using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    partial class Sobe
    {
        public void ShowShobeler()
        {
            foreach (var item in shobeName)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowDoctorsInList(List<string> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowDoctorsInShobe()
        {
            Console.WriteLine("Hansi shobenin hekimlerini?");
            ShowShobeler();
            int addDoctors = Convert.ToInt32(Console.ReadLine());
            switch (shobeName[--addDoctors])
            {
                case "Pediatriya":
                    ShowDoctorsInList(pediatriyaDoctors);
                    break;
                case "Stomatologiya":
                    ShowDoctorsInList(stomatologiyaDoctors);
                    break;
                case "Terapiya":
                    ShowDoctorsInList(terapiyaDoctors);
                    break;
                default:
                    Console.WriteLine("Duzgun deyer girmemisiniz.");
                    break;
            }
        }

        public void AddShobe()
        {
            Console.Write("Shobenin adini daxil edin: ");
            string newShobe = Console.ReadLine();
            shobeName.Add(newShobe);
            Console.WriteLine("Emeliyyat ugurla kecdi.");
            ShowShobeler();
        }

        public void DeleteShobe()
        {
            Console.WriteLine("Hansi shobe?");
            ShowShobeler();
            int whichToDelete = Convert.ToInt32(Console.ReadLine());
            if (whichToDelete > 0 && whichToDelete <= shobeName.Count)
            {
                shobeName.RemoveAt(--whichToDelete);
                Console.WriteLine("Emeliyyat ugurla kecdi.");
            }
            else
            {
                Console.WriteLine("Duzgun deyer girmemisiniz.");
            }
            ShowShobeler();
        }

        public void UpdateShobe()
        {
            Console.WriteLine("Hansi shobe?");
            Console.WriteLine(new string('-', 30));
            ShowShobeler();
            int whichToUpdate = Convert.ToInt32(Console.ReadLine());
            if (whichToUpdate > 0 && whichToUpdate <= shobeName.Count)
            {
                shobeName.RemoveAt(--whichToUpdate);
                Console.WriteLine("Shobeye yeni ad yazin.");
                string newShobe = Console.ReadLine();
                shobeName.Insert(whichToUpdate, newShobe);
                Console.WriteLine("Emeliyyat ugurla kecdi.");
                ShowShobeler();
            }
            else
            {
                Console.WriteLine("Duzgun deyer girmemisiniz.");
            }
        }

        public void DeleteDoctor()
        {
            Console.WriteLine("Hansi shobeden?");
            ShowShobeler();
            int whichToDelete = Convert.ToInt32(Console.ReadLine());
            switch (shobeName[--whichToDelete])
            {
                case "Pediatriya":
                    ShowDoctorsInList(pediatriyaDoctors);
                    Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                    whichToDelete = Convert.ToInt32(Console.ReadLine());
                    pediatriyaDoctors.RemoveAt(--whichToDelete);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(pediatriyaDoctors);
                    break;
                case "Stomatologiya":
                    ShowDoctorsInList(stomatologiyaDoctors);
                    Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                    whichToDelete = Convert.ToInt32(Console.ReadLine());
                    stomatologiyaDoctors.RemoveAt(--whichToDelete);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(stomatologiyaDoctors);
                    break;
                case "Terapiya":
                    ShowDoctorsInList(terapiyaDoctors);
                    Console.WriteLine("Hansi hekimi silmek isteyirsiniz?");
                    whichToDelete = Convert.ToInt32(Console.ReadLine());
                    terapiyaDoctors.RemoveAt(--whichToDelete);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(terapiyaDoctors);
                    break;
            }
        }

        public void AddDoctor()
        {
            Console.WriteLine("Hansi shobeye?");
            ShowShobeler();
            int addDoctors = Convert.ToInt32(Console.ReadLine());
            string doctorName;
            switch (shobeName[--addDoctors])
            {
                case "Pediatriya":
                    Console.WriteLine("Hekimin adini ve soyadini yazin.");
                    doctorName = Console.ReadLine();
                    pediatriyaDoctors.Add(doctorName);
                    Console.WriteLine("Emeliyyet ugurla kecdi.");
                    ShowDoctorsInList(pediatriyaDoctors);
                    break;
                case "Stomatologiya":
                    Console.WriteLine("Hekimin adini ve soyadini yazin.");
                    doctorName = Console.ReadLine();
                    stomatologiyaDoctors.Add(doctorName);
                    Console.WriteLine("Emeliyyet ugurla kecdi.");
                    ShowDoctorsInList(stomatologiyaDoctors);
                    break;
                case "Terapiya":
                    Console.WriteLine("Hekimin adini ve soyadini yazin.");
                    doctorName = Console.ReadLine();
                    terapiyaDoctors.Add(doctorName);
                    Console.WriteLine("Emeliyyet ugurla kecdi.");
                    ShowDoctorsInList(terapiyaDoctors);
                    break;
            }
        }

        public void UpdateDoctor()
        {
            Console.WriteLine("Hansi sobeden?");
            ShowShobeler();
            int whichToUpdate = Convert.ToInt32(Console.ReadLine());
            switch (shobeName[--whichToUpdate])
            {
                case "Pediatriya":
                    ShowDoctorsInList(pediatriyaDoctors);
                    Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                    whichToUpdate = Convert.ToInt32(Console.ReadLine());
                    pediatriyaDoctors.RemoveAt(--whichToUpdate);
                    Console.WriteLine("Yeni ad soyad verin.");
                    string pediatriyaDoctorName = Console.ReadLine();
                    pediatriyaDoctors.Insert(whichToUpdate, pediatriyaDoctorName);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(pediatriyaDoctors);
                    break;
                case "Stomatologiya":
                    ShowDoctorsInList(stomatologiyaDoctors);
                    Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                    whichToUpdate = Convert.ToInt32(Console.ReadLine());
                    stomatologiyaDoctors.RemoveAt(--whichToUpdate);
                    Console.WriteLine("Yeni ad soyad verin.");
                    string stomatologiyaDoctorName = Console.ReadLine();
                    stomatologiyaDoctors.Insert(whichToUpdate, stomatologiyaDoctorName);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(stomatologiyaDoctors);
                    break;
                case "Terapiya":
                    ShowDoctorsInList(terapiyaDoctors);
                    Console.WriteLine("Hansi hekimi deyismek isteyirsiniz?");
                    whichToUpdate = Convert.ToInt32(Console.ReadLine());
                    terapiyaDoctors.RemoveAt(--whichToUpdate);
                    Console.WriteLine("Yeni ad soyad verin.");
                    string terapiyaDoctorName = Console.ReadLine();
                    terapiyaDoctors.Insert(whichToUpdate, terapiyaDoctorName);
                    Console.WriteLine("Emeliyyat ugurla kecdi.");
                    ShowDoctorsInList(terapiyaDoctors);
                    break;
            }
        }
    }
}
