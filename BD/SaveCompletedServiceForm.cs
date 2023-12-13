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
    public partial class SaveCompletedServiceForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public SaveCompletedServiceForm()
        {
            InitializeComponent();
        }

        private void SaveCompletedServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.record_book". При необходимости она может быть перемещена или удалена.
            this.record_bookTableAdapter.Fill(this.auto1DataSet.record_book);

        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(comboBoxIdCar.SelectedValue.ToString()) || string.IsNullOrWhiteSpace(comboBoxIdService.SelectedValue.ToString()) || string.IsNullOrWhiteSpace(textBoxDate.Text) || string.IsNullOrWhiteSpace(textBoxCost.Text))
            {
                MessageBox.Show("Заполните все поля перед продолжением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveCompletedServiceOpenButton_Click(object sender, EventArgs e)
        {
            comboBoxIdCar.Text = "";
            comboBoxIdService.Text = "";
            textBoxDate.Text = "";
            textBoxCost.Text = "";
        }
        private void sql_Command(string request)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            textBox2.Text = request;
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = request;
            command.ExecuteNonQuery();
            connect.Close();
            this.carsTableAdapter.Fill(this.auto1DataSet.cars);
            this.servicesTableAdapter.Fill(this.auto1DataSet.services);
            this.record_bookTableAdapter.Fill(this.auto1DataSet.record_book);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                comboBoxIdCar.Text = id_t;
                comboBoxIdService.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
                textBoxDate.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
                textBoxCost.Text = dataGridView1.Rows[ts].Cells[3].Value.ToString();

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                string sqlIncert = $"UPDATE record_book SET id_car = {comboBoxIdCar.SelectedValue}, id_service = {comboBoxIdService.SelectedValue}," +
                    $"date = \'{textBoxDate.Text}\', cost = '{textBoxCost.Text}' WHERE id_str = {id_t};";
                sql_Command(sqlIncert);
            }
        }
    }
}
