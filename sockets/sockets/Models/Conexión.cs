using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sockets.Models
{
    internal class Conexión
    {
        private readonly string conexion = "Server=PCERDA\\SQLEXPRESS;"
                            + " Database=Chatoso;"
                            + " Integrated Security=True; "
                            + " TrustServerCertificate=True";
        public Conexión() { }


        public Conexión(string conexion)
        {
            this.conexion = conexion;
            
        }


        public bool probarConexion(out String mensajeError)
        {
            mensajeError = "";

            try
            {

            using (SqlConnection conexion = new(this.conexion))
            {
                conexion.Open();
                mensajeError = "Conexion exitosa";
                return true;
            }

            }
            catch (SqlException ex)
            {

                mensajeError = $"Error de conexion: {ex.Message}";
                return false;
            }
            catch (Exception ex)
            {

                mensajeError = $"Error inesperado: {ex.Message}";
                return false;
            }
        }


        public bool validarUsuario(String usuario, 
            String contraseña, out string mensajeError)
        {
            bool Valido = false;
            mensajeError = "";

            using (SqlConnection conexion = new(this.conexion))
            {
                try
                {

                    conexion.Open();

                    String consulta = "SELECT COUNT(*) FROM Usuarios " +
                        "WHERE Nombre = @usuario AND Password = @contraseña";

                    using (SqlCommand comandin = new(consulta, conexion))
                    {
                        comandin.Parameters.AddWithValue("@usuario", usuario);
                        comandin.Parameters.AddWithValue("@contraseña", contraseña);

                        int kueri = (int)comandin.ExecuteScalar();

                        if (kueri > 0)
                        {
                            Valido = true;
                        }
                        else
                        {
                            mensajeError = "Usuario o contraseña incorrectos";
                        }
                    }
                }
                catch (SqlException ex)
                {

                    mensajeError = $"Error en la conexion a base de datos: " +
                        $"{ex.Message}";
                    Valido = false;
                }
                catch (Exception ex) 
                {
                    mensajeError = $"Error inesperado: {ex.Message}";
                    Valido = false;
                }
            }
            return Valido;
        }//cierra validarUsuario


        public DataRow ObtenerUsuario(String usuario, 
            String contraseña, out String mensajeError)
        {
            DataRow usuarioRow = null;
            mensajeError = "";

            using (SqlConnection conetzion = new(this.conexion))
            {
                try
                {
                    conetzion.Open();
                    String consulta = "SELECT ID, Nombre, Email, Rol " +
                        "FROM Usuarios WHERE Nombre = @usuario AND Password = @contraseña";

                    using (SqlCommand commandcomando = new(consulta, conetzion))
                    {
                        commandcomando.Parameters.AddWithValue("@usuario", usuario);
                        commandcomando.Parameters.AddWithValue("@contraseña", contraseña);
                        
                        SqlDataAdapter adaptadorcito = new(commandcomando);
                        DataTable tablita = new();
                        adaptadorcito.Fill(tablita);

                    }

                    



                }
                catch (SqlException ex)
                {

                    
                }
            }

        }
    }
}
