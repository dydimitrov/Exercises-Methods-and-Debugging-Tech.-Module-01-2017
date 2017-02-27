using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercise
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Student> students = new List<Student>();

        while (!input.Equals("end of dates"))
        {
            string[] command = input.Split(' ');
            string name = command[0];
            string[] getData = command[1].Split(',').ToArray();

            foreach (var item in getData)
            {
                DateTime parseDate = DateTime.ParseExact(item, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (students.Any(st => st.Name.Equals(name)))
                {
                    Student student = students.First(cust => cust.Name.Equals(name));
                    student.dates.Add(parseDate);
                }
                else
                {
                    Student newStudent = new Student(name);
                    newStudent.dates.Add(parseDate);
                    students.Add(newStudent);
                }
            }

            input = Console.ReadLine();
        }

        string inputComment = Console.ReadLine();

        while (!inputComment.Equals("end of comments"))
        {
            string[] command = inputComment.Split('-');
            string name = command[0];
            string comment = command[1];

            if (!students.Any(st => st.Name.Equals(name)))
            {
                inputComment = Console.ReadLine();
                continue;
            }

            Student student = students.First(cust => cust.Name.Equals(name));
            student.comments.Add(comment);

            inputComment = Console.ReadLine();
        }

        foreach (var item in students.OrderBy(s => s.Name))
        {
            Console.WriteLine($"{item.Name}\nComments:");
            foreach (var comment in item.comments)
            {
                Console.WriteLine($"- {comment}");
            }

            Console.WriteLine("Dates attended:");

            foreach (var dates in item.dates.OrderBy(d => d.Date))
            {
                Console.WriteLine($"-- {dates.Day}/{dates.Month:00}/{dates.Year}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<string> comments { get; set; }
        public List<DateTime> dates { get; set; }

        public Student(string name)
        {
            Name = name;
            comments = new List<string>();
            dates = new List<DateTime>();
        }
    }
}