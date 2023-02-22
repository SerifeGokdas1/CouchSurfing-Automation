using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PU.CouchSurfing;
using PU.CouchSurfing.Entity;
using PU.CouchSurfing.Facede;

namespace CouchSurfing
{
    public partial class Hosts : Form
    {
        public Hosts()
        {
            InitializeComponent();
        }

        private void Hosts_Load(object sender, EventArgs e)
        {

            Tools.Connect.Open();
            SqlCommand select = new SqlCommand("Select * from Hosts", Tools.Connect);
            SqlDataReader dr;
            dr = select.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["HostNameSurname"]);
            }
            Tools.Connect.Close();
        }
        public void List()
        {
            dataGridView1.DataSource = FHosts.List();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EHosts add = new EHosts();
            add.HostNameSurname = textBox4.Text;
            add.HostPhone =Convert.ToInt32( textBox3.Text);
            add.HostMail = textBox5.Text;
            add.HostAddress = textBox6.Text;
            add.HostAcceptGuests = textBox1.Text;
            if (!FHosts.Add(add))
            {
                MessageBox.Show("Host Information could not be added. Please try again!");
            }
            List();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EHosts update = new EHosts();
            update.HostId = Convert.ToInt32(textBox4.Tag);
            update.HostNameSurname = textBox4.Text;
            update.HostPhone = Convert.ToInt32(textBox3.Text);
            update.HostMail = textBox5.Text;
            update.HostAddress = textBox6.Text;
            update.HostAcceptGuests = textBox1.Text;
            if (!FHosts.Update(update))
            {
                MessageBox.Show("Host Information could not be updated. Please try again!");
            }
            List();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EHosts delete= new EHosts();
            delete.HostId = Convert.ToInt32(textBox4.Tag);
            if (!FHosts.Delete(delete))
            {
                MessageBox.Show("Host Information could not be deleted. Please try again!");
            }
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            textBox4.Tag = line.Cells["HostId"].Value.ToString();
            textBox4.Text = line.Cells["HostNameSurname"].Value.ToString();
            textBox3.Text = line.Cells["HostPhone"].Value.ToString();
            textBox5.Text = line.Cells["HostMail"].Value.ToString();
            textBox6.Text = line.Cells["HostAddress"].Value.ToString();
            textBox1.Text = line.Cells["HostAcceptGuests"].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EHosts search = new EHosts();
            search.HostNameSurname = comboBox1.Text;
            List();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
