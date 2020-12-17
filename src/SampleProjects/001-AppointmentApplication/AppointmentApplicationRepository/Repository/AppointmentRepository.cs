using CSD.AppointmentApplication.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


using static CSD.AppointmentApplication.Repository.Global;

namespace CSD.AppointmentApplication.Repository
{
    public class AppointmentRepository
    {
        private readonly static string ms_insertCmd = @"insert into appointments (client_id, date) values (@client_id, @date)";
        private readonly static string ms_selectByClientIdCmd = @"select * from appointments where client_id=@client_id";

        private static List<Appointment> getAppointments(SqlDataReader dr)
        {
            var appointments = new List<Appointment>();

            while (dr.Read())
                appointments.Add(new Appointment { Id = (int)dr[0], ClientId = (int)dr[1], Date = (DateTime)dr[2] });

            return appointments;
        }

        public Appointment Save(Appointment appointment)
        {
            try
            {
                using var command = new SqlCommand(ms_insertCmd, Connection);

                command.Parameters.AddWithValue("@client_id", appointment.ClientId);
                command.Parameters.AddWithValue("@date", appointment.Date);
                Connection.Open();
                command.ExecuteNonQuery();
            }
            finally {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }

            return appointment;
        }

        public List<Appointment> GetAppointmentsByClientId(int clientId)
        {
            try
            {
                using var command = new SqlCommand(ms_selectByClientIdCmd, Connection);

                command.Parameters.AddWithValue("@client_id", clientId);                
                Connection.Open();
                return getAppointments(command.ExecuteReader());
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
        }
    }
}
