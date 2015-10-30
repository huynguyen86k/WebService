using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.WebServiceSoapClient sv = new ServiceReference1.WebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = sv.GetAllSP();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}