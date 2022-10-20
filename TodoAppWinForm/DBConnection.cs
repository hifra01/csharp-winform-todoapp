using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWinForm
{
    internal class DBConnection
    {
        string dsn = "Host=localhost;Username=postgres;Password=postgres;Database=todolist;Port=5432";
        NpgsqlConnection conn;
        NpgsqlCommand? cmd;

        public DBConnection()
        {
            conn = new NpgsqlConnection(dsn);
        }

        public bool ExecuteNonQuery(string query, NpgsqlParameter[] queryParams)
        {
            try
            {
                cmd = new NpgsqlCommand(query, conn);

                foreach (var param in queryParams)
                {
                    cmd.Parameters.Add(param);
                }

                conn.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            } catch (NpgsqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return false;
            }
        }

        public DataSet ExecuteQueryRows(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new NpgsqlCommand(query, conn);
                conn.Open();
                new NpgsqlDataAdapter(cmd).Fill(ds);
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
    }
}
