using CSD.AppointmentApplication.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using CSD.AppointmentApplication.Entity;

namespace AppointmentApplicationDesktop
{
    public partial class ClientsListForm : Form
    {
        private AppointmentApplicationHelper m_appointmentApplicationHelper = new AppointmentApplicationHelper();

        private void loadAppointments()
        {
            try
            {
                if (m_listBoxClients.SelectedIndex == -1)
                    return;

                var client = m_listBoxClients.SelectedItem as Client;
                m_listBoxClientsAppointments.Items.Clear();
                m_appointmentApplicationHelper.GetAppointmetsByClientId(client.Id)
                    .ForEach(a => m_listBoxClientsAppointments.Items.Add(a));
            }
            catch
            {
                MessageBox.Show("Beklenmedik bir durum oluştu", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClientsListForm()
        {
            InitializeComponent();
            m_listBoxClients.DisplayMember = "Name";
            m_listBoxClientsAppointments.DisplayMember = "Date";
        }

        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                m_appointmentApplicationHelper.GetAllClients().ForEach(c => m_listBoxClients.Items.Add(c));
            }
            catch {
                MessageBox.Show("Beklenmedik bir durum oluştu", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_listBoxClients_DoubleClick(object sender, EventArgs e)
        {

        }

        private void m_listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_listBoxClients.SelectedIndex == -1) {
                m_groupBoxDate.Enabled = false;
                return;
            }

            this.loadAppointments();
            m_groupBoxDate.Enabled = true;
        }

        private void m_buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_listBoxClients.SelectedIndex == -1)
                    return;

                var client = m_listBoxClients.SelectedItem as Client;
                var date = m_dateTimePickerDate.Value;

                var appointment = new Appointment { ClientId = client.Id, Date = date };

                m_appointmentApplicationHelper.SaveAppointment(appointment);
                this.loadAppointments();
            }
            catch
            {
                MessageBox.Show("Beklenmedik bir durum oluştu", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
