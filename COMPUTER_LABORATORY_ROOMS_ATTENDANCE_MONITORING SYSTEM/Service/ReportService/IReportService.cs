using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.ReportService
{
    public interface IReportService
    {
        Task<Teacher> GetTeacher(Teacher teacher);
    }
}
