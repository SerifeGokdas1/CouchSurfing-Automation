using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CouchSurfing
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void hOSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hosts go = new Hosts();
            go.Show();
            this.Hide();
        }

        private void gUESTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guests go = new Guests();
            go.Show();
            this.Hide();
        }

        private void cOUCHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Couchs go = new Couchs();
            go.Show();
            this.Hide();
        }
    }
}
