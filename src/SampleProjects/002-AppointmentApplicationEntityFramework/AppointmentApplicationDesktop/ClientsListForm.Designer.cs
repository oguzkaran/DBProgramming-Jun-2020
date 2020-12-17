namespace AppointmentApplicationDesktop
{
    partial class ClientsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_listBoxClients = new System.Windows.Forms.ListBox();
            this.m_buttonExit = new System.Windows.Forms.Button();
            this.m_dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.m_groupBoxDate = new System.Windows.Forms.GroupBox();
            this.m_listBoxClientsAppointments = new System.Windows.Forms.ListBox();
            this.m_groupBoxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_listBoxClients
            // 
            this.m_listBoxClients.FormattingEnabled = true;
            this.m_listBoxClients.ItemHeight = 15;
            this.m_listBoxClients.Location = new System.Drawing.Point(57, 55);
            this.m_listBoxClients.Name = "m_listBoxClients";
            this.m_listBoxClients.Size = new System.Drawing.Size(105, 109);
            this.m_listBoxClients.TabIndex = 0;
            this.m_listBoxClients.SelectedIndexChanged += new System.EventHandler(this.m_listBoxClients_SelectedIndexChanged);
            this.m_listBoxClients.DoubleClick += new System.EventHandler(this.m_listBoxClients_DoubleClick);
            // 
            // m_buttonExit
            // 
            this.m_buttonExit.Location = new System.Drawing.Point(57, 210);
            this.m_buttonExit.Name = "m_buttonExit";
            this.m_buttonExit.Size = new System.Drawing.Size(77, 23);
            this.m_buttonExit.TabIndex = 1;
            this.m_buttonExit.Text = "Çıkış";
            this.m_buttonExit.UseVisualStyleBackColor = true;
            this.m_buttonExit.Click += new System.EventHandler(this.m_buttonExit_Click);
            // 
            // m_dateTimePickerDate
            // 
            this.m_dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dateTimePickerDate.Location = new System.Drawing.Point(119, 22);
            this.m_dateTimePickerDate.Name = "m_dateTimePickerDate";
            this.m_dateTimePickerDate.Size = new System.Drawing.Size(105, 23);
            this.m_dateTimePickerDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevu Zamanı";
            // 
            // m_buttonOK
            // 
            this.m_buttonOK.Location = new System.Drawing.Point(55, 73);
            this.m_buttonOK.Name = "m_buttonOK";
            this.m_buttonOK.Size = new System.Drawing.Size(75, 23);
            this.m_buttonOK.TabIndex = 2;
            this.m_buttonOK.Text = "Randevu Al";
            this.m_buttonOK.UseVisualStyleBackColor = true;
            this.m_buttonOK.Click += new System.EventHandler(this.m_buttonOK_Click);
            // 
            // m_groupBoxDate
            // 
            this.m_groupBoxDate.Controls.Add(this.m_listBoxClientsAppointments);
            this.m_groupBoxDate.Controls.Add(this.m_buttonOK);
            this.m_groupBoxDate.Controls.Add(this.label1);
            this.m_groupBoxDate.Controls.Add(this.m_dateTimePickerDate);
            this.m_groupBoxDate.Enabled = false;
            this.m_groupBoxDate.Location = new System.Drawing.Point(183, 38);
            this.m_groupBoxDate.Name = "m_groupBoxDate";
            this.m_groupBoxDate.Size = new System.Drawing.Size(258, 237);
            this.m_groupBoxDate.TabIndex = 3;
            this.m_groupBoxDate.TabStop = false;
            this.m_groupBoxDate.Text = "Randevu Tarihi Belirle";
            // 
            // m_listBoxClientsAppointments
            // 
            this.m_listBoxClientsAppointments.FormattingEnabled = true;
            this.m_listBoxClientsAppointments.ItemHeight = 15;
            this.m_listBoxClientsAppointments.Location = new System.Drawing.Point(55, 116);
            this.m_listBoxClientsAppointments.Name = "m_listBoxClientsAppointments";
            this.m_listBoxClientsAppointments.Size = new System.Drawing.Size(98, 94);
            this.m_listBoxClientsAppointments.TabIndex = 3;
            // 
            // ClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 316);
            this.Controls.Add(this.m_groupBoxDate);
            this.Controls.Add(this.m_buttonExit);
            this.Controls.Add(this.m_listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Müşteriler";
            this.Load += new System.EventHandler(this.ClientsListForm_Load);
            this.m_groupBoxDate.ResumeLayout(false);
            this.m_groupBoxDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_listBoxClients;
        private System.Windows.Forms.Button m_buttonExit;
        private System.Windows.Forms.DateTimePicker m_dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_buttonOK;
        private System.Windows.Forms.GroupBox m_groupBoxDate;
        private System.Windows.Forms.ListBox m_listBoxClientsAppointments;
    }
}