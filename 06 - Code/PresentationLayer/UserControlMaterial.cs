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
	public partial class UserControlMaterial : UserControl
	{
		public UserControlMaterial()
		{
			InitializeComponent();
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// UserControlMaterial
			// 
			this.Name = "UserControlMaterial";
			this.Size = new System.Drawing.Size(733, 483);
			this.ResumeLayout(false);

		}
	}
}
