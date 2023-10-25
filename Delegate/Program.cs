namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
              new Person { Name = "Kamil", Surname = "Jabrayilov", Age = 25 },
              new Person { Name = "Elvin", Surname = "Quliyev", Age = 20 },
              new Person { Name = "Ali", Surname = "Rzayev", Age = 29 },
            };

            List<Person> kamilPersons = people.FindAll(p => p.Name == "Kamil");
            List<Person> ovSurnamePersons = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            List<Person> olderThan20 = people.FindAll(p => p.Age > 20);

            static void PrintPersons(List<Person> personList)
            {
                foreach (var person in personList)
                {
                    Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
                }
            }

            Console.WriteLine("Adı Kamil olanlar:");
            PrintPersons(kamilPersons);

            Console.WriteLine("\nSoyadı ov və ova ilə bitənlər:");
            PrintPersons(ovSurnamePersons);

            Console.WriteLine("\nYaşı 20+ olanlar:");
            PrintPersons(olderThan20);

           


            List <Exam> exams = new List<Exam>
            {
              new Exam() { Subject = "Biology", ExamDuration = 2, StartDate = new DateTime(2023, 10, 27, 11, 30, 0), EndDate = new DateTime(2023, 10, 27,13 ,00 ,00 ) },
              new Exam() { Subject = "History", ExamDuration =3 , StartDate = new DateTime(2023 ,10 ,28 ,8 ,30 ,0 ), EndDate = new DateTime(2023 ,10 ,28 ,11 ,00 ,0 ) },
              new Exam() { Subject = "Geography", ExamDuration=4 , StartDate=new DateTime(2023 ,10 ,29 ,13 ,30 ,0 ), EndDate=new DateTime(2023 ,10 ,29 ,16 ,00 ,0 ) },
              new Exam() { Subject = "Math", ExamDuration = 4, StartDate = new DateTime(2023, 10, 23, 9, 0, 0), EndDate = new DateTime(2023, 10, 23, 12, 0, 0) },
            };

            List<Exam> longExams = exams.FindAll(e => e.ExamDuration > 2);

            void PrintExams(List<Exam> examList)
            {
                foreach (var exam in examList)
                {
                    Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration}");
                }
            }

            //Console.WriteLine("\nSon 1 həftə ərzində olan imtahanlar:");
            //PrintExams(lastWeekExams);

            Console.WriteLine("\n2 saatdan uzun çəkən imtahanlar:");
            PrintExams(longExams);

            //Console.WriteLine("\nBaşlayıb amma bitməmiş (hazırda davam edən) imtahanlar:");
            //PrintExams(ongoingExams);

        }

    }
}