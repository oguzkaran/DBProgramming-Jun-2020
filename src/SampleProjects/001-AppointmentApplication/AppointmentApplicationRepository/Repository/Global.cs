using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CSD.AppointmentApplication.Repository
{
    public static class Global
    {
        private static readonly string ms_connectionString = @"Server=.;Database=appointmentdb;Trusted_Connection=True;";
        public readonly static SqlConnection Connection = new SqlConnection(ms_connectionString);
    }
}
