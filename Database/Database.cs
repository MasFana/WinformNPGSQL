using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WinformNPGSQL.Database
{
	public static class DB
	{
		public static NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=pbo");
		public static void Open()
		{
			if (conn.State == System.Data.ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		public static void Close()
		{
			conn.Close();
		}

		public static DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            Open();
            DataTable dt = new DataTable();
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
					cmd.Parameters.AddRange(parameters);
					dt.Load(reader);
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string command, params NpgsqlParameter[] parameters)
        {
            Open();
            using (var cmd = new NpgsqlCommand(command, conn))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
	}

}
