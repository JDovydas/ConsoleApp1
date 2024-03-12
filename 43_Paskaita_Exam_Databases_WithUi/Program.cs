using _43_Paskaita_Exam_Databases_WithUi.Models;
using _43_Paskaita_Exam_Databases_WithUi.Repository;
using _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces;
using _43_Paskaita_Exam_Databases_WithUi.UI;

namespace _43_Paskaita_Exam_Databases_WithUi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                var ui = new UniversityUI(new DepartmentRepository(context), new LectureRepository(context), new StudentRepository(context));
                ui.Run();

            }

            using (var context = new UniversityContext())
            {

                IDepartmentRepository departmentRepository = new DepartmentRepository(context);
                ILectureRepository lectureRepository = new LectureRepository(context);
                IStudentRepository studentRepository = new StudentRepository(context);

                var department = new Department() { Name = "Faculty of Magic" };
                departmentRepository.CreateDepartment(department);



                //var department = new Department() { Name = "Faculty of Information Technology" };

                //var lecture1 = new Lecture() { Name = "Introduction to Computer Science" };

                //var lecture2 = new Lecture() { Name = "Programming Fundamentals" };

                //var student1 = new Student() { Name = "Jonas Pirmasis" };

                //var student2 = new Student() { Name = "Petras Didysis" };

                //department.Lectures = new List<Lecture> { lecture1, lecture2 };

                //department.Students = new List<Student> { student1, student2 };

                //context.Departments.Add(department);
                //context.SaveChanges();
            }



        }

    }
}

//var department1 = new Department { Name = "Faculty of Information Technology");
//var department2 = new Department { Name = "Faculty of Economics" };

//var lecture1 = new Lecture { Name = "Introduction to Computer Science", Departments = new List<Department>() { department1, department2 } };
//var lecture2 = new Lecture { Name = "Programming Fundamentals", Departments = new List<Department>() { department1 } };
//var lecture3 = new Lecture { Name = "Database Management Systems", Departments = new List<Department>() { department1 } };
//var lecture4 = new Lecture { Name = "Microeconomics", Departments = new List<Department>() { department1, department2 } };
//var lecture5 = new Lecture { Name = "Macroeconomics", Departments = new List<Department>() { department1, department2 } };
//var lecture6 = new Lecture { Name = "Econometrics", Departments = new List<Department>() { department1, department2 } };

//var student1 = new Student { FullName = "Jonas Pirmasis", Department = department1, Lectures = new List<Lecture>() { lecture1, lecture2, lecture3, lecture4 } };
//var student2 = new Student { FullName = "Petras Didysis", Department = department1, Lectures = new List<Lecture>() { lecture1, lecture2, lecture3, lecture5 } };
//var student3 = new Student { FullName = "Kazys Kazelis", Department = department1, Lectures = new List<Lecture>() { lecture1, lecture2, lecture3, lecture6 } };
//var student4 = new Student { FullName = "Ona Onelyte", Department = department2, Lectures = new List<Lecture>() { lecture4, lecture5, lecture6 } };
//var student5 = new Student { FullName = "Daiva Daivelyte", Department = department2, Lectures = new List<Lecture>() { lecture4, lecture5, lecture6 } };
//var student6 = new Student { FullName = "Lijana Pavardene", Department = department2, Lectures = new List<Lecture>() { lecture4, lecture5, lecture6 } };


//lecture1.Students.Add(student1);
//lecture1.Students.Add(student2);
//lecture1.Students.Add(student3);

//lecture2.Students.Add(student4);
//lecture2.Students.Add(student5);
//lecture2.Students.Add(student6);

//lecture3.Students.Add(student1);
//lecture3.Students.Add(student2);
//lecture3.Students.Add(student3);

//lecture4.Students.Add(student1);
//lecture4.Students.Add(student4);
//lecture4.Students.Add(student5);
//lecture4.Students.Add(student6);

//lecture5.Students.Add(student2);
//lecture5.Students.Add(student4);
//lecture5.Students.Add(student5);
//lecture5.Students.Add(student6);

//lecture6.Students.Add(student3);
//lecture6.Students.Add(student4);
//lecture6.Students.Add(student5);
//lecture6.Students.Add(student6);