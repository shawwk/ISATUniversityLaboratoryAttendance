using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Reporting.NETCore;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using static MudBlazor.CategoryTypes;
using static System.Collections.Specialized.BitVector32;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.GlobalService
{
    public class GlobalService : IGlobalService
    {
        private IConfiguration _configuration { get; }
        private IWebHostEnvironment _webHostEnvironment;
        private string _connectionString = "";
        private readonly HttpClient _client;
        public GlobalService(IConfiguration configuration, IWebHostEnvironment webHostEnvironment, HttpClient client)
        {
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
            _client = client;
        }
        public List<Sections> GetAssignSections(long teacherId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT Sec.Id, CS.Id AS ClassId, Course, Section, Subject, CS.TimeFrom, CS.TimeTo, CS.Day, CS.SubjectId FROM ClassSchedule CS " +
                    "LEFT JOIN Faculty F ON CS.TeacherId = F.Id " +
                    "LEFT JOIN Sections Sec ON CS.SectionId = Sec.Id " +
                    "LEFT JOIN Subjects Sub ON CS.SubjectId = Sub.Id " +
                    "WHERE CS.TeacherId = @teacherId AND CS.Active=1";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Sections>(query, new { teacherId = teacherId }).ToList();
                con.Close();
                return results;
            }
        }

        public List<Student> GetStudentAttendanceRecord(FilterParameter filterParameter)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.SectionId, Sec.Course, Sec.Section, T.Date, TL.TimeIn, TL.TimeOut, CS.TimeFrom, CS.TimeTo FROM Student S  " +
                    "LEFT JOIN TimeInOut T ON S.StudentId = T.IDNumber " +
                    "LEFT JOIN ClassSchedule CS ON CS.SectionId = S.SectionId " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                    "LEFT JOIN Timelogs TL ON TL.TimeId = T.Id " +
                    "WHERE " +
                    "CS.Active = 1 AND CS.TeacherId=@TeacherId " +
                    "AND CS.SectionId=@SectionId " +
                    "AND T.Date BETWEEN  format(@DateFrom, 'dd-MMM-yyyy') " +
                    "AND format(@DateTo, 'dd-MMM-yyyy') " +
                    "AND TL.TimeIn IS NOT NULL " +
                    "AND CS.SubjectId = T.SubjectId " +
                    "AND T.SubjectId=@SubjectId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Student>(query, filterParameter).ToList();
                con.Close();
                return results;
            }
        }

        public List<Student> GetStudentByDate(FilterParameter filterParameter)
        {

            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.SectionId,S.Active, Sec.Course, Sec.Section, T.Date, TL.TimeIn, TL.TimeOut, CS.TimeFrom FROM Student S  " +
                    "LEFT JOIN TimeInOut T ON S.StudentId = T.IDNumber " +
                    "LEFT JOIN ClassSchedule CS ON CS.SectionId = S.SectionId " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                    "LEFT JOIN Timelogs TL ON TL.TimeId = T.Id " +
                    "WHERE CS.SubjectId=@SubjectId AND CS.TeacherId=@TeacherId AND S.SectionId=@SectionId AND T.Date BETWEEN  format(@DateFrom, 'dd-MMM-yyyy') AND format(@DateTo, 'dd-MMM-yyyy')";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Student>(query, filterParameter).ToList();
                con.Close();
                return results;
            }
        }

        public List<Student> GetAllStudentRecord(FilterParameter filterParameter)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.SectionId, S.Active, Sec.Course, Sec.Section, T.Date, TL.TimeIn, TL.TimeOut, CS.TimeFrom FROM Student S  " +
                    "LEFT JOIN TimeInOut T ON S.StudentId = T.IDNumber " +
                    "LEFT JOIN ClassSchedule CS ON CS.SectionId = S.SectionId " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                    "LEFT JOIN Timelogs TL ON TL.TimeId = T.Id " +
                    "WHERE CS.TeacherId=@TeacherId AND CS.SectionId=@SectionId " +
                    "AND CS.SubjectId=@SubjectId AND T.Date IS NOT NULL AND T.SubjectId=@SubjectId ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Student>(query, filterParameter).ToList();
                con.Close();
                return results;
            }
        }

        public List<Student> GetStudentRecord(Int64 studentId, Int64 subjectId)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.SectionId, Sec.Course, Sec.Section, T.Date, TL.TimeIn, TL.TimeOut FROM Student S  " +
                    "LEFT JOIN TimeInOut T ON S.StudentId = T.IDNumber " +
                    "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                    "LEFT JOIN Timelogs TL ON TL.TimeId = T.Id " +
                    "WHERE S.StudentId=@StudentId AND T.SubjectId=@SubjectId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Student>(query, new { StudentId = studentId, SubjectId = subjectId }).ToList();
                con.Close();
                return results;
            }
        }

        public IActionResult LoadReport(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentReport(long teacherId, long sectionId, long subjectId, DateTime date)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT DISTINCT CS.Id AS ClassId, S.Id, S.FirstName, S.MiddleName, S.LastName, S.Gender, S.StudentId, S.SectionId, Sec.Course, Sec.Section, T.Date, TL.TimeIn, TL.TimeOut, CS.TimeFrom FROM Student S  " +
                   "LEFT JOIN TimeInOut T ON S.StudentId = T.IDNumber " +
                   "LEFT JOIN ClassSchedule CS ON CS.SectionId = S.SectionId " +
                   "LEFT JOIN Sections Sec ON Sec.Id = S.SectionId " +
                   "LEFT JOIN Timelogs TL ON TL.TimeId = T.Id " +
                   "WHERE CS.TeacherId=@TeacherId AND CS.SectionId=@SectionId AND CS.Active=1 " +
                   "AND CS.SubjectId=@SubjectId AND T.Date IS NOT NULL AND T.Date=@Date AND T.SubjectId=@SubjectId";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var results = con.Query<Student>(query, new { TeacherId = teacherId, SubjectId = subjectId, SectionId = sectionId, Date = date.Date }).ToList();
                con.Close();
                return results;
            }
        }

        public async Task<string> GetReport(long teacherId, long sectionId, long subjectId, Enums.Rooms room)
        {
            var pdfContent = "data:application/pdf;base64,";
            HttpResponseMessage responseMessage = await _client.GetAsync($"Report/GetStudentRecord/{teacherId}/{sectionId}/{subjectId}/{room}");
            if (responseMessage.IsSuccessStatusCode)
                pdfContent += Convert.ToBase64String(await responseMessage.Content.ReadAsByteArrayAsync());
            return pdfContent;
        }
    }
}
