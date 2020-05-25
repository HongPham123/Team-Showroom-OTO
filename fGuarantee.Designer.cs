namespace PhanMemQuanLyShowroomXeHoi
{
    partial class fGuarantee
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
            this.dGVGuarantee = new System.Windows.Forms.DataGridView();
            this.dGVInstanceOfCar = new System.Windows.Forms.DataGridView();
            this.btnThembaohanh = new System.Windows.Forms.Button();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGuarantee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInstanceOfCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVGuarantee
            // 
            this.dGVGuarantee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGVGuarantee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGuarantee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGuarantee.Location = new System.Drawing.Point(3, 41);
            this.dGVGuarantee.Name = "dGVGuarantee";
            this.dGVGuarantee.Size = new System.Drawing.Size(525, 285);
            this.dGVGuarantee.TabIndex = 0;
            this.dGVGuarantee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGuarantee_CellClick);
            // 
            // dGVInstanceOfCar
            // 
            this.dGVInstanceOfCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVInstanceOfCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVInstanceOfCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInstanceOfCar.Location = new System.Drawing.Point(531, 41);
            this.dGVInstanceOfCar.Name = "dGVInstanceOfCar";
            this.dGVInstanceOfCar.Size = new System.Drawing.Size(599, 408);
            this.dGVInstanceOfCar.TabIndex = 1;
            this.dGVInstanceOfCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVInstanceOfCar_CellClick);
            // 
            // btnThembaohanh
            // 
            this.btnThembaohanh.Location = new System.Drawing.Point(1023, 12);
            this.btnThembaohanh.Name = "btnThembaohanh";
            this.btnThembaohanh.Size = new System.Drawing.Size(99, 23);
            this.btnThembaohanh.TabIndex = 2;
            this.btnThembaohanh.Text = "Thêm bảo hành";
            this.btnThembaohanh.UseVisualStyleBackColor = true;
            this.btnThembaohanh.Click += new System.EventHandler(this.btnThembaohanh_Click);
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(3, 368);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(522, 81);
            this.txtcontent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung bảo hành :";
            // 
            // btnAddContent
            // 
            this.btnAddContent.Location = new System.Drawing.Point(407, 339);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(118, 23);
            this.btnAddContent.TabIndex = 5;
            this.btnAddContent.Text = "Cập nhật nội dung";
            this.btnAddContent.UseVisualStyleBackColor = true;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(254, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(99, 23);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách xe";
            // 
            // fGuarantee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnAddContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.btnThembaohanh);
            this.Controls.Add(this.dGVInstanceOfCar);
            this.Controls.Add(this.dGVGuarantee);
            this.Name = "fGuarantee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGuarantee";
            this.Load += new System.EventHandler(this.fGuarantee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGuarantee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInstanceOfCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVGuarantee;
        private System.Windows.Forms.DataGridView dGVInstanceOfCar;
        private System.Windows.Forms.Button btnThembaohanh;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddContent;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}