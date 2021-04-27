using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Inicio : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_InicioSesion_Click(object sender, EventArgs e)
    {
        Response.Redirect("InicioSesion.aspx");
    }
}
