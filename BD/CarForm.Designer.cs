namespace BD
{
    partial class CarForm
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataGaranty = new System.Windows.Forms.TextBox();
            this.textBoxIdCar = new System.Windows.Forms.TextBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.SaveCarFormShowButton = new System.Windows.Forms.Button();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto1DataSet = new BD.Auto1DataSet();
            this.carsTableAdapter = new BD.Auto1DataSetTableAdapters.carsTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new BD.Auto1DataSetTableAdapters.clientsTableAdapter();
            this.markscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marks_carTableAdapter = new BD.Auto1DataSetTableAdapters.marks_carTableAdapter();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(582, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(601, 13);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(145, 48);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(600, 67);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(145, 48);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Код машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата гарантии";
            // 
            // textBoxDataGaranty
            // 
            this.textBoxDataGaranty.Location = new System.Drawing.Point(146, 426);
            this.textBoxDataGaranty.Name = "textBoxDataGaranty";
            this.textBoxDataGaranty.Size = new System.Drawing.Size(121, 26);
            this.textBoxDataGaranty.TabIndex = 9;
            // 
            // textBoxIdCar
            // 
            this.textBoxIdCar.Location = new System.Drawing.Point(146, 330);
            this.textBoxIdCar.Name = "textBoxIdCar";
            this.textBoxIdCar.ReadOnly = true;
            this.textBoxIdCar.Size = new System.Drawing.Size(121, 26);
            this.textBoxIdCar.TabIndex = 10;
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Location = new System.Drawing.Point(146, 362);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(121, 26);
            this.textBoxIdClient.TabIndex = 15;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(146, 394);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.ReadOnly = true;
            this.textBoxMark.Size = new System.Drawing.Size(121, 26);
            this.textBoxMark.TabIndex = 16;
            // 
            // SaveCarFormShowButton
            // 
            this.SaveCarFormShowButton.Location = new System.Drawing.Point(600, 121);
            this.SaveCarFormShowButton.Name = "SaveCarFormShowButton";
            this.SaveCarFormShowButton.Size = new System.Drawing.Size(145, 48);
            this.SaveCarFormShowButton.TabIndex = 17;
            this.SaveCarFormShowButton.Text = "Новый";
            this.SaveCarFormShowButton.UseVisualStyleBackColor = true;
            this.SaveCarFormShowButton.Click += new System.EventHandler(this.SaveCarFormShowButton_Click);
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.auto1DataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // markscarBindingSource
            // 
            this.markscarBindingSource.DataMember = "marks_car";
            this.markscarBindingSource.DataSource = this.auto1DataSet;
            // 
            // marks_carTableAdapter
            // 
            this.marks_carTableAdapter.ClearBeforeFill = true;
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
            this.id_client1.Width = 80;
            // 
            // id_mark1
            // 
            this.id_mark1.DataPropertyName = "id_mark1";
            this.id_mark1.HeaderText = "Код марки";
            this.id_mark1.MinimumWidth = 8;
            this.id_mark1.Name = "id_mark1";
            this.id_mark1.ReadOnly = true;
            this.id_mark1.Width = 80;
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
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 465);
            this.Controls.Add(this.SaveCarFormShowButton);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.textBoxIdCar);
            this.Controls.Add(this.textBoxDataGaranty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
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
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataGaranty;
        private System.Windows.Forms.TextBox textBoxIdCar;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Auto1DataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource markscarBindingSource;
        private Auto1DataSetTableAdapters.marks_carTableAdapter marks_carTableAdapter;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Button SaveCarFormShowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategarantyDataGridViewTextBoxColumn;
    }
}