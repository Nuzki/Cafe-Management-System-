using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System_Simple.AllUserControls
{
    public partial class UC_UpdateItems : UserControl
    {
        functions fn = new functions();
        string qry;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {

            qry = "select * from items";
            DataSet ds = fn.GetData(qry);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            qry = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.GetData(qry);
            dataGridView1.DataSource = ds.Tables[0];

        }
        int id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string catergory = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                txtCatergory.Text = catergory;
                txtName.Text = name;
                txtPrice.Text = price.ToString();
            }
            catch (NullReferenceException)
            {
                
                MessageBox.Show("One or more cells contain null values.");
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Error parsing data. Please check the format of the data in the cells.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qry = "update items set name ='" + txtName.Text + "',catergory = '" + txtCatergory.Text + "',price=" + txtPrice.Text + "where iid =" + id + "";
            fn.setData(qry);
            loadData();

            txtName.Clear();
            txtCatergory.Clear();
            txtPrice.Clear();
        }
    }
}
