
namespace ApartmentsSales
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saleRequestTypeSearch = new System.Windows.Forms.ComboBox();
            this.saleRequests = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.agentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apartmentRoomCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.apartmentFloor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.apartmentArea = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.makeSaleRequest = new System.Windows.Forms.Button();
            this.saleRequestType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleRequests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRoomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentFloor)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saleRequestTypeSearch);
            this.groupBox1.Controls.Add(this.saleRequests);
            this.groupBox1.Location = new System.Drawing.Point(25, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Sale Requests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent Name";
            // 
            // saleRequestTypeSearch
            // 
            this.saleRequestTypeSearch.FormattingEnabled = true;
            this.saleRequestTypeSearch.Location = new System.Drawing.Point(322, 59);
            this.saleRequestTypeSearch.Name = "saleRequestTypeSearch";
            this.saleRequestTypeSearch.Size = new System.Drawing.Size(121, 21);
            this.saleRequestTypeSearch.TabIndex = 0;
            this.saleRequestTypeSearch.SelectedValueChanged += new System.EventHandler(this.saleRequestTypeSearch_SelectedValueChanged);
            // 
            // saleRequests
            // 
            this.saleRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleRequests.Location = new System.Drawing.Point(6, 95);
            this.saleRequests.Name = "saleRequests";
            this.saleRequests.Size = new System.Drawing.Size(437, 359);
            this.saleRequests.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.saleRequestType);
            this.groupBox2.Controls.Add(this.makeSaleRequest);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(480, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make sale request";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.apartmentArea);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.apartmentFloor);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.apartmentRoomCount);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(21, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 157);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Apartment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Count";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.agentName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(21, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agent";
            // 
            // agentName
            // 
            this.agentName.Location = new System.Drawing.Point(119, 29);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(100, 20);
            this.agentName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agent Name";
            // 
            // apartmentRoomCount
            // 
            this.apartmentRoomCount.Location = new System.Drawing.Point(119, 29);
            this.apartmentRoomCount.Name = "apartmentRoomCount";
            this.apartmentRoomCount.Size = new System.Drawing.Size(120, 20);
            this.apartmentRoomCount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Floor";
            // 
            // apartmentFloor
            // 
            this.apartmentFloor.Location = new System.Drawing.Point(119, 70);
            this.apartmentFloor.Name = "apartmentFloor";
            this.apartmentFloor.Size = new System.Drawing.Size(120, 20);
            this.apartmentFloor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Area";
            // 
            // apartmentArea
            // 
            this.apartmentArea.Location = new System.Drawing.Point(119, 117);
            this.apartmentArea.Name = "apartmentArea";
            this.apartmentArea.Size = new System.Drawing.Size(120, 20);
            this.apartmentArea.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clientName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(21, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 64);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Client";
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(119, 29);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(100, 20);
            this.clientName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Client Name";
            // 
            // makeSaleRequest
            // 
            this.makeSaleRequest.Location = new System.Drawing.Point(21, 414);
            this.makeSaleRequest.Name = "makeSaleRequest";
            this.makeSaleRequest.Size = new System.Drawing.Size(265, 29);
            this.makeSaleRequest.TabIndex = 2;
            this.makeSaleRequest.Text = "Make sale request";
            this.makeSaleRequest.UseVisualStyleBackColor = true;
            this.makeSaleRequest.Click += new System.EventHandler(this.makeSaleRequest_Click);
            // 
            // saleRequestType
            // 
            this.saleRequestType.FormattingEnabled = true;
            this.saleRequestType.Location = new System.Drawing.Point(139, 369);
            this.saleRequestType.Name = "saleRequestType";
            this.saleRequestType.Size = new System.Drawing.Size(121, 21);
            this.saleRequestType.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sale Requests";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleRequests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRoomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentFloor)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView saleRequests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox saleRequestTypeSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox agentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apartmentArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown apartmentFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown apartmentRoomCount;
        private System.Windows.Forms.Button makeSaleRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox saleRequestType;
    }
}

