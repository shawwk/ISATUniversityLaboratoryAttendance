using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.UserService
{
    public class UserService : IUserService
    {
        private IConfiguration _configuration { get; }
        private string _connectionString = "";
        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ISAT_COMPLAB_ATTENDANCE_DB");
        }
        public Users Authenticate(Users account)
        {
            var user = new Users();
            var password = PasswordManager.Encrypt(account.Password);
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Users WHERE [UserName]=@UserName AND [Password]=@Password AND Active=1";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, new { UserName = account.UserName, Password = password}).FirstOrDefault();

                if (currentUser != null && currentUser.Id > 0)
                    user = (Users)currentUser;

                return user;
            }
        }

        public Users DeactivateUser(Users users)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "UPDATE Users SET Active=0 WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, users).FirstOrDefault();
                return GetUserById(users.Id);
            }
        }

        public Users GetUserById(long studentId)
        {
            var user = new Users();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Users WHERE UserId=@Id ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, new { Id = studentId}).FirstOrDefault();

                if (currentUser != null && currentUser.Id > 0)
                    user = (Users)currentUser;

                return user;
            }
        }

        public Users RegisterUser(Users users)
        {
            var user = new Users();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO Users(Password, UserName, UserId, Active, UserRole, IDNumber) VALUES(@Password, @UserName, @UserId, 1, @UserRole, @IDNumber) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int) ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                int resultId = con.Query<int>(query, users).FirstOrDefault();
                if (resultId != 0)
                    user.Id = resultId;
                con.Close();
                return user;
            }
        }

        public Users ResetAccount(Users account)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "UPDATE Users SET UserName=@UserName, Password=@Password WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, account).FirstOrDefault();
                return GetUserById(account.Id);
            }
        }

        public Users UpdateUsernamePassword(Users account)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "UPDATE Users SET Password=@Password WHERE Id=@Id";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, account).FirstOrDefault();
                return GetUserById(account.Id);
            }
        }

        public Users GetUserByIDNumber(long Id)
        {
            var user = new Users();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Users WHERE IDNumber=@Id ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, new { Id = Id }).FirstOrDefault();

                if (currentUser != null && currentUser.Id > 0)
                    user = (Users)currentUser;

                return user;
            }
        }

        public Users RegisterAdmin(Users users)
        {
            var user = new Users();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO Admin(UserId, FullName) VALUES(@UserId, @FullName) " +
                    "UPDATE Users SET Password=@Password WHERE Id=@UserId ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, users).FirstOrDefault();
                if (currentUser != null && currentUser.Id > 0)
                    user = (Users)currentUser;

                con.Close();
                return user;
            }
        }

        public List<Users> GetAllUser()
        {
            var user = new List<Users>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT U.Id, U.UserName, U.Password, A.UserId, U.IDNumber, U.UserRole, A.FullName FROM Users U LEFT JOIN Admin A ON A.UserId = U.Id WHERE Active=1";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var list = con.Query<Users>(query).ToList();
                return list;
            }
        }

        public Users UpdateUsers(Users users)
        {
            var user = new Users();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "UPDATE Users SET UserName=@UserName, Password=@Password WHERE Id=@Id " +
                    "UPDATE Admin SET FullName=@FullName WHERE UserId=@Id ";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var currentUser = con.Query<Users>(query, users).FirstOrDefault();
                if (currentUser != null && currentUser.Id > 0)
                    user = (Users)currentUser;

                con.Close();
                return user;
            }
        }

        public bool CheckUser(int id, string user)
        {
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Users WHERE UserName=@user OR IDNumber=@id";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var list = con.Query<Users>(query, new {user = user, id = id}).ToList();
                if (list != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
