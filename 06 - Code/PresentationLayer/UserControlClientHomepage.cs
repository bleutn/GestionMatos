using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatosApplication.GestionMatosDataSetTableAdapters;
using GestionMatosApplication;
using System.Reflection;

namespace GestionMatosApplication
{
	public partial class UserControlClientHomepage : UserControl
	{
		private GestionMatosDataSet.ClientDataTable m_tblClient = new GestionMatosDataSet.ClientDataTable();
		private ClientTableAdapter m_adapterClient = new ClientTableAdapter();
		private List<ListItem> m_clientsList = new List<ListItem>();
		private int m_selectedClientID = -1;

		public UserControlClientHomepage()
		{
			InitializeComponent();
		}

		private void UserControlClientHomepage_Load(object sender, EventArgs e)
		{
			FetchClient();
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

		protected void FetchClient()
		{
			FillTable<ClientTableAdapter, GestionMatosDataSet.ClientDataTable>(m_adapterClient, m_tblClient);

			m_clientsList.Clear();
			m_clientsList = new List<ListItem>();
			foreach (GestionMatosDataSet.ClientRow row in m_tblClient.Rows)
			{
				m_clientsList.Add(new ListItem(row.nom_Client, row.id_Client));
			}
			if (m_clientsList.Count > 0)
			{
				listBox1.DataSource = m_clientsList;
				listBox1.SelectedIndex = 0;
				m_selectedClientID = m_clientsList[listBox1.SelectedIndex].ID;
				return;
			}
			m_selectedClientID = -1;
			listBox1.DataSource = null;
		}
	}
}
