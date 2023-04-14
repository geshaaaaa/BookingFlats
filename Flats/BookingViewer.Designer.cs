namespace BookingUI
{
    partial class BookingViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.CheckInCalendar = new System.Windows.Forms.DateTimePicker();
            this.CheckOutCalendar = new System.Windows.Forms.DateTimePicker();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.DistrictDropdown = new System.Windows.Forms.ComboBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.RoomsDropdown = new System.Windows.Forms.ComboBox();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.FlatDropdown = new System.Windows.Forms.ComboBox();
            this.FlatLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.PriceEquals = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Aparts";
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInLabel.Location = new System.Drawing.Point(10, 160);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(182, 21);
            this.CheckInLabel.TabIndex = 2;
            this.CheckInLabel.Text = "Оберіть дату заселення:";
            // 
            // CheckInCalendar
            // 
            this.CheckInCalendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckInCalendar.Location = new System.Drawing.Point(211, 155);
            this.CheckInCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.CheckInCalendar.Name = "CheckInCalendar";
            this.CheckInCalendar.Size = new System.Drawing.Size(145, 29);
            this.CheckInCalendar.TabIndex = 3;
            this.CheckInCalendar.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // CheckOutCalendar
            // 
            this.CheckOutCalendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckOutCalendar.Location = new System.Drawing.Point(211, 215);
            this.CheckOutCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.CheckOutCalendar.Name = "CheckOutCalendar";
            this.CheckOutCalendar.Size = new System.Drawing.Size(145, 29);
            this.CheckOutCalendar.TabIndex = 4;
            this.CheckOutCalendar.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            this.CheckOutCalendar.ValueChanged += new System.EventHandler(this.CheckOutCalendar_ValueChanged);
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLabel.Location = new System.Drawing.Point(10, 220);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(184, 21);
            this.CheckOutLabel.TabIndex = 5;
            this.CheckOutLabel.Text = "Оберіть дату виселення:";
            // 
            // DistrictDropdown
            // 
            this.DistrictDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictDropdown.FormattingEnabled = true;
            this.DistrictDropdown.Location = new System.Drawing.Point(187, 94);
            this.DistrictDropdown.Name = "DistrictDropdown";
            this.DistrictDropdown.Size = new System.Drawing.Size(134, 29);
            this.DistrictDropdown.TabIndex = 6;
            this.DistrictDropdown.SelectedIndexChanged += new System.EventHandler(this.DistrictDropdown_SelectedIndexChanged_1);
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictLabel.Location = new System.Drawing.Point(194, 60);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(115, 21);
            this.DistrictLabel.TabIndex = 7;
            this.DistrictLabel.Text = "Оберіть район";
            // 
            // RoomsDropdown
            // 
            this.RoomsDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsDropdown.FormattingEnabled = true;
            this.RoomsDropdown.Location = new System.Drawing.Point(402, 94);
            this.RoomsDropdown.Name = "RoomsDropdown";
            this.RoomsDropdown.Size = new System.Drawing.Size(121, 29);
            this.RoomsDropdown.TabIndex = 8;
            this.RoomsDropdown.SelectedIndexChanged += new System.EventHandler(this.RoomsDropdown_SelectedIndexChanged);
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsLabel.Location = new System.Drawing.Point(399, 60);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(124, 21);
            this.RoomsLabel.TabIndex = 9;
            this.RoomsLabel.Text = "Кількість кімнат";
            // 
            // FlatDropdown
            // 
            this.FlatDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatDropdown.FormattingEnabled = true;
            this.FlatDropdown.Location = new System.Drawing.Point(622, 94);
            this.FlatDropdown.Name = "FlatDropdown";
            this.FlatDropdown.Size = new System.Drawing.Size(121, 29);
            this.FlatDropdown.TabIndex = 10;
            // 
            // FlatLabel
            // 
            this.FlatLabel.AutoSize = true;
            this.FlatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatLabel.Location = new System.Drawing.Point(644, 60);
            this.FlatLabel.Name = "FlatLabel";
            this.FlatLabel.Size = new System.Drawing.Size(77, 21);
            this.FlatLabel.TabIndex = 11;
            this.FlatLabel.Text = "Квартира";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(752, 350);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 43);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(12, 356);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(62, 30);
            this.TotalPriceLabel.TabIndex = 13;
            this.TotalPriceLabel.Text = "Ціна:";
            // 
            // PriceEquals
            // 
            this.PriceEquals.AutoSize = true;
            this.PriceEquals.ForeColor = System.Drawing.Color.Black;
            this.PriceEquals.Location = new System.Drawing.Point(80, 356);
            this.PriceEquals.Name = "PriceEquals";
            this.PriceEquals.Size = new System.Drawing.Size(24, 30);
            this.PriceEquals.TabIndex = 14;
            this.PriceEquals.Text = "0";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "500-800",
            "800-1100",
            "1100-1400"});
            this.PriceComboBox.Location = new System.Drawing.Point(33, 94);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(102, 29);
            this.PriceComboBox.TabIndex = 15;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(29, 60);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(102, 21);
            this.PriceLabel.TabIndex = 16;
            this.PriceLabel.Text = "Оберіть ціну";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(201, 283);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(120, 29);
            this.PhoneTextBox.TabIndex = 17;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(10, 287);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(185, 21);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "Введіть номер телефону";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(374, 287);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(95, 21);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Введіть ФІО";
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(475, 284);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(173, 29);
            this.NametextBox.TabIndex = 20;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // BookingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(867, 405);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceComboBox);
            this.Controls.Add(this.PriceEquals);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.FlatLabel);
            this.Controls.Add(this.FlatDropdown);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.RoomsDropdown);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.DistrictDropdown);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.CheckOutCalendar);
            this.Controls.Add(this.CheckInCalendar);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BookingViewer";
            this.Text = "BookingViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.DateTimePicker CheckInCalendar;
        private System.Windows.Forms.DateTimePicker CheckOutCalendar;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.ComboBox DistrictDropdown;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.ComboBox RoomsDropdown;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.ComboBox FlatDropdown;
        private System.Windows.Forms.Label FlatLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label PriceEquals;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NametextBox;
    }
}

