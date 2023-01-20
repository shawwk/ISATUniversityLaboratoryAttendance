using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent
{
    public class Student 
    {
        public Student()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            SectionId = 0;
            BirthDate = DateTime.Now;
            StudentId = 0;
            Active = true;
        }
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Enums.Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Int64 StudentId { get; set; } 
        public Int64 SectionId { get; set; }
        public string Section { get; set; }
        public string Course { get; set; }
        public string CourseSection
        {
            get
            {
                return Course + " " + Section;
            }
        }
        public bool Active { get; set; }

        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeOut { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public DateTime Date { get; set; }
    }
}
