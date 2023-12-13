namespace BD
{
    partial class AppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientFormShowButton = new System.Windows.Forms.Button();
            this.MarkFormShowButton = new System.Windows.Forms.Button();
            this.ServiceFormShowButton = new System.Windows.Forms.Button();
            this.CarFormShowButton = new System.Windows.Forms.Button();
            this.CompletedServiceFormShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientFormShowButton
            // 
            this.ClientFormShowButton.Location = new System.Drawing.Point(51, 31);
            this.ClientFormShowButton.Name = "ClientFormShowButton";
            this.ClientFormShowButton.Size = new System.Drawing.Size(132, 61);
            this.ClientFormShowButton.TabIndex = 0;
            this.ClientFormShowButton.Text = "Клиенты";
            this.ClientFormShowButton.UseVisualStyleBackColor = true;
            this.ClientFormShowButton.Click += new System.EventHandler(this.ClientFormShowButton_Click);
            // 
            // MarkFormShowButton
            // 
            this.MarkFormShowButton.Location = new System.Drawing.Point(189, 31);
            this.MarkFormShowButton.Name = "MarkFormShowButton";
            this.MarkFormShowButton.Size = new System.Drawing.Size(120, 61);
            this.MarkFormShowButton.TabIndex = 1;
            this.MarkFormShowButton.Text = "Марки";
            this.MarkFormShowButton.UseVisualStyleBackColor = true;
            this.MarkFormShowButton.Click += new System.EventHandler(this.MarkFormShowButton_Click);
            // 
            // ServiceFormShowButton
            // 
            this.ServiceFormShowButton.Location = new System.Drawing.Point(315, 31);
            this.ServiceFormShowButton.Name = "ServiceFormShowButton";
            this.ServiceFormShowButton.Size = new System.Drawing.Size(114, 61);
            this.ServiceFormShowButton.TabIndex = 2;
            this.ServiceFormShowButton.Text = "Услуги";
            this.ServiceFormShowButton.UseVisualStyleBackColor = true;
            this.ServiceFormShowButton.Click += new System.EventHandler(this.ServiceFormShowButton_Click);
            // 
            // CarFormShowButton
            // 
            this.CarFormShowButton.Location = new System.Drawing.Point(51, 98);
            this.CarFormShowButton.Name = "CarFormShowButton";
            this.CarFormShowButton.Size = new System.Drawing.Size(131, 59);
            this.CarFormShowButton.TabIndex = 3;
            this.CarFormShowButton.Text = "Машины";
            this.CarFormShowButton.UseVisualStyleBackColor = true;
            this.CarFormShowButton.Click += new System.EventHandler(this.CarFormShowButton_Click);
            // 
            // CompletedServiceFormShowButton
            // 
            this.CompletedServiceFormShowButton.Location = new System.Drawing.Point(188, 98);
            this.CompletedServiceFormShowButton.Name = "CompletedServiceFormShowButton";
            this.CompletedServiceFormShowButton.Size = new System.Drawing.Size(241, 59);
            this.CompletedServiceFormShowButton.TabIndex = 4;
            this.CompletedServiceFormShowButton.Text = "Записная книжка";
            this.CompletedServiceFormShowButton.UseVisualStyleBackColor = true;
            this.CompletedServiceFormShowButton.Click += new System.EventHandler(this.CompletedServiceFormShowButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompletedServiceFormShowButton);
            this.Controls.Add(this.CarFormShowButton);
            this.Controls.Add(this.ServiceFormShowButton);
            this.Controls.Add(this.MarkFormShowButton);
            this.Controls.Add(this.ClientFormShowButton);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientFormShowButton;
        private System.Windows.Forms.Button MarkFormShowButton;
        private System.Windows.Forms.Button ServiceFormShowButton;
        private System.Windows.Forms.Button CarFormShowButton;
        private System.Windows.Forms.Button CompletedServiceFormShowButton;
    }
}

