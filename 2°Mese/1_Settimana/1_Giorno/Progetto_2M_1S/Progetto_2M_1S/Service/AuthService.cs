using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Progetto_2M_1S.Models;

namespace Progetto_2M_1S.Service
{
    public class AuthService : ServiceSQL, IAuthService
    {
        private string connectionString;

        private const string LOGIN_COMMAND =
            "SELECT IdUser, FrinedlyName FROM Users WHERE Username = @user AND Password = @pass";
        private const string ROLES_COMMAND =
            "SELECT RolesName FROM Roles ro JOIN [Table] ur ON ro.IdRoles = ur.RoleId WHERE UserId = @id";

        public AuthService(IConfiguration configuration)
            : base(configuration) { }

        public User Login(string username, string password)
        {
            try
            {   
                var _connection = GetConnection();
                Console.WriteLine("ciao Brutto");
                _connection.Open();

                //Primo comando
                var command = GetCommand(LOGIN_COMMAND);
                Console.WriteLine("ciao bello");
                command.Parameters.Add(new SqlParameter("@user", username));
                command.Parameters.Add(new SqlParameter("@pass", password));
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var u = new User
                    {
                        IdUser = reader.GetInt32(0),
                        Password = password,
                        Username = username,
                        FrinedlyName = reader.IsDBNull(1) ? null : reader.GetString(1)
                    };
                    reader.Close();

                    //Secondo comando
                    var roleCmd = GetCommand(ROLES_COMMAND);
                    roleCmd.Parameters.Add(new SqlParameter("@id", u.IdUser));
                    using var re = roleCmd.ExecuteReader();
                    while (re.Read())
                    {
                        u.Roles.Add(re.GetString(0));
                    }
                    return u;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
                return null;
        }
    }
}
