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
        private BindingList<DATA_DB_USERS> list_user;
        private bool isadmin;
        private TabPage del_page;
        private BindingList<DATA_BD> List_items;

        public MAIN_FORM_DB(BD_CONNECT DB_conection, bool isAdmin)
        {
            InitializeComponent();
            DB_con = DB_conection;
            this.isadmin = isAdmin;
            Data_user.AllowUserToAddRows = false;
            if (!isAdmin)
            {
                del_page = USERS;
                tabControl1.TabPages.Remove(USERS);
                loadData_item();

            }
            else
            {
                loadData_user();
                loadData_item();
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
        private void loadData_item()
        {
            List_items = DB_con.GetDataDB();
            DATA_DB_tabl.DataSource = List_items;
            DATA_DB_tabl.Columns["ID"].HeaderText = "ID";
            DATA_DB_tabl.Columns["Name_item"].HeaderText = "Имя предмета";
            DATA_DB_tabl.Columns["Item_id"].HeaderText = "Артикул";
            DATA_DB_tabl.Columns["count"].HeaderText = "Количество";
            DATA_DB_tabl.Columns["status"].HeaderText = "Статус";
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
                изменитьToolStripMenuItem.Visible = true;
                создатьСтрокуToolStripMenuItem.Visible = false;
                удалитьСтрокуToolStripMenuItem.Visible = true;
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
                EDIT_USER edit_form_user = new EDIT_USER(edit_row, false);
                edit_form_user.ShowDialog();
                DATA_DB_USERS edited_row = edit_form_user.GETDATA;
                edit_row.User_name = edited_row.User_name;
                edit_row.Password = edited_row.Password;
                edit_row.user_role = edited_row.user_role;
                Data_user.RefreshEdit();
                Data_user.Refresh();
                list_user = Data_user.DataSource as BindingList<DATA_DB_USERS>;

            }
        }

        private void сохранитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_con.InsertNewData(list_user);
        }

        private void создатьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDIT_USER get_new_row = new EDIT_USER(null, true);
            get_new_row.ShowDialog();
            DATA_DB_USERS added_row = get_new_row.GETDATA;
            added_row.ID = list_user.Count() + 1;
            list_user.Add(added_row);
            Data_user.DataSource = list_user;
            Data_user.RefreshEdit();
            Data_user.Refresh();
        }

        private void Data_user_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                изменитьToolStripMenuItem.Visible = false;
                удалитьСтрокуToolStripMenuItem.Visible = false;
                создатьСтрокуToolStripMenuItem.Visible = true;
                User_selector.Show(Cursor.Position);
            }
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data_user.CurrentRow != null)
            {
                DATA_DB_USERS select_row = Data_user.CurrentRow.DataBoundItem as DATA_DB_USERS;

                Data_user.Rows.RemoveAt(Data_user.SelectedRows[select_row.ID - 1].Index);
                Data_user.RefreshEdit();
                Data_user.Refresh();

            }
        }

        private void изменитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DATA_DB_tabl_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                изменитьСтрокуToolStripMenuItem.Visible = true;
                удалитьСтрокуToolStripMenuItem1.Visible = true;
                добавитьНовуюСтрокуToolStripMenuItem.Visible = false;
                DATA_DB_tabl.ClearSelection();
                DATA_DB_tabl.Rows[e.RowIndex].Selected = true;

                DATA_ITEM_SELECTOR.Show(Cursor.Position);
            }
        }

        private void DATA_DB_tabl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                изменитьСтрокуToolStripMenuItem.Visible = false;
                удалитьСтрокуToolStripMenuItem1.Visible = false;
                добавитьНовуюСтрокуToolStripMenuItem.Visible = true;
                DATA_ITEM_SELECTOR.Show(Cursor.Position);
            }

        }

        private void добавитьНовуюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
