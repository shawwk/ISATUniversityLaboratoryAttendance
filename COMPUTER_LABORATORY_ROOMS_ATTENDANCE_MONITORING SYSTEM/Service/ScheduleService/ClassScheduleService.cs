using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.ClassSchedulePage;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using static MudBlazor.CategoryTypes;
using static MudBlazor.Defaults;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.ScheduleService
{
    public class ClassScheduleService : IClassScheduleService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public ClassScheduleService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public Schedule AddSchedule(Schedule classSchedule)
        {
            var schedule = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "IF NOT EXISTS(SELECT * FROM ClassSchedule WHERE " +
                    "TimeFrom BETWEEN @TimeFrom AND @TimeTo AND TimeTo BETWEEN @TimeFrom AND @TimeTo AND Day=@Day AND Active=1 AND Room=@Room) " +
                    "BEGIN " +
                    "INSERT INTO ClassSchedule(SubjectId, TimeFrom, TimeTo, TeacherId, SectionId, Day, Active, Room) VALUES(@SubjectId, @TimeFrom, @TimeTo, @TeacherId, @SectionId, @Day, @Active, @Room) " +
                     "SELECT CAST(SCOPE_IDENTITY() as int) " +
                     "END";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var scheduleId = con.Query<int>(query, classSchedule).SingleOrDefault();
                con.Close();
                return GetClassScheduleById(scheduleId);
            }
        }

        public Schedule GetClassScheduleById(long classSchedule)
        {
            var schedule = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CS.Id, S.Id AS SubjectId, S.Subject AS SubjectName, TimeFrom, TimeTo, Day, F.Id AS TeacherId, " +
                    "CONCAT(F.FirstName, ' ', F.MiddleName, ' ', F.LastName) AS TeacherName, SEC.Id AS SectionID, SEC.Section AS SectionName,  SEC.Course AS Course, CS.Room  " +
                    "FROM ClassSchedule CS " +
                    "LEFT JOIN Subjects S ON CS.SubjectId = S.Id " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "LEFT JOIN Sections SEC ON CS.SectionId = SEC.Id " +
                    "WHERE CS.Id = @classSchedule";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query, new { classSchedule = classSchedule }).SingleOrDefault();
                con.Close();
                return schedule;
            }
        }

        public List<Schedule> GetClassSchedules()
        {
            var listOfSchedules = new List<Schedule>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CS.Id, S.Id AS SubjectId, S.Subject AS SubjectName, TimeFrom, TimeTo, Day, F.Id AS TeacherId, " +
                    "CONCAT(F.FirstName, ' ', F.MiddleName, ' ', F.LastName) AS TeacherName, SEC.Id AS SectionID, SEC.Section AS SectionName,  SEC.Course AS Course " +
                    "FROM ClassSchedule CS " +
                    "LEFT JOIN Subjects S ON CS.SubjectId = S.Id " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "LEFT JOIN Sections SEC ON CS.SectionId = SEC.Id WHERE CS.Active = 1";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSchedules = con.Query<Schedule>(query).ToList();
                con.Close();
                return listOfSchedules;
            }
        }

        public Schedule UpdateSchedule(Schedule classSchedule)
        {
            
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE ClassSchedule SET " +
                    "SubjectId = @SubjectId,  TimeFrom = @TimeFrom, " +
                    "TimeTo = @TimeTo, TeacherId = @TeacherId, " +
                    "SectionId = @SectionId, Day = @Day, Room = @Room " +
                    "WHERE Id = @Id ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, classSchedule).FirstOrDefault();
                con.Close();
                return GetClassScheduleById(classSchedule.Id);
            }
        }

        public void DeactivateSchedule(long classScheduleId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE ClassSchedule SET Active = 0 WHERE Id=@classScheduleId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, new { classScheduleId = classScheduleId }).FirstOrDefault();
                con.Close();
            }
        }

        public List<Schedule> GetScheduleByTeacherId(long teacherId)
        {
            var listOfSchedules = new List<Schedule>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CS.Id, S.Id AS SubjectId, S.Subject AS SubjectName, TimeFrom, TimeTo, Day, F.Id AS TeacherId, " +
                    "CONCAT(F.FirstName, ' ', F.MiddleName, ' ', F.LastName) AS TeacherName, SEC.Id AS SectionID, SEC.Section AS SectionName,  SEC.Course AS Course, CS.Room " +
                    "FROM ClassSchedule CS " +
                    "LEFT JOIN Subjects S ON CS.SubjectId = S.Id " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "LEFT JOIN Sections SEC ON CS.SectionId = SEC.Id WHERE CS.Active = 1 AND TeacherId=@teacherId";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSchedules = con.Query<Schedule>(query, new { teacherId = teacherId}).ToList();
                con.Close();
                return listOfSchedules;
            }
        }

        public void StartClass(long ClassId, DateTime Date, Enums.ClassStatus status)
        {
            var schedule = new Schedule();
            var startTime = Date.TimeOfDay;
            var endTime = Date.TimeOfDay;
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "IF NOT EXISTS(SELECT * FROM ClassStatus WHERE ClassId=@ClassId AND Date=@Date AND Status=0) " +
                    "BEGIN " +
                    "INSERT INTO ClassStatus(ClassId, Date, Status, StartTime) " +
                    "VALUES(@ClassId, @Date, @Status, @StartTime) " +
                    "END ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, new {ClassId = ClassId, Date = Date.Date, Status = status, StartTime = startTime}).SingleOrDefault();
                con.Close();
            }
        }

        public Schedule GetClass(FilterParameter filter)
        {
            var schedule = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClassSchedule WHERE TeacherId=@TeacherId AND SectionId=@SectionId AND SubjectId=@SubjectId " +
                    "AND TimeFrom=@TimeFrom AND TimeTo=@TimeTo AND Day=@Day";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query,filter).SingleOrDefault();
                con.Close();
                return schedule;
            }
        }

        public Schedule SaveStudentSubject(Schedule schedule)
        {
            var schedules = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO StudentSubjects(StudentId, SectionId, SubjectId, TeacherId, ClassId) " +
                    "VALUES(@StudentId, @SectionId, @SubjectId, @TeacherId, @Id) ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedules = con.Query(query, schedule).SingleOrDefault();
                con.Close();
                return schedules;
            }
        }

        public bool CheckClassOngoing(long ClassId)
        {
            var schedule = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClassStatus WHERE ClassId=@ClassId AND Date=@Date AND Status=1"; 
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query, new { ClassId = ClassId, Date=DateTime.Now.Date }).SingleOrDefault();
                con.Close();
                if (schedule != null)
                    return true;
                else
                    return false;
            }
        }

        public void EndClass(long ClassId, DateTime Date, Enums.ClassStatus status)
        {
            var endTime = DateTime.Now;
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "UPDATE ClassStatus SET Status=1, EndTime=@EndTime " +
                               "WHERE ClassId=@ClassId AND Date=@Date ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Query(query, new { ClassId = ClassId, Date = Date.Date, EndTime = endTime }).SingleOrDefault();
                con.Close();
            }
        }

        public List<Schedule> TeacherClasses()
        {
            var schedule = new List<Schedule>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CS.Id, F.FirstName, F.MiddleName , F.LastName, CS.TimeFrom, CS.TimeTo, Stat.StartTime, Stat.EndTime, Stat.Status, Stat.Date, " +
                    "(SELECT Subject FROM Subjects WHERE Id=CS.SubjectId) AS SubjectName, (SELECT CONCAT((SELECT Course FROM Sections WHERE Id=CS.SectionId),+' '+ " +
                    "(SELECT Section FROM Sections WHERE Id=CS.SectionId)))AS SectionName, " +
                    "CS.SubjectId, CS.SectionId, CS.TeacherId, CS.Room  " +
                    "FROM Faculty F " +
                    "INNER JOIN ClassSchedule CS  ON F.Id = CS.TeacherId " +
                    "INNER JOIN ClassStatus Stat ON CS.Id = Stat.ClassId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query).ToList();
                con.Close();
                return schedule;
            }
        }

        public List<Schedule> GetClassSchedules(Enums.ClassStatus status, DateTime date)
        {
            var listOfSchedules = new List<Schedule>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CS.Id, S.Id AS SubjectId, S.Subject AS SubjectName, TimeFrom, TimeTo, Day, F.Id AS TeacherId, " +
                    "CONCAT(F.FirstName, ' ', F.MiddleName, ' ', F.LastName) AS TeacherName, SEC.Id AS SectionID, SEC.Section AS SectionName,  SEC.Course AS Course, " +
                    "Stat.Status, Stat.Date, CS.Room " +
                    "FROM ClassSchedule CS " +
                    "LEFT JOIN Subjects S ON CS.SubjectId = S.Id " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "INNER JOIN ClassStatus Stat ON Stat.ClassId = CS.Id " +
                    "LEFT JOIN Sections SEC ON CS.SectionId = SEC.Id WHERE CS.Active = 1" +
                    "AND Stat.Status=@Status AND Stat.Date=@Date";

                if (con.State == ConnectionState.Closed)
                    con.Open();
                listOfSchedules = con.Query<Schedule>(query, new {Status=status, Date=date}).ToList();
                con.Close();
                return listOfSchedules;
            }
        }

        public bool CheckClasses(Int64 ClassId)
        {
            var schedule = new Schedule();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClassStatus WHERE ClassId=@ClassId AND Date=@Date AND Status=0";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query, new {ClassId=ClassId, Date = DateTime.Now.Date }).SingleOrDefault();
                con.Close();
                if (schedule != null)
                    return true;
                else
                    return false;
            }
        }

        public bool CheckDuplicate(Schedule schedule)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClassSchedule WHERE " +
                    "TimeFrom BETWEEN @TimeFrom AND @TimeTo AND TimeTo BETWEEN @TimeFrom AND @TimeTo AND Day=@Day AND Active=1 AND Room=@Room";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                schedule = con.Query<Schedule>(query,schedule).SingleOrDefault();
                con.Close();
                if (schedule != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
