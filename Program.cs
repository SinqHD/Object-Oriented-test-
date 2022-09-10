using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instances of the object students;
            Student Student1 = new Student();
            Student Student2 = new Student();
            Student Student3 = new Student();

            Teacher Teacher1 = new Teacher();
            Teacher Teacher2 = new Teacher();

            //set the data for each student through its methods
            Student1.SetFirstName("Sue");
            Student1.SetLastName("Smith");
            Student1.SetGrade("A*");
            Student1.SetStudentNo("12345");
            Student1.SetAge(15);

            Student2.SetFirstName("Peter");
            Student2.SetLastName("West");
            Student2.SetGrade("B");
            Student2.SetStudentNo("77777");
            Student2.SetAge(17);

            Student3.SetFirstName("Ian");
            Student3.SetLastName("Jones");
            Student3.SetGrade("C");
            Student3.SetStudentNo("98765");
            Student3.SetAge(19);

            Teacher1.SetFirstName("Darryn");
            Teacher1.SetLastName("Gordan");
            Teacher1.SetSubject("Computer Science");
            Teacher1.SetAge(29);

            Teacher2.SetFirstName("Debbie");
            Teacher2.SetLastName("Waugh");
            Teacher2.SetSubject("IT");
            Teacher2.SetAge(30);

            Person[] memberArray = new Person[5];
            memberArray[0] = new Person();
            memberArray[0].SetFirstName("John");
            memberArray[0].SetLastName("Kramer");
            memberArray[1] = new Student();
            memberArray[1].SetFirstName("Isaac");
            memberArray[1].SetLastName("Newton");
            memberArray[2] = new Teacher();
            memberArray[2].SetFirstName("Bill");
            memberArray[2].SetLastName("Gates");

            Console.WriteLine(memberArray[0].GetFullName());
            Console.WriteLine(memberArray[1].GetFullName());
            Console.WriteLine(memberArray[2].GetFullName());

            Console.WriteLine(Student1.GetStudentRecord());
            Console.WriteLine(Student2.GetStudentRecord());
            Console.WriteLine(Student3.GetStudentRecord());

            if (Student1.GetAge() > 16)
                Console.WriteLine(Student1.GetFirstName() + " is old enough for college");
            else
                Console.WriteLine(Student1.GetFirstName() + " should be at school");

            Console.WriteLine(Teacher1.reportDetails());
            Console.WriteLine(Teacher2.reportDetails());
            Console.ReadKey();
        }
    }
}
