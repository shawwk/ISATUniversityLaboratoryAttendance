using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimelogs;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut
{
    public class TimeInOut : Timelogs
    {
        public new Int64 Id { get; set; }
        public Int64 IDNumber { get; set; }
        public new Int64 SectionId { get; set; }
        public Int64 SubjectId { get; set; }
        public DateTime Date { get; set; }
    }
}
