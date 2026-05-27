using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace item_bd
{
    public class BD_CONNECT
    {
        private string IP;
        private int port;
        private string name_DB;
        private string login;
        private string password; 
        private bool isLocalhost;

        public BD_CONNECT(string IP,int PORT,string name_DB,string login,string pass, bool isLocal)
        {
            this.IP = IP;
            this.port = PORT;
            this.name_DB = name_DB;
            this.login = login;
            this.password = pass;
            this.isLocalhost = isLocal;
        }
        public NpgsqlConnection ConectToDB()
        {
            string config = "";
            if (isLocalhost)
            {
                config = $"Host=localhost;Database={name_DB};Username={login};Password={password}"; 

            }
            else 
            {
                config = $"Host={IP};Port={port};Database={name_DB};Username={login};Password={password}";

            }

            return new NpgsqlConnection(config);
        }
        public bool PingPong()
        {
            try
            {
                using (var con = ConectToDB())
                {
                    con.Open();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                return false;
            }
        }
        /*public List<DATA_DB_USERS> GetDataUsers()
        {
            
        }
        */
        // тут будут методы для подключения
        // 1 - подключение с данными вверху
        // 2 - получения данных из таблицы
            
    }
}
