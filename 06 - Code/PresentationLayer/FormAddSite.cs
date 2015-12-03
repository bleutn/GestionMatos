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
    public partial class FormAddSite : Form
    {
        private Site.SiteDataTable m_tblSites = new Site.SiteDataTable();

        private SiteTableAdapters.SiteTableAdapter m_adapterSite = new SiteTableAdapters.SiteTableAdapter();
        private string s_adressesite;
        private string s_namesite;

        public FormAddSite()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AjouterSiteButton_Click(object sender, EventArgs e)
        {
            try
            {
                s_namesite = NomSiteTextBox.Text;
                s_adressesite = AdresseSiteTextBox.Text;

                m_adapterSite.Insert(
                    s_namesite.ToString(),
                    s_adressesite.ToString());
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
