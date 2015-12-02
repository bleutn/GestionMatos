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

		public bool modifying = false;

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

		public FormAddMateriel()
		{
			InitializeComponent();
		}

        private void FillMTBF()
        {
			if (cmbMaterialType.SelectedIndex != -1 && m_materialtypesList.Count > cmbMaterialType.SelectedIndex)
            {
				int materialTypeIndex = m_materialtypesList[cmbMaterialType.SelectedIndex].ID;
				m_mtbf = m_tblMaterielType.FindByid_Type_Materiel(materialTypeIndex).MTBF;
				txbMTBF.Text = m_mtbf.ToString();
            }

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

		protected void SelectClient()
		{
			m_selectedClientID = m_clientsList.Count > cmbClientName.SelectedIndex ? 
				m_clientsList[cmbClientName.SelectedIndex].ID : -1;
		}

		protected void SelectMtlType()
		{
			m_selectedTypeMtlID = m_materialtypesList.Count > cmbMaterialType.SelectedIndex ? 
				m_materialtypesList[cmbMaterialType.SelectedIndex].ID : -1; 
		}

		protected void SelectBuilding()
		{
			m_selectedBatimentID = m_batimentsList.Count > cmbBatiment.SelectedIndex ?
				m_batimentsList[cmbBatiment.SelectedIndex].ID : -1;
		}

		protected void SelectSite()
		{
			m_selectedSiteID = m_sitesList.Count >cmbSite.SelectedIndex ?
				m_sitesList[cmbSite.SelectedIndex].ID : -1;
		}

		protected void SelectFloor()
		{
			m_selectedEtageID = m_etagesList.Count > cmbEtage.SelectedIndex ?
				m_etagesList[cmbEtage.SelectedIndex].ID : -1;
		}

		protected void SelectRoom()
		{
			m_selectedSalleID = m_sallesList.Count > cmbSalle.SelectedIndex? 
				m_sallesList[cmbSalle.SelectedIndex].ID : -1;
		}

		protected void FetchClient()
		{
			m_clientsList.Clear();
			m_clientsList = new List<ListItem>();
			foreach (GestionMatosDataSet.ClientRow row in m_tblClient.Rows)
			{
				m_clientsList.Add(new ListItem(row.nom_Client, row.id_Client));
			}
			cmbClientName.DataSource = m_clientsList;
			cmbClientName.SelectedIndex = 0;
			m_selectedClientID = m_clientsList[cmbClientName.SelectedIndex].ID;
		}

		protected void FetchMaterialTypes()
		{
			FillListItem<GestionMatosDataSet.Type_MaterielDataTable, GestionMatosDataSet.Type_MaterielRow, ComboBox>(m_tblMaterielType, m_materialtypesList, cmbMaterialType, "nom_Type_Materiel", "id_Type_Materiel", Item.MATERIELTYPE);
			cmbMaterialType.SelectedIndex = 0;
			SelectMtlType();
		}

		protected void FetchBuildings()
		{
			m_batimentsList.Clear();
			m_batimentsList = new List<ListItem>();
			EnumerableRowCollection batimentRows = m_tblBatiments.Where(e => e.id_Site == m_selectedSiteID);
			foreach (GestionMatosDataSet.BatimentRow row in batimentRows)
			{
				m_batimentsList.Add(new ListItem("Batiment n°" + Convert.ToInt32(row.num_Batiment), row.id_Batiment));
			}
			cmbBatiment.DataSource = m_batimentsList;
			cmbBatiment.SelectedIndex = 0;
			m_selectedBatimentID = m_batimentsList[cmbBatiment.SelectedIndex].ID;
		}

		protected void FetchSite()
		{
			m_sitesList.Clear();
			m_sitesList = new List<ListItem>();
			EnumerableRowCollection sitesByClientID = m_tblBatiments.Where(b => b.id_Client == m_selectedClientID);

			foreach (GestionMatosDataSet.BatimentRow row in sitesByClientID)
			{
				GestionMatosDataSet.SiteRow siteRow = m_tblSites.Where(s => s.id_Site == row.id_Site).Single();
				m_sitesList.Add(new ListItem(siteRow.nom_Site, siteRow.id_Site));
			}
			m_sitesList.GroupBy(s => s.ID);
			cmbSite.DataSource = m_sitesList;
			cmbSite.SelectedIndex = 0;
			m_selectedSiteID = m_sitesList[cmbSite.SelectedIndex].ID;
		}

		protected void FetchFloors()
		{
			m_etagesList.Clear();
			m_etagesList = new List<ListItem>();
			EnumerableRowCollection etageRows = m_tblEtage.Where(e => e.id_Batiment == m_selectedBatimentID);
			foreach (GestionMatosDataSet.EtageRow row in etageRows)
			{
				m_etagesList.Add(new ListItem("Etage n°" + Convert.ToInt32(row.num_Etage), row.id_Etage));
			}
			cmbEtage.DataSource = m_etagesList;
			cmbEtage.SelectedIndex = 0;
			m_selectedEtageID = m_etagesList[cmbEtage.SelectedIndex].ID;
		}

		protected void FetchRooms()
		{
			m_sallesList.Clear();
			m_sallesList = new List<ListItem>();
			EnumerableRowCollection salleRows = m_tblSalle.Where(e => e.id_Etage == m_selectedEtageID);
			foreach (GestionMatosDataSet.SalleRow row in salleRows)
			{
				m_sallesList.Add(new ListItem(row.nom_Salle, row.id_Salle));
			}
			cmbSalle.DataSource = m_sallesList;
			cmbSalle.SelectedIndex = 0;
			m_selectedSalleID = m_sallesList[cmbSalle.SelectedIndex].ID;
		}

		protected void FillAddingIHM()
		{
			FillTables();
			FetchMaterialTypes();
			FetchClient();
		}
		
		protected void FillModifyingIHM()
		{ 
			
		}

		private void FormAddMateriel_Load(object sender, EventArgs e)
		{
			try
			{
				if (modifying)
				{
					FillModifyingIHM();
				}
				else
				{
					FillAddingIHM();
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

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
			m_selectedClientID = ((ListItem)cmbClientName.SelectedItem).ID;
			FetchSite();
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_materialName = txbMaterialName.Text;
				m_materialSerial = Guid.NewGuid();
                m_client_id = ((ListItem)cmbClientName.SelectedItem).ID;
                m_etage_id = ((ListItem)cmbSite.SelectedItem).ID;
                m_materialtype_id = ((ListItem)cmbMaterialType.SelectedItem).ID;
                m_description = txbDesc.Text;
                m_mtbf = Convert.ToInt32(txbMTBF.Text);
				m_intervention = dateIntervention.Value;

				m_adapterMaterials.Insert(
					m_materialSerial.ToString(),
					m_materialtype_id,
					m_client_id,
					m_etage_id,
					m_intervention);

				Close();
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
			m_selectedSiteID = ((ListItem)cmbSite.SelectedItem).ID;
			FetchBuildings();
		}

		private void cmbBatiment_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_selectedBatimentID = ((ListItem)cmbBatiment.SelectedItem).ID;
			FetchFloors();
		}

		private void cmbEtage_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_selectedEtageID = ((ListItem)cmbEtage.SelectedItem).ID;
			FetchRooms();
		}
	}
}
