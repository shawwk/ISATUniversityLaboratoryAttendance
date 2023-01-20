using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsCourse;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SubjectService
{
    public class SubjectService : ISubjectService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public SubjectService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }

        public List<Subjects> GetSubjects(string subj)
        {
            var listOfSubjects = new List<Subjects>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Subjects WHERE Active=1 AND Subject LIKE @subj";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSubjects = con.Query<Subjects>(query, new { subj = '%' + subj + '%' }).ToList();
                return listOfSubjects;
            }
        }

        public Subjects AddSubject(Subjects subject)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Subjects(Subject, Semester, Active) VALUES(@Subject, @Semester, @Active) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                var subId = con.Query<int>(query, subject).SingleOrDefault();
                return GetSubjectById(subId);
            }
        }

        public Subjects UpdateSubject(Subjects subject)
        {
            var sub = new Subjects();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Subjects SET Subject=@Subject, Semester=@Semester, Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sub = con.Query<Subjects>(query, subject).SingleOrDefault();
                return GetSubjectById(subject.Id); ;
            }
        }

        public List<Subjects> GetAllSubject()
        {
            var listOfSubjects = new List<Subjects>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Subjects WHERE Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSubjects = con.Query<Subjects>(query).ToList();
                return listOfSubjects;
            }
        }

        public Subjects GetSubjectById(long Id)
        {
            var subject = new Subjects();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Subjects WHERE Active=1 AND Id=@Id ";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                subject = con.Query<Subjects>(query, new { Id = Id }).SingleOrDefault();
                return subject;
            }
        }

        public void Deactivate(Subjects subject)
        {
            var sub = new Subjects();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Subjects SET Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sub = con.Query<Subjects>(query, subject).SingleOrDefault();
            }
        }

        public List<Subjects> GetSubjectByStudent(long studentId)
        {
            var subject = new List<Subjects>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT Sec.Id, CS.Id AS ClassId, Course, Section, Subject, CS.TimeFrom, CS.TimeTo, CS.Day, CS.SubjectId FROM ClassSchedule CS " +
                    "LEFT JOIN Sections Sec ON CS.SectionId = Sec.Id " +
                    "LEFT JOIN Subjects Sub ON CS.SubjectId = Sub.Id " +
                    "LEFT JOIN Student Stu ON Stu.SectionId = CS.SectionId " +
                    " WHERE Stu.StudentId = @StudentId AND CS.Active=1";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                subject = con.Query<Subjects>(query, new { StudentId = studentId }).ToList();
                return subject;
            }
        }

        public bool CheckSubject(Subjects subjects)
        {
            var sect = new Subjects();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Subjects WHERE Subject=@Subject AND Semester=@Semester AND Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sect = con.Query<Subjects>(query, subjects).FirstOrDefault();
                if (sect != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
