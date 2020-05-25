namespace PhanMemQuanLyShowroomXeHoi
{
    partial class fAdmin
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
            this.dGV = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.rbtnInventoryAccessory = new System.Windows.Forms.RadioButton();
            this.rbtnInventoryCar = new System.Windows.Forms.RadioButton();
            this.rbtnBill = new System.Windows.Forms.RadioButton();
            this.rbtnAccessoryEntry = new System.Windows.Forms.RadioButton();
            this.rbtnAccessorySold = new System.Windows.Forms.RadioButton();
            this.rbtnEntryCar = new System.Windows.Forms.RadioButton();
            this.rbtnSoldCar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dTPTo = new System.Windows.Forms.DateTimePicker();
            this.dTPFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(1, 66);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(799, 383);
            this.dGV.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rbtnInventoryAccessory);
            this.panel.Controls.Add(this.rbtnInventoryCar);
            this.panel.Controls.Add(this.rbtnBill);
            this.panel.Controls.Add(this.rbtnAccessoryEntry);
            this.panel.Controls.Add(this.rbtnAccessorySold);
            this.panel.Controls.Add(this.rbtnEntryCar);
            this.panel.Controls.Add(this.rbtnSoldCar);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnShow);
            this.panel.Controls.Add(this.dTPTo);
            this.panel.Controls.Add(this.dTPFrom);
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 70);
            this.panel.TabIndex = 1;
            // 
            // rbtnInventoryAccessory
            // 
            this.rbtnInventoryAccessory.AutoSize = true;
            this.rbtnInventoryAccessory.Location = new System.Drawing.Point(573, 42);
            this.rbtnInventoryAccessory.Name = "rbtnInventoryAccessory";
            this.rbtnInventoryAccessory.Size = new System.Drawing.Size(107, 17);
            this.rbtnInventoryAccessory.TabIndex = 11;
            this.rbtnInventoryAccessory.Text = "Phụ tùng tồn kho";
            this.rbtnInventoryAccessory.UseVisualStyleBackColor = true;
            this.rbtnInventoryAccessory.CheckedChanged += new System.EventHandler(this.rbtnInventoryAccessory_CheckedChanged);
            // 
            // rbtnInventoryCar
            // 
            this.rbtnInventoryCar.AutoSize = true;
            this.rbtnInventoryCar.Location = new System.Drawing.Point(261, 42);
            this.rbtnInventoryCar.Name = "rbtnInventoryCar";
            this.rbtnInventoryCar.Size = new System.Drawing.Size(77, 17);
            this.rbtnInventoryCar.TabIndex = 10;
            this.rbtnInventoryCar.Text = "Xe tồn kho";
            this.rbtnInventoryCar.UseVisualStyleBackColor = true;
            this.rbtnInventoryCar.CheckedChanged += new System.EventHandler(this.rbtnInventoryCar_CheckedChanged);
            // 
            // rbtnBill
            // 
            this.rbtnBill.AutoSize = true;
            this.rbtnBill.Checked = true;
            this.rbtnBill.Location = new System.Drawing.Point(20, 42);
            this.rbtnBill.Name = "rbtnBill";
            this.rbtnBill.Size = new System.Drawing.Size(67, 17);
            this.rbtnBill.TabIndex = 9;
            this.rbtnBill.TabStop = true;
            this.rbtnBill.Text = "Hóa đơn";
            this.rbtnBill.UseVisualStyleBackColor = true;
            this.rbtnBill.CheckedChanged += new System.EventHandler(this.rbtnBill_CheckedChanged);
            // 
            // rbtnAccessoryEntry
            // 
            this.rbtnAccessoryEntry.AutoSize = true;
            this.rbtnAccessoryEntry.Location = new System.Drawing.Point(456, 42);
            this.rbtnAccessoryEntry.Name = "rbtnAccessoryEntry";
            this.rbtnAccessoryEntry.Size = new System.Drawing.Size(111, 17);
            this.rbtnAccessoryEntry.TabIndex = 8;
            this.rbtnAccessoryEntry.Text = "Phụ tùng đã nhập";
            this.rbtnAccessoryEntry.UseVisualStyleBackColor = true;
            this.rbtnAccessoryEntry.CheckedChanged += new System.EventHandler(this.rbtnAccessoryEntry_CheckedChanged);
            // 
            // rbtnAccessorySold
            // 
            this.rbtnAccessorySold.AutoSize = true;
            this.rbtnAccessorySold.Location = new System.Drawing.Point(345, 42);
            this.rbtnAccessorySold.Name = "rbtnAccessorySold";
            this.rbtnAccessorySold.Size = new System.Drawing.Size(105, 17);
            this.rbtnAccessorySold.TabIndex = 7;
            this.rbtnAccessorySold.Text = "Phụ tùng đã bán";
            this.rbtnAccessorySold.UseVisualStyleBackColor = true;
            this.rbtnAccessorySold.CheckedChanged += new System.EventHandler(this.rbtnAccessorySold_CheckedChanged);
            // 
            // rbtnEntryCar
            // 
            this.rbtnEntryCar.AutoSize = true;
            this.rbtnEntryCar.Location = new System.Drawing.Point(174, 42);
            this.rbtnEntryCar.Name = "rbtnEntryCar";
            this.rbtnEntryCar.Size = new System.Drawing.Size(81, 17);
            this.rbtnEntryCar.TabIndex = 6;
            this.rbtnEntryCar.Text = "Xe đã nhập";
            this.rbtnEntryCar.UseVisualStyleBackColor = true;
            this.rbtnEntryCar.CheckedChanged += new System.EventHandler(this.rbtnEntryCar_CheckedChanged);
            // 
            // rbtnSoldCar
            // 
            this.rbtnSoldCar.AutoSize = true;
            this.rbtnSoldCar.Location = new System.Drawing.Point(93, 42);
            this.rbtnSoldCar.Name = "rbtnSoldCar";
            this.rbtnSoldCar.Size = new System.Drawing.Size(75, 17);
            this.rbtnSoldCar.TabIndex = 5;
            this.rbtnSoldCar.Text = "Xe đã bán";
            this.rbtnSoldCar.UseVisualStyleBackColor = true;
            this.rbtnSoldCar.CheckedChanged += new System.EventHandler(this.rbtnSoldCar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày :";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(692, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 42);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Thống kê";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dTPTo
            // 
            this.dTPTo.Location = new System.Drawing.Point(409, 13);
            this.dTPTo.Name = "dTPTo";
            this.dTPTo.Size = new System.Drawing.Size(200, 20);
            this.dTPTo.TabIndex = 1;
            // 
            // dTPFrom
            // 
            this.dTPFrom.Location = new System.Drawing.Point(127, 13);
            this.dTPFrom.Name = "dTPFrom";
            this.dTPFrom.Size = new System.Drawing.Size(200, 20);
            this.dTPFrom.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dGV);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton rbtnAccessoryEntry;
        private System.Windows.Forms.RadioButton rbtnAccessorySold;
        private System.Windows.Forms.RadioButton rbtnEntryCar;
        private System.Windows.Forms.RadioButton rbtnSoldCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dTPTo;
        private System.Windows.Forms.DateTimePicker dTPFrom;
        private System.Windows.Forms.RadioButton rbtnBill;
        private System.Windows.Forms.RadioButton rbtnInventoryCar;
        private System.Windows.Forms.RadioButton rbtnInventoryAccessory;
    }
}