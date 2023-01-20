using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection
{
    public class Sections
    {
        public Sections()
        {
            Course = "";
            Section = "";
            Active = true;
        }
        public Int64 Id { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public bool Active { get; set; }
        public string Subject { get; set; }
        public Int64 ClassId { get; set; }
        public Int64 SubjectId { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public Enums.Days Day { get; set; }
    }
}
