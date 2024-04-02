using Microsoft.VisualStudio.TestTools.UnitTesting;
using _43_Paskaita_Exam_Databases;
using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _45_IntegrationTesting_StudentInformationSystem
{
    [TestClass]
    public class IntegrationTests
    {
        private UniversityContext _context;
        private IDepartmentRepository _departmentRepository;
        private ILectureRepository _lectureRepository;
        private IStudentRepository _studentRepository;


        [TestInitialize]

        public void Setup()
        {
            var options = new DbContextOptionsBuilder<UniversityContext>()
                .UseInMemoryDatabase("ExamTestDb")
                .Options;

            _context = new UniversityContext(options);
            _departmentRepository = new DepartmentRepository(_context);
            _lectureRepository = new LectureRepository(_context);
            _studentRepository = new StudentRepository(_context);
        }


        //[TestCleanup]
        //public void Cleanup()
        //{
        //    _context.Database.EnsureDeleted();
        //}

        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [TestMethod]

        public void Test_AddLectureToDepartment()
        {
            var department = new Department { Name = "Test Department" };
            _departmentRepository.CreateDepartment(department);

            var lecture = new Lecture { Name = "Test Lecture" };
            _lectureRepository.CreateLecture(lecture);

            _lectureRepository.CreateLectureAndAssignToDepartment(lecture, department);

            var lectureInDepartment = _lectureRepository.DisplayLecturesInSelectedDepartment(department);
            Assert.IsTrue(lectureInDepartment.Contains(lecture));

        }


        [TestMethod]
        public void Test_CrateStudentAddToDepartmentAndAssignToExistingLecture()
        {
            //Arrange: Create a new department
            var department = new Department { Name = "Test Department2" };
            _departmentRepository.CreateDepartment(department);

            //Arrange: Create an existing lecture
            var existingLecture = new Lecture { Name = "Existing Lecture" };
            _lectureRepository.CreateLecture(existingLecture);

            //Arrange: Add the existing lecture to the department
            _lectureRepository.CreateLectureAndAssignToDepartment(existingLecture, department);

            //Arrange: Create a new student
            var student = new Student { Name = "Test Student" };

            //Act: Add the student to the department and assign it to the existing lecture
            _studentRepository.CreateStudentAndAssignToDepartmentAndLectures(student, department, new List<Lecture> { existingLecture });

            //Assert: Check if the student is added to the department
            var studentsInDepartment = _studentRepository.DisplayStudentsInSelectedDepartment(department);
            Assert.IsTrue(studentsInDepartment.Contains(student));

            // Assert: Check if the student is assigned to the existing lecture
            var lecturesByStudent = _lectureRepository.DisplayLecturesByStudent(student);
            Assert.IsTrue(lecturesByStudent.Contains(existingLecture));


        }















    }
}