using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                config = $"Host=localhost;Database={name_DB};Username={login};Password={password};Client Encoding=UTF8"; 

            }
            else 
            {
                config = $"Host={IP};Port={port};Database={name_DB};Username={login};Password={password};Client Encoding=UTF8";

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
        public BindingList<DATA_DB_USERS> GetDataUsers()
        {
            BindingList<DATA_DB_USERS> list_user = new BindingList<DATA_DB_USERS>();
            string sql_ms = "SELECT User_name,Password,user_role,ID from user_data";
            using (var conect = ConectToDB())
            {
                conect.Open();
                using (var cmd = new NpgsqlCommand(sql_ms,conect))
                {
                    using (var read = cmd.ExecuteReader())
                    {
                        while ( read.Read())
                        {
                            DATA_DB_USERS data_user = new DATA_DB_USERS();
                           
                            data_user.User_name = read.GetString(0);
                            data_user.Password = read.GetString(1);
                            data_user.user_role = read.GetString(2);
                            data_user.ID = read.GetInt32(3);
                            list_user.Add(data_user);
                        }
                        return list_user;
                    }
                }
            }
        }
        public void InsertNewData(BindingList<DATA_DB_USERS> new_data)
        {
            string sql_cmd = @"INSERT INTO User_data( ID,User_name,Password,user_role) VALUES (@id,@User_name,@Password,@user_role) ON CONFLICT (ID) DO UPDATE SET User_name = EXCLUDED.User_name,Password = EXCLUDED.Password,user_role = EXCLUDED.user_role;";
            using (var conn = ConectToDB())
            {

                conn.Open();
                using (var trans = conn.BeginTransaction()) {
                    try
                    {
                        //стоит добавить ключ
                        using (var cmd = new NpgsqlCommand(sql_cmd, conn, trans))
                        {
                            cmd.Parameters.Add("@User_name", NpgsqlTypes.NpgsqlDbType.Text);
                            cmd.Parameters.Add("@Password", NpgsqlTypes.NpgsqlDbType.Text);
                            cmd.Parameters.Add("@user_role", NpgsqlTypes.NpgsqlDbType.Text);
                            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                            foreach (var item in new_data)
                            {
                                cmd.Parameters["@User_name"].Value = item.User_name;
                                cmd.Parameters["@Password"].Value = item.Password;
                                cmd.Parameters["@user_role"].Value = item.user_role;
                                cmd.Parameters["@id"].Value = item.ID;
                                cmd.ExecuteNonQuery();
                            }
                            trans.Commit();
                            MessageBox.Show("Все изменения сохранены!","SAVE DATA SUCCSESS!");
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show($"ОШИБКА СОХРАНЕНИЯ: {ex.Message} ","SAVE DATA FAILURE!");
                    }
                }
            }
        }
        // тут будут методы для подключения
        
        /// 1 - получения данных из таблицы не пользователей 
        /// 2 - метод обновления данных 
        /// 3 - метод записи данных
        /// 4 - метод удаления выбраных данных

            
    }
}
