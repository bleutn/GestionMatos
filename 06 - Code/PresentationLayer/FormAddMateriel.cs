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
	public partial class FormAddMateriel : Form
	{
		private GestionMatosDataSet.ClientDataTable m_tblClient = new GestionMatosDataSet.ClientDataTable();
		private GestionMatosDataSet.Type_MaterielDataTable m_tblMaterielType = new GestionMatosDataSet.Type_MaterielDataTable();
		private GestionMatosDataSet.SiteDataTable m_tblSites = new GestionMatosDataSet.SiteDataTable();
		private GestionMatosDataSet.BatimentDataTable m_tblBatiments = new GestionMatosDataSet.BatimentDataTable();
		private GestionMatosDataSet.EtageDataTable m_tblEtage = new GestionMatosDataSet.EtageDataTable();
		private GestionMatosDataSet.SalleDataTable m_tblSalle = new GestionMatosDataSet.SalleDataTable();
		private GestionMatosDataSet.MaterielDataTable m_tblMaterial = new GestionMatosDataSet.MaterielDataTable();

		private GestionMatosDataSetTableAdapters.ClientTableAdapter m_adapterClient = new GestionMatosDataSetTableAdapters.ClientTableAdapter();
		private GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter m_adapterMaterielType = new GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter();
		private GestionMatosDataSetTableAdapters.SiteTableAdapter m_adapterSite = new GestionMatosDataSetTableAdapters.SiteTableAdapter();
		private GestionMatosDataSetTableAdapters.BatimentTableAdapter m_adapterBatiment = new GestionMatosDataSetTableAdapters.BatimentTableAdapter();
		private GestionMatosDataSetTableAdapters.SalleTableAdapter m_adapterSalle = new GestionMatosDataSetTableAdapters.SalleTableAdapter();
		private GestionMatosDataSetTableAdapters.EtageTableAdapter m_adapterEtage = new GestionMatosDataSetTableAdapters.EtageTableAdapter();
		private GestionMatosDataSetTableAdapters.MaterielTableAdapter m_adapterMaterials = new GestionMatosDataSetTableAdapters.MaterielTableAdapter();

		private List<ListItem> m_clientsList        = new List<ListItem>();
		private List<ListItem> m_materialtypesList = new List<ListItem>();
		private List<ListItem> m_sitesList = new List<ListItem>();
		private List<ListItem> m_batimentsList = new List<ListItem>();
		private List<ListItem> m_sallesList = new List<ListItem>();
		private List<ListItem> m_etagesList = new List<ListItem>();

        string      m_materialName;
        Guid        m_materialSerial;
        int         m_client_id;
        int         m_etage_id;
        int         m_materialtype_id;
        string      m_description;
        DateTime    m_intervention;
        int         m_mtbf;

		public FormAddMateriel()
		{
			InitializeComponent();
		}

        private void FillMTBF()
        { 
            if (cmbMaterialType.SelectedIndex != -1)
            {
				int materialTypeIndex = m_materialtypesList[cmbMaterialType.SelectedIndex].ID;
				m_mtbf = m_tblMaterielType.FindByid_Type_Materiel(materialTypeIndex).MTBF;
				txbMTBF.Text = m_mtbf.ToString();
            }

        }

		private void Fill<A, T, Row, Control>(A adapter, T table, List<ListItem> list, Control control, string column1,
			string column2)
		{
			MethodInfo methodInfo = typeof(A).GetMethod("Fill");
			if (methodInfo != null)
			{
				object[] data = new object[1];
				data[0] = table;
				methodInfo.Invoke((object)adapter, data);

				PropertyInfo rowsProperty = typeof(T).GetProperty("Rows");
				DataRowCollection rows = rowsProperty.GetValue(table) as DataRowCollection;
				foreach (Row row in rows)
				{
					PropertyInfo name = typeof(Row).GetProperty(column1);
					PropertyInfo id = typeof(Row).GetProperty(column2);
					list.Add(new ListItem((string)name.GetValue(row), (int)id.GetValue(row)));
				}

				PropertyInfo dataSource = typeof(Control).GetProperty("DataSource");
				if (dataSource != null)
				{
					dataSource.SetValue(control,list);
				}
			}
		}

		private void FormAddMateriel_Load(object sender, EventArgs e)
		{
			try
			{
				Fill<GestionMatosDataSetTableAdapters.ClientTableAdapter,
					GestionMatosDataSet.ClientDataTable, 
					GestionMatosDataSet.ClientRow, 
					ComboBox>(m_adapterClient,
								m_tblClient, 
								m_clientsList, 
								cmbClientName, 
								"nom_Client", 
								"id_Client");

				Fill<GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter,
					GestionMatosDataSet.Type_MaterielDataTable,
					GestionMatosDataSet.Type_MaterielRow,
					ComboBox>(m_adapterMaterielType,
								m_tblMaterielType,
								m_materialtypesList,
								cmbMaterialType,
								"nom_Type_Materiel",
								"id_Type_Materiel");

				Fill<GestionMatosDataSetTableAdapters.SiteTableAdapter,
						GestionMatosDataSet.SiteDataTable,
						GestionMatosDataSet.SiteRow,
						ComboBox>(m_adapterSite,
									m_tblSites,
									m_sitesList,
									cmbSite,
									"nom_Site",
									"id_Site");

				Fill<GestionMatosDataSetTableAdapters.BatimentTableAdapter,
						GestionMatosDataSet.BatimentDataTable,
						GestionMatosDataSet.BatimentRow,
						ComboBox>(m_adapterBatiment,
									m_tblBatiments,
									m_batimentsList,
									cmbBatiment,
									"nom_Batiment",
									"id_Batiment");

				Fill<GestionMatosDataSetTableAdapters.EtageTableAdapter,
						GestionMatosDataSet.EtageDataTable,
						GestionMatosDataSet.EtageRow,
						ComboBox>(m_adapterEtage,
									m_tblEtage,
									m_etagesList,
									cmbEtage,
									"nom_Etage",
									"id_Etage");

				Fill<GestionMatosDataSetTableAdapters.SalleTableAdapter,
						GestionMatosDataSet.SalleDataTable,
						GestionMatosDataSet.SalleRow,
						ComboBox>(m_adapterSalle,
									m_tblSalle,
									m_sallesList,
									cmbSalle,
									"nom_Salle",
									"id_Salle");
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

        }

        private void cmbMaterialType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
			FillMTBF();
        }

        private void cmbEtage_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string materialName;
            Guid materialSerial;
            int client_id;
            int etage_id;
            int materialtype_id;
            string description;
            DateTime intervention;
            int mtbf;

            try
            {
                materialName = txbMaterialName.Text;
				materialSerial = Guid.NewGuid();
                client_id = ((ListItem)cmbClientName.SelectedItem).ID;
                etage_id = ((ListItem)cmbSite.SelectedItem).ID;
                materialtype_id = ((ListItem)cmbMaterialType.SelectedItem).ID;
                description = txbDesc.Text;
                mtbf = Convert.ToInt32(txbMTBF.Text);

                GestionMatosDataSet.MaterielRow inserted_data = m_tblMaterial.NewMaterielRow();
				inserted_data.id_Client = client_id;
				inserted_data.id_Etage = etage_id;
				inserted_data.id_type_Materiel = materialtype_id;
				inserted_data.date_dernier_Intervention = dateIntervention.Value;
				inserted_data.guid_Materiel = materialSerial.ToString();

				m_tblMaterial.ImportRow(inserted_data);
                m_tblMaterial.AcceptChanges();
				m_adapterMaterials.Insert(1,
					materialSerial.ToString(),
					materialtype_id,
					client_id,
					etage_id,
					dateIntervention.Value);
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
