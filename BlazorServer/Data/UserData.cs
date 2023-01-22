using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBLibrary;
using Microsoft.Extensions.Configuration;

namespace BlazorServer.Data
{
    public class UserData
    {
        public UserLoginData LoginData;
        public bool IsLoged { get; private set; }

        public async Task TryToLogin(string UserName, string Password)
        {
            DBLibrary.DataBaseAcces dbAcces = new DBLibrary.DataBaseAcces();
            string sql_command = $"SELECT * FROM `Users` WHERE `UserName`=@username AND `Password`=@password;";

            try
            {
                List<UserLoginData> LoginsData = await dbAcces.LoadData<UserLoginData, dynamic>(sql_command, new { username = UserName, password = Password });
                if (LoginsData.Count > 0)
                {
                    LoginData = LoginsData[0];
                    IsLoged = true;
                }
            }
			catch
			{
                IsLoged = false;
            }
        }
    }
}
