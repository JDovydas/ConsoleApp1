using _43_Paskaita_Exam_Databases_WithUi.Models;
using _43_Paskaita_Exam_Databases_WithUi.Repository;
using _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.UI
{
    internal class UniversityUI
    {

        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILectureRepository _lectureRepository;
        private readonly IStudentRepository _studentRepository;


        public UniversityUI(IDepartmentRepository departmentRepository, ILectureRepository lectureRepository, IStudentRepository studentRepository)
        {
            _departmentRepository = departmentRepository;
            _lectureRepository = lectureRepository;
            _studentRepository = studentRepository;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Student Information System Menu:");
                Console.WriteLine("1. Create a department and add students and lectures to it");
                Console.WriteLine("2. Add students/lectures to an existing department");
                Console.WriteLine("3. Create a lecture and assign it to a department");
                Console.WriteLine("4. Create a student, add it to an existing department, and assign it to existing lectures");
                Console.WriteLine("5. Transfer a student to another department");
                Console.WriteLine("6. Display all students in a department");
                Console.WriteLine("7. Display all lectures in a department");
                Console.WriteLine("8. Display all lectures by a student");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Create a department and add students and lectures to it 
                            break;
                        case 2:
                            // Add students/lectures to an existing department
                            break;
                        case 3:
                            // Create a lecture and assign it to a department
                            break;
                        case 4:
                            // Create a student, add it to an existing department and assign it to existing lectures
                            break;
                        case 5:
                            // Transfer the student to another department (bonus points if the student's lectures are also changed
                            break;
                        case 6:
                            // Display all students in the department
                            break;
                        case 7:
                            // Display all lectures in the department
                            break;
                        case 8:
                            // Display all lectures by student
                            break;
                        case 9:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine();
            }

        }
    }
}
