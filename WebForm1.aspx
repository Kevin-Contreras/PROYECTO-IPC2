<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="proyecto1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <style>
        #contenedor{
        margin:20px;
        
        position:absolute;
        top:309px;
            left: 126px;
            width: 1405px;
        }
        button{
            position:relative;
            left:707px
        }
        label{
            text-align:center;
            width: 1572px;
        }
        #exampleInputPassword1{
            width:300px;
            position:relative;
            left:640px
        }
        #exampleInputEmail1{
            width:300px;
            position:relative;
            left:640px
        }
        h1{
        position:relative;
        width:200px;
        left:700px;
        top:-50px;
        color:white;
        }
        h2{
             position:relative;
        width:400px;
        left:670px;
        top:-10px
        }
        #a{
            color:white;
            
        }
        #registro{
            width:153px;
            top: 95px;
        }
        #var{
            position:fixed;
            width:100%;
        }
    </style>
<body>
    <nav class="navbar navbar-dark bg-dark" id="var">
  <a class="navbar-brand" href="#">
    
    OTHARO
  </a>
</nav>
    <div id="contenedor">
        <h1>OTHARO</h1>
    <h2>INICAR SESCION</h2>
    <form id="form1" runat="server">
        <div class="form-group">
    <label for="exampleInputEmail1">USUARIO</label>
    <input runat="server" type="text" class="form-control" id="nuevo"  aria-describedby="emailHelp" >
   
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">CONTRASEÑA</label>
    <input type="password"  runat="server" class="form-control" id="exampleInputPassword1" >
  </div>
    <button class="btn btn-danger" id="registro"><a href="WebForm2.aspx" id="a"> REGISTRARSE </a></button>
    <label for="exampleInputPassword1">
    <asp:Button Text="INICIAR SESION" runat ="server" OnClick ="login" CssClass="btn-success" ID="registro" BorderStyle="None" BorderWidth="200px" Height="40px" Width="162px" />
        </label>
    </form>
    </div>
    
    <asp:Image ID="Image1" runat="server" Height="100%" ImageUrl="~/img/login.jpg" Width="100%" />
    
</body>
</html>
