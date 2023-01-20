using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SectionService
{
    public class SectionService : ISectionService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public SectionService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }

        public List<Sections> GetSection(string sectionName)
        {
            var listOfSection = new List<Sections>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                //string query = "SELECT * FROM Sections WHERE (Section LIKE @sectionName OR Course LIKE @sectionName) AND Active=1";
                string query = "SELECT * FROM Sections WHERE Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSection = con.Query<Sections>(query, new { sectionName = '%' + sectionName + '%' }).ToList();
                return listOfSection;
            }
        }

        public Sections AddSection(Sections section)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Sections(Course, Section, Active) VALUES(@Course, @Section, @Active) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                var secId = con.Query<int>(query, section).SingleOrDefault();
                return GetSectionById(secId);
            }
        }

        public Sections UpdateSection(Sections section)
        {
            var sect = new Subjects();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Sections SET Course=@Course, Section=@Section, Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sect = con.Query<Subjects>(query, section).SingleOrDefault();
                return GetSectionById(section.Id); ;
            }
        }

        public List<Sections> GetAllSection()
        {
            var listOfSection = new List<Sections>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Sections WHERE Active=1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSection = con.Query<Sections>(query).ToList();
                return listOfSection;
            }
        }

        public Sections GetSectionById(long Id)
        {
            var sec = new Sections();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Sections WHERE Active=1 AND Id=@Id ";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sec = con.Query<Sections>(query, new { Id = Id }).SingleOrDefault();
                return sec;
            }
        }

        public void Deactivate(Sections section)
        {
            var sec = new Sections();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Sections SET Active=@Active WHERE Id=@Id";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sec = con.Query<Sections>(query, section).SingleOrDefault();
            }
        }

        public bool CheckSection(Sections sections)
        {
            var sec = new Sections();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Sections WHERE Active=1 AND Section=@Section AND Course=@Course";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                sec = con.Query<Sections>(query,sections).FirstOrDefault();
                if (sec != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
