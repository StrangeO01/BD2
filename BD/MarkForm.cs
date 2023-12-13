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
    public partial class MarkForm : Form
    {
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=MSI;Initial Catalog=Auto1;Integrated Security=True";
        string id_t;
        public MarkForm()
        {
            InitializeComponent();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "auto1DataSet.marks_car". При необходимости она может быть перемещена или удалена.
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_up = "UPDATE marks_car SET mark= \'" + textBoxMark.Text + "\' WHERE id_mark=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_up;
            command.ExecuteNonQuery();
            connect.Close();
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
        }

        private void NewMarkButton_Click(object sender, EventArgs e)
        {
            textBoxIdMark.Text = "";
            textBoxMark.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_in = $"INSERT INTO marks_car (mark) VALUES (\'{textBoxMark.Text}\');";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_in;
            command.ExecuteNonQuery();
            connect.Close();
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            string sql_del = "DELETE marks_car WHERE id_mark=" + id_t + ";";
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql_del;
            command.ExecuteNonQuery();
            connect.Close();
            this.marks_carTableAdapter.Fill(this.auto1DataSet.marks_car);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int ts = dataGridView1.CurrentRow.Index;

                id_t = dataGridView1.Rows[ts].Cells[0].Value.ToString();
                textBoxIdMark.Text = id_t;
                textBoxMark.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
            }
        }
    }
}
