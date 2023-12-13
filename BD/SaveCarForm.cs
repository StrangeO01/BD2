using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD
{
    public partial class SaveCarForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public SaveCarForm()
        {
            InitializeComponent();
        }

        private void SaveCarForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.marks_car". При необходимости она может быть перемещена или удалена.
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdCar.Text = id_t;
                comboBoxClient.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                comboBoxMark.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
                textBoxDateGaranty.Text = dataGridView1.Rows[ts].Cells[3].Value.ToString();
            }
        }

        private void NewCarButton_Click(object sender, EventArgs e)
        {
            textBoxIdCar.Text = "";
            comboBoxClient.Text = "";
            comboBoxMark.Text = "";
            textBoxDateGaranty.Text = "";
        }

        private void sql_Command(string request)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            textBox4.Text = request;
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = request;
            command.ExecuteNonQuery();
            connect.Close();
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
            this.clientsTableAdapter.Fill(this.auto1DataSet.clients);
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(comboBoxClient.SelectedValue.ToString()) || string.IsNullOrWhiteSpace(comboBoxMark.SelectedValue.ToString()) || string.IsNullOrWhiteSpace(textBoxDateGaranty.Text))
            {
                MessageBox.Show("Заполните все поля перед продолжением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                string sqlIncert = $"UPDATE cars SET id_client = {comboBoxClient.SelectedValue}, id_mark = {comboBoxMark.SelectedValue}," +
                    $"date_garanty = \'{textBoxDateGaranty.Text}\' WHERE id_car = {id_t};";
                sql_Command(sqlIncert);
            }

        }
      
    }
}
