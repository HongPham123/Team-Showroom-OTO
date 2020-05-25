namespace PhanMemQuanLyShowroomXeHoi
{
    partial class fSell
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
            this.fLPCar = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPProducer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnAddNewProducer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bảoHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLPCar
            // 
            this.fLPCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPCar.AutoScroll = true;
            this.fLPCar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fLPCar.Location = new System.Drawing.Point(2, 50);
            this.fLPCar.Name = "fLPCar";
            this.fLPCar.Size = new System.Drawing.Size(717, 448);
            this.fLPCar.TabIndex = 0;
            // 
            // fLPProducer
            // 
            this.fLPProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPProducer.AutoScroll = true;
            this.fLPProducer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fLPProducer.Location = new System.Drawing.Point(725, 50);
            this.fLPProducer.Name = "fLPProducer";
            this.fLPProducer.Padding = new System.Windows.Forms.Padding(3);
            this.fLPProducer.Size = new System.Drawing.Size(319, 448);
            this.fLPProducer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Các Dòng Xe Tìm Được";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Các Hãng Xe ";
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewCar.Location = new System.Drawing.Point(9, 511);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(160, 35);
            this.btnAddNewCar.TabIndex = 6;
            this.btnAddNewCar.Text = "Thêm dòng xe mới";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnAddNewProducer
            // 
            this.btnAddNewProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProducer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProducer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewProducer.Location = new System.Drawing.Point(740, 511);
            this.btnAddNewProducer.Name = "btnAddNewProducer";
            this.btnAddNewProducer.Size = new System.Drawing.Size(130, 35);
            this.btnAddNewProducer.TabIndex = 7;
            this.btnAddNewProducer.Text = "Thêm hãng xe mới";
            this.btnAddNewProducer.UseVisualStyleBackColor = true;
            this.btnAddNewProducer.Click += new System.EventHandler(this.btnAddNewProducer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProducer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProducer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteProducer.Location = new System.Drawing.Point(876, 511);
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(148, 35);
            this.btnDeleteProducer.TabIndex = 8;
            this.btnDeleteProducer.Text = "Xóa hãng xe đã chọn";
            this.btnDeleteProducer.UseVisualStyleBackColor = true;
            this.btnDeleteProducer.Click += new System.EventHandler(this.btnDeleteProducer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảoHànhToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.tàiKhoảnCáNhânToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bảoHànhToolStripMenuItem
            // 
            this.bảoHànhToolStripMenuItem.Name = "bảoHànhToolStripMenuItem";
            this.bảoHànhToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.bảoHànhToolStripMenuItem.Text = "Bảo hành";
            this.bảoHànhToolStripMenuItem.Click += new System.EventHandler(this.bảoHànhToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tàiKhoảnCáNhânToolStripMenuItem
            // 
            this.tàiKhoảnCáNhânToolStripMenuItem.Name = "tàiKhoảnCáNhânToolStripMenuItem";
            this.tàiKhoảnCáNhânToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.tàiKhoảnCáNhânToolStripMenuItem.Text = "Tài khoản cá nhân";
            this.tàiKhoảnCáNhânToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnCáNhânToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.adminToolStripMenuItem.Text = "Thống kê";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // fSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 558);
            this.Controls.Add(this.btnDeleteProducer);
            this.Controls.Add(this.btnAddNewProducer);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fLPProducer);
            this.Controls.Add(this.fLPCar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bán sản phẩm";
            this.Load += new System.EventHandler(this.fSell_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLPCar;
        private System.Windows.Forms.FlowLayoutPanel fLPProducer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnAddNewProducer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteProducer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảoHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    }
}