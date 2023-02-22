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
using PU.CouchSurfing.Entity;
using PU.CouchSurfing.Facede;
using PU.CouchSurfing;

namespace CouchSurfing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EStaffs add = new EStaffs();
            add.StaffNameSurname = textBox4.Text;
            add.StaffPassword = textBox3.Text;
            add.StaffMail = textBox5.Text;
            add.StaffPhone = Convert.ToInt32(textBox6.Text);
            if (!FStaffs.Add(add))
            {
                MessageBox.Show("Personnel Information could not be added. Please try again!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Visible = false ;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Tools.Connect.Open();
             SqlCommand command = new SqlCommand("Select * from Staffs where StaffNameSurname=@StaffNameSurname " +
                 "and StaffPassword=@StaffPassword", Tools.Connect);
             command.Parameters.AddWithValue("@StaffNameSurname", textBox1.Text);
             command.Parameters.AddWithValue("@StaffPassword", textBox2.Text);
             SqlDataReader dr = command.ExecuteReader();
             if (dr.Read())
             {
                 MessageBox.Show("Login successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 HomePage go = new HomePage();
                 go.Show();
                 this.Hide();
             } else
             {
                 MessageBox.Show("Staff name, surname or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
            Tools.Connect.Close();
        }
    }
}
