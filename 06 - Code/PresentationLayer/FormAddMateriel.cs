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
	public partial class FormAddMateriel : Form
	{
		private GestionMatosDataSet.Type_MaterielDataTable m_tblMaterielType = new GestionMatosDataSet.Type_MaterielDataTable();
		private GestionMatosDataSet.ClientDataTable m_tblClient = new GestionMatosDataSet.ClientDataTable();
		private GestionMatosDataSet.EtageDataTable m_tblEtage = new GestionMatosDataSet.EtageDataTable();
		private GestionMatosDataSet.MaterielDataTable m_tblMaterial = new GestionMatosDataSet.MaterielDataTable();

		private GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter m_adapterMaterielType = new GestionMatosDataSetTableAdapters.Type_MaterielTableAdapter();
		private GestionMatosDataSetTableAdapters.ClientTableAdapter m_adapterClient = new GestionMatosDataSetTableAdapters.ClientTableAdapter();
		private GestionMatosDataSetTableAdapters.EtageTableAdapter m_adapterEtage = new GestionMatosDataSetTableAdapters.EtageTableAdapter();
		private GestionMatosDataSetTableAdapters.MaterielTableAdapter m_adapterMaterials = new GestionMatosDataSetTableAdapters.MaterielTableAdapter();

		private List<ListItem> m_clients = new List<ListItem>();
		private List<ListItem> m_etages = new List<ListItem>();
		private List<ListItem> m_types = new List<ListItem>();
		private List<ListItem> m_materialtypes = new List<ListItem>();

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
				int materialTypeIndex = m_types[cmbMaterialType.SelectedIndex].ID;
				m_mtbf = m_tblMaterielType.FindByid_Type_Materiel(materialTypeIndex).MTBF;
				txbMTBF.Text = m_mtbf.ToString();
            }

        }

		private void FillClients()
		{
			m_adapterClient.Fill(m_tblClient);

			foreach (GestionMatosDataSet.ClientRow row in m_tblClient.Rows)
			{
				m_clients.Add(new ListItem(row.nom_Client, row.id_Client));
			}

			cmbClientName.DataSource = m_clients;
		}

		private void FillRooms()
		{
			m_adapterEtage.Fill(m_tblEtage);

			foreach (GestionMatosDataSet.EtageRow row in m_tblEtage.Rows)
			{
				m_etages.Add(new ListItem("Etage " + row.num_Etage.ToString(), row.id_Etage));
			}

			cmbEtage.DataSource = m_etages;
		}

		private void FillMaterialTypes()
		{
			m_adapterMaterielType.Fill(m_tblMaterielType);

			foreach (GestionMatosDataSet.Type_MaterielRow row in m_tblMaterielType.Rows)
			{
				m_types.Add(new ListItem(row.nom_Type_Materiel, row.id_Type_Materiel));
			}

			cmbMaterialType.DataSource = m_types;
		}

		private void FormAddMateriel_Load(object sender, EventArgs e)
		{
			try
			{
				FillClients();
				FillRooms();
				FillMaterialTypes();
				FillMTBF();
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
                etage_id = ((ListItem)cmbEtage.SelectedItem).ID;
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
