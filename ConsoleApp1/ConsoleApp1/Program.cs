using System;
using System.Collections.Generic;

namespace OBSProject
{
    class Program
    {
        static Dictionary<string, string> students = new Dictionary<string, string>();
        static Dictionary<string, string> teachers = new Dictionary<string, string>();
        static Dictionary<string, List<string>> documents = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. Öğrenci Kaydı");
                Console.WriteLine("2. Öğretmen Kaydı");
                Console.WriteLine("3. Doküman Ekleme");
                Console.WriteLine("4. Doküman Silme");
                Console.WriteLine("5. Çıkış");
                Console.WriteLine("Lütfen bir seçenek seçin (1-5): ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegisterStudent();
                        break;
                    case "2":
                        RegisterTeacher();
                        break;
                    case "3":
                        AddDocument();
                        break;
                    case "4":
                        RemoveDocument();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void RegisterStudent()
        {
            Console.WriteLine("Öğrenci Numarası: ");
            string studentId = Console.ReadLine();

            Console.WriteLine("İsim: ");
            string name = Console.ReadLine();

            students[studentId] = name;
            Console.WriteLine("Öğrenci kaydı başarılı.");
        }

        static void RegisterTeacher()
        {
            Console.WriteLine("Öğretmen Numarası: ");
            string teacherId = Console.ReadLine();

            Console.WriteLine("İsim: ");
            string name = Console.ReadLine();

            teachers[teacherId] = name;
            Console.WriteLine("Öğretmen kaydı başarılı.");
        }

        static void AddDocument()
        {
            Console.WriteLine("Öğretmen Numarası: ");
            string teacherId = Console.ReadLine();

            if (teachers.ContainsKey(teacherId))
            {
                Console.WriteLine("Doküman Adı: ");
                string documentName = Console.ReadLine();

                if (!documents.ContainsKey(teacherId))
                {
                    documents[teacherId] = new List<string>();
                }

                documents[teacherId].Add(documentName);
                Console.WriteLine("Doküman eklendi.");
            }
            else
            {
                Console.WriteLine("Öğretmen bulunamadı.");
            }
        }

        static void RemoveDocument()
        {
            Console.WriteLine("Öğretmen Numarası: ");
            string teacherId = Console.ReadLine();

            if (teachers.ContainsKey(teacherId))
            {
                Console.WriteLine("Doküman Adı: ");
                string documentName = Console.ReadLine();

                if (documents.ContainsKey(teacherId) && documents[teacherId].Contains(documentName))
                {
                    documents[teacherId].Remove(documentName);
                    Console.WriteLine("Doküman silindi.");
                }
                else
                {
                    Console.WriteLine("Doküman bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Öğretmen bulunamadı.");
            }
        }
    }
}
