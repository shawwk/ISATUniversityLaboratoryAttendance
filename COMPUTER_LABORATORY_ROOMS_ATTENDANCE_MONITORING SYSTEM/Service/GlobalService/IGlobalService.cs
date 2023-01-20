using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using Microsoft.AspNetCore.Mvc;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.GlobalService
{
    public interface IGlobalService
    {
        List<Sections> GetAssignSections(Int64 teacherId);
        List<Student> GetStudentByDate(FilterParameter filterParameter);
        List<Student> GetStudentAttendanceRecord(FilterParameter filterParameter);
        List<Student> GetAllStudentRecord(FilterParameter filterParameter);
        List<Student> GetStudentRecord(Int64 studentId, Int64 SubjectId);
        List<Student> GetStudentReport(Int64 teacherId, Int64 sectionId, Int64 subjectId, DateTime date);
        IActionResult LoadReport(Teacher teacher);
        Task<string> GetReport(Int64 teacherId, Int64 sectionId, Int64 subjectId, Enums.Rooms room);

    }
}
