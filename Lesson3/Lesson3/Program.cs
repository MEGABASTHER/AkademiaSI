using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string mainPath = @"D:\Programowanie\Projects\C# Projects\AkademiaSI\Lesson3\Katalog";
            string fakePath = @"D:\Programowanie\Projects\C# Projects\AkademiaSI\Lesson3\Katalog2";
            string fileName = "tekst.txt";
            string fileName = "plik.xml";
            string fullPath = Path.Combine(mainPath, fileName);

            
            if (Directory.Exists(mianPath))
            {
                string fullPath = Path.Combine(mainPath, fileName);

                if (File.Exists(fileName))
                using (StreamWriter pisz = new StreamWriter(fullPath))
                {
                    pisz.WriteLine(participants);
                }
                else
                {
                    Console.WriteLine("Błąd");
                }
            }
            else
            {
                Directory.CreateDirectory(mianPath);
                pisz.WriteLine(participants);
            }
            
            if (!Directory.Exists(fakePath))
            {
                Directory.CreateDirectory(fakePath);
            }
            else
            {
                try
                {
                    Directory.Delete(fakePath);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Directory not exist!");
                }
                catch (IOException ex)
                {
                    Directory.Delete(fakePath, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd!");
                }
            }
            */

            string mainPath = @"D:\Programowanie\Projects\C# Projects\AkademiaSI\Lesson3\Katalog";
            string fileName = "plik.xml";
            string fullPath = Path.Combine(mainPath, fileName);


            XElement participants = new XElement("participants");

            /*
            participants.Add(
                new XElement("participants",
                    new XElement("teacher",
                        new XElement("name", "Marcin")),
                    new XElement("student",
                        new XElement("name", "Tomek")),
                    new XElement("student",
                        new XElement("name", "Mariusz")),
                    new XElement("student",
                        new XElement("name", "Zdzisiu")),
                    new XElement("student",
                        new XElement("name", "Michał"))
                    ));
            */

            XElement teachers = new XElement("teachers");
            teachers.Add(new XElement("name", "Marcin"));
            teachers.Add(new XElement("name", "Paweł"));
            teachers.Add(new XElement("name", "Daniel"));

            XElement students = new XElement("students");
            students.Add(new XElement("name", "Maciek"));
            students.Add(new XElement("name", "Tomek"));
            students.Add(new XElement("name", "Mariusz"));
            students.Add(new XElement("name", "Zdzisiu"));
            students.Add(new XElement("name", "Michał"));

            participants.Add(teachers);
            participants.Add(students);

            if (Directory.Exists(mainPath))
                {
                    if (File.Exists(fullPath))
                        using (StreamWriter pisz = new StreamWriter(fullPath))
                        {
                            pisz.WriteLine(participants);
                        }
                    else
                    {
                        Console.WriteLine("Plik nie istnieje!");
                    }
                }
                else
                {
                    Directory.CreateDirectory(mainPath);
                    using (StreamWriter pisz = new StreamWriter(fullPath))
                    {
                        pisz.WriteLine(participants);
                    }
                }
            Console.ReadKey();
        }
    }
}
