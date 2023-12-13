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
    public partial class CarForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.marks_car". При необходимости она может быть перемещена или удалена.
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_up = "UPDATE cars SET id_client= \'" + textBoxIdClient.Text + "\' WHERE id_car=" + id_t + ";";
            string sql_up2 = "UPDATE cars SET date_garanty= \'" + textBoxDataGaranty.Text + "\' WHERE id_car=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            SqlCommand command2 = connect.CreateCommand();
            command.CommandText = sql_up;
            command2.CommandText = sql_up2;
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connect.Close();
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_del = "DELETE cars WHERE id_car=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_del;
            command.ExecuteNonQuery();
            connect.Close();
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdCar.Text = id_t;
                textBoxIdClient.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                textBoxMark.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
                textBoxDataGaranty.Text = dataGridView1.Rows[ts].Cells[3].Value.ToString();
            }
        }

        private void SaveCarFormShowButton_Click(object sender, EventArgs e)
        {
            SaveCarForm saveCarForm = new SaveCarForm();
            saveCarForm.ShowDialog();
        }
    }
}
