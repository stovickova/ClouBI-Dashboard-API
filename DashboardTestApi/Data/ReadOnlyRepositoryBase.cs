using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    /// <summary>
    /// Abstraktní třída obsahující základní ReadOnly metody pro čtení v DB nad entity objekty.
    /// Předpokládá, že entita obsahuje jednoduchý klíč.
    /// </summary>
    /// <typeparam name="TId">Typ Id entity</typeparam>
    /// <typeparam name="TEntity">Typ entity</typeparam>
    /// <typeparam name="TBusiness">Typ business objektu, který je promappovát s entitou</typeparam>
    public class ReadOnlyRepositoryBase//<TId, TEntity, TBusiness>// : IReadOnlyRepositoryBase<TId, TEntity, TBusiness> where TEntity : class, IEntity<TId> where TBusiness : class
    {
        /// <summary>
        /// Databázový kontext
        /// </summary>
    //    internal readonly DatabaseContext _context;

        /// <summary>
        /// Databázový set nad entitou
        /// </summary>
  //      public DbSet<TEntity> _dbSet => _context.Set<TEntity>();

   //     public virtual IQueryable<TEntity> _queryableSet => _dbSet;


        /// <summary>
        /// Seznam repository
        /// </summary>

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context">Databázový kontext (DI)</param>
        /// <param name="repository">Seznam repository (DI)</param>
        public ReadOnlyRepositoryBase(/*DatabaseContext context*/)
        {
        //    _context = context;
        }


        public List<OutputXmlEntity> GetOutputXmls(string connectionString, int outputId, int? xmlType, int? userId)
        {
            List<OutputXmlEntity> result = new List<OutputXmlEntity>();

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))// "Host=localhost:5432;Database=ambica;Username=ambica;Password=ambica"))  // "postgres://localhost:5432/ambica?user=ambica&password=ambica"/*connectionString*/))
            {
                //            using (SqlCommand cmd = new SqlCommand("[amb].[GetAccecibleDocuments]", con))
                using (NpgsqlCommand cmd = new NpgsqlCommand($"select xmldata from demo.outputs where id = {outputId}", con))
                {

                    try
                    {
                        con.Open();

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OutputXmlEntity output = new OutputXmlEntity();
                            output.Id = outputId;
                            output.XmlData = (string)reader["xmldata"];

                            result.Add(output);
                        }
                    }
                    catch (Exception e)
                    {
                        int i = 0;
                        //   throw new Exception(SPTranslator.Translate(cmd), con.ConnectionString, "Exception in stored procedure.", e);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
/*

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[amb].[GetOutputXmls]", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("OutputId", outputId));
                    if (xmlType.HasValue)
                        cmd.Parameters.Add(new SqlParameter("XmlType", xmlType.Value));
                    else
                        cmd.Parameters.Add(new SqlParameter("XmlType", DBNull.Value));
                    if (userId.HasValue)
                        cmd.Parameters.Add(new SqlParameter("UserId", userId.Value));
                    else
                        cmd.Parameters.Add(new SqlParameter("UserId", DBNull.Value));

                    con.Open();

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OutputXmlEntity xml = new OutputXmlEntity();
                            xml.Id = (int)reader["Id"];
                            xml.OutputId = (int)reader["OutputId"];
                            if (reader["UserId"] != DBNull.Value)
                                xml.UserId = (int)reader["UserId"];
                            xml.XmlData = reader["XmlData"].ToString();
                            xml.XmlType = (byte)reader["XmlType"];
                            xml.OutputType = (byte)reader["OutputType"];
                            if (reader["File"] != DBNull.Value)
                                xml.File = (byte[])reader["File"];
                            result.Add(xml);
                        }
                    }
                    catch (Exception e)
                    {
                     //   throw new Exception(SPTranslator.Translate(cmd), con.ConnectionString, "Exception in stored procedure.", e);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }*/
            return result;
        }

        public List<OutputEntity> GetOutputs(string connectionString)
        {
            try
            {
                List<OutputEntity> result = new List<OutputEntity>();

                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))// "Host=localhost:5432;Database=ambica;Username=ambica;Password=ambica"))  // "postgres://localhost:5432/ambica?user=ambica&password=ambica"/*connectionString*/))
                {

                    //            using (SqlCommand cmd = new SqlCommand("[amb].[GetAccecibleDocuments]", con))
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select id, name, type from demo.outputs", con))
                    {

                        /*      cmd.CommandType = CommandType.StoredProcedure;

                              cmd.Parameters.Add(new SqlParameter("UserId", 100));
                              cmd.Parameters.Add(new SqlParameter("SuperUser", 1));
                              cmd.Parameters.Add(new SqlParameter("FolderId", DBNull.Value));
                              cmd.Parameters.Add(new SqlParameter("FullRefresh", DBNull.Value));*/

                        try
                        {
                            con.Open();

                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                var type = (short)reader["type"];
                                if (type == 1)
                                {
                                    OutputEntity output = new OutputEntity();
                                    output.Id = (int)reader["id"];
                                    output.Name = (string)reader["name"];

                                    result.Add(output);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            OutputEntity output = new OutputEntity();
                            output.Id = 1;
                            output.Name = e.GetBaseException().Message;

                            result.Add(output);
                            //   throw new Exception(SPTranslator.Translate(cmd), con.ConnectionString, "Exception in stored procedure.", e);
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                }
                return result;
            }
            catch (Exception e)
            {
                int i = 0;
                
                return new List<OutputEntity>(); 
            }
        }
    }
}
