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
    public class ListItem
    { 
	    private string m_name;
	    private int m_id;

        public ListItem()
        {
            m_name = "";
            m_id = -1;
        }

	    public ListItem(string name, int id)
	    {
            m_name = name;
            m_id = id;
	    }

	    public string Name {   get  {  return m_name;   }  set { m_name = value; }  }
	    public int ID {   get  {  return m_id;   }  set { m_id = value; }  }

	    public override string ToString()
	    {
		     return m_name;
	    }
    }

}