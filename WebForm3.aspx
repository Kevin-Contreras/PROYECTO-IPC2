<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="proyecto1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <style>
        *{
            margin:0px;
           
        }
        body{
            background:gray;
        }
        #principal{
            height:754px;
            width:726px;
            background:black;
            padding:20px;
            position:relative;
            left:594px;
            top:100px
        }
        button{
            height:67.5px;
            width:67.5px;
            display:inline;
            

        }
        td{
            background:green;
            border-color:black;
        }
        .b{
            position:absolute;
        }
        .bor{
            border-radius:200px;
            border-style:none;
            background:green;
        }
       .bot{
           height:72px;
           width:72px;
       }
    </style>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="principal">
                <table runat="server">
                    <tr>
                       <td><button></button></td>
                        <td><button >A</button></td>
                        <td><button>B</button></td>
                        <td><button>C</button></td>
                        <td><button>D</button></td>
                        <td><button>E</button></td>
                        <td><button>F</button></td>
                        <td><button>G</button></td>
                        <td><button>H</button></td>
                        <td><button></button></td>
                        
                    </tr>
                    <tr>
                        <td><button>1</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON" CssClass="bor" OnClick ="clic" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON1" OnClick ="clic1" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON2" OnClick ="clic2" CssClass="bor" Height="67.5px"  Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON3"  OnClick ="clic3" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON4" OnClick ="clic4" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON5" OnClick ="clic5" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON6" OnClick ="clic6" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON7" OnClick ="clic7" CssClass="bor" Height="67.5px" Width="67.5px"/></td>
                       <td><button>1</button></td>
                        
                    </tr>
                    <tr>
                      <td><button>2</button></td>
                       <td><asp:Button  runat ="server"  ID="BOTON8" CssClass="bor"  OnClick ="clic8" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON9" CssClass="bor" OnClick ="clic9" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON10" CssClass="bor" OnClick ="clic10" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON11" CssClass="bor" OnClick ="clic11" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON12" CssClass="bor" OnClick ="clic12" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON13" CssClass="bor" OnClick ="clic13" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON14" CssClass="bor" OnClick ="clic14" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON15" CssClass="bor" OnClick ="clic15" Height="67.5px" Width="67.5px"/></td>
                       <td><button>2</button></td>
                    </tr>
                    <tr>
                        <td><button>3</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON16"  CssClass ="bor" OnClick ="clic16" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON17" CssClass ="bor" OnClick ="clic17" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON18" CssClass ="bor" OnClick ="clic18" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON19" CssClass ="bor" OnClick ="clic19" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON20" CssClass ="bor" OnClick ="clic20" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON21" CssClass ="bor" OnClick ="clic21" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON22" CssClass ="bor" OnClick ="clic22" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON23" CssClass ="bor" OnClick ="clic23" Height="67.5px" Width="67.5px"/></td>
                       <td><button>3</button></td>
                    </tr>
                    <tr>
                        <td><button>4</button></td>
                       <td><asp:Button  runat ="server"  ID="BOTON24" CssClass ="bor" OnClick ="clic24" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON25" CssClass ="bor" OnClick ="clic25" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON26"  CssClass ="bor" OnClick ="clic26" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON27" CssClass ="bor" OnClick ="clic27" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON28" CssClass ="bor" OnClick ="clic28" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON29" CssClass ="bor" OnClick ="clic29" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON30" CssClass ="bor" OnClick ="clic30" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON31" CssClass ="bor" OnClick ="clic31" Height="67.5px" Width="67.5px"/></td>
                       <td><button>4</button></td>
                    </tr>
                    <tr>
                     <td><button>5</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON32" CssClass ="bor" OnClick ="clic32" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON33" CssClass ="bor" OnClick ="clic33" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON34" CssClass ="bor" OnClick ="clic34" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON35" CssClass ="bor" OnClick ="clic35" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON36" CssClass ="bor" OnClick ="clic36" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON37" CssClass ="bor" OnClick ="clic37" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON38" CssClass ="bor" OnClick ="clic38" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON39" CssClass ="bor" OnClick ="clic39" Height="67.5px" Width="67.5px"/></td>
                       <td><button>5</button></td>
                    </tr>
                    <tr>
                      <td><button>6</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON40" CssClass ="bor" OnClick ="clic40" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON41" CssClass ="bor" OnClick ="clic41" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON42" CssClass ="bor" OnClick ="clic42" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON43" CssClass ="bor" OnClick ="clic43" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON44" CssClass ="bor" OnClick ="clic44" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON45" CssClass ="bor" OnClick ="clic45" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON46" CssClass ="bor" OnClick ="clic46" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON47" CssClass ="bor" OnClick ="clic47" Height="67.5px" Width="67.5px"/></td>
                       <td><button>6</button></td>
                    </tr>
                    <tr>
                        <td><button>7</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON48" CssClass ="bor" OnClick ="clic48" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON49" CssClass ="bor" OnClick ="clic49" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON50" CssClass ="bor" OnClick ="clic50" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON51" CssClass ="bor" OnClick ="clic51" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON52" CssClass ="bor" OnClick ="clic52" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON53" CssClass ="bor" OnClick ="clic53" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON54" CssClass ="bor" OnClick ="clic54" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON55" CssClass ="bor" OnClick ="clic55" Height="67.5px" Width="67.5px"/></td>
                      <td><button>7</button></td>
                    </tr>
                    <tr>
                        <td><button>8</button></td>
                       <td><asp:Button  runat ="server" ID="BOTON56" CssClass ="bor" OnClick ="clic56" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON57" CssClass ="bor" OnClick ="clic57" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON58" CssClass ="bor" OnClick ="clic58" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON59" CssClass ="bor" OnClick ="clic59" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON60" CssClass ="bor" OnClick ="clic60" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON61" CssClass ="bor" OnClick ="clic61" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON62" CssClass ="bor" OnClick ="clic62" Height="67.5px" Width="67.5px"/></td>
                       <td><asp:Button  runat ="server" ID="BOTON63" CssClass ="bor" OnClick ="clic63" Height="67.5px" Width="67.5px"/></td>
                       <td><button>8</button></td>
                    </tr>
                    <tr>
                       <td><button></button></td>
                        <td><button>A</button></td>
                        <td><button>B</button></td>
                        <td><button>C</button></td>
                        <td><button>D</button></td>
                        <td><button>E</button></td>
                        <td><button>F</button></td>
                        <td><button>G</button></td>
                        <td><button>H</button></td>
                        <td><button></button></td>
                    </tr>
                  
                </table>

            </div>

                <asp:button runat="server" ID="DESCARGAR" OnClick="DESCARGAR_Click" Text="DESCARGAR XML"/>
                
        </div>
        
               
            
    </form>
</body>
</html>
