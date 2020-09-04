<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="proyecto1.WebForm2" %>

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
        top:131px;
            left: 134px;
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
        left:698px;
        top:-78px;
        }
        h2{
             position:relative;
        width:400px;
        left:668px;
        top:-43px
        }
        #a{
            color:white;
            
        }
        #registro{
            width:153px;
            top: 95px;
        }
    </style>
<body>
    <nav class="navbar navbar-dark bg-dark">
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
    <input type="text" runat="server" class="form-control" id="usuario1" aria-describedby="emailHelp"  >
   
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">CONTRASEÑA</label>
    <input runat="server" type="password" class="form-control" id="contraseña">
  </div>
      <div class="form-group">
    <label for="exampleInputEmail1">NOMBRES</label>
    <input  type="text" runat="server" class="form-control" id="nombres1"  aria-describedby="emailHelp" >
   
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">APELLIDOS</label>
    <input runat="server" type="text" class="form-control" id="apellido1">
  </div>
              <div class="form-group">
    <label for="exampleInputEmail1">FECHA DE NACIMIENTO</label>
    <input runat="server" type="text" class="form-control" id="fecha1" aria-describedby="emailHelp" >
   
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">PAIS</label>
    <input runat="server" type="text" class="form-control" id="pais1" />
  </div>
       
  <div class="form-group">
    <label for="exampleInputPassword1">CORREO ELECTRONICO</label>
    <input runat="server" type="text" class="form-control" id="correo1" >
  </div>
    <button class="btn btn-danger" id="registro"><a href ="WebForm1.aspx" id="a">REGRESAR </a></button>
    <label for="exampleInputPassword1">
    <asp:Button Text="REGISTRARSE" runat ="server" OnClick ="login" CssClass="btn-success" ID="registro2" BorderStyle="None" BorderWidth="200px" Height="40px" Width="162px" ></asp:Button>
        </label>
    </form>
    </div>
    
</body>
</html>
