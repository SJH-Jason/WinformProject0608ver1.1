namespace WinformPoject0527
{
    partial class SellerShipmentEdit
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
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTime4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAction3 = new System.Windows.Forms.TextBox();
            this.txtAction2 = new System.Windows.Forms.TextBox();
            this.txtAction1 = new System.Windows.Forms.TextBox();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.btnCompletion = new System.Windows.Forms.Button();
            this.btnArrival = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtShipmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(626, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 35);
            this.label12.TabIndex = 62;
            this.label12.Text = "貨品清單";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(632, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 262);
            this.dataGridView1.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(82, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 35);
            this.label11.TabIndex = 60;
            this.label11.Text = "出貨單";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(278, 162);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 25);
            this.btnReset.TabIndex = 59;
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(528, 91);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(50, 25);
            this.btnEnd.TabIndex = 58;
            this.btnEnd.Text = "確認";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(92, 242);
            this.txtTime2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.ReadOnly = true;
            this.txtTime2.Size = new System.Drawing.Size(94, 22);
            this.txtTime2.TabIndex = 57;
            this.txtTime2.Text = "出貨時間";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "ShipDate";
            // 
            // txtTime4
            // 
            this.txtTime4.Location = new System.Drawing.Point(484, 242);
            this.txtTime4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime4.Name = "txtTime4";
            this.txtTime4.ReadOnly = true;
            this.txtTime4.Size = new System.Drawing.Size(94, 22);
            this.txtTime4.TabIndex = 55;
            this.txtTime4.Text = "完成時間";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "ReceiveStatus";
            // 
            // txtAction3
            // 
            this.txtAction3.Location = new System.Drawing.Point(484, 309);
            this.txtAction3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAction3.Name = "txtAction3";
            this.txtAction3.ReadOnly = true;
            this.txtAction3.Size = new System.Drawing.Size(94, 22);
            this.txtAction3.TabIndex = 53;
            this.txtAction3.Text = "等候中/等候領取/已領取/已完成";
            // 
            // txtAction2
            // 
            this.txtAction2.Location = new System.Drawing.Point(288, 309);
            this.txtAction2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAction2.Name = "txtAction2";
            this.txtAction2.ReadOnly = true;
            this.txtAction2.Size = new System.Drawing.Size(94, 22);
            this.txtAction2.TabIndex = 52;
            this.txtAction2.Text = "運送中";
            // 
            // txtAction1
            // 
            this.txtAction1.Location = new System.Drawing.Point(92, 309);
            this.txtAction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAction1.Name = "txtAction1";
            this.txtAction1.ReadOnly = true;
            this.txtAction1.Size = new System.Drawing.Size(94, 22);
            this.txtAction1.TabIndex = 51;
            this.txtAction1.Text = "準備中";
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(288, 242);
            this.txtTime3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.ReadOnly = true;
            this.txtTime3.Size = new System.Drawing.Size(94, 22);
            this.txtTime3.TabIndex = 50;
            this.txtTime3.Text = "送達時間";
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(278, 106);
            this.txtTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.ReadOnly = true;
            this.txtTime1.Size = new System.Drawing.Size(94, 22);
            this.txtTime1.TabIndex = 42;
            this.txtTime1.Text = "訂單時間";
            // 
            // btnCompletion
            // 
            this.btnCompletion.Enabled = false;
            this.btnCompletion.Location = new System.Drawing.Point(512, 349);
            this.btnCompletion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompletion.Name = "btnCompletion";
            this.btnCompletion.Size = new System.Drawing.Size(50, 25);
            this.btnCompletion.TabIndex = 46;
            this.btnCompletion.Text = "結單";
            this.btnCompletion.UseVisualStyleBackColor = true;
            this.btnCompletion.Click += new System.EventHandler(this.btnCompletion_Click);
            // 
            // btnArrival
            // 
            this.btnArrival.Enabled = false;
            this.btnArrival.Location = new System.Drawing.Point(314, 349);
            this.btnArrival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(50, 25);
            this.btnArrival.TabIndex = 45;
            this.btnArrival.Text = "已送達";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(113, 349);
            this.btnShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(50, 25);
            this.btnShip.TabIndex = 44;
            this.btnShip.Text = "已出貨";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 49;
            this.label8.Text = "CompletionDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 48;
            this.label7.Text = "CompletionStatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "ShipmentStatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "ArrivalTimeDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "ShipmentDate";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(144, 179);
            this.txtSellerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(76, 22);
            this.txtSellerId.TabIndex = 40;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(144, 144);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(76, 22);
            this.txtOrderId.TabIndex = 39;
            // 
            // txtShipmentID
            // 
            this.txtShipmentID.Location = new System.Drawing.Point(144, 112);
            this.txtShipmentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShipmentID.Name = "txtShipmentID";
            this.txtShipmentID.Size = new System.Drawing.Size(76, 22);
            this.txtShipmentID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "SellerId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "OrderId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "ShipmentId";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderID";
            this.Column1.HeaderText = "訂單編號";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductID";
            this.Column2.HeaderText = "商品編號";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ProductName";
            this.Column3.HeaderText = "商品名稱";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductPrice";
            this.Column4.HeaderText = "商品價格";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "購買數量";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SellerID";
            this.Column6.HeaderText = "商家編號";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // SellerShipmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 426);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTime4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAction3);
            this.Controls.Add(this.txtAction2);
            this.Controls.Add(this.txtAction1);
            this.Controls.Add(this.txtTime3);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.btnCompletion);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtShipmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellerShipmentEdit";
            this.Text = "SellerShipmentEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTime4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAction3;
        private System.Windows.Forms.TextBox txtAction2;
        private System.Windows.Forms.TextBox txtAction1;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.Button btnCompletion;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtShipmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}