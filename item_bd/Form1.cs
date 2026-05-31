using System.ComponentModel;

namespace item_bd
{
    public partial class Form1 : Form
    {
        private Setings seting_form = new Setings();
        private string ip;
        private int port;
        private BD_CONNECT conect_db;
        private string APP_path = AppDomain.CurrentDomain.BaseDirectory;
        private bool ishost;
        private bool isAdmin;
        public Form1()
        {
            InitializeComponent();
            loadconf();
            
        }
        private void loadconf()
        {
            if (File.Exists(APP_path + "IP.txt") && File.Exists(APP_path +"port.txt") 
            && int.TryParse(File.ReadAllText(APP_path + "port.txt"),out port) && File.Exists(APP_path + "ishost.txt") && bool.TryParse(File.ReadAllText(APP_path + "ishost.txt"),out ishost))
            {
                ip = File.ReadAllText(APP_path + "IP.txt");
                
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            File.WriteAllText(APP_path + "IP.txt", ip);
            File.WriteAllText(APP_path + "port.txt", port.ToString());
            File.WriteAllText(APP_path + "ishost.txt", ishost.ToString());
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seting_form.GETPORT = port;
            seting_form.IPGET = ip;
            seting_form.GETHost = ishost;
            seting_form.ShowDialog();
            ip = seting_form.IPGET;
            port = seting_form.GETPORT;
            ishost = seting_form.GETHost;
        }

        private void enter_to_db_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string user = login_box.Text;
                string password = pass_box.Text;
              
                conect_db = new BD_CONNECT(ip, port, "user", user, password, ishost);
                conect_db.ConectToDB();
                if (conect_db.PingPong())
                {
                    BindingList<DATA_DB_USERS> list_users = conect_db.GetDataUsers();
                    bool isinDBUsers = false;
                    foreach (var user_data in list_users)
                    {
                        if (user == user_data.User_name && user_data.user_role == "Admin" && password == user_data.Password)
                        {
                            isAdmin = true;
                            isinDBUsers = true;
                            break;
                        }

                        else if (user == user_data.User_name && password == user_data.Password)
                        {
                            isAdmin = false;
                            isinDBUsers = true;
                            break;
                        }
                        else 
                        {

                        }
                        
                    }
                    if (!isinDBUsers)
                    {
                        MessageBox.Show("Пользователь не найден!","ERROR: USER NOT FOUND!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    this.Hide();
                    this.ShowInTaskbar = false;
                    this.WindowState = FormWindowState.Minimized;
                    MAIN_FORM_DB main = new MAIN_FORM_DB(conect_db,isAdmin);
                    if (main.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                        this.ShowInTaskbar = true;
                        this.WindowState = FormWindowState.Normal;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД!","ERROR DB CONNECTION!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
            }
        }
        
    }
}
