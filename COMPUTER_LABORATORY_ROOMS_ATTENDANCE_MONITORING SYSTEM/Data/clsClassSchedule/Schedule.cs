using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule
{
    public class Schedule : Teacher
    {
        public Schedule()
        {
            Id = 0;
            SubjectId = 0;
            SubjectName = "";
            TeacherId = 0;
            TeacherName = "";
            SectionId = 0;
            SectionName = "";
            TimeFrom = new TimeSpan(8,0,0);
            TimeTo = new TimeSpan(12, 0, 0);
            Active = true;
        }
        public Int64 Id { get; set; }
        public Int64 SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Int64 TeacherId { get; set; }
        public string TeacherName { get; set; }
        public Int64 SectionId { get; set; }
        public string SectionName { get; set; }
        public string Course { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public Enums.Days Day { get; set; }
        public bool Active { get; set; }
        public Int64 StudentId { get ; set; }   
        public Int64 ClassId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public Enums.ClassStatus Status { get; set; }
        public Enums.Rooms Room { get; set; }

    }
}
