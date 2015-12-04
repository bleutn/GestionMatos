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
		private GestionMatosDataSet.InterventionDataTable m_tblInterventions = new GestionMatosDataSet.InterventionDataTable();
		private GestionMatosDataSetTableAdapters.InterventionTableAdapter m_adapterIntervention = new InterventionTableAdapter();
		private GestionMatosDataSet3TableAdapters.GetInterventionsTableAdapter m_adapterInterventionView = new GestionMatosDataSet3TableAdapters.GetInterventionsTableAdapter();
		private GestionMatosDataSet3.GetInterventionsDataTable m_tblInterventionsView = new GestionMatosDataSet3.GetInterventionsDataTable();

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
        }

        public static string connString { get; set; }

        private void add_Click(object sender, EventArgs e)
        {
            var myForm = new FormAddClient();
            myForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'gestionMatosDataSet3.GetInterventions' table. You can move, or remove it, as needed.
			this.getInterventionsTableAdapter.Fill(this.gestionMatosDataSet3.GetInterventions);
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
            FormAddIntervention materiel = new FormAddIntervention(this);
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

		private void AddMaterial()
		{
			if (!addingMaterial)
			{
				(new FormAddMateriel(this)).Show();
				addingMaterial = true;
			}
		}

		private void AddIntervention()
		{
			(new FormAddIntervention(this)).Show();
		}

		private void AddClient()
		{
			(new FormAddClient()).Show();
		}

		private void AddSite()
		{
			(new FormAddSite()).Show();
		}

		private void UpdateMaterial()
		{
			if (!updatingMaterial && m_selectedMaterial!= null)
			{
				(new FormUpdateMateriel(this, m_selectedMaterial)).Show();
				updatingMaterial = true;
			}
		}

		private void UpdateIntervention()
		{
			//(new FormUpdateIntervention()).Show();
		}

		private void UpdateClient()
		{
			//(new FormUpdateClient()).Show();
		}

		private void UpdateSite()
		{
			//(new FormUpdateSite()).Show();
		}

		private void add_Click_1(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedIndex)
			{ 
				case 0:	AddMaterial();					break;
				case 4: AddSite(); break;
				case 1: AddIntervention(); break;
				case 3: AddClient(); break;
				default: break;
			
			}
		}

		private void update_Click(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedIndex)
			{
				case 0: UpdateMaterial(); break;
				case 4: UpdateSite(); break;
				case 1: UpdateIntervention(); break;
				case 3: UpdateClient(); break;
				default: break;
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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Client_Click(object sender, EventArgs e)
		{

		}

		public void AddIntervention(GestionMatosDataSet.MaterielRow material)
		{
			try
			{
				m_adapterIntervention.Insert(material.id_Materiel,
					material.date_dernier_Intervention,
					null,
					"Prochaine intervention prévue le " + material.date_dernier_Intervention.ToString() +
					" sur matériel " + material.nom_Materiel + "(" + material.guid_Materiel + ")",
					false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void RebindInterventions()
		{
			this.getInterventionsTableAdapter.Fill(this.gestionMatosDataSet3.GetInterventions);
			this.getInterventionsBindingSource.DataSource = this.gestionMatosDataSet3;
		}
    }
}
