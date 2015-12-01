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
		private GestionMatosDataSet.ClientDataTable m_tblClient = new GestionMatosDataSet.ClientDataTable();
		private GestionMatosDataSet.EtageDataTable m_tblEtage = new GestionMatosDataSet.EtageDataTable();
		private GestionMatosDataSetTableAdapters.ClientTableAdapter m_adapterClient = new GestionMatosDataSetTableAdapters.ClientTableAdapter();
		private GestionMatosDataSetTableAdapters.EtageTableAdapter m_adapterEtage = new GestionMatosDataSetTableAdapters.EtageTableAdapter();
		private GestionMatosDataSet.Type_MaterielDataTable m_tblMaterielType = new GestionMatosDataSet.Type_MaterielDataTable();
		private GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter m_adapterMaterielType = new GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter();


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
			// TODO: This line of code loads data into the 'gestionMatosDataSet2.Materiel' table. You can move, or remove it, as needed.
			this.materielTableAdapter2.Fill(this.gestionMatosDataSet2.Materiel);
			// TODO: This line of code loads data into the 'gestionMatosDataSet11.Materiel' table. You can move, or remove it, as needed.
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

		private void materielBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.materielTableAdapter1.FillBy(this.gestionMatosDataSet1.Materiel);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{

		}

		private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			string typeMaterialName;
			string clientName;
			string etageStockage;

			string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
			if (cellValue.Contains('G') || cellValue.Contains('g'))
			{
				//dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "abc";
			}
		}
    }
}
