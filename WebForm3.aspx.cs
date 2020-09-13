using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace proyecto1
{

    public partial class WebForm3 : System.Web.UI.Page
    {
        XmlDocument doc = new XmlDocument();
        XmlDocument docs;
        XmlElement element1;
        static String d1, d2, d3, d4, d5, d6, d7, d8, d9, d10,d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21;
        static String d22, d23, d24, d25, d26, d27, d28, d29, d30, d31, d32, d33, d34, d35, d36, d37, d38, d39, d40, d41, d42;
        static String d43, d44, d45, d46, d47, d48, d49, d50, d51, d52, d53, d54, d55, d56, d57, d58, d59, d60, d61, d62, d63,d64;

        protected void Page_Load(object sender, EventArgs e)
        {
      
           
        }
        protected void clic(object sender, EventArgs e)
        { 
            BOTON.BackColor = Color.Black;
            d1 = "<ficha>" +
                            "<color> negro </color>" +
                            "<columna> A </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";

        }

        protected void clic1(object sender, EventArgs e)
        {
            BOTON1.BackColor = Color.White;
           d2 = "<ficha>" +
                            "<color> negro </color>" +
                            "<columna> B </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";


        }
        protected void clic2(object sender, EventArgs e)
        {
            BOTON2.BackColor = Color.Black;
                    d3 = "<ficha>" +
                            "<color> negro </color>" +
                            "<columna> C </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic3(object sender, EventArgs e)
        {
            BOTON3.BackColor = Color.Black;
            d4 = "<ficha>" +
                            "<color> negro </color>" +
                            "<columna> D </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic4(object sender, EventArgs e)
        {
            BOTON4.BackColor = Color.Black;
            d5="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> E </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic5(object sender, EventArgs e)
        {
            BOTON5.BackColor = Color.White;
            d6="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> F </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic6(object sender, EventArgs e)
        {
            BOTON6.BackColor = Color.Black;
            d7="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> G </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic7(object sender, EventArgs e)
        {
            BOTON7.BackColor = Color.White;
            d8="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> H </columna>" +
                            "<fila> 1 </fila>" +
                            "</ficha>";
        }
        protected void clic8(object sender, EventArgs e)
        {
            BOTON8.BackColor = Color.Black;
            d9="<ficha>" +
                            "<color> negro </color>" +
                            "<columna>A  </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }

        protected void clic9(object sender, EventArgs e)
        {
            BOTON9.BackColor = Color.White;
            d10="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> B </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic10(object sender, EventArgs e)
        {
            BOTON10.BackColor = Color.Black;
            d11="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> C </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic11(object sender, EventArgs e)
        {
            BOTON11.BackColor = Color.White;
            d12="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> D </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic12(object sender, EventArgs e)
        {
            BOTON12.BackColor = Color.White;
            d13="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> E </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic13(object sender, EventArgs e)
        {
            BOTON13.BackColor = Color.White;
            d14="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> F </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic14(object sender, EventArgs e)
        {
            BOTON14.BackColor = Color.Black;
            d15="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> G</columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic15(object sender, EventArgs e)
        {
            BOTON15.BackColor = Color.Black;
            d16="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> H </columna>" +
                            "<fila> 2 </fila>" +
                            "</ficha>";
        }
        protected void clic16(object sender, EventArgs e)
        {
            BOTON16.BackColor = Color.Black;
            d17="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> A </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }

        protected void clic17(object sender, EventArgs e)
        {
            BOTON17.BackColor = Color.White;
            d18="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> B </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic18(object sender, EventArgs e)
        {
            BOTON18.BackColor = Color.Black;
            d19="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> C </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic19(object sender, EventArgs e)
        {
            BOTON19.BackColor = Color.White;
            d20="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> D </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic20(object sender, EventArgs e)
        {
            BOTON20.BackColor = Color.White;
            d21="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> E </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic21(object sender, EventArgs e)
        {
            BOTON21.BackColor = Color.White;
            d22 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> F </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic22(object sender, EventArgs e)
        {
            BOTON22.BackColor = Color.White;
            d23 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> G </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic23(object sender, EventArgs e)
        {
            BOTON23.BackColor = Color.White;
            d24 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> H </columna>" +
                            "<fila> 3 </fila>" +
                            "</ficha>";
        }
        protected void clic24(object sender, EventArgs e)
        {
            BOTON24.BackColor = Color.White;
            d25 = "<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> A </columna>" +
                            "<fila> 4 </fila>" +
                            "</ficha>";
        }

        protected void clic25(object sender, EventArgs e)
        {
            BOTON25.BackColor = Color.White;
            d26 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> B </columna>" +
                            "<fila> 4 </fila>" +
                            "</ficha>";
        }
        protected void clic26(object sender, EventArgs e)
        {
            BOTON26.BackColor = Color.White;
            d27 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> C </columna>" +
                            "<fila> 4 </fila>" +
                            "</ficha>";
        }
        protected void clic27(object sender, EventArgs e)
        {
            BOTON27.BackColor = Color.White;
            d28 ="<ficha>" +
                            "<color> blanco </color>" +
                            "<columna> D </columna>" +
                            "<fila> 4 </fila>" +
                            "</ficha>";
        }
        protected void clic28(object sender, EventArgs e)
        {
            BOTON28.BackColor = Color.Black;
            d29="<ficha>" +
                            "<color> negro </color>" +
                            "<columna> E </columna>" +
                            "<fila> 4 </fila>" +
                            "</ficha>";
        }
        protected void clic29(object sender, EventArgs e)
        {
            BOTON29.BackColor = Color.Black;
            d30="<ficha>" +
                "<color> negro </color>" +
                "<columna> F </columna>" +
                "<fila> 4 </fila>" +
                "</ficha>";
        }
        protected void clic30(object sender, EventArgs e)
        {
            BOTON30.BackColor = Color.Black;
            d31="<ficha>" +
                "<color> negro </color>" +
                "<columna> G </columna>" +
                "<fila> 4 </fila>" +
                "</ficha>";
        }
        protected void clic31(object sender, EventArgs e)
        {
            BOTON31.BackColor = Color.Black;
            d32="<ficha>" +
                "<color> negro </color>" +
                "<columna> H </columna>" +
                "<fila> 4 </fila>" +
                "</ficha>";

        }
        protected void clic32(object sender, EventArgs e)
        {
            BOTON32.BackColor = Color.Black;
            d33="<ficha>" +
                "<color> negro </color>" +
                "<columna> A </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }

        protected void clic33(object sender, EventArgs e)
        {
            BOTON33.BackColor = Color.White;
            d34="<ficha>" +
                "<color> blanco </color>" +
                "<columna> B </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }
        protected void clic34(object sender, EventArgs e)
        {
            BOTON34.BackColor = Color.Black;
            d35="<ficha>" +
                "<color> negro </color>" +
                "<columna> C </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }
        protected void clic35(object sender, EventArgs e)
        {
            BOTON35.BackColor = Color.White;
            d36="<ficha>" +
                "<color> blanco </color>" +
                "<columna> D </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }
        protected void clic36(object sender, EventArgs e)
        {
            BOTON36.BackColor = Color.White;
            d37="<ficha>" +
                "<color> blanco </color>" +
                "<columna> E </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";

        }
        protected void clic37(object sender, EventArgs e)
        {
            BOTON37.BackColor = Color.White;
            d38="<ficha>" +
                "<color> blanco </color>" +
                "<columna> F </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }
        protected void clic38(object sender, EventArgs e)
        {
            BOTON38.BackColor = Color.Black;
            d39="<ficha>" +
                "<color> negro </color>" +
                "<columna> G </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";
        }
        protected void clic39(object sender, EventArgs e)
        {
            BOTON39.BackColor = Color.Black;
            d40="<ficha>" +
                "<color> negro </color>" +
                "<columna> H </columna>" +
                "<fila> 5 </fila>" +
                "</ficha>";

        }
        protected void clic40(object sender, EventArgs e)
        {
            BOTON40.BackColor = Color.White;
            d41="<ficha>" +
                "<color> blanco </color>" +
                "<columna> A </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }

        protected void clic41(object sender, EventArgs e)
        {
            BOTON41.BackColor = Color.Black;
            d42="<ficha>" +
                "<color> negro </color>" +
                "<columna> B </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic42(object sender, EventArgs e)
        {
            BOTON42.BackColor = Color.Black;
            d43="<ficha>" +
                "<color> negro </color>" +
                "<columna> C </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic43(object sender, EventArgs e)
        {
            BOTON43.BackColor = Color.White;
            d44="<ficha>" +
                "<color> negro </color>" +
                "<columna> D </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic44(object sender, EventArgs e)
        {
            BOTON44.BackColor = Color.White;
            d45="<ficha>" +
                "<color> blanco </color>" +
                "<columna> E </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic45(object sender, EventArgs e)
        {
            BOTON45.BackColor = Color.White;
            d46="<ficha>" +
                "<color> blanco </color>" +
                "<columna> F </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic46(object sender, EventArgs e)
        {
            BOTON46.BackColor = Color.Black;
            d47="<ficha>" +
                "<color> blanco </color>" +
                "<columna> G </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";
        }
        protected void clic47(object sender, EventArgs e)
        {
            BOTON47.BackColor = Color.Black;
            d48="<ficha>" +
                "<color> negro </color>" +
                "<columna> H </columna>" +
                "<fila> 6 </fila>" +
                "</ficha>";

        }
        protected void clic48(object sender, EventArgs e)
        {
            BOTON48.BackColor = Color.Black;
            d49="<ficha>" +
                "<color> negro </color>" +
                "<columna> A </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }

        protected void clic49(object sender, EventArgs e)
        {
            BOTON49.BackColor = Color.Black;
            d50="<ficha>" +
                "<color> negro </color>" +
                "<columna> B </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }
        protected void clic50(object sender, EventArgs e)
        {
            BOTON50.BackColor = Color.Black;
            d51="<ficha>" +
                "<color> negro </color>" +
                "<columna> C </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }
        protected void clic51(object sender, EventArgs e)
        {
            BOTON51.BackColor = Color.White;
            d52="<ficha>" +
                "<color> blanco </color>" +
                "<columna> D </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }
        protected void clic52(object sender, EventArgs e)
        {
            BOTON52.BackColor = Color.White;
            d53="<ficha>" +
                "<color> blanco </color>" +
                "<columna> F </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";

        }
        protected void clic53(object sender, EventArgs e)
        {
            BOTON53.BackColor = Color.White;
            d54="<ficha>" +
                "<color> blanco </color>" +
                "<columna> G </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }
        protected void clic54(object sender, EventArgs e)
        {
            BOTON54.BackColor = Color.Black;
            d55=
                "<ficha>" +
                "<color> negro </color>" +
                "<columna> H </columna>" +
                "<fila> 7 </fila>" +
                "</ficha>";
        }
        protected void clic55(object sender, EventArgs e)
        {
            BOTON55.BackColor = Color.Black;
            d56="<ficha>" +
                "<color> negro </color>" +
                "<columna> A </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";

        }
        protected void clic56(object sender, EventArgs e)
        {
            BOTON56.BackColor = Color.Black;
            d57="<ficha>" +
                "<color> negro </color>" +
                "<columna> B </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
        }

        protected void clic57(object sender, EventArgs e)
        {
            BOTON57.BackColor = Color.White;
            d58="<ficha>" +
                "<color> blanco </color>" +
                "<columna> C </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
        }
        protected void clic58(object sender, EventArgs e)
        {
            BOTON58.BackColor = Color.Black;
            d59="<ficha>" +
                "<color> negro </color>" +
                "<columna> D </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
        }
        protected void clic59(object sender, EventArgs e)
        {
            BOTON59.BackColor = Color.White;
 
            d60= "<ficha>" +
                "<color> blanco </color>" +
                "<columna> E </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
          
        }
        protected void clic60(object sender, EventArgs e)
        {
            BOTON60.BackColor = Color.Black;
            d61 = "<ficha>" +
                "<color> negro </color>" +
                "<columna> E </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";

        }
        protected void clic61(object sender, EventArgs e)
        {
            BOTON61.BackColor = Color.Black;
            d62 = "<ficha>" +
                "<color> negro </color>" +
                "<columna> F </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
        }
        protected void clic62(object sender, EventArgs e)
        {
            BOTON62.BackColor = Color.White;
            d63 = "<ficha>" +
                "<color> blanco </color>" +
                "<columna> G </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
        }
        protected void clic63(object sender, EventArgs e)
        {
            BOTON63.BackColor = Color.White;
            d64 = "<ficha>" +
                "<color> blanco </color>" +
                "<columna> H </columna>" +
                "<fila> 8 </fila>" +
                "</ficha>";
          
        }

        protected void DESCARGAR_Click(object sender, EventArgs e)
        {
            XmlDocument documento = new XmlDocument();
            documento.LoadXml("<tablero>"
          +d1 + d2+d3 +d4 +d5 +d6 +d7 +d8 +d9 +d10 +d11 +d12 +d13 +d14 +d15 +d16 +d17 +d18 +d19 +d20 +d21 +d22 +d23 +d24 +d25 +d26 +d27 +d28 +d29 +d30 +
          d31 +d32 +d33 +d34 +d35 +d36 +d37 +d38 +d39+ d40 +d41 +d42 +d43 +d44 +d45 +d46 +d47 +d48 +d49 +d50 +d51 +d52 +d53 +d54 +d55 +d56 +d57 +d58 +d59 +d60 +d61 +d62+ d63 +
          d64+
                "</tablero>");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            documento.Save(path+"/posicionesFichas.xml");
            HttpContext.Current.Response.Write("el archivo se ha descargado se encuentra en el directorio escritorio, nombre del archivo: posicionesFichas.xml");





        }
    }
}