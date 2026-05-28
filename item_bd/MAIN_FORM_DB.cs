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
        public MAIN_FORM_DB(BD_CONNECT DB_conection)
        {
            InitializeComponent();
            DB_con = DB_conection;
            loadData_user();
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
    }
}
