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
    public partial class FormAddTypeMateriel : Form
    {

        private TypeMaterial.Type_MaterielDataTable m_tblMaterielType = new TypeMaterial.Type_MaterielDataTable();

        private TypeMaterialTableAdapters.Type_MaterielTableAdapter m_adapterMaterielType = new TypeMaterialTableAdapters.Type_MaterielTableAdapter();
        private string Ty_TypeMaterial;
        private string Ty_MTBF;


        public FormAddTypeMateriel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeMatAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ty_TypeMaterial = TypeMatTextBox.Text;
                Ty_MTBF = MTBFTextBox.Text;

                m_adapterMaterielType.Insert(
                    Ty_TypeMaterial.ToString(),
                    Convert.ToInt32(Ty_MTBF));
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void TypeMatCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
