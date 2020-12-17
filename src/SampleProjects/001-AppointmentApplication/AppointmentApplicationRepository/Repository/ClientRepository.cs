using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CSD.AppointmentApplication.Entity;

using static CSD.AppointmentApplication.Repository.Global;

namespace CSD.AppointmentApplication.Repository
{
    public class ClientRepository
    {
        
        private static readonly string ms_insertCmd = @"sp_insert_client";
        private static readonly string ms_selectAllCmd = @"select * from clients";        

        private static List<Client> getClients(SqlDataReader dr)
        {
            var clients = new List<Client>();

            while (dr.Read())
                clients.Add(new Client { Id = (int)dr[0], Name = (string)dr[2], Email = (string)dr[1], Phone = (string)dr[3] });

            return clients;
        }

        public List<Client> All {
            get {
                try
                {                    
                    using var sqlCommand = new SqlCommand(ms_selectAllCmd, Connection);

                    Connection.Open();

                    return getClients(sqlCommand.ExecuteReader());
                }
                finally {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }
            }
        }

        public Client Save(Client client)
        {
            try
            {
                using var sqlCommand = new SqlCommand(ms_insertCmd, Connection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", client.Name);
                sqlCommand.Parameters.AddWithValue("@email", client.Email);
                sqlCommand.Parameters.AddWithValue("@phone", client.Phone);
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return client;
        }



    }
}
