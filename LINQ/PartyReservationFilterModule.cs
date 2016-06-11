using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PartyReservationFilterModule
{
    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<StudentSpecialty> listofStudentSpecialties = new List<StudentSpecialty>();

            while (input != "Students:")
            {
                string[] studentInfo = input.Split(' ');
                StudentSpecialty studentSpecialty = new StudentSpecialty();
                studentSpecialty.SpecialtyName = studentInfo[0] + " " + studentInfo[1];
                studentSpecialty.FacNumber = studentInfo[2];
                listofStudentSpecialties.Add(studentSpecialty);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {

                string[] data = input.Split(' ');
                Student student = new Student();
                student.FacultyNumber = data[0];
                student.StudentName = data[1] + " " + data[2];
                students.Add(student);
                input = Console.ReadLine();
            }

            var sortStudent =
                students.Join(listofStudentSpecialties, a => a.FacultyNumber, b => b.FacNumber,
                    (a, b) => new { a.StudentName, a.FacultyNumber, b.SpecialtyName })
                    .OrderBy(x => x.StudentName)
                    .ToList();

            foreach (var student in sortStudent)
            {
                Console.WriteLine($"{student.StudentName} {student.FacultyNumber} {student.SpecialtyName}");
            }


        }
        public class StudentSpecialty
        {
            public string SpecialtyName { get; set; }
            public string FacNumber { get; set; }
        }
        public class Student
        {
            public string StudentName { get; set; }
            public string FacultyNumber { get; set; }
        }
    }
}
