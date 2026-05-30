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

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data_user.CurrentRow != null)
            {
                DATA_DB_USERS edit_row = Data_user.CurrentRow.DataBoundItem as DATA_DB_USERS;
                EDIT_USER edit_form_user = new EDIT_USER(edit_row);
                edit_form_user.ShowDialog();
                DATA_DB_USERS edited_row = edit_form_user.GETDATA;
                edit_row.User_name = edited_row.User_name;
                edit_row.Password = edited_row.Password;
                edit_row.user_role = edited_row.user_role;
                Data_user.RefreshEdit();
                Data_user.Refresh();
                list_user = Data_user.DataSource as List<DATA_DB_USERS>;
                DB_con.InsertNewData(list_user);
            }
        }

        ///План:
        ///1 - сделать норм меню по правой кнопке мыши по выделеной строке
        ///2 - сделать форму изменения данных выбраной строки
        ///3 - сделать таблицу с данными 
        ///
    }
}
