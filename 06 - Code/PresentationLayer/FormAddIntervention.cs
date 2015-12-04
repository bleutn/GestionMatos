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
		private GestionMatosDataSet.InterventionDataTable m_tblInterventions = new GestionMatosDataSet.InterventionDataTable();
		private GestionMatosDataSetTableAdapters.InterventionTableAdapter m_adapterIntervention = new InterventionTableAdapter();
		private GestionMatosDataSet3TableAdapters.GetInterventionsTableAdapter m_adapterInterventionView = new GestionMatosDataSet3TableAdapters.GetInterventionsTableAdapter();
		private GestionMatosDataSet3.GetInterventionsDataTable m_tblInterventionsView = new GestionMatosDataSet3.GetInterventionsDataTable();


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

        private Guid m_materialSerial;
        private int m_client_id;
        private int m_materialtype_id;
        private string  m_description;
        private DateTime  m_intervention;
        private int m_mtbf;
		private int m_selectedClientID = -1;
		private int m_selectedTypeMtlID = -1;
		private int m_selectedMaterialID = -1;

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
			FillTable<MaterielTableAdapter, GestionMatosDataSet.MaterielDataTable>(m_adapterMaterials, m_tblMaterial);

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

		protected void FetchMaterials()
		{
			EnumerableRowCollection materials = 
			m_tblMaterial.Where(m => m.id_Client == m_selectedClientID &&
				m.id_type_Materiel == m_selectedTypeMtlID);

			List<ListItem> listMaterials = new List<ListItem>();
			listMaterials.Clear();

			foreach (GestionMatosDataSet.MaterielRow row in materials)
			{
				listMaterials.Add(new ListItem(row.nom_Materiel, row.id_Materiel));
			}
			if (listMaterials.Count > 0)
			{
				cmbMaterial.DataSource = listMaterials;
				cmbMaterial.SelectedIndex = 0;
				m_selectedMaterialID = listMaterials[cmbMaterial.SelectedIndex].ID;
				return;
			}
			m_selectedMaterialID = -1;
			cmbMaterial.DataSource = null;
		}

		protected void FillAddingIHM()
		{
			FillTables();
			FetchClient();
			FetchMaterialTypes();
			FetchMaterials();
		}

		private void FormAddIntervention_Load(object sender, EventArgs e)
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
					m_adapterIntervention.Insert(m_selectedMaterialID,
						this.dateIntervention.Value,
						this.dateLimitIntervention.Value,
						this.txbDesc.Text,
						false);


					if (s_formHomepage != null)
					{
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

		private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbClientName.SelectedItem != null)
			{
				try
				{
					m_selectedClientID = ((ListItem)cmbClientName.SelectedItem).ID;
					FetchMaterials();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbMaterialType.SelectedItem != null)
			{
				m_selectedTypeMtlID = ((ListItem)cmbMaterialType.SelectedItem).ID;
				FetchMaterials();
				FillMTBF();
			}
		}

		private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((ListItem)cmbMaterial.SelectedItem != null)
			{
				m_selectedMaterialID = ((ListItem)cmbMaterial.SelectedItem).ID;
			}
		}
	}
}
