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
    public partial class EDIT_USER : Form
    {
        private DATA_DB_USERS user_data = new DATA_DB_USERS();
        private bool isnewrow;

        public EDIT_USER(DATA_DB_USERS? user_data, bool isnewrow)
        {
            InitializeComponent();
            if (isnewrow) 
            {
                this.isnewrow = isnewrow;
               
            }
            else
            {


                this.user_data = user_data;
                login_BOX.Text = user_data.User_name;
                pass_box.Text = user_data.Password;
                if (user_data.user_role == "Admin")
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (user_data.user_role == "User")
                {
                    comboBox1.SelectedIndex = 1;
                }
                else
                {
                    comboBox1.SelectedIndex = 2;
                }
            }
        }

        public DATA_DB_USERS GETDATA
        {
            get 
            {
                return user_data;
            }
            
        }
        private void login_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_save_user_data_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrWhiteSpace(login_BOX.Text) && !string.IsNullOrWhiteSpace(pass_box.Text) && comboBox1.Text != null)
                {
                //MessageBox.Show(login_BOX.Text);
                    user_data.User_name = login_BOX.Text;
                    user_data.Password = pass_box.Text;
                    user_data.user_role = comboBox1.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка: Заполните строки!", "ERROR: STRING IS NULL!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            
        }
    }
}
