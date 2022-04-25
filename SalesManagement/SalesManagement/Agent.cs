using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class Agent : Form
    {
        SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Agent()
        {
            InitializeComponent();
            disData();
        }
        private void Agent_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            connString.Open();
            cmd = new SqlCommand("insert into Agent values('" + txtAgentID.Text + "',N'" + txtAgentName.Text + "',N'" + txtAgentAddress.Text + "','" + txtAgentPhone.Text + "')", connString);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add successfully");
            connString.Close();
            disData();
            ClearE();

        }

        public void disData()
        {
            //Display Data
            connString.Open();
            adpt = new SqlDataAdapter("select *from Agent", connString);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            connString.Close();
        }

        public void ClearE()
        {
            txtAgentID.Text = "";
            txtAgentName.Text = "";
            txtAgentAddress.Text = "";
            txtAgentPhone.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connString.Open();
                cmd = new SqlCommand("update Agent set AgentID=" + txtAgentID.Text + "',AgentName= N'" + txtAgentName.Text + "',AgentAdress= N'" + txtAgentAddress.Text + "',Phone=" + txtAgentPhone.Text + "'", connString);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully");
                connString.Close();
                disData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connString.Open();
            cmd = new SqlCommand("delete from Agent where AgentID='" + txtAgentID.Text + "'", connString);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            connString.Close();
            disData();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            txtAgentID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtAgentName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtAgentAddress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtAgentPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }



        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtAgentID.Clear();
            txtAgentName.Clear();
            txtAgentAddress.Clear();
            txtAgentPhone.Clear();

            txtAgentID.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnRefesh.Enabled = false;
        }

        
    }
}
