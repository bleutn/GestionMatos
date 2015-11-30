using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatosApplication
{
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Batiment' table. You can move, or remove it, as needed.
            this.batimentTableAdapter.Fill(this.gestionMatosDataSet.Batiment);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.gestionMatosDataSet.Site);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.gestionMatosDataSet.Site);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.gestionMatosDataSet.Site);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.gestionMatosDataSet.Site);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.gestionMatosDataSet.Site);

        }

        private void siteBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddSite();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddBatiment();
            myForm.Show();
        }
    }
}
