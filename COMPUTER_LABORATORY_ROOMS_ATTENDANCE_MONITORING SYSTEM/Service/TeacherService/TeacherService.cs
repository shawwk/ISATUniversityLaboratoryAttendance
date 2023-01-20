using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TeacherService
{
    public class TeacherService : ITeacherService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public TeacherService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Faculty(FirstName, MiddleName, LastName, Gender, BirthDate, EmployeeId, Active) " +
                    "VALUES(@FirstName, @MiddleName, @LastName, @Gender, @BirthDate, @EmployeeId, @Active) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int id = con.Query<int>(query, teacher).SingleOrDefault();
                con.Close();
                return GetTeacherById(id);
            }
        }

        public List<Teacher> GetTeacher(string name)
        {
            var listOfTeachers = new List<Teacher>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Faculty WHERE Active=1 AND  FirstName LIKE @name OR LastName LIKE @name ";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfTeachers = con.Query<Teacher>(query, new { name = '%' + name + '%' }).ToList();
                con.Close();
                return listOfTeachers;
            }
        }

        public List<Teacher> GetAllTeacher()
        {
            var listOfTeachers = new List<Teacher>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Faculty WHERE Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfTeachers = con.Query<Teacher>(query).ToList();
                con.Close();
                return listOfTeachers;
            }
        }

        public Teacher GetTeacherById(long teacherId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Faculty WHERE Id = @teacherId ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var result = con.Query<Teacher>(query, new { teacherId = teacherId}).FirstOrDefault();
                con.Close();
                return result;
            }
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Faculty SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, " +
                    "Gender=@Gender, BirthDate=@BirthDate, EmployeeId=@EmployeeId WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Query(query, teacher).SingleOrDefault();
                con.Close();
                return GetTeacherById(teacher.Id);
            }
        }

        public Teacher DeactivateTeacher(Teacher teacher)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Faculty SET Active=0 WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                con.Query(query, teacher).SingleOrDefault();
                con.Close();
                return GetTeacherById(teacher.Id);
            }
        }

        public bool IsEmployeeIDExist(long empId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Faculty WHERE EmployeeId=@employeeId ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var result = con.Query<Teacher>(query, new { employeeId = empId }).FirstOrDefault();
                if(result != null)
                {
                    if (result.Id > 0)
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

        public List<Student> StudentRecord(Int64 teacherId, Int64 sectionId, Int64 subjectId)
        {
            var result = new List<Student>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.StudentId, S.Id , S.FirstName , S.MiddleName, S.LastName, S.Gender, S.BirthDate, S.Active,Sec.Course, Sec.Section FROM ClassSchedule CS " +
                    "INNER JOIN Student S ON CS.SectionId = S.SectionId " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                    "WHERE CS.TeacherId = @teacherId AND CS.SectionId = @sectionId AND CS.Active = 1 AND CS.SubjectId=@SubjectId";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = con.Query<Student>(query, new { teacherId = teacherId, sectionId = sectionId, SubjectId = subjectId }).ToList();
                con.Close();
                return result;
            }
        }

        public Teacher GetTeacherByIdNumber(long teacherId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Faculty WHERE EmployeeId = @teacherId ";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var result = con.Query<Teacher>(query, new { teacherId = teacherId }).FirstOrDefault();
                con.Close();
                return result;
            }
        }
    }
}
