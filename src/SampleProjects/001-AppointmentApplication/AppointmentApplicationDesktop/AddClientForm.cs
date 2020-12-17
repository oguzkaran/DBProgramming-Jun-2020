using CSD.AppointmentApplication.DAL;
using CSD.AppointmentApplication.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AppointmentApplicationDesktop
{    
    public partial class AddClientForm : Form
    {
        private AppointmentApplicationHelper m_appointmentApplicationHelper = new AppointmentApplicationHelper();

        private void clearTexts()
        {
            foreach (var control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = "";
        }

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void m_buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var name = m_textBoxName.Text;
                var email = m_textBoxEmail.Text;
                var phone = m_textBoxPhone.Text;

                var client = new Client { Name = name, Email = email, Phone = phone };

                m_appointmentApplicationHelper.SaveClient(client);
                this.Close();
            }
            catch (AggregateException) {
                MessageBox.Show("Beklenmedik bir durum oluştu", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_buttonClear_Click(object sender, EventArgs e)
        {
            this.clearTexts();
        }

        private void m_buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
