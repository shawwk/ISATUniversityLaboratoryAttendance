using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimelogs;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TimelogsService
{
    public interface ITimelogsService
    {
        int AddTimeInOut(TimeInOut timeInOut);
        void AddTimeLogs(Timelogs timelogs, Int64 IdNumber, DateTime Date);
        void UpdateTimeLogs(Timelogs timelogs);
        bool CheckDate(DateTime date, Int64 IdNumber, Int64 SubjectId);
        void MarkAbsent(Int64 IdNumber, DateTime Date, Int64 SectionId, Int64 SubjectId);
    }
}
