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
    public partial class Setings : Form
    {
        private string ip;
        private int port;
        private bool islocal;
        public string IPGET
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
                IP_box.Text = ip;
            }
        }
        public int GETPORT
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
                PORT_box.Text = port.ToString();
            }
        }
        public bool GETHost
        {
            get {  return islocal; }
            set
            {
                if (value)
                {

                    checkBox1.Checked = true;
                    IP_box.Enabled = false;
                    PORT_box.Text = "5432";
                    PORT_box.Enabled = false;
                    islocal = true;
                }
                else
                {
                    IP_box.Enabled = true;
                    PORT_box.Text = port.ToString();
                    PORT_box.Enabled = true;
                    islocal = false;
                    checkBox1.Checked = false;
                }
                
            }
        }
        public Setings()
        {
            InitializeComponent();
            IP_box.Text = ip;
            PORT_box.Text = port.ToString();
        }

        private void save_BT_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(IP_box.Text) || string.IsNullOrWhiteSpace(PORT_box.Text))
                {
                    MessageBox.Show("Ошибка: Заполните все данные!", "ERROR: data is null!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(PORT_box.Text, out port))
                {
                    MessageBox.Show("Ошибка: Некоректый порт!", "ERROR: port convert error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ip = IP_box.Text;
                this.Close();
            }
            else 
            {
                this.Close();   
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                IP_box.Enabled = false;
                PORT_box.Text = "5432";
                PORT_box.Enabled = false;
                islocal = true;
            }
            else 
            {
                IP_box.Enabled = true;
                PORT_box.Text = port.ToString();
                PORT_box.Enabled = true;
                islocal = false;
            }

        }
    }
}
