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

namespace GestionMatosApplication
{
    public partial class FormAddClient : Form
    {

        private Client.ClientDataTable m_tblClient = new Client.ClientDataTable();
        
        private ClientTableAdapters.ClientTableAdapter m_adapterClient = new ClientTableAdapters.ClientTableAdapter();
        

        private string C_NomClient;
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

        
        private void ClientAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                C_NomClient = NomClientTextBox.Text;

                m_adapterClient.Insert(
                    C_NomClient.ToString());
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Client bien ajouté !");
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
