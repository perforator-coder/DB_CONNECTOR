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
        public MAIN_FORM_DB(BD_CONNECT DB_conection)
        {
            InitializeComponent();
            DB_con = DB_conection;
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

        private void MAIN_FORM_DB_Load(object sender, EventArgs e)
        {

        }
    }
}
