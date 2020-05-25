namespace PhanMemQuanLyShowroomXeHoi
{
    partial class fCurrentBills
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
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.dGVBill = new System.Windows.Forms.DataGridView();
            this.dGVBillDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(12, 10);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(120, 32);
            this.btnAddBill.TabIndex = 1;
            this.btnAddBill.Text = "Thêm hóa đơn";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Location = new System.Drawing.Point(154, 10);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteBill.TabIndex = 2;
            this.btnDeleteBill.Text = "Xóa hóa đơn";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // dGVBill
            // 
            this.dGVBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBill.Location = new System.Drawing.Point(1, 51);
            this.dGVBill.Name = "dGVBill";
            this.dGVBill.Size = new System.Drawing.Size(460, 398);
            this.dGVBill.TabIndex = 3;
            this.dGVBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBill_CellClick);
            this.dGVBill.SelectionChanged += new System.EventHandler(this.dGVBill_SelectionChanged);
            // 
            // dGVBillDetails
            // 
            this.dGVBillDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGVBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBillDetails.Location = new System.Drawing.Point(463, 51);
            this.dGVBillDetails.Name = "dGVBillDetails";
            this.dGVBillDetails.Size = new System.Drawing.Size(583, 398);
            this.dGVBillDetails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chi tiết hóa đơn:";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(297, 10);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(120, 32);
            this.btnThanhtoan.TabIndex = 6;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // fCurrentBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVBillDetails);
            this.Controls.Add(this.dGVBill);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnAddBill);
            this.Name = "fCurrentBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn hiện tại";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCurrentBills_FormClosed);
            this.Load += new System.EventHandler(this.fCurrentBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.DataGridView dGVBill;
        private System.Windows.Forms.DataGridView dGVBillDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhtoan;
    }
}