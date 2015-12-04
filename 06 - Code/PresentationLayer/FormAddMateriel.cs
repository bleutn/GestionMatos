using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatosApplication.GestionMatosDataSetTableAdapters;
using GestionMatosApplication;

namespace GestionMatosApplication
{
	public partial class FormAddMateriel : Form
	{
		private GestionMatosDataSet.ClientDataTable m_tblClient = new GestionMatosDataSet.ClientDataTable();
		private GestionMatosDataSet.Type_MaterielDataTable m_tblMaterielType = new GestionMatosDataSet.Type_MaterielDataTable();
		private GestionMatosDataSet.SiteDataTable m_tblSites = new GestionMatosDataSet.SiteDataTable();
		private GestionMatosDataSet.BatimentDataTable m_tblBatiments = new GestionMatosDataSet.BatimentDataTable();
		private GestionMatosDataSet.EtageDataTable m_tblEtage = new GestionMatosDataSet.EtageDataTable();
		private GestionMatosDataSet.SalleDataTable m_tblSalle = new GestionMatosDataSet.SalleDataTable();
		private GestionMatosDataSet.MaterielDataTable m_tblMaterial = new GestionMatosDataSet.MaterielDataTable();

		private ClientTableAdapter m_adapterClient = new ClientTableAdapter();
		private Type_MaterielTableAdapter m_adapterMaterielType = new Type_MaterielTableAdapter();
		private SiteTableAdapter m_adapterSite = new SiteTableAdapter();
		private BatimentTableAdapter m_adapterBatiment = new BatimentTableAdapter();
		private SalleTableAdapter m_adapterSalle = new SalleTableAdapter();
		private EtageTableAdapter m_adapterEtage = new EtageTableAdapter();
		private MaterielTableAdapter m_adapterMaterials = new MaterielTableAdapter();

		private List<ListItem> m_clientsList        = new List<ListItem>();
		private List<ListItem> m_materialtypesList = new List<ListItem>();
		private List<ListItem> m_sitesList = new List<ListItem>();
		private List<ListItem> m_batimentsList = new List<ListItem>();
		private List<ListItem> m_sallesList = new List<ListItem>();
		private List<ListItem> m_etagesList = new List<ListItem>();

		private static FormHomepage s_formHomepage;

        private string m_materialName;
        private Guid m_materialSerial;
        private int m_client_id;
        private int m_etage_id;
        private int m_materialtype_id;
        private string  m_description;
        private DateTime  m_intervention;
        private int m_mtbf;
		private int m_selectedSiteID = -1;
		private int m_selectedBatimentID = -1; 
		private int m_selectedEtageID = -1;
		private int m_selectedSalleID = -1;
		private int m_selectedClientID = -1;
		private int m_selectedTypeMtlID = -1;

		public FormAddMateriel(FormHomepage form)
		{
			s_formHomepage = form;
			InitializeComponent();
		}

        private void FillMTBF()
        {
			if (cmbMaterialType.SelectedIndex != -1 && m_materialtypesList.Count > cmbMaterialType.SelectedIndex)
            {
				int materialTypeIndex = m_materialtypesList[cmbMaterialType.SelectedIndex].ID;
				m_mtbf = m_tblMaterielType.FindByid_Type_Materiel(materialTypeIndex).MTBF;
				txbMTBF.Text = m_mtbf.ToString();

				FillLimitInterventionDate();
            }

        }

		private void FillLimitInterventionDate()
		{
			dateLimitIntervention.Value = DateTime.Today.AddDays((double)m_mtbf);
			dateLimitIntervention.Enabled = false;
			dateIntervention.MaxDate = dateLimitIntervention.Value;
			dateIntervention.MinDate = DateTime.Today;
		}

		private enum Item
		{
			CLIENT = 0,
			SITE,
			BATIMENT,
			ETAGE,
			SALLE,
			MATERIELTYPE
		}

		private void FillTable<A, T>(A adapter, T table)
		{ 
			MethodInfo methodInfo = typeof(A).GetMethod("Fill");
			if (methodInfo != null)
			{
				object[] data = new object[1];
				data[0] = table;
				methodInfo.Invoke((object)adapter, data);
			}
		}

		private void FillListItem<T, Row, Control>(T table, List<ListItem> list, Control control, string column1,
			string column2, Item item)
		{ 
			PropertyInfo rowsProperty = typeof(T).GetProperty("Rows");
			DataRowCollection rows = rowsProperty.GetValue(table) as DataRowCollection;
			if (rows.Count > 0)
			{
				foreach (Row row in rows)
				{
					PropertyInfo name = typeof(Row).GetProperty(column1);
					PropertyInfo id = typeof(Row).GetProperty(column2);
					switch (item)
					{
						case Item.BATIMENT:
							list.Add(new ListItem("Batiment n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
							break;
						case Item.ETAGE:
							list.Add(new ListItem("Etage n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
							break;
						case Item.SALLE:
							list.Add(new ListItem("Salle n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
							break;
						default:
							list.Add(new ListItem((string)name.GetValue(row), (int)id.GetValue(row)));
							break;
					}

				}

				PropertyInfo dataSource = typeof(Control).GetProperty("DataSource");
				if (dataSource != null)
				{
					dataSource.SetValue(control, list);
				}
			}
		}

		private void FillListItemCollection<Row, Control>(EnumerableRowCollection rows, List<ListItem> list, Control control, string column1, string column2, Item item)
		{
			foreach (Row row in rows)
			{
				PropertyInfo name = typeof(Row).GetProperty(column1);
				PropertyInfo id = typeof(Row).GetProperty(column2);
				switch (item)
				{
					case Item.BATIMENT:
						list.Add(new ListItem("Batiment n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
						break;
					case Item.ETAGE:
						list.Add(new ListItem("Etage n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
						break;
					case Item.SALLE:
						list.Add(new ListItem("Salle n°" + Convert.ToInt32(name.GetValue(row)), (int)id.GetValue(row)));
						break;
					default:
						list.Add(new ListItem((string)name.GetValue(row), (int)id.GetValue(row)));
						break;
				}

			}

			PropertyInfo dataSource = typeof(Control).GetProperty("DataSource");
			if (dataSource != null)
			{
				dataSource.SetValue(control, list);
			}
		}

		private void FillSelectedIndex<Control>(List<ListItem> list, Control control, int index)
		{
			PropertyInfo selectIdxProperty = typeof(Control).GetProperty("SelectedIndex");
			if (selectIdxProperty != null)
			{
				index = list[(int)selectIdxProperty.GetValue(control)].ID;
			}
		}

		protected void FillTables()
		{
			//fetch all entities data
			FillTable<ClientTableAdapter, GestionMatosDataSet.ClientDataTable>(m_adapterClient, m_tblClient);
			FillTable<Type_MaterielTableAdapter, GestionMatosDataSet.Type_MaterielDataTable>(m_adapterMaterielType, m_tblMaterielType);
			FillTable<SiteTableAdapter, GestionMatosDataSet.SiteDataTable>(m_adapterSite, m_tblSites);
			FillTable<BatimentTableAdapter, GestionMatosDataSet.BatimentDataTable>(m_adapterBatiment, m_tblBatiments);
			FillTable<EtageTableAdapter, GestionMatosDataSet.EtageDataTable>(m_adapterEtage, m_tblEtage);
			FillTable<SalleTableAdapter, GestionMatosDataSet.SalleDataTable>(m_adapterSalle, m_tblSalle);
		}

		protected void FetchClient()
		{
			m_clientsList.Clear();
			m_clientsList = new List<ListItem>();
			foreach (GestionMatosDataSet.ClientRow row in m_tblClient.Rows)
			{
				m_clientsList.Add(new ListItem(row.nom_Client, row.id_Client));
			}
			if (m_clientsList.Count > 0)
			{
				cmbClientName.DataSource = m_clientsList;
				cmbClientName.SelectedIndex = 0;
				m_selectedClientID = m_clientsList[cmbClientName.SelectedIndex].ID;
				return;
			}
			m_selectedClientID = -1;
			cmbClientName.DataSource = null;
		}

		protected void FetchMaterialTypes()
		{
			m_materialtypesList.Clear();
			m_materialtypesList = new List<ListItem>();
			foreach (GestionMatosDataSet.Type_MaterielRow row in m_tblMaterielType.Rows)
			{
				m_materialtypesList.Add(new ListItem(row.nom_Type_Materiel, row.id_Type_Materiel));
			}
			if (m_materialtypesList.Count > 0)
			{
				cmbMaterialType.DataSource = m_materialtypesList;
				cmbMaterialType.SelectedIndex = 0;
				m_selectedTypeMtlID = m_materialtypesList[cmbMaterialType.SelectedIndex].ID;
				return;
			}
			m_selectedTypeMtlID = -1;
			cmbMaterialType.DataSource = null;
		}

		protected void FetchBuildings()
		{
			m_batimentsList.Clear();
			m_batimentsList = new List<ListItem>();
			if (m_selectedSiteID != -1)
			{
				EnumerableRowCollection batimentRows = m_tblBatiments.Where(e => e.id_Site == m_selectedSiteID);
				foreach (GestionMatosDataSet.BatimentRow row in batimentRows)
				{
					m_batimentsList.Add(new ListItem("Batiment n°" + Convert.ToInt32(row.num_Batiment), row.id_Batiment));
				}
				if (m_batimentsList.Count > 0)
				{
					cmbBatiment.DataSource = m_batimentsList;
					cmbBatiment.SelectedIndex = 0;
					m_selectedBatimentID = m_batimentsList[cmbBatiment.SelectedIndex].ID;
					return;
				}
				m_selectedBatimentID = -1;
			}
			ClearBuildings();
		}

		protected void ClearSite()
		{
			cmbSite.DataSource = null;
			cmbSite.Items.Clear(); 
			ClearBuildings();
		}

		protected void ClearBuildings()
		{
			cmbBatiment.DataSource = null;
			cmbBatiment.Items.Clear(); 
			ClearFloors();
		}

		protected void ClearFloors()
		{
			cmbEtage.DataSource = null;
			cmbEtage.Items.Clear(); 
			ClearRooms();
		}

		protected void ClearRooms()
		{
			cmbSalle.DataSource = null;
			cmbSalle.Items.Clear(); 
		}

		protected void FetchSite()
		{
			m_sitesList.Clear();
			m_sitesList = new List<ListItem>();
			if (m_selectedClientID != -1)
			{
				EnumerableRowCollection sitesByClientID = m_tblBatiments.Where(b => b.id_Client == m_selectedClientID);

				foreach (GestionMatosDataSet.BatimentRow row in sitesByClientID)
				{
					GestionMatosDataSet.SiteRow siteRow = m_tblSites.Where(s => s.id_Site == row.id_Site).Single();
					m_sitesList.Add(new ListItem(siteRow.nom_Site, siteRow.id_Site));
				}
				if (m_sitesList.Count > 0)
				{
					m_sitesList.GroupBy(s => s.ID);
					cmbSite.DataSource = m_sitesList;
					cmbSite.SelectedIndex = 0;
					m_selectedSiteID = m_sitesList[cmbSite.SelectedIndex].ID;
					return;
				}
				m_selectedSiteID = -1;
				ClearSite();
			}
		}

		protected void FetchFloors()
		{
			m_etagesList.Clear();
			m_etagesList = new List<ListItem>();
			if (m_selectedBatimentID != -1)
			{
				EnumerableRowCollection etageRows = m_tblEtage.Where(e => e.id_Batiment == m_selectedBatimentID);
				foreach (GestionMatosDataSet.EtageRow row in etageRows)
				{
					m_etagesList.Add(new ListItem("Etage n°" + Convert.ToInt32(row.num_Etage), row.id_Etage));
				}
				if (m_etagesList.Count > 0)
				{
					cmbEtage.DataSource = m_etagesList;
					cmbEtage.SelectedIndex = 0;
					m_selectedEtageID = m_etagesList[cmbEtage.SelectedIndex].ID;
					return;
				}
				m_selectedEtageID = -1;
				ClearFloors();
			}
		}

		protected void FetchRooms()
		{
			m_sallesList.Clear();
			m_sallesList = new List<ListItem>();
			if (m_selectedEtageID != -1)
			{
				EnumerableRowCollection salleRows = m_tblSalle.Where(e => e.id_Etage == m_selectedEtageID);
				foreach (GestionMatosDataSet.SalleRow row in salleRows)
				{
					m_sallesList.Add(new ListItem(row.nom_Salle, row.id_Salle));
				}
				if (m_sallesList.Count > 0)
				{
					cmbSalle.DataSource = m_sallesList;
					cmbSalle.SelectedIndex = 0;
					m_selectedSalleID = m_sallesList[cmbSalle.SelectedIndex].ID;
					return;
				}
				m_selectedSalleID = -1;
				ClearRooms();
			}
		}

		protected void FillAddingIHM()
		{
			FillTables();
			FetchMaterialTypes();
			FetchClient();
		}

		private void FormAddMateriel_Load(object sender, EventArgs e)
		{
			try
			{
				FillAddingIHM();
			}
			catch (SqlException sqlex)
			{
				MessageBox.Show(sqlex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
			if ((ListItem)cmbClientName.SelectedItem != null)
			{
				try
				{
					m_selectedClientID = ((ListItem)cmbClientName.SelectedItem).ID;
					FetchSite();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
        }

        private void cmbMaterialType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
			FillMTBF();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient clientWindow = new FormAddClient();
            clientWindow.Show();
        }

        private void btnMaterialType_Click(object sender, EventArgs e)
        {
            FormAddTypeMateriel typeWindow = new FormAddTypeMateriel();
            typeWindow.Show();
        }

        private void btnAddEtage_Click(object sender, EventArgs e)
        {
			FormAddSite form = new FormAddSite();
			form.Show();
        }

		private bool ValidateMaterial()
		{
			bool CanValidate = true;
			string warningCaption = "Warning: ajout de matériel";
			string warningMsg = "";

			if (txbMaterialName.Text == null || txbMaterialName.Text == "")
			{
				CanValidate = false;
				warningMsg = "Le nom de matériel est non valide";
			}
			else if (cmbClientName.Items.Count > 0 && cmbClientName.SelectedIndex == -1)
			{
				CanValidate = false;
				warningMsg = "Selectionner un client valide";
			}
			else if (cmbMaterialType.SelectedIndex == -1)
			{
				CanValidate = false;
				warningMsg = "Selectionner un type de matériel";
			}
			else if (cmbSite.SelectedIndex == -1)
			{
				CanValidate = false;
				warningMsg = "Aucun site sélectionné - sélectionner un client associé à un site";
			}
			else if (m_selectedBatimentID == -1)
			{
				CanValidate = false;
				warningMsg = "Aucun batiment sélectionné - sélectionner un site associé à un batiment";
			}
			else if (m_selectedEtageID == -1)
			{
				CanValidate = false;
				warningMsg = "Aucun étage sélectionné - sélectionner un batiment associé à un étage";
			}
			else if (m_selectedSalleID == -1)
			{
				CanValidate = false;
				warningMsg = "Aucun salle sélectionnée - sélectionner un étage associé à une salle"; ;
			}
			
			if (!CanValidate)
			{
				MessageBox.Show(warningMsg, warningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return CanValidate;
		}

		private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
				if (ValidateMaterial())
				{
					m_materialName = txbMaterialName.Text;
					m_materialSerial = Guid.NewGuid();
					m_client_id = ((ListItem)cmbClientName.SelectedItem).ID;
					m_etage_id = ((ListItem)cmbSite.SelectedItem).ID;
					m_materialtype_id = ((ListItem)cmbMaterialType.SelectedItem).ID;
					m_description = txbDesc.Text;
					m_mtbf = Convert.ToInt32(txbMTBF.Text);
					m_intervention = dateLimitIntervention.Value;
					m_description = txbDesc.Text;

					m_adapterMaterials.Insert(
						m_materialName,
						m_materialSerial.ToString(),
						m_materialtype_id,
						m_client_id,
						m_selectedSiteID,
						m_selectedBatimentID,
						m_selectedEtageID,
						m_selectedSalleID,
						m_intervention,
						m_description);

					if (s_formHomepage != null)
					{
						s_formHomepage.RebindMaterials();
					}

					MessageBox.Show("Le matériel a bien été ajouté");

					Close();
				}
			}
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

		private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbSite.SelectedItem != null)
			{
				m_selectedSiteID = ((ListItem)cmbSite.SelectedItem).ID;
				FetchBuildings();
			}
		}

		private void cmbBatiment_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbBatiment.SelectedItem != null)
			{
				m_selectedBatimentID = ((ListItem)cmbBatiment.SelectedItem).ID;
				FetchFloors();
			}
		}

		private void cmbEtage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbEtage.SelectedItem != null)
			{
				m_selectedEtageID = ((ListItem)cmbEtage.SelectedItem).ID;
				FetchRooms();
			}
		}

		private void btnAddSalle_Click_1(object sender, EventArgs e)
		{
			FormAddSalle form = new FormAddSalle();
			form.Show();
		}

		private void FormAddMateriel_FormClosed(object sender, FormClosedEventArgs e)
		{
			s_formHomepage.addingMaterial = false;
		}

		private void btnAddBatiment_Click(object sender, EventArgs e)
		{
			FormAddBatiment form = new FormAddBatiment();
			form.Show();
		}

		private void btnAddEtage_Click_1(object sender, EventArgs e)
		{
			FormAddEtage form = new FormAddEtage();
			form.Show();
		}

	}
}
