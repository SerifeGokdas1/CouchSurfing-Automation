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
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EGuests add = new EGuests();
            add.HostId = Convert.ToInt32(textBox2.Text);
            add.GuestNameSurname = textBox4.Text;
            add.GuestPhone = Convert.ToInt32(textBox3.Text);
            add.GuestMail = textBox5.Text;
            add.GuestAddress = textBox6.Text;
            add.GuestGoTo = textBox1.Text;
            if (!FGuests.Add(add))
            {
                MessageBox.Show("Host Information could not be added. Please try again!");
            }
            List();
        }

        private void Guests_Load(object sender, EventArgs e)
        {

            Tools.Connect.Open();
            SqlCommand select = new SqlCommand("Select * from Guests", Tools.Connect);
            SqlDataReader dr;
            dr = select.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GuestNameSurname"]);
            }
            Tools.Connect.Close();
        }
        public void List()
        {
            dataGridView1.DataSource = FGuests.List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EGuests update = new EGuests();
            update.GuestId = Convert.ToInt32(textBox2.Tag);
            update.HostId = Convert.ToInt32(textBox2.Text);
            update.GuestNameSurname = textBox4.Text;
            update.GuestPhone = Convert.ToInt32(textBox3.Text);
            update.GuestMail = textBox5.Text;
            update.GuestAddress = textBox6.Text;
            update.GuestGoTo = textBox1.Text;
            if (!FGuests.Update(update))
            {
                MessageBox.Show("Host Information could not be updated. Please try again!");
            }
            List();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EGuests delete = new EGuests();
            delete.GuestId = Convert.ToInt32(textBox2.Tag);
            if (!FGuests.Delete(delete))
            {
                MessageBox.Show("Host Information could not be deleted. Please try again!");
            }
            List();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EGuests search = new EGuests();
            search.GuestNameSurname = comboBox1.Text;
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            textBox2.Tag = line.Cells["GuestId"].Value.ToString();
            textBox2.Text = line.Cells["HostId"].Value.ToString();
            textBox4.Text = line.Cells["GuestNameSurname"].Value.ToString();
            textBox3.Text = line.Cells["GuestPhone"].Value.ToString();
            textBox5.Text = line.Cells["GuestMail"].Value.ToString();
            textBox6.Text = line.Cells["GuestAddress"].Value.ToString();
            textBox1.Text = line.Cells["GuestGoTo"].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage go=new HomePage();
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
