namespace PhanMemQuanLyShowroomXeHoi
{
    partial class fCarDetails
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPg1 = new System.Windows.Forms.TabPage();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtRearBrake = new System.Windows.Forms.TextBox();
            this.txtFrontBrake = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCombine = new System.Windows.Forms.TextBox();
            this.txtNonurban = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrban = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPetrolTank = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEngine = new System.Windows.Forms.Panel();
            this.cmbProducer = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMomen = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtCylinderCapacity = new System.Windows.Forms.TextBox();
            this.txtGear = new System.Windows.Forms.TextBox();
            this.txtTypeEngine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.tPg2 = new System.Windows.Forms.TabPage();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.fLPInstanceCar = new System.Windows.Forms.FlowLayoutPanel();
            this.tPg3 = new System.Windows.Forms.TabPage();
            this.btnAddNewAccessory = new System.Windows.Forms.Button();
            this.fLPAccessory = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tPg1.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.tPg2.SuspendLayout();
            this.tPg3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tPg1);
            this.tabControl1.Controls.Add(this.tPg2);
            this.tabControl1.Controls.Add(this.tPg3);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tPg1
            // 
            this.tPg1.Controls.Add(this.btnDeleteCar);
            this.tPg1.Controls.Add(this.pnlDetails);
            this.tPg1.Controls.Add(this.panel1);
            this.tPg1.Controls.Add(this.btnUpdateCar);
            this.tPg1.Location = new System.Drawing.Point(4, 22);
            this.tPg1.Name = "tPg1";
            this.tPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tPg1.Size = new System.Drawing.Size(822, 531);
            this.tPg1.TabIndex = 0;
            this.tPg1.Text = "Thông tin chi tiết";
            this.tPg1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(190, 483);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(135, 35);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.Text = "Xóa dòng xe này";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetails.AutoScroll = true;
            this.pnlDetails.Controls.Add(this.label17);
            this.pnlDetails.Controls.Add(this.txtSeat);
            this.pnlDetails.Controls.Add(this.txtRearBrake);
            this.pnlDetails.Controls.Add(this.txtFrontBrake);
            this.pnlDetails.Controls.Add(this.label15);
            this.pnlDetails.Controls.Add(this.label16);
            this.pnlDetails.Controls.Add(this.txtCombine);
            this.pnlDetails.Controls.Add(this.txtNonurban);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.txtUrban);
            this.pnlDetails.Controls.Add(this.label12);
            this.pnlDetails.Controls.Add(this.txtPetrolTank);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.label14);
            this.pnlDetails.Controls.Add(this.txtFuel);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.txtWeight);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.txtWidth);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtHeight);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.txtLength);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Location = new System.Drawing.Point(393, 6);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(375, 466);
            this.pnlDetails.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Số ghế";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(66, 51);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(238, 20);
            this.txtSeat.TabIndex = 33;
            // 
            // txtRearBrake
            // 
            this.txtRearBrake.Location = new System.Drawing.Point(70, 583);
            this.txtRearBrake.Name = "txtRearBrake";
            this.txtRearBrake.Size = new System.Drawing.Size(238, 20);
            this.txtRearBrake.TabIndex = 31;
            // 
            // txtFrontBrake
            // 
            this.txtFrontBrake.Location = new System.Drawing.Point(69, 535);
            this.txtFrontBrake.Name = "txtFrontBrake";
            this.txtFrontBrake.Size = new System.Drawing.Size(238, 20);
            this.txtFrontBrake.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Hệ thống phanh trước";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(66, 564);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Hệ thống phanh sau";
            // 
            // txtCombine
            // 
            this.txtCombine.Location = new System.Drawing.Point(68, 484);
            this.txtCombine.Name = "txtCombine";
            this.txtCombine.Size = new System.Drawing.Size(238, 20);
            this.txtCombine.TabIndex = 27;
            // 
            // txtNonurban
            // 
            this.txtNonurban.Location = new System.Drawing.Point(67, 436);
            this.txtNonurban.Name = "txtNonurban";
            this.txtNonurban.Size = new System.Drawing.Size(238, 20);
            this.txtNonurban.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dung tích bình xăng";
            // 
            // txtUrban
            // 
            this.txtUrban.Location = new System.Drawing.Point(67, 390);
            this.txtUrban.Name = "txtUrban";
            this.txtUrban.Size = new System.Drawing.Size(238, 20);
            this.txtUrban.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tiêu thụ xăng khu đô thị";
            // 
            // txtPetrolTank
            // 
            this.txtPetrolTank.Location = new System.Drawing.Point(66, 338);
            this.txtPetrolTank.Name = "txtPetrolTank";
            this.txtPetrolTank.Size = new System.Drawing.Size(238, 20);
            this.txtPetrolTank.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tiêu thụ xăng ngoài đô thị";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tiêu thụ xăng hành trình kết hợp";
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(68, 285);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(238, 20);
            this.txtFuel.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Chiều dài";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(67, 237);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(238, 20);
            this.txtWeight.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Chiều cao";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(67, 191);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(238, 20);
            this.txtWidth.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chiều rộng";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(66, 139);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(238, 20);
            this.txtHeight.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trọng lượng";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(66, 96);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(238, 20);
            this.txtLength.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hệ thông phun xăng";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.pnlEngine);
            this.panel1.Controls.Add(this.picCar);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 466);
            this.panel1.TabIndex = 0;
            // 
            // pnlEngine
            // 
            this.pnlEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEngine.AutoScroll = true;
            this.pnlEngine.Controls.Add(this.cmbProducer);
            this.pnlEngine.Controls.Add(this.label19);
            this.pnlEngine.Controls.Add(this.txtCarName);
            this.pnlEngine.Controls.Add(this.label18);
            this.pnlEngine.Controls.Add(this.txtMomen);
            this.pnlEngine.Controls.Add(this.txtPower);
            this.pnlEngine.Controls.Add(this.txtCylinderCapacity);
            this.pnlEngine.Controls.Add(this.txtGear);
            this.pnlEngine.Controls.Add(this.txtTypeEngine);
            this.pnlEngine.Controls.Add(this.label5);
            this.pnlEngine.Controls.Add(this.label4);
            this.pnlEngine.Controls.Add(this.label3);
            this.pnlEngine.Controls.Add(this.label2);
            this.pnlEngine.Controls.Add(this.label1);
            this.pnlEngine.Location = new System.Drawing.Point(3, 221);
            this.pnlEngine.Name = "pnlEngine";
            this.pnlEngine.Size = new System.Drawing.Size(375, 242);
            this.pnlEngine.TabIndex = 1;
            // 
            // cmbProducer
            // 
            this.cmbProducer.FormattingEnabled = true;
            this.cmbProducer.Location = new System.Drawing.Point(65, 32);
            this.cmbProducer.Name = "cmbProducer";
            this.cmbProducer.Size = new System.Drawing.Size(238, 21);
            this.cmbProducer.TabIndex = 13;
            this.cmbProducer.SelectedIndexChanged += new System.EventHandler(this.cmbProducer_SelectedIndexChanged);
            this.cmbProducer.Click += new System.EventHandler(this.cmbProducer_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(62, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Hãng";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(67, 83);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(238, 20);
            this.txtCarName.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(60, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tên Xe";
            // 
            // txtMomen
            // 
            this.txtMomen.Location = new System.Drawing.Point(67, 315);
            this.txtMomen.Name = "txtMomen";
            this.txtMomen.Size = new System.Drawing.Size(238, 20);
            this.txtMomen.TabIndex = 9;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(66, 273);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(238, 20);
            this.txtPower.TabIndex = 8;
            // 
            // txtCylinderCapacity
            // 
            this.txtCylinderCapacity.Location = new System.Drawing.Point(67, 231);
            this.txtCylinderCapacity.Name = "txtCylinderCapacity";
            this.txtCylinderCapacity.Size = new System.Drawing.Size(238, 20);
            this.txtCylinderCapacity.TabIndex = 7;
            // 
            // txtGear
            // 
            this.txtGear.Location = new System.Drawing.Point(66, 179);
            this.txtGear.Name = "txtGear";
            this.txtGear.Size = new System.Drawing.Size(238, 20);
            this.txtGear.TabIndex = 6;
            // 
            // txtTypeEngine
            // 
            this.txtTypeEngine.Location = new System.Drawing.Point(66, 136);
            this.txtTypeEngine.Name = "txtTypeEngine";
            this.txtTypeEngine.Size = new System.Drawing.Size(238, 20);
            this.txtTypeEngine.TabIndex = 5;
            this.txtTypeEngine.TextChanged += new System.EventHandler(this.txtTypeEngine_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô-men cực đại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công suất tối đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dung tích động cơ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hộp số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu động cơ";
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picCar.Location = new System.Drawing.Point(3, 2);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(375, 213);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            this.picCar.Click += new System.EventHandler(this.picCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(24, 483);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(134, 35);
            this.btnUpdateCar.TabIndex = 1;
            this.btnUpdateCar.Text = "Cập nhật thay đồi";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // tPg2
            // 
            this.tPg2.AutoScroll = true;
            this.tPg2.Controls.Add(this.btnAddNew);
            this.tPg2.Controls.Add(this.fLPInstanceCar);
            this.tPg2.Location = new System.Drawing.Point(4, 22);
            this.tPg2.Name = "tPg2";
            this.tPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tPg2.Size = new System.Drawing.Size(822, 531);
            this.tPg2.TabIndex = 1;
            this.tPg2.Text = "Các sản phẩm từ dòng xe ";
            this.tPg2.UseVisualStyleBackColor = true;
            this.tPg2.Click += new System.EventHandler(this.tPg2_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(318, 454);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(134, 35);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // fLPInstanceCar
            // 
            this.fLPInstanceCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fLPInstanceCar.AutoScroll = true;
            this.fLPInstanceCar.BackColor = System.Drawing.Color.Transparent;
            this.fLPInstanceCar.Location = new System.Drawing.Point(3, 3);
            this.fLPInstanceCar.Name = "fLPInstanceCar";
            this.fLPInstanceCar.Size = new System.Drawing.Size(840, 445);
            this.fLPInstanceCar.TabIndex = 0;
            // 
            // tPg3
            // 
            this.tPg3.Controls.Add(this.btnAddNewAccessory);
            this.tPg3.Controls.Add(this.fLPAccessory);
            this.tPg3.Location = new System.Drawing.Point(4, 22);
            this.tPg3.Name = "tPg3";
            this.tPg3.Padding = new System.Windows.Forms.Padding(3);
            this.tPg3.Size = new System.Drawing.Size(822, 531);
            this.tPg3.TabIndex = 2;
            this.tPg3.Text = "Phụ tùng, phụ kiện theo xe ";
            this.tPg3.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAccessory
            // 
            this.btnAddNewAccessory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewAccessory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAccessory.Location = new System.Drawing.Point(318, 489);
            this.btnAddNewAccessory.Name = "btnAddNewAccessory";
            this.btnAddNewAccessory.Size = new System.Drawing.Size(134, 35);
            this.btnAddNewAccessory.TabIndex = 4;
            this.btnAddNewAccessory.Text = "Thêm mới";
            this.btnAddNewAccessory.UseVisualStyleBackColor = true;
            this.btnAddNewAccessory.Click += new System.EventHandler(this.btnAddNewAccessory_Click);
            // 
            // fLPAccessory
            // 
            this.fLPAccessory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fLPAccessory.AutoScroll = true;
            this.fLPAccessory.Location = new System.Drawing.Point(3, 3);
            this.fLPAccessory.Name = "fLPAccessory";
            this.fLPAccessory.Size = new System.Drawing.Size(814, 481);
            this.fLPAccessory.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "fCarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Về Xe ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCarDetails_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tPg1.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlEngine.ResumeLayout(false);
            this.pnlEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.tPg2.ResumeLayout(false);
            this.tPg3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPg1;
        private System.Windows.Forms.TabPage tPg2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlEngine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRearBrake;
        private System.Windows.Forms.TextBox txtFrontBrake;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCombine;
        private System.Windows.Forms.TextBox txtNonurban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUrban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPetrolTank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMomen;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtCylinderCapacity;
        private System.Windows.Forms.TextBox txtGear;
        private System.Windows.Forms.TextBox txtTypeEngine;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbProducer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tPg3;
        private System.Windows.Forms.FlowLayoutPanel fLPInstanceCar;
        private System.Windows.Forms.FlowLayoutPanel fLPAccessory;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAddNewAccessory;
    }
}