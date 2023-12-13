namespace BD
{
    partial class SaveCompletedServiceForm
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
            this.recordbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto1DataSet = new BD.Auto1DataSet();
            this.record_bookTableAdapter = new BD.Auto1DataSetTableAdapters.record_bookTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveCompletedServiceOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxIdCar = new System.Windows.Forms.ComboBox();
            this.comboBoxIdService = new System.Windows.Forms.ComboBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.idstrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new BD.Auto1DataSetTableAdapters.carsTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new BD.Auto1DataSetTableAdapters.servicesTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstrDataGridViewTextBoxColumn,
            this.Expr1,
            this.Expr2,
            this.dateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordbookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(633, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // recordbookBindingSource
            // 
            this.recordbookBindingSource.DataMember = "record_book";
            this.recordbookBindingSource.DataSource = this.auto1DataSet;
            // 
            // auto1DataSet
            // 
            this.auto1DataSet.DataSetName = "Auto1DataSet";
            this.auto1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // record_bookTableAdapter
            // 
            this.record_bookTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(652, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 48);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveCompletedServiceOpenButton
            // 
            this.SaveCompletedServiceOpenButton.Location = new System.Drawing.Point(652, 13);
            this.SaveCompletedServiceOpenButton.Name = "SaveCompletedServiceOpenButton";
            this.SaveCompletedServiceOpenButton.Size = new System.Drawing.Size(145, 48);
            this.SaveCompletedServiceOpenButton.TabIndex = 4;
            this.SaveCompletedServiceOpenButton.Text = "Новый";
            this.SaveCompletedServiceOpenButton.UseVisualStyleBackColor = true;
            this.SaveCompletedServiceOpenButton.Click += new System.EventHandler(this.SaveCompletedServiceOpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код машины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата проведения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 10;
            // 
            // comboBoxIdCar
            // 
            this.comboBoxIdCar.DataSource = this.carsBindingSource;
            this.comboBoxIdCar.DisplayMember = "id_car";
            this.comboBoxIdCar.FormattingEnabled = true;
            this.comboBoxIdCar.Location = new System.Drawing.Point(172, 384);
            this.comboBoxIdCar.Name = "comboBoxIdCar";
            this.comboBoxIdCar.Size = new System.Drawing.Size(121, 28);
            this.comboBoxIdCar.TabIndex = 11;
            this.comboBoxIdCar.ValueMember = "id_car";
            // 
            // comboBoxIdService
            // 
            this.comboBoxIdService.DataSource = this.servicesBindingSource;
            this.comboBoxIdService.DisplayMember = "service";
            this.comboBoxIdService.FormattingEnabled = true;
            this.comboBoxIdService.Location = new System.Drawing.Point(172, 419);
            this.comboBoxIdService.Name = "comboBoxIdService";
            this.comboBoxIdService.Size = new System.Drawing.Size(121, 28);
            this.comboBoxIdService.TabIndex = 12;
            this.comboBoxIdService.ValueMember = "id_service";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(172, 452);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 26);
            this.textBoxDate.TabIndex = 13;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(172, 484);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 26);
            this.textBoxCost.TabIndex = 14;
            // 
            // idstrDataGridViewTextBoxColumn
            // 
            this.idstrDataGridViewTextBoxColumn.DataPropertyName = "id_str";
            this.idstrDataGridViewTextBoxColumn.HeaderText = "Номер строки";
            this.idstrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idstrDataGridViewTextBoxColumn.Name = "idstrDataGridViewTextBoxColumn";
            this.idstrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstrDataGridViewTextBoxColumn.Width = 80;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            this.Expr1.HeaderText = "Код машины";
            this.Expr1.MinimumWidth = 8;
            this.Expr1.Name = "Expr1";
            this.Expr1.ReadOnly = true;
            this.Expr1.Width = 80;
            // 
            // Expr2
            // 
            this.Expr2.DataPropertyName = "Expr2";
            this.Expr2.HeaderText = "Код услуги";
            this.Expr2.MinimumWidth = 8;
            this.Expr2.Name = "Expr2";
            this.Expr2.ReadOnly = true;
            this.Expr2.Width = 80;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 120;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.auto1DataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.auto1DataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(802, 576);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 26);
            this.textBox2.TabIndex = 15;
            // 
            // SaveCompletedServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 614);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBoxIdService);
            this.Controls.Add(this.comboBoxIdCar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveCompletedServiceOpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaveCompletedServiceForm";
            this.Text = "SaveCompletedServiceForm";
            this.Load += new System.EventHandler(this.SaveCompletedServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Auto1DataSet auto1DataSet;
        private System.Windows.Forms.BindingSource recordbookBindingSource;
        private Auto1DataSetTableAdapters.record_bookTableAdapter record_bookTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveCompletedServiceOpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxIdCar;
        private System.Windows.Forms.ComboBox comboBoxIdService;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Auto1DataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Auto1DataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
    }
}