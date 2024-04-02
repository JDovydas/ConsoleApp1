using _43_Paskaita_Exam_Databases;
using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace _46_MoqTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_CreateDepartment()
        {
            var mockDepartmentRepository = new Mock<IDepartmentRepository>();
            var expectedDepartmentName = "Test Department";
            var department = new Department { Name = expectedDepartmentName };

            mockDepartmentRepository.Object.CreateDepartment(department);

            mockDepartmentRepository.Verify(repo => repo.CreateDepartment(It.Is<Department>(d => d.Name == expectedDepartmentName)));
        }

        [TestMethod]
        public void Test_CreateStudent()
        {
            var mockStudentRepository = new Mock<IStudentRepository>();

            var student = new Student()
            {
                Name = "Test Student"
            };

            mockStudentRepository.Object.CreateStudent(student);

            mockStudentRepository.Verify(repo => repo.CreateStudent(It.Is<Student>(s => s.Name == student.Name)));

        }


        [TestMethod]
        public void Test_DisplayStudentsInDepartment()
        {
            var mockStudentRepository = new Mock<IStudentRepository>();
            var department = new Department { Name = "Test Department" };
            var students = new List<Student>();

            mockStudentRepository.Setup(repo => repo.DisplayStudentsInSelectedDepartment(department)).Returns(students);

            Assert.AreEqual(0, mockStudentRepository.Object.DisplayStudentsInSelectedDepartment(department).Count());
        }

        [TestMethod]
        public void Test_DisplayStudentsInDepartment_OneStudent()
        {
            var mockStudentRepository = new Mock<IStudentRepository>();
            var department = new Department { Name = "Test Department" };
            var studentName = "John Doe";
            var student = new Student { Name = studentName, Department = department };
            var students = new List<Student> { student };

            mockStudentRepository.Setup(repo => repo.DisplayStudentsInSelectedDepartment(department)).Returns(students);


            var displayedStudents = mockStudentRepository.Object.DisplayStudentsInSelectedDepartment(department);
            var displayedStudent = displayedStudents.FirstOrDefault();
            Assert.AreEqual(studentName, displayedStudent.Name);
        }


        [TestMethod]
        public void Test1()
        {
            //var department = new Department { DepartmentId = 1, Name = "Arts" };//.AsQueryable();            

            var departments = new[]
            {
                new Department { DepartmentId = 1, Name = "Science"},
                new Department { DepartmentId = 2, Name = "Arts"},
                new Department { DepartmentId = 3, Name = "Math"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Department>>();
            var mockContext = new Mock<UniversityContext>(new DbContextOptions<UniversityContext>());

            mockSet.As<IQueryable<Department>>().Setup(m => m.Provider).Returns(departments.Provider);
            mockSet.As<IQueryable<Department>>().Setup(m => m.Expression).Returns(departments.Expression);
            mockSet.As<IQueryable<Department>>().Setup(m => m.ElementType).Returns(departments.ElementType);
            mockSet.As<IQueryable<Department>>().Setup(m => m.GetEnumerator()).Returns(departments.GetEnumerator());

            mockContext.Setup(d => d.Departments).Returns(mockSet.Object);

            var departmentRepository = new DepartmentRepository(mockContext.Object);
            var result = departmentRepository.GetDepartmentByName("Arts");

            Assert.IsNotNull(result);
            Assert.AreEqual("Arts", result.Name);


        }

    }
}