using GestionMatosApplication.GestionMatosDataSetTableAdapters;
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

namespace GestionMatosApplication
{
	public partial class FormAddIntervention : Form
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

		public FormAddIntervention(FormHomepage form)
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

		private bool ValidateIntervention()
		{
			bool CanValidate = true;
			string warningCaption = "Warning: ajout de matériel";
			string warningMsg = "";

			if (cmbClientName.Items.Count > 0 && cmbClientName.SelectedIndex == -1)
			{
				CanValidate = false;
				warningMsg = "Selectionner un client valide";
			}
			else if (cmbMaterialType.SelectedIndex == -1)
			{
				CanValidate = false;
				warningMsg = "Selectionner un type de matériel";
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
				if (ValidateIntervention())
				{

					m_materialSerial = Guid.NewGuid();
					m_client_id = ((ListItem)cmbClientName.SelectedItem).ID;
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
						m_adapterMaterials.Fill(m_tblMaterial);
						s_formHomepage.RebindMaterials();
						s_formHomepage.AddIntervention(m_tblMaterial.FindByid_Materiel(m_tblMaterial.Last().id_Materiel));
						s_formHomepage.RebindInterventions();
					}

					MessageBox.Show("L'intervention a bien été ajoutée");

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
	}
}
