using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser
{
    public class Users
    {
        public Users()
        {
            Id = 0;
            UserName = "";
            Password = "";
            FullName = "";
            Active = true;
        }
        public Int64 Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public Int64 IDNumber { get; set; }
        public bool Active { get; set; }
        public string FullName { get; set; }
        public Enums.UserRole UserRole  { get; set; }
    }
}
