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
    public partial class UC_RemoveItem : UserControl
    {
        functions fn = new functions();
        String qry;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            Dellabel.Text = "How to DELETE?";
            Dellabel.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            qry = "select * from items";
            DataSet ds = fn.GetData(qry);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            qry = "Select * from items where name like '" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.GetData(qry);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item ?","Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                qry = "delete from items where iid =" + id + "";
                fn.setData(qry);
                loadData();
            }
        }

        private void Dellabel_Click(object sender, EventArgs e)
        {
            Dellabel.ForeColor = Color.Red;
            Dellabel.Text = "Click on Rows to Delete the Items";
        }

        private void UC_RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
