using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_InicioSesion : System.Web.UI.Page
{




    protected void B_Registrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registrar.aspx");
    }
}