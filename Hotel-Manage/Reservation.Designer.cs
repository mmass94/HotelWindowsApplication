namespace Hotel_Manage
{
    partial class Reservation
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbp = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmanageDataSet2 = new Hotel_Manage.HotelmanageDataSet();
            this.reservationTableAdapter = new Hotel_Manage.HotelmanageDataSetTableAdapters.ReservationTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfChildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancePaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmanageDataSet3 = new Hotel_Manage.HotelmanageDataSet();
            this.reservationTableAdapter1 = new Hotel_Manage.HotelmanageDataSetTableAdapters.ReservationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 121;
            this.label11.Text = "ID Guest";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(361, 67);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(76, 20);
            this.textBox0.TabIndex = 120;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(904, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 119;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(904, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 117;
            this.label5.Text = "Reservation List :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.comboBox1.Location = new System.Drawing.Point(361, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 116;
            // 
            // dbp
            // 
            this.dbp.Location = new System.Drawing.Point(361, 129);
            this.dbp.Name = "dbp";
            this.dbp.Size = new System.Drawing.Size(200, 20);
            this.dbp.TabIndex = 115;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(929, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 114;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 113;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(904, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 112;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(904, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 111;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(780, 195);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(92, 16);
            this.Label15.TabIndex = 110;
            this.Label15.Text = "Total Balance";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(780, 157);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(118, 16);
            this.Label14.TabIndex = 109;
            this.Label14.Text = "Advance Payment";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(789, 106);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(77, 16);
            this.Label12.TabIndex = 108;
            this.Label12.Text = "No-Of-Child";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(789, 70);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(84, 16);
            this.Label10.TabIndex = 107;
            this.Label10.Text = "No-Of-Adults";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Date Of Birth";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(361, 256);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 105;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 103;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 102;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(208, 227);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 16);
            this.Label8.TabIndex = 101;
            this.Label8.Text = "Check In Date";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(203, 263);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(101, 16);
            this.Label7.TabIndex = 100;
            this.Label7.Text = "Check Out Date";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(208, 195);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 16);
            this.Label6.TabIndex = 99;
            this.Label6.Text = "Room Type";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(208, 165);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 16);
            this.Label4.TabIndex = 98;
            this.Label4.Text = "Room Number";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(208, 93);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 16);
            this.Label3.TabIndex = 97;
            this.Label3.Text = "Guest Full Name";
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(529, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(187, 24);
            this.Label1.TabIndex = 96;
            this.Label1.Text = "Reservation Form :";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.hotelmanageDataSet2;
            // 
            // hotelmanageDataSet2
            // 
            this.hotelmanageDataSet2.DataSetName = "HotelmanageDataSet2";
            this.hotelmanageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.guestFullNameDataGridViewTextBoxColumn,
            this.dateBirthDataGridViewTextBoxColumn,
            this.roomNumbDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.noOfAdultsDataGridViewTextBoxColumn,
            this.noOfChildDataGridViewTextBoxColumn,
            this.advancePaymentDataGridViewTextBoxColumn,
            this.totalBalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(125, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 200);
            this.dataGridView1.TabIndex = 122;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // guestFullNameDataGridViewTextBoxColumn
            // 
            this.guestFullNameDataGridViewTextBoxColumn.DataPropertyName = "GuestFullName";
            this.guestFullNameDataGridViewTextBoxColumn.HeaderText = "GuestFullName";
            this.guestFullNameDataGridViewTextBoxColumn.Name = "guestFullNameDataGridViewTextBoxColumn";
            // 
            // dateBirthDataGridViewTextBoxColumn
            // 
            this.dateBirthDataGridViewTextBoxColumn.DataPropertyName = "DateBirth";
            this.dateBirthDataGridViewTextBoxColumn.HeaderText = "DateBirth";
            this.dateBirthDataGridViewTextBoxColumn.Name = "dateBirthDataGridViewTextBoxColumn";
            // 
            // roomNumbDataGridViewTextBoxColumn
            // 
            this.roomNumbDataGridViewTextBoxColumn.DataPropertyName = "RoomNumb";
            this.roomNumbDataGridViewTextBoxColumn.HeaderText = "RoomNumb";
            this.roomNumbDataGridViewTextBoxColumn.Name = "roomNumbDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            // 
            // noOfAdultsDataGridViewTextBoxColumn
            // 
            this.noOfAdultsDataGridViewTextBoxColumn.DataPropertyName = "NoOfAdults";
            this.noOfAdultsDataGridViewTextBoxColumn.HeaderText = "NoOfAdults";
            this.noOfAdultsDataGridViewTextBoxColumn.Name = "noOfAdultsDataGridViewTextBoxColumn";
            // 
            // noOfChildDataGridViewTextBoxColumn
            // 
            this.noOfChildDataGridViewTextBoxColumn.DataPropertyName = "NoOfChild";
            this.noOfChildDataGridViewTextBoxColumn.HeaderText = "NoOfChild";
            this.noOfChildDataGridViewTextBoxColumn.Name = "noOfChildDataGridViewTextBoxColumn";
            // 
            // advancePaymentDataGridViewTextBoxColumn
            // 
            this.advancePaymentDataGridViewTextBoxColumn.DataPropertyName = "AdvancePayment";
            this.advancePaymentDataGridViewTextBoxColumn.HeaderText = "AdvancePayment";
            this.advancePaymentDataGridViewTextBoxColumn.Name = "advancePaymentDataGridViewTextBoxColumn";
            // 
            // totalBalanceDataGridViewTextBoxColumn
            // 
            this.totalBalanceDataGridViewTextBoxColumn.DataPropertyName = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn.HeaderText = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn.Name = "totalBalanceDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataMember = "Reservation";
            this.reservationBindingSource1.DataSource = this.hotelmanageDataSet3;
            // 
            // hotelmanageDataSet3
            // 
            this.hotelmanageDataSet3.DataSetName = "HotelmanageDataSet3";
            this.hotelmanageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dbp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dbp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private HotelmanageDataSet hotelmanageDataSet2;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private HotelmanageDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelmanageDataSet hotelmanageDataSet3;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private HotelmanageDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfChildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advancePaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBalanceDataGridViewTextBoxColumn;
    }
}