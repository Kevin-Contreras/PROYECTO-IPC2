using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Class1 rl2 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            rl2.Setnombre(nombres1.Value);
            rl2.Setapellido(apellido1.Value);
            rl2.Setcon(contraseña.Value);
            rl2.Setcorreo(correo1.Value);
            rl2.Setpais(pais1.Value);
            rl2.Setfecha(fecha1.Value);
            rl2.Setusuario(usuario1.Value);
            rl2.guardarRegistro();
            
        }
    }
}