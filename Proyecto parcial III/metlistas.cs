using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_parcial_III
{
    class metlistas
    {
        private string cadenadeconexion = "Data Source=.;Initial Catalog=ListasdeSuper;Integrated Security=True";
        public bool conectado()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenadeconexion);
                conexion.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public void agregar (string codigolst, string fecha, string super, string producto, int precio)
        {
            string query = "insert into Listas(Codigolista, Fechacompra, Supermercado, Producto, Precio) values" + "(@codigolst, @fecha, @super, @producto, @precio)";

            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand comando = new SqlCommand(query, conectando);
                comando.Parameters.AddWithValue("@codigolst", codigolst);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@super", super);
                comando.Parameters.AddWithValue("@producto", producto);
                comando.Parameters.AddWithValue("@precio", precio);
                try
                {
                    conectando.Open();
                    comando.ExecuteNonQuery();
                    conectando.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error" + ex.Message);
                }
            }
        }
        public List<objetoslst> buscar(string codlst)
        {
            List<objetoslst> lstobjetos = new List<objetoslst>();
            string query = "select * from Listas" + " where Codigolista=@codlst";
            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand comando = new SqlCommand(query, conectando);
                comando.Parameters.AddWithValue("@codlst", codlst);
                try
                {
                    conectando.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        objetoslst tobjetos = new objetoslst();
                        tobjetos.Idlista = lector.GetInt32(0);
                        tobjetos.Codigolista = lector.GetString(1);
                        tobjetos.Fechacompra = lector.GetString(2);
                        tobjetos.Supermercado = lector.GetString(3);
                        tobjetos.Producto = lector.GetString(4);
                        tobjetos.Precio = lector.GetInt32(5);
                        lstobjetos.Add(tobjetos);
                    }
                    lector.Close();
                    conectando.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay en error" + ex.Message);
                }
            }
            return lstobjetos;
        }
        public rsum sumar(string cdlst)
        {
            string query = "select SUM(Precio) as Total from Listas" + " where Codigolista=@cdlst";

            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand comando = new SqlCommand(query, conectando);
                comando.Parameters.AddWithValue("@cdlst", cdlst);
                try
                {
                    conectando.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    lector.Read();
                    rsum calcular = new rsum();
                    calcular.Total = lector.GetInt32(0);

                    lector.Close();
                    conectando.Close();
                    return calcular;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error" + ex.Message);
                }
            }
        }
        public List<objetoslst> mostrar()
        {
            List<objetoslst> lstmunicipios = new List<objetoslst>();
            string query = "select * from Listas";
            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand comando = new SqlCommand(query, conectando);
                try
                {
                    conectando.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        objetoslst tlsts = new objetoslst();
                        tlsts.Idlista = lector.GetInt32(0);
                        tlsts.Codigolista = lector.GetString(1);
                        tlsts.Fechacompra = lector.GetString(2);
                        tlsts.Supermercado = lector.GetString(3);
                        tlsts.Producto = lector.GetString(4);
                        tlsts.Precio = lector.GetInt32(5);
                        lstmunicipios.Add(tlsts);
                    }
                    lector.Close();
                    conectando.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay en error" + ex.Message);
                }
            }
            return lstmunicipios;
        }
        public objetoslst mostrar(int id)
        {
            string query = "select * from Listas" + " where Idlista=@id";

            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand comando = new SqlCommand(query, conectando);
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    conectando.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    lector.Read();

                    objetoslst tlsts = new objetoslst();
                    tlsts.Idlista = lector.GetInt32(0);
                    tlsts.Codigolista = lector.GetString(1);
                    tlsts.Fechacompra = lector.GetString(2);
                    tlsts.Supermercado = lector.GetString(3);
                    tlsts.Producto = lector.GetString(4);
                    tlsts.Precio = lector.GetInt32(5);

                    lector.Close();
                    conectando.Close();
                    return tlsts;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error" + ex.Message);
                }
            }
        }
        public void editar(string cls, string fecha, string super, string producto, int precio, int id)
        {
            string query = "update Listas set Codigolista=@cls, Fechacompra=@fecha, Supermercado=@super, Producto=@producto, Precio=@precio" + " where Idlista=@id";
            using (SqlConnection conectando = new SqlConnection(cadenadeconexion))
            {
                SqlCommand cambiar = new SqlCommand(query, conectando);
                cambiar.Parameters.AddWithValue("@cls", cls);
                cambiar.Parameters.AddWithValue("@fecha", fecha);
                cambiar.Parameters.AddWithValue("@super", super);
                cambiar.Parameters.AddWithValue("@producto", producto);
                cambiar.Parameters.AddWithValue("@precio", precio);
                cambiar.Parameters.AddWithValue("@id", id);
                try
                {
                    conectando.Open();
                    cambiar.ExecuteNonQuery();
                    conectando.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error" + ex.Message);
                }
            }
        }
        public void eliminar(int id)
        {
            string query = "delete from Listas" + " where Idlista=@id";
            using (SqlConnection conexion2 = new SqlConnection(cadenadeconexion))
            {
                SqlCommand borrar = new SqlCommand(query, conexion2);
                borrar.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion2.Open();
                    borrar.ExecuteNonQuery();
                    conexion2.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error" + ex.Message);
                }
            }
        }
    }
    public class objetoslst
    {
        public int Idlista { get; set; }
        public string Codigolista { get; set; }
        public string Fechacompra { get; set; } 
        public string Supermercado { get; set; }
        public string Producto { get; set; }
        public int Precio { get; set; }
    }
    public class rsum
    {
        public int Total { get; set; }
    }
}
