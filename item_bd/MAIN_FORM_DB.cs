using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace item_bd
{
    public partial class MAIN_FORM_DB : Form
    {
        private BD_CONNECT DB_con;
        private List<DATA_DB_USERS> list_user;
        private bool isadmin;
        private TabPage del_page;
        public MAIN_FORM_DB(BD_CONNECT DB_conection, bool isAdmin)
        {
            InitializeComponent();
            DB_con = DB_conection;
            this.isadmin = isAdmin;
            if (!isAdmin)
            {
                del_page = USERS;
                tabControl1.TabPages.Remove(USERS);
                // метод подключения и получения данных
            }
            else
            {
                loadData_user();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult mess = MessageBox.Show(
                "Вы уверены что хотите закрыть?",
                "Потверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (mess == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        private void loadData_user()
        {
            list_user = DB_con.GetDataUsers();
            Data_user.DataSource = list_user;
            Data_user.Columns["ID"].HeaderText = "ID";
            Data_user.Columns["User_name"].HeaderText = "User_name";
            Data_user.Columns["Password"].HeaderText = "password";
            Data_user.Columns["user_role"].HeaderText = "role";
        }
        private void MAIN_FORM_DB_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_user_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                Data_user.ClearSelection();
                Data_user.Rows[e.RowIndex].Selected = true;
                User_selector.Show(Cursor.Position);
            }
        }

        ///План:
        ///1 - сделать норм меню по правой кнопке мыши по выделеной строке
        ///2 - сделать форму изменения данных выбраной строки
        ///3 - сделать таблицу с данными 
        ///
    }
}
