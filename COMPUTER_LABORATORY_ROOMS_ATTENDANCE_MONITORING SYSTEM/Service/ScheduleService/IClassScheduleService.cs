using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;
using static COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums.Enums;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.ScheduleService
{
    public interface IClassScheduleService
    {
        Schedule AddSchedule(Schedule classSchedule);
        Schedule UpdateSchedule(Schedule classSchedule);
        List<Schedule> GetClassSchedules();
        List<Schedule> GetClassSchedules(Enums.ClassStatus status, DateTime date);
        Schedule GetClassScheduleById(Int64 classSchedule);
        List<Schedule> GetScheduleByTeacherId(Int64 teacherId);
        Schedule GetClass(FilterParameter filterParameter);
        Schedule SaveStudentSubject(Schedule schedule);
        void DeactivateSchedule(Int64 classScheduleId);
        void StartClass(Int64 ClassId, DateTime Date, Enums.ClassStatus status);
        void EndClass(Int64 ClassId, DateTime Date, Enums.ClassStatus status);
        bool CheckClassOngoing(Int64 ClassId);
        bool CheckClasses(Int64 ClassId);
        bool CheckDuplicate(Schedule schedule);
        List<Schedule> TeacherClasses();
        //void UpdateClass(Int64 ClassId, Enums.ClassStatus status);
        //bool ClassStarted(Int64 ClassId, Enums.ClassStatus status);
    }
}
