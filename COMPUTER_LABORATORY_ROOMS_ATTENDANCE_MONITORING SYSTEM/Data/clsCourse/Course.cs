namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsCourse
{
    public class Course
    {
        public Course()
        {
            CourseName = "";
            ShortCutName = "";
            Active= true;
        }
        public Int64 Id { get; set; }
        public string CourseName { get; set; }
        public string ShortCutName { get; set; }
        public bool Active { get; set; }

    }
}
