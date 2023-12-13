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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD
{
    public partial class ClientForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_up = "UPDATE clients SET name= \'" + textBoxNameClient.Text + "\' WHERE id_client=" + id_t + ";";
            string sql_up2 = "UPDATE clients SET number= \'" + textBoxNumber.Text + "\' WHERE id_client=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            SqlCommand command2 = connect.CreateCommand();
            command.CommandText = sql_up;
            command2.CommandText = sql_up2;
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connect.Close();
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            textBoxIdClient.Text = "";
            textBoxNameClient.Text = "";
            textBoxNumber.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_in = $"INSERT INTO clients (name, number) VALUES (\'{textBoxNameClient.Text}\',\'{textBoxNumber.Text}\');";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_in;
            command.ExecuteNonQuery();
            connect.Close();
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_del = "DELETE clients WHERE id_client=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_del;
            command.ExecuteNonQuery();
            connect.Close();
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdClient.Text = id_t;
                textBoxNameClient.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                textBoxNumber.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
            }
        }
    }
}
