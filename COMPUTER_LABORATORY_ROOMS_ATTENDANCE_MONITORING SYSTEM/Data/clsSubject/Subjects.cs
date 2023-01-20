using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject
{
    public class Subjects
    {
        public Subjects()
        {
            Subject = "";
            Active = true;
        }
        public Int64 Id { get; set; }
        public Int64 SubjectId { get; set; }
        public string Subject { get; set; }
        public Enums.Semester Semester { get; set; }
        public bool Active { get; set; }
    }
}
