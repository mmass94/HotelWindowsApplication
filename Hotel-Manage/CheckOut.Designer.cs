namespace Hotel_Manage
{
    partial class CheckOut
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
            this.hoteldbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmanageDataSet = new Hotel_Manage.HotelmanageDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.hoteldbTableAdapter = new Hotel_Manage.HotelmanageDataSetTableAdapters.HoteldbTableAdapter();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dataGridView1.DataSource = this.hoteldbBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(136, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1146, 206);
            this.dataGridView1.TabIndex = 0;
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
            // hoteldbBindingSource
            // 
            this.hoteldbBindingSource.DataMember = "Hoteldb";
            this.hoteldbBindingSource.DataSource = this.hotelmanageDataSet;
            // 
            // hotelmanageDataSet
            // 
            this.hotelmanageDataSet.DataSetName = "HotelmanageDataSet";
            this.hotelmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hoteldbTableAdapter
            // 
            this.hoteldbTableAdapter.ClearBeforeFill = true;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(760, 131);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(94, 20);
            this.textBox0.TabIndex = 96;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(779, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 98;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Enter ID Guest that you want to  Check Out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "Check Out Form :";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(599, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 101;
            this.label5.Text = "Check Out List :";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1227, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteldbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private HotelmanageDataSet hotelmanageDataSet;
        private System.Windows.Forms.BindingSource hoteldbBindingSource;
        private HotelmanageDataSetTableAdapters.HoteldbTableAdapter hoteldbTableAdapter;
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
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label5;
    }
}