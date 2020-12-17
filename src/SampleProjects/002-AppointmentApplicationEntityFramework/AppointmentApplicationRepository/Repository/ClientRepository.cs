using CSD.AppointmentApplication.Data;
using CSD.AppointmentApplication.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CSD.AppointmentApplication.Repository
{
    public class ClientRepository
    {
        private readonly AppointmentDbContext m_appointmentDbContext = new AppointmentDbContext();
        public List<Client> All => m_appointmentDbContext.Clients.ToList();        

        public Client Save(Client client)
        {
            m_appointmentDbContext.Clients.Add(client);
            m_appointmentDbContext.SaveChanges();

            return client;
        }
    }
}
