using System;
using System.Data;
using System.Data.SqlClient;

namespace herra_emp1
{
    public class AccesoDatos
    {
        private readonly string _connectionString =
            "Server=localhost\\SQLEXPRESS;Database=Ejercicio3;Trusted_Connection=True;";

        // Ejecuta consultas SELECT
        public DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            return dt;
        }

        // INSERT, UPDATE o DELETE
        public int EjecutarComando(string query, SqlParameter[] parametros = null)
        {
            int filas = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    conexion.Open();
                    filas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el comando: " + ex.Message);
            }
            return filas;
        }

        // Procedimientos almacenados
        public DataTable EjecutarProcedimiento(string nombreSP, SqlParameter[] parametros = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(nombreSP, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el procedimiento almacenado: " + ex.Message);
            }
            return dt;
        }
    }
}
