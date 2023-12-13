namespace BD
{
    partial class SaveCarForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto1DataSet = new BD.Auto1DataSet();
            this.carsTableAdapter = new BD.Auto1DataSetTableAdapters.carsTableAdapter();
            this.NewCarButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdCar = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.markscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDateGaranty = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new BD.Auto1DataSetTableAdapters.clientsTableAdapter();
            this.marks_carTableAdapter = new BD.Auto1DataSetTableAdapters.marks_carTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.idcarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_mark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dategarantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markscarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcarDataGridViewTextBoxColumn,
            this.id_client1,
            this.id_mark1,
            this.dategarantyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(619, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.auto1DataSet;
            // 
            // auto1DataSet
            // 
            this.auto1DataSet.DataSetName = "Auto1DataSet";
            this.auto1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // NewCarButton
            // 
            this.NewCarButton.Location = new System.Drawing.Point(638, 13);
            this.NewCarButton.Name = "NewCarButton";
            this.NewCarButton.Size = new System.Drawing.Size(145, 48);
            this.NewCarButton.TabIndex = 1;
            this.NewCarButton.Text = "Новый";
            this.NewCarButton.UseVisualStyleBackColor = true;
            this.NewCarButton.Click += new System.EventHandler(this.NewCarButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(638, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 48);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата гарантии";
            // 
            // textBoxIdCar
            // 
            this.textBoxIdCar.Location = new System.Drawing.Point(157, 297);
            this.textBoxIdCar.Name = "textBoxIdCar";
            this.textBoxIdCar.ReadOnly = true;
            this.textBoxIdCar.Size = new System.Drawing.Size(121, 26);
            this.textBoxIdCar.TabIndex = 7;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientsBindingSource;
            this.comboBoxClient.DisplayMember = "name";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(157, 330);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 28);
            this.comboBoxClient.TabIndex = 8;
            this.comboBoxClient.ValueMember = "id_client";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.auto1DataSet;
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.DataSource = this.markscarBindingSource;
            this.comboBoxMark.DisplayMember = "mark";
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Location = new System.Drawing.Point(157, 365);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMark.TabIndex = 9;
            this.comboBoxMark.ValueMember = "id_mark";
            // 
            // markscarBindingSource
            // 
            this.markscarBindingSource.DataMember = "marks_car";
            this.markscarBindingSource.DataSource = this.auto1DataSet;
            // 
            // textBoxDateGaranty
            // 
            this.textBoxDateGaranty.Location = new System.Drawing.Point(157, 400);
            this.textBoxDateGaranty.Name = "textBoxDateGaranty";
            this.textBoxDateGaranty.Size = new System.Drawing.Size(121, 26);
            this.textBoxDateGaranty.TabIndex = 10;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // marks_carTableAdapter
            // 
            this.marks_carTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(751, 412);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 26);
            this.textBox4.TabIndex = 19;
            // 
            // idcarDataGridViewTextBoxColumn
            // 
            this.idcarDataGridViewTextBoxColumn.DataPropertyName = "id_car";
            this.idcarDataGridViewTextBoxColumn.HeaderText = "Код машины";
            this.idcarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcarDataGridViewTextBoxColumn.Name = "idcarDataGridViewTextBoxColumn";
            this.idcarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcarDataGridViewTextBoxColumn.Width = 80;
            // 
            // id_client1
            // 
            this.id_client1.DataPropertyName = "id_client1";
            this.id_client1.HeaderText = "Код клиента";
            this.id_client1.MinimumWidth = 8;
            this.id_client1.Name = "id_client1";
            this.id_client1.ReadOnly = true;
            this.id_client1.Width = 150;
            // 
            // id_mark1
            // 
            this.id_mark1.DataPropertyName = "id_mark1";
            this.id_mark1.HeaderText = "Код марки";
            this.id_mark1.MinimumWidth = 8;
            this.id_mark1.Name = "id_mark1";
            this.id_mark1.ReadOnly = true;
            this.id_mark1.Width = 150;
            // 
            // dategarantyDataGridViewTextBoxColumn
            // 
            this.dategarantyDataGridViewTextBoxColumn.DataPropertyName = "date_garanty";
            this.dategarantyDataGridViewTextBoxColumn.HeaderText = "Дата гарантии";
            this.dategarantyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dategarantyDataGridViewTextBoxColumn.Name = "dategarantyDataGridViewTextBoxColumn";
            this.dategarantyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dategarantyDataGridViewTextBoxColumn.Width = 120;
            // 
            // SaveCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxDateGaranty);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxIdCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewCarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaveCarForm";
            this.Text = "SaveCarForm";
            this.Load += new System.EventHandler(this.SaveCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markscarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Auto1DataSet auto1DataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Auto1DataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.Button NewCarButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdCar;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.TextBox textBoxDateGaranty;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Auto1DataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource markscarBindingSource;
        private Auto1DataSetTableAdapters.marks_carTableAdapter marks_carTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategarantyDataGridViewTextBoxColumn;
    }
}