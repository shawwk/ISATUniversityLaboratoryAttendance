using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.UserService
{
    public interface IUserService
    {
        Users Authenticate(Users users);
        Users RegisterUser(Users users);
        Users RegisterAdmin(Users users);
        Users DeactivateUser(Users users);
        Users GetUserById(long studentId);
        Users ResetAccount(Users account);
        Users GetUserByIDNumber(long Id);
        Users UpdateUsernamePassword(Users account);
        Users UpdateUsers(Users users);
        List<Users> GetAllUser();
        bool CheckUser(int id, string user);

    }
}
