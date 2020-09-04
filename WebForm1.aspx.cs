using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 rl1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void login(object sender, EventArgs e) { 
        
            
            rl1.login("nombre_usuario", exampleInputPassword1.Value,nuevo.Value);



        }
    }
}