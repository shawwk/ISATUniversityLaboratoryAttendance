using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.common
{
    public class Global
    {
        public static string Header { get; set; }
        public static Users CurrentUser { get; set; }
        public static bool isStarted { get; set; }
    }
}
