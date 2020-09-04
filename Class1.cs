using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace proyecto1
{
    public class Class1
    {
        private String nombre;
        private String pais;
        private String apellido;
        private String correo;
        private String fecha;
        private String usuario;
        private String contraseña;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private String cadena;
       
        SqlConnection sql = new SqlConnection(ConfigurationManager.AppSettings["StrConnection"]);
       
         void conectar()
        {
            if (sql.State == ConnectionState.Closed) {
                sql.Open();
            }
        }
         void desconectar()
        {
            if (sql.State == ConnectionState.Open)
            {
                sql.Close();
            }
        }

        public void Setnombre(String a)
        {
            nombre = a;
        }
        public void Setapellido(String a)
        {
            apellido = a;
        }
        public void Setpais(String a)
        {
            pais = a;
        }
        public void Setcorreo(String a)
        {
            correo = a;
        }
        public void Setusuario(String a)
        {
            usuario = a;
        }
        public void Setcon(String a)
        {
            contraseña = a;
        }
        public void Setfecha(String a)
        {
            fecha = a;
        }
        public void guardarRegistro()
        {
            
            cadena = "Insert into USUARIOS(nombres,apellidos,nombre_usuario,contraseña,fecha_nacimiento,pais,correo_electronico) values (@nombre1,@apellido1,@usuario1,@contraseña1,@fecha1,@pais1,@correo1)";
            conectar();
            SqlCommand cmd = new SqlCommand(cadena, sql);
            cmd.Parameters.AddWithValue("nombre1",nombre);
            cmd.Parameters.AddWithValue("apellido1",apellido);
            cmd.Parameters.AddWithValue("usuario1", usuario);
            cmd.Parameters.AddWithValue("contraseña1",contraseña);
            cmd.Parameters.AddWithValue("fecha1",fecha);
            cmd.Parameters.AddWithValue("pais1", pais);
            cmd.Parameters.AddWithValue("correo1", correo);
            cmd.ExecuteNonQuery();
            desconectar();
            HttpContext.Current.Response.Redirect("webform1.aspx");

        }
        public void login(String user,String pass,String user2) {

            cadena = "select *  from USUARIOS where nombre_usuario = "+ user + " and contraseña = contraseña";
            conectar();
            cmd = new SqlCommand(cadena, sql);
            dr = cmd.ExecuteReader();
            int i = 0;
            int k = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    if (pass == dr.GetString(3) && user2 == dr.GetString(2))
                    {
                        HttpContext.Current.Response.Redirect("webform3.aspx");
                    }
                    else
                    {
                        if (i==k)
                        {
                            HttpContext.Current.Response.Write("los datos no concuerdan");
                        }

                        
                    }


                    k++;
                }
                desconectar();
            }
            else
            {

                HttpContext.Current.Response.Redirect("webform2.aspx");
                desconectar();
            }

           
           

        }
    }
}