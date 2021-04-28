using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        EUsuario user = new EUsuario();
        user.UserName = LN_Principal.
        user.Clave =

        user = new DAOUsuario().login(user);

        if (user != null)
        {
            Session["user"] = user;
            switch (user.RolId)
            {
                case 1:
                    Response.Redirect("Administrador.aspx");
                    break;
                case 2:
                    Response.Redirect("Agricultor.aspx");
                    break;

                case 3:
                    Response.Redirect("Usuario.aspx");
                    break;
                default:
                    break;
            }
        }
        else
            LN_Principal.FailureText = "Usuario Y/o Clave Incorrecta";

    }
}