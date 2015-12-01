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
    public partial class FormHomepage : Form
    {
        public FormHomepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelect();
        }

        private void ClientSelect()
        {
            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            SqlDataReader drSQL = null;
            string strSQL;
            ListBox objListItem;
            string strID;

            try
            {

                objListItem = (ListBox)listClients.SelectedItem;
                if (objListItem == null)
                    return;

                strSQL = "SELECT id_Client, " +
                         "       nom_Client, " +
                         "FROM Client " +
                         "WHERE id_Client = " + objListItem.Name;

                cnSQL = new SqlConnection(FormHomepage.connString);
                cnSQL.Open();
                cmSQL = new SqlCommand(strSQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

               /* if (drSQL.Read())
                {
                    // Populate form with the data

                    tbProductID.Text = drSQL["ProductID"].ToString();
                    tbProdName.Text = drSQL["ProductName"].ToString();
                    tbQtyPerUnit.Text = drSQL["QuantityPerUnit"].ToString();
                    tbUPrice.Text = drSQL["UnitPrice"].ToString();
                    tbStock.Text = drSQL["UnitsInStock"].ToString();
                    tbUOnOrder.Text = drSQL["UnitsOnOrder"].ToString();
                    tbReOrder.Text = drSQL["ReorderLevel"].ToString();
                    cbDiscontinued.IsChecked = (bool)drSQL["Discontinued"];
                    strID = drSQL["SupplierID"].ToString();
                    FindItemByID(cbSuppliers, strID);
                    strID = drSQL["CategoryID"].ToString();
                    FindItemByID(cbCategories, strID);
                }*/

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "General Error");
            }
            finally
            {
                if (drSQL != null)
                    drSQL.Close();
                if (cnSQL != null)
                    cnSQL.Close();
                if (cmSQL != null)
                    cmSQL.Dispose();
                if (cnSQL != null)
                    cnSQL.Dispose();
            }
        }

        public static string connString { get; set; }

        private void add_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddClient();
            myForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'gestionMatosDataSet11.Materiel' table. You can move, or remove it, as needed.
			this.materielTableAdapter.Fill(this.gestionMatosDataSet11.Materiel);
            WindowState = FormWindowState.Maximized;
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAddMateriel materiel = new FormAddMateriel();
            materiel.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void créerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddClient();
            myForm.Show();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddSite();
            myForm.Show();
        }
    }
}
