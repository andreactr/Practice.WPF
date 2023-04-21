using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWPF.Data_Access
{
    public class Data
    {
        string connST2 = ConfigurationManager.AppSettings["defaultConnection"].ToString();



        public DataTable GetPersonas()
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {

                SqlCommand com = new SqlCommand("exec dbo.SelPersona", conn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public DataTable GetPersonasPorBuscador(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.buscarPersonas '{0}'", nombre);
                //conn.Open();
                SqlCommand com = new SqlCommand(command, conn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }

        }


        public void UpdatePersonas(int id, string nombre, int edad, string correo)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                //placeholder
                string command = String.Format("exec dbo.UdpPersona '{0}','{1}', '{2}', '{3}'", id,
                                                                                                nombre,
                                                                                                edad,
                                                                                                correo);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CreatePersona(string nombre, int edad, string correo)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.InsPersona '{0}','{1}', '{2}'",
                                                                                               nombre,
                                                                                               edad,
                                                                                               correo);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeletePersonas(string id)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.DelPersona '{0}'", id);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }

        }

    }
}

