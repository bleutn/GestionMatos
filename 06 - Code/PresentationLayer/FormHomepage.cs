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
using GestionMatosApplication.GestionMatosDataSetTableAdapters;
using GestionMatosApplication;



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
		private GestionMatosDataSet.MaterielDataTable m_tblMaterial = new GestionMatosDataSet.MaterielDataTable();
		private MaterielTableAdapter m_adapterMaterials = new MaterielTableAdapter();

		public bool addingMaterial = false;
		public bool updatingMaterial = false;

		private GestionMatosDataSet1.GetMaterialsRow m_selectedMaterial;

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
			// TODO: This line of code loads data into the 'gestionMatosDataSet1.GetMaterials' table. You can move, or remove it, as needed.
			this.getMaterialsTableAdapter.Fill(this.gestionMatosDataSet1.GetMaterials);
			// TODO: This line of code loads data into the 'gestionMatosDataSet2.GetMaterials' table. You can move, or remove it, as needed.
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
            FormAddMateriel materiel = new FormAddMateriel(this);
            materiel.Show();
        }

		private void materielBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
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
			//DataRowView dataRowView = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
			//GestionMatosDataSet2.MaterielRow materialRow = dataRowView.Row as GestionMatosDataSet2.MaterielRow;
			//if (materialRow != null)
			//{
			//	m_adapterClient.Fill(m_tblClient);
			//	m_adapterEtage.Fill(m_tblEtage);
			//	m_adapterMaterielType.Fill(m_tblMaterielType);
			//	int clientID = (int)materialRow["id_Client"];
			//	int etageID = (int)materialRow["id_Etage"];
			//	int typeMaterialID = (int)materialRow["id_type_Materiel"];
			//	GestionMatosDataSet.ClientRow clientData = m_tblClient.Where(item => item.id_Client == clientID).Single() as GestionMatosDataSet.ClientRow;
			//	GestionMatosDataSet.Type_MaterielRow typeMtlData = m_tblMaterielType.Where(item => item.id_Type_Materiel == typeMaterialID).Single() as GestionMatosDataSet.Type_MaterielRow;
			//	GestionMatosDataSet.EtageRow etageData = m_tblEtage.Where(item => item.id_Etage == etageID).Single() as GestionMatosDataSet.EtageRow;
			//	dataGridView1.Rows[e.RowIndex].Cells["idClientDataGridViewTextBoxColumn"].ValueType = "".GetType();
			//	dataGridView1.Rows[e.RowIndex].Cells["idClientDataGridViewTextBoxColumn"].Value = clientData.nom_Client;
			//	dataGridView1.Rows[e.RowIndex].Cells["idEtageDataGridViewTextBoxColumn"].Value = "Etage n°" + etageData.num_Etage.ToString();
			//	dataGridView1.Rows[e.RowIndex].Cells["idtypeMaterielDataGridViewTextBoxColumn"].Value = typeMtlData.nom_Type_Materiel;
			//}
		}

		private void getMaterialsBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{

		}

		private void add_Click_1(object sender, EventArgs e)
		{
			if (!addingMaterial && !updatingMaterial)
			{
				FormAddMateriel materiel = new FormAddMateriel(this);
				materiel.Show();
				addingMaterial = true;
			}

		}

		private void update_Click(object sender, EventArgs e)
		{
			//if (!updatingMaterial)
			{
				FormUpdateMateriel materiel = new FormUpdateMateriel(this, m_selectedMaterial);
				materiel.Show();
				updatingMaterial = true;
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			m_adapterMaterials.Fill(m_tblMaterial);
			GestionMatosDataSet.MaterielRow material = m_tblMaterial.FindByid_Materiel(m_selectedMaterial.id_Materiel);
			m_adapterMaterials.Delete(material.id_Materiel,
				material.nom_Materiel,
				material.guid_Materiel,
				material.id_type_Materiel,
				material.id_Client,
				material.id_Site,
				material.id_Batiment,
				material.id_Etage,
				material.id_Salle,
				material.date_dernier_Intervention,
				material.description);

			RebindMaterials();
		}

		public void RebindMaterials()
		{
			this.getMaterialsTableAdapter.Fill(this.gestionMatosDataSet1.GetMaterials);
			this.getMaterialsBindingSource.DataSource = this.gestionMatosDataSet1;
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				if (row != null)
				{
					DataRowView dataRowView = row.DataBoundItem as DataRowView;
					if (dataRowView != null)
					{
						GestionMatosDataSet1.GetMaterialsRow dataRow = (GestionMatosDataSet1.GetMaterialsRow)dataRowView.Row;
						if (dataRow != null)
						{
							m_selectedMaterial = dataRow;
						}
					}
				}
			}
		}
    }
}
