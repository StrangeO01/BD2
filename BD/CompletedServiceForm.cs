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
    public partial class CompletedServiceForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public CompletedServiceForm()
        {
            InitializeComponent();
        }

        private void CompletedServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.record_book". При необходимости она может быть перемещена или удалена.
            this.record_bookTableAdapter.Fill(this.auto1DataSet.record_book);

        }

        private void SCSFormOpenButton_Click(object sender, EventArgs e)
        {
            SaveCompletedServiceForm saveCompletedServiceForm = new SaveCompletedServiceForm();
            saveCompletedServiceForm.ShowDialog();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_up = "UPDATE record_book SET id_car= \'" + textBoxIdCar.Text + "\' WHERE id_str=" + id_t + ";";
            string sql_up2 = "UPDATE record_book SET id_service= \'" + textBoxIdService.Text + "\' WHERE id_str=" + id_t + ";";
            string sql_up3 = "UPDATE record_book SET date= \'" + textBoxDate.Text + "\' WHERE id_str=" + id_t + ";";
            string sql_up4 = "UPDATE record_book SET cost= \'" + textBoxCost.Text + "\' WHERE id_str=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            SqlCommand command2 = connect.CreateCommand();
            SqlCommand command3 = connect.CreateCommand();
            SqlCommand command4 = connect.CreateCommand();
            command.CommandText = sql_up;
            command2.CommandText = sql_up2;
            command.CommandText = sql_up3;
            command2.CommandText = sql_up4;
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connect.Close();
            this.record_bookTableAdapter.Fill(this.auto1DataSet.record_book);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_del = "DELETE record_book WHERE id_str=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_del;
            command.ExecuteNonQuery();
            connect.Close();
            this.record_bookTableAdapter.Fill(this.auto1DataSet.record_book);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdCar.Text = id_t;
                textBoxIdService.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                textBoxDate.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
                textBoxCost.Text = dataGridView1.Rows[ts].Cells[3].Value.ToString();
            }
        }
    }
}
