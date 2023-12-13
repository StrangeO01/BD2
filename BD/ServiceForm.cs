using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class ServiceForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_up = "UPDATE services SET service= \'" + textBoxService.Text + "\' WHERE id_service=" + id_t + ";";
            string sql_up2 = "UPDATE services SET cost= \'" + textBoxCost.Text + "\' WHERE id_service=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            SqlCommand command2 = connect.CreateCommand();
            command.CommandText = sql_up;
            command2.CommandText = sql_up2;
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connect.Close();
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);
        }

        private void NewServiceButton_Click(object sender, EventArgs e)
        {
            textBoxIdService.Text = "";
            textBoxService.Text = "";
            textBoxCost.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_in = $"INSERT INTO services (service, cost) VALUES (\'{textBoxService.Text}\',\'{textBoxCost.Text}\');";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_in;
            command.ExecuteNonQuery();
            connect.Close();
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_del = "DELETE services WHERE id_service=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_del;
            command.ExecuteNonQuery();
            connect.Close();
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdService.Text = id_t;
                textBoxService.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                textBoxCost.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
            }
        }

    }
}
