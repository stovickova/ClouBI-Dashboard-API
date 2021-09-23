using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DashboardTestApi.Data;
using DevExpress.DashboardWeb;
using Npgsql;

namespace DashboardTestApi
{
    public class DataBaseEditaleDashboardStorage : IEditableDashboardStorage
    {
        private string connectionString;
        ReadOnlyRepositoryBase repository = new ReadOnlyRepositoryBase();
        List<DashboardInfo> dashboardInfos = null;

        public DataBaseEditaleDashboardStorage(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string AddDashboard(XDocument document, string dashboardName)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))// "Host=localhost:5432;Database=ambica;Username=ambica;Password=ambica"))  // "postgres://localhost:5432/ambica?user=ambica&password=ambica"/*connectionString*/))
                {

                    //                    using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO demo.outputs (Name, XmlData) output INSERTED.ID SELECT ('{dashboardName}', '{document.ToString()}')", con))
                    //                    using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO demo.outputs (Name, XmlData) SELECT (@n, @x) RETURNING demo.outputs.id", con))
                    using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO demo.outputs (id, name, type, xmldata) VALUES (@i, @n, @t, @x)", con))
                //    using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO demo.outputs (name, xmldata) SELECT (@n, @x)", con))
                    {
                        try
                        {
                            con.Open();

                            int max = 1;

                            using (NpgsqlCommand cmd1 = new NpgsqlCommand("select max(id) from demo.outputs", con))
                            {
                                max = (int)cmd1.ExecuteScalar();
                            }
                            max++;

                            cmd.Parameters.AddWithValue("i", max);
                            cmd.Parameters.AddWithValue("t", 1);
                            cmd.Parameters.AddWithValue("n", dashboardName);
                            cmd.Parameters.AddWithValue("x", document.ToString());



                            var id = cmd.ExecuteNonQuery();

                            return max.ToString();
                        }
                        catch (Exception e)
                        {
                            int i = 0;
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                }
                return string.Empty;
            }
            catch (Exception e)
            {
                int i = 0;

                return string.Empty;
            }

            /*       using (SqlConnection connection = new SqlConnection(connectionString))
                   {
                       connection.Open();
                       MemoryStream stream = new MemoryStream();
                       document.Save(stream);
                       stream.Position = 0;

                       SqlCommand InsertCommand = new SqlCommand(
                           "INSERT INTO Dashboards (Dashboard, Caption) " +
                           "output INSERTED.ID " +
                           "VALUES (@Dashboard, @Caption)");
                       InsertCommand.Parameters.Add("Caption", SqlDbType.NVarChar).Value = dashboardName;
                       InsertCommand.Parameters.Add("Dashboard", SqlDbType.VarBinary).Value = stream.ToArray();
                       InsertCommand.Connection = connection;
                       string ID = InsertCommand.ExecuteScalar().ToString();
                       connection.Close();
                       return ID;
                   }*/
        }

        public XDocument LoadDashboard(string dashboardID)
        {
            try
            {
                int id = int.Parse(dashboardID);
                var output = repository.GetOutputXmls(connectionString, id, 1, null).FirstOrDefault();
                if (output == null)
                    return null;

                var xml = output.XmlData;
/*                var xml = output.XmlData.Replace("@", "");
                xml = output.XmlData.Replace("\r\n", "");
                int i = xml.IndexOf("?>");
                xml = xml.Substring(i + 2);*/

                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write(xml);
                writer.Flush();
                stream.Position = 0;


                XDocument x = XDocument.Load(stream);
                return x;
            }
            catch (Exception ex)
            {
                int i = 0;
                return null;
            }
          //  return doc.FirstNode.NextNode;

      /*      using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand GetCommand = new SqlCommand("SELECT  Dashboard FROM Dashboards WHERE ID=@ID");
                GetCommand.Parameters.Add("ID", SqlDbType.Int).Value = Convert.ToInt32(dashboardID);
                GetCommand.Connection = connection;
                SqlDataReader reader = GetCommand.ExecuteReader();
                reader.Read();
                byte[] data = reader.GetValue(0) as byte[];
                MemoryStream stream = new MemoryStream(data);
                connection.Close();
                return XDocument.Load(stream);
            }*/
        }

        public IEnumerable<DashboardInfo> GetAvailableDashboardsInfo()
        {
        //    if (dashboardInfos == null)
            {
                dashboardInfos = new List<DashboardInfo>();

                var data = repository.GetOutputs(connectionString);

                foreach (var di in data)
                {
                    dashboardInfos.Add(new DashboardInfo() { ID = di.Id.ToString(), Name = di.Name });
                }
            }

            return dashboardInfos;
        }

        public void SaveDashboard(string dashboardID, XDocument document)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))// "Host=localhost:5432;Database=ambica;Username=ambica;Password=ambica"))  // "postgres://localhost:5432/ambica?user=ambica&password=ambica"/*connectionString*/))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE demo.outputs Set xmldata = @x WHERE ID = @i", con))
                    {
                        try
                        {
                            con.Open();

                            int id = int.Parse(dashboardID);

                            cmd.Parameters.AddWithValue("i", id);
                            cmd.Parameters.AddWithValue("x", document.ToString());



                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            int i = 0;
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                }
            }
            catch (Exception e)
            {
                int i = 0;

           }

    /*        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                MemoryStream stream = new MemoryStream();
                document.Save(stream);
                stream.Position = 0;

                SqlCommand InsertCommand = new SqlCommand(
                    "UPDATE Dashboards Set Dashboard = @Dashboard " +
                    "WHERE ID = @ID");
                InsertCommand.Parameters.Add("ID", SqlDbType.Int).Value = Convert.ToInt32(dashboardID);
                InsertCommand.Parameters.Add("Dashboard", SqlDbType.VarBinary).Value = stream.ToArray();
                InsertCommand.Connection = connection;
                InsertCommand.ExecuteNonQuery();

                connection.Close();
            }*/
        }
    }
}
