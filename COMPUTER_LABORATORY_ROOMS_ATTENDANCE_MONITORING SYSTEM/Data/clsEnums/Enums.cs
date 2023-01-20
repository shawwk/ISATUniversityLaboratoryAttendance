using System.ComponentModel;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums
{
    public class Enums
    {
        public enum UserRole : byte
        {
            [Description("Faculty")]
            Faculty = 0,
            [Description("Administrator")]
            Admin = 1,
            [Description("Student")]
            Student = 2,
        }
        public enum Days : byte
        {
            [Description("Monday")]
            Monday = 0,
            [Description("Tuesday")]
            Tuesday = 1,
            [Description("Wednesday")]
            Wednesday = 2,
            [Description("Thursday")]
            Thursday = 3,
            [Description("Friday")]
            Friday = 4,
            [Description("Saturday")]
            Saturday = 5,
            [Description("Sunday")]
            Sunday = 6
        }
        public enum Gender : byte
        {
            [Description("Male")]
            Male = 0,
            [Description("Female")]
            Female = 1,
        }
        public enum Semester : byte
        {
            [Description("1st Semester")]
            FirstSemester = 0,
            [Description("2nd Semester")]
            SecondSemester = 1,
        }
        public enum ClassStatus : byte
        {
            [Description("On Going")]
            OnGoing = 0,
            [Description("Ended")]
            Ended = 1,
        }
        public enum Rooms : byte
        {
            [Description("Rm-105")]
            RM105 = 0,
            [Description("Rm-106")]
            RM106 = 1,
            [Description("Rm-107")]
            RM107 = 2,
            [Description("Rm-108")]
            RM108 = 3,
            [Description("Rm-109")]
            RM109 = 4,
            [Description("Rm-201")]
            RM201 = 5,
            [Description("Rm-202")]
            RM202 = 6,
            [Description("Rm-203")]
            RM203 = 7,
            [Description("Rm-204")]
            RM204 = 8,
            [Description("Rm-205")]
            RM205 = 9,
            [Description("Rm-206")]
            RM206 = 10,
            [Description("Rm-207")]
            RM207 = 11,
            [Description("Rm-208")]
            RM208 = 12,
            [Description("Rm-209")]
            RM209 = 13,
            [Description("Rm-300")]
            RM300 = 14,
            [Description("Rm-301")]
            RM301 = 15
        }
    }

}
