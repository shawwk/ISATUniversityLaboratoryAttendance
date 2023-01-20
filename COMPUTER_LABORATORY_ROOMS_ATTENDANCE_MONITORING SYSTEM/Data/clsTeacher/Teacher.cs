using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher
{
    public class Teacher
    {
        public Teacher()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            EmployeeId = "";
            BirthDate = DateTime.Now;
            Active = true;
        }
        public long Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s.\-']{2,}$", ErrorMessage = "Employee name contains invalid characters.")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmployeeId { get; set; }
        public Enums.Gender Gender { get; set; }
        public bool Active { get; set; }
    }
}
