using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Search(Edit & Delete)");
            Console.WriteLine("3) Save");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Export");
            Console.WriteLine("6) Display");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreatePerson();
                    return true;
                case "2":
                   Search();
                    return true;
                case "3":
                    save();
                    return true;
                case "4":
                    Load();
                    return true;
                case "5":
                    Export();
                    return true;
                case "6":
                    Display();
                    return true;
                case "7":

                     Environment.Exit(0);
                    return true;
                default:
                    return true;
            }
        }

        private static void Export()
        {
            PersonManager pp = new PersonManager();
            pp.AddPerson();
        }
        private static void Remove()
        {
            PersonManager pp = new PersonManager();
            Console.WriteLine("Enter key");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            pp.RemovePerson(id);
        }

        private static void Display()
        {
            PersonManager pp = new PersonManager();
            pp.AddPerson();
        }

        private static void Load()
        {
            PersonManager pp = new PersonManager();
            pp.Load();
        }

        private static void save()
        {
            PersonManager pp = new PersonManager();
            pp.Save();
        }

        private static string Search()
        {
            Console.WriteLine("Search By Island or age");
            Console.WriteLine("a) island");
            Console.WriteLine("b) age");
            
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "a":
                    searchby_island();
                    return "";
                case "b":
                    Searchby_age();
                    return "";
                 
                default:
                    return "";
            }


        }

        private static void searchby_island()
        {
            Console.WriteLine("Enter Island name");
            string name = Console.ReadLine();
            List<Person> list = new List<Person>();
            Person res = (Person)list.Where(x => x.Name == name);
            var item = list.Where(e => e.Name == name).ToList();
            if (item.Count <= 0)
            {
                Console.WriteLine("Nothing is here");
            }
            else
            {
                Console.WriteLine("you have entered {0}", item);
            }
        }

        private static int[] Searchby_age()
        {
            Console.WriteLine("Enter the Age");
            int age = int.Parse(Console.ReadLine());

            List<Person> ls = new List<Person>();

            var data = ls.Where(x => x.Age == age).Select(s => s.Age);
            return data.ToArray();        }

        private static void CreatePerson()
        {
            PersonManager pp = new PersonManager();
            pp.AddPerson();

           
            


        }
    }
}
