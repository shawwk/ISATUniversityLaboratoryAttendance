using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimelogs;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.ClassSchedulePage;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading;
using System.Timers;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TimelogsService
{
    public class TimelogsService : ITimelogsService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public TimelogsService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public int AddTimeInOut(TimeInOut timeInOut)
        {
            var time = new TimeInOut();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "IF NOT EXISTS(SELECT * FROM TimeInOut WHERE Date=@Date AND IDNumber=@IDNumber AND SubjectId=@SubjectId) " +
                    "BEGIN " +
                    "INSERT INTO TimeInOut(IDNumber, SectionId, Date, SubjectId) VALUES(@IDNumber, @SectionId, @Date, @SubjectId) " +
                     "SELECT CAST(SCOPE_IDENTITY() as int) " +
                     "SET @TimeId = SCOPE_IDENTITY() " +
                     "INSERT INTO Timelogs(TimeId, TimeIn, TimeOut) VALUES(@TimeId, @TimeIn, @TimeOut) " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "UPDATE Timelogs SET TimeOut=@TimeOut WHERE TimeId IN(SELECT Id FROM TimeInOut WHERE IDNumber=@IDNumber AND Date=@Date ) " +
                    "END ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var timeId = con.Query<int>(query, timeInOut).SingleOrDefault();
                con.Close();
                return timeId;
            }

        }

        public void AddTimeLogs(Timelogs timelogs, Int64 IdNumber, DateTime Date)
        {
            var time = new Timelogs();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "IF EXISTS(SELECT * FROM TimeInOut WHERE Date=@Date AND IDNumber=@IdNumber ) " +
                    "BEGIN " +
                    "UPDATE Timelogs SET TimeOut=@TimeOut WHERE TimeId IN(SELECT Id FROM TimeInOut WHERE IDNumber=@IdNumber AND Date=@Date ) " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                     "INSERT INTO Timelogs(TimeId, TimeIn, TimeOut) VALUES(@TimeId, @TimeIn, @TimeOut) " +
                     "END ";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, new { TimeId = timelogs.Id, TimeIn = timelogs.TimeIn, TimeOut = timelogs.TimeOut, IdNumber = IdNumber, Date = Date }).SingleOrDefault();
                con.Close();
            }
        }

        public bool CheckDate(DateTime date, Int64 IdNumber, Int64 subjectId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TimeInOut WHERE Date=@Date AND IDNumber=@IDNumber AND SubjectId=@SubjectId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var time = con.Query<Timelogs>(query, new { Date = date.Date, IdNumber = IdNumber, SubjectId= subjectId }).SingleOrDefault();
                con.Close();
                if (time != null)
                    return true;
                else
                    return false;
            }
        }

        public void UpdateTimeLogs(Timelogs timelogs)
        {
            var time = new Timelogs();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Timelogs SET TimeOut=@TimeOut WHERE Id";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var timeId = con.Query<int>(query, timelogs).SingleOrDefault();
                con.Close();
            }
        }

        public void MarkAbsent(long IdNumber, DateTime Date, Int64 SectionId, Int64 SubjectId)
        {
            var time = new TimeInOut();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "IF NOT EXISTS(SELECT * FROM TimeInOut WHERE Date=@Date AND IDNumber=@IDNumber AND SubjectId=@SubjectId) " +
                    "BEGIN " +
                    "INSERT INTO TimeInOut(IDNumber, SectionId, Date, SubjectId) VALUES(@IDNumber, @SectionId, @Date, @SubjectId) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int) " +
                    "END ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, new { IDNumber = IdNumber, Date = Date, SectionId = SectionId, SubjectId = SubjectId }).SingleOrDefault();
                con.Close();
            }
        }
    }
}
