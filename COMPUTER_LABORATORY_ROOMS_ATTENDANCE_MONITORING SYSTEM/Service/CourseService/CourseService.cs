using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsCourse;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using static System.Collections.Specialized.BitVector32;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.CourseService
{
    public class CourseService : ICourseService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public CourseService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public List<Course> GetCourse(string sectionName)
        {
            var listOfSection = new List<Course>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Sections WHERE Active=1 AND Section LIKE @sectionName OR Course LIKE @sectionName";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSection = con.Query<Course>(query, new { sectionName = '%' + sectionName + '%' }).ToList();
                return listOfSection;
            }
        }

        public Course AddCourse(Course section)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Course(CourseName, ShortCutName, Active) VALUES(@CourseName, @ShortCutName, 1) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                var secId = con.Query<int>(query, section).SingleOrDefault();
                return GetCourseById(secId);
            }
        }

        public Course UpdateCourse(Course section)
        {
            var sect = new Course();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Course SET CourseName=@CourseName, ShortCutName=@ShortCutName, Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sect = con.Query<Course>(query, section).SingleOrDefault();
                return GetCourseById(section.Id); ;
            }
        }

        public List<Course> GetAllCourse()
        {
            var listOfCourse = new List<Course>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Course WHERE Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfCourse = con.Query<Course>(query).ToList();
                return listOfCourse;
            }
        }

        public Course GetCourseById(long Id)
        {
            var sec = new Course();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Course WHERE Active=1 AND Id=@Id ";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sec = con.Query<Course>(query, new { Id = Id }).SingleOrDefault();
                return sec;
            }
        }

        public void Deactivate(Course section)
        {
            var sec = new Course();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Course SET Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sec = con.Query<Course>(query, section).SingleOrDefault();
            }
        }

        public bool CheckCourse(Course course)
        {
            var sect = new Course();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Course WHERE (CourseName=@CourseName OR ShortCutName=@ShortCutName) AND Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sect = con.Query<Course>(query, course).FirstOrDefault();
                if (sect != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
