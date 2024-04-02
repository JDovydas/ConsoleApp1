using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.VisualBasic;
namespace _43_Paskaita_Exam_Databases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {

                //IDepartmentRepository departmentRepository = new DepartmentRepository(context);
                //ILectureRepository lectureRepository = new LectureRepository(context);
                //IStudentRepository studentRepository = new StudentRepository(context);

                //Exercise no.1

                //var department = new Department() { Name = "Faculty of Information Technology" };

                //var lecture1 = new Lecture() { Name = "Introduction to Computer Science" };

                //var lecture2 = new Lecture() { Name = "Programming Fundamentals" };

                //var student1 = new Student() { Name = "Jonas Pirmasis" };

                //var student2 = new Student() { Name = "Petras Didysis" };

                //department.Lectures = new List<Lecture> { lecture1, lecture2 };

                //department.Students = new List<Student> { student1, student2 };

                //student1.Lectures = new List<Lecture> { lecture1, lecture2 };

                //student2.Lectures = new List<Lecture> { lecture1 };

                //context.Departments.Add(department);
                //context.SaveChanges();// turėtų būti repository dalyje

                //2.1 Create a new department:

                //var department2 = new Department() { Name = "Faculty of Arts" };
                //departmentRepository.CreateDepartment(department2);


                //2.2 Add students/lectures to an existing department (to the one created in 2.1)

                //var lecture3 = new Lecture() { Name = "Film Studies" };

                //var lecture4 = new Lecture() { Name = "History" };

                //var student3 = new Student() { Name = "Ona Onelyte" };

                //var student4 = new Student() { Name = "Daiva Daivelytes" };

                //Department existingDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Arts");
                //if (existingDepartment != null)
                //{
                //    List<Student> studentsToAdd = new List<Student> { student3, student4 };
                //    List<Lecture> lecturesToAdd = new List<Lecture> { lecture3, lecture4 };
                //    departmentRepository.AddStudentsAndLecturesToExistingDepartment(studentsToAdd, lecturesToAdd, existingDepartment);
                //}


                // 3.Create a lecture and assign it to a department.

                //Department existingDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Arts");

                //var newLecture = new Lecture() { Name = "Introduction to History" };
                //lectureRepository.CreateLectureAndAssignToDepartment(newLecture, existingDepartment);

                //4.Create a student, add it to an existing department and assign it to existing lectures.

                //var existingDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Information Technology");

                //var newStudent = new Student() { Name = "John Deer" };

                //var existingLectures = context.Lectures.ToList();

                //studentRepository.CreateStudentAndAssignToDepartmentAndLectures(newStudent, existingDepartment, existingLectures);


                //5.1 Transfer the student to another department(bonus points if the student's lectures are also changed).

                //var existingStudent = context.Students.FirstOrDefault(s => s.Name == "John Deer");
                //var oldDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Information Technology");
                //var newDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Arts");

                //if (existingStudent != null && oldDepartment != null && newDepartment != null)
                //{
                //    studentRepository.TransferStudentToAnotherDepartment(existingStudent, newDepartment);
                //    Console.WriteLine($"Student {existingStudent.Name} transferred from {oldDepartment.Name} to {newDepartment.Name} department.");
                //}
                //else
                //{
                //    Console.WriteLine("Student or department does not exist.");
                //}

                //5.2 Update Student information: remove all lectures belonging to oldDepartment and assign the lectures belonging to newDepartment

                //studentRepository.StudentToHaveOnlyNewDepartmentLecturesAssigned(existingStudent, newDepartment);


                //6. Display all students in the department.

                //Department selectedDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Information Technology");
                //if (selectedDepartment != null)
                //{
                //    var studentsInDepartment = studentRepository.DisplayStudentsInSelectedDepartment(selectedDepartment);

                //    Console.WriteLine($"Students in {selectedDepartment.Name} department:");
                //    foreach (var student in studentsInDepartment)
                //    {
                //        Console.WriteLine($"- {student.Name}");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Department does not exist.");
                //}


                //7. Display all lectures in the department

                //Department selectedDepartment = context.Departments.FirstOrDefault(d => d.Name == "Faculty of Information Technology");

                //if (selectedDepartment != null)
                //{
                //    IEnumerable<Lecture> lecturesInDepartment = lectureRepository.DisplayLecturesInSelectedDepartment(selectedDepartment);

                //    Console.WriteLine($"Lectures in {selectedDepartment.Name} department:");
                //    foreach (var lecture in lecturesInDepartment)
                //    {
                //        Console.WriteLine($"- {lecture.Name}");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Department does not exist.");
                //}


                //8. Display all lectures by student.

                //Student selectedStudent = context.Students.FirstOrDefault(s => s.Name == "John Deer");

                //if (selectedStudent != null)
                //{
                //    IEnumerable<Lecture> lecturesByStudent = lectureRepository.DisplayLecturesByStudent(selectedStudent);
                //    Console.WriteLine($"Lectures by {selectedStudent.Name}:");
                //    foreach (var lecture in lecturesByStudent)
                //    {
                //        Console.WriteLine($"- {lecture.Name}");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Student does not exist.");
                //}
            }

        }


    }

}