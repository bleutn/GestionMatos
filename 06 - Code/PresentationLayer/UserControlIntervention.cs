using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatosApplication
{
	public partial class UserControlIntervention : UserControl
	{
		private GestionMatosDataSet.InterventionDataTable m_tblIntervention = new GestionMatosDataSet.InterventionDataTable();
		private GestionMatosDataSetTableAdapters.InterventionTableAdapter m_adapterIntervention = new GestionMatosDataSetTableAdapters.InterventionTableAdapter();


		public UserControlIntervention()
		{
			InitializeComponent();
		}

		public void AddIntervention(GestionMatosDataSet.MaterielRow material)
		{
			//this.interventionTableAdapter.Insert();
		}

		private void UserControlIntervention_Load(object sender, EventArgs e)
		{
			RebindInterventions();
		}

		public void RebindInterventions()
		{
			this.interventionTableAdapter.Fill(this.gestionMatosIntervention.Intervention);
			this.interventionBindingSource.DataSource = this.gestionMatosIntervention;
		}
	}
}
