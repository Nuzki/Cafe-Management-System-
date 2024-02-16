using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System_Simple.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        functions fn = new functions();
        string qry;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            qry = "insert into items(name,catergory,price) values('" + txtItemName.Text + "','" + txtCatergory.Text + "'," + txtPrice.Text + ")";

            fn.setData(qry);
            clearAll();
        }

        public void clearAll()
        {
            txtCatergory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
         clearAll();
        }
    }
}
