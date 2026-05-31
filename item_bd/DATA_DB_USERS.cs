using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace item_bd
{
    public class DATA_DB_USERS
    {
        //нужен ли сдесь ключ для расшифровки пароля?
        public int ID { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public string user_role { get; set; }
    }
}
