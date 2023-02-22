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
using PU.CouchSurfing;
using PU.CouchSurfing.Entity;
using PU.CouchSurfing.Facede;


namespace CouchSurfing
{
    public partial class Couchs : Form
    {
        public Couchs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Couchs_Load(object sender, EventArgs e)
        {
            Tools.Connect.Open();
            SqlCommand select = new SqlCommand("Select * from Couchs", Tools.Connect);
            SqlDataReader dr;
            dr = select.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CouchId"]);
            }
            Tools.Connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void List()
        {
            dataGridView1.DataSource = FHosts.List();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ECouchs add = new ECouchs();
            add.CouchAddress = textBox4.Text;
            add.HostId = Convert.ToInt32(textBox3.Text);
            if (!ECouchs.Add(add))
            {
                MessageBox.Show("Couch Information could not be added. Please try again!");
            }
            List();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ECouchs update = new ECouchs();
            update.CouchAddress = textBox4.Text;
            update.HostId = Convert.ToInt32(textBox3.Text);
            if (!ECouchs.Update(update))
            {
                MessageBox.Show("Couch Information could not be updated. Please try again!");
            }
            List();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ECouchs delete = new ECouchs();
            delete.CouchId = Convert.ToInt32(textBox4.Tag);
            if (!ECouchs.Delete(delete))
            {
                MessageBox.Show("Couch Information could not be deleted. Please try again!");
            }
            List();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ECouchs search = new ECouchs();
            search.CouchId = Convert.ToInt32(comboBox1.Text);
            List();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }
    }
}
