using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dapper;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.StudentService;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.StudentService
{
    public class StudentService : IStudentService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public StudentService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public Student AddStudent(Student student)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Student(FirstName, MiddleName, LastName, Gender, BirthDate,SectionId, StudentId, Active) " +
                    "VALUES(@FirstName, @MiddleName, @LastName, @Gender, @BirthDate, @SectionId, @StudentId, @Active) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int id = con.Query<int>(query, student).SingleOrDefault();
                con.Close();
                return GetStudentById(id);
            }
        }

        public Student UpdateStudent(Student student)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Student SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, " +
                    "Gender=@Gender, BirthDate=@BirthDate, SectionId=@SectionId, StudentId=@StudentId WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Query(query, student).SingleOrDefault();
                con.Close();
                return GetStudentById(student.Id);
            }
        }

        public List<Student> GetStudent(string name)
        {
            var listOfStudents = new List<Student>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.Active, S.BirthDate, Sec.Section, Sec.Course FROM Student S " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId WHERE FirstName LIKE @name OR LastName LIKE @name";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfStudents = con.Query<Student>(query, new { name = '%' + name + '%' }).ToList();
                con.Close();
                return listOfStudents;
            }
        }

        public List<Student> GetAllStudent()
        {
            var listOfStudents = new List<Student>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.Active, S.BirthDate,Sec.Id AS SectionId, Sec.Section, Sec.Course FROM Student S " +
                    "LEFT JOIN Sections Sec  ON Sec.Id = S.SectionId WHERE S.Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfStudents = con.Query<Student>(query).ToList();
                con.Close();
                return listOfStudents;
            }
        }

        public Student GetStudentById(long studentId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.Active, S.BirthDate,Sec.Id AS SectionId, Sec.Section, Sec.Course FROM Student S " +
                    "LEFT JOIN Sections Sec  ON Sec.Id = S.SectionId WHERE S.Id = @studentId ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var result = con.Query<Student>(query, new { studentId = studentId }).FirstOrDefault();
                con.Close();
                return result;
            }
        }

        public Student DeactivateStudent(Student student)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Student SET Active=0 WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Query(query, student).SingleOrDefault();
                con.Close();
                return GetStudentById(student.Id);
            }
        }

        public bool IsStudentIdExists(long studentId)
        {
            var student = new Student();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Student WHERE StudentId = @studentId AND Active=1";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                student = con.Query<Student>(query, new { studentId = studentId }).FirstOrDefault();
                if(student != null)
                {
                    if (student.Id > 0)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
                return false;
            }
        }

        public Student GetStudentByIdNumber(long IdNumber)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.Active, S.BirthDate,Sec.Id AS SectionId, Sec.Section, Sec.Course FROM Student S " +
                    "LEFT JOIN Sections Sec  ON Sec.Id = S.SectionId " +
                    " WHERE S.StudentId = @IdNumber ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var result = con.Query<Student>(query, new { IdNumber = IdNumber }).FirstOrDefault();
                con.Close();
                return result;
            }
        }

        public List<Schedule> GetSubjects(long studentId)
        {
            var listOfSchedules = new List<Schedule>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT DISTINCT CS.Id, S.Id AS SubjectId, S.Subject AS SubjectName, TimeFrom, TimeTo, Day, F.Id AS TeacherId, " +
                    "CONCAT(F.FirstName, ' ', F.MiddleName, ' ', F.LastName) AS TeacherName, SEC.Id AS SectionID, SEC.Section AS SectionName,  SEC.Course AS Course " +
                    "FROM ClassSchedule CS " +
                    "LEFT JOIN Subjects S ON CS.SubjectId = S.Id " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "LEFT JOIN Student Stu ON  CS.SectionId = Stu.SectionId " +
                    "LEFT JOIN Sections SEC ON CS.SectionId = SEC.Id WHERE CS.Active = 1 AND Stu.Id=@studentId";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSchedules = con.Query<Schedule>(query, new { studentId = studentId }).ToList();
                con.Close();
                return listOfSchedules;
            }
        }
    }
}
