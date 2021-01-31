using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

using System.Threading.Tasks;

namespace PersonHomework
{
    
    public class PersonManager

    {
        private const string DATA_FILENAME = "personmanager.dat";
        private BinaryFormatter formatter;

        public List<Person> People { get; set; }


        public PersonManager()
        {
            this.People = new List<Person>();
            this.formatter = new BinaryFormatter();
        }
        public void AddPerson()
        {
            string name;
            int age;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the age of the person");

            age = int.Parse(Console.ReadLine());

            Person p = new Person();
            People.Add((p));

            var lst = new List<Person>
            {
                new Person{Name=name, Age=age }          
            };
            Console.WriteLine(lst.ToList());

        }

        public void Save()
        {
            try
            {
                
                FileStream writerFileStream =
                    new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                
                this.formatter.Serialize(writerFileStream, this.People);

                
                writerFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to save our person's information");
            } // end try-catch
        }


        public void RemovePerson(int id)
        {
            //Console.WriteLine("")
            var people = People.Single(x => x.Age == id);
            People.Remove(people);
            Console.WriteLine("Person removed");

            
        } 
        public void Load()
        {

            if (File.Exists(DATA_FILENAME))
            {

                try
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME,
                        FileMode.Open, FileAccess.Read);

                    this.People = (List<Person>)
                        this.formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();

                }
                catch (Exception)
                {
                    Console.WriteLine("There seems to be a file that contains " +
                        "person's information but somehow there is a problem " +
                        "with reading it.");
                }

            }

        }
    }
}
