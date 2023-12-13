using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void ClientFormShowButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void MarkFormShowButton_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.ShowDialog();
        }

        private void ServiceFormShowButton_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void CarFormShowButton_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            carForm.ShowDialog();
        }

        private void CompletedServiceFormShowButton_Click(object sender, EventArgs e)
        {
            CompletedServiceForm completedServiceForm = new CompletedServiceForm();
            completedServiceForm.ShowDialog();
        }
    }
}
