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
    public partial class DATA_EDIT_item : Form
    {
        private DATA_BD item;
       
        public DATA_EDIT_item(DATA_BD? item,bool isnewrow)
        {
            InitializeComponent();
            if (!isnewrow)
            {
                this.item = item;
            }
        }

        public DATA_BD GETITEM
        {
            get { return item;  }
            set { 

                item = value;
                ITEM_NAME_BOX = item.Name_item;
                ITEM_ID_BOX = item.ID;

            }
        }
        private void SAVE_ITEM_BT_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
