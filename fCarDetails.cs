using PhanMemQuanLyShowroomXeHoi.DAO;
using PhanMemQuanLyShowroomXeHoi.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PhanMemQuanLyShowroomXeHoi
{
    public partial class fCarDetails : Form
    {
        private Car car;
        public Account acc;
        List<Producer> producersList;
        List<InstanceOfCar> instanceOfCarsList;
        List<AccessoryOfCar> accessoryOfCarsList;
        SpecificDescriptionOfCar specCar;
        fCurrentBills fCurrent;

        #region event handmake
        private event EventHandler deleteCar;
        public event EventHandler DeleteCar
        {
            add { deleteCar += value; }
            remove { deleteCar -= value; }
        }

        #endregion

        public fCarDetails(Car car, Account acc, List<Producer> producersList)
        {
            InitializeComponent();
            this.acc = acc;
            this.car = new Car(car);
            this.producersList = producersList;
            instanceOfCarsList = InstanceOFCarDAO.Instance.GetInstanceOfCarsByIdCar(car);
            accessoryOfCarsList = AccessoryOfCarDAO.Instance.GetAccessoryListByIdCar(car.ID);

            LoadInfoDetailsForAll();
            LoadInstanceCarForPageTwo();
            LoadInstanceCarForPageThree();
        }

        private void LoadInstanceCarForPageThree()
        {
            if(acc.Type == 0)
            {
                btnAddNewAccessory.Enabled = false;
            }

            foreach (AccessoryOfCar accessory in accessoryOfCarsList)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(fLPAccessory.Size.Width, 200);
                pnl.BackColor = Color.Linen;
                pnl.BackgroundImage = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
                pnl.BackgroundImageLayout = ImageLayout.Stretch;
                
                PictureBox picAccessory = new PictureBox();
                picAccessory.Size = new Size(215, 147);
                picAccessory.Click += PicAccessory_Click;
                picAccessory.Location = new Point(3, 15);
                picAccessory.SizeMode = PictureBoxSizeMode.Zoom;
                picAccessory.Image = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
                picAccessory.Tag = accessory;

                pnl.Controls.Add(picAccessory);
                fLPAccessory.Controls.Add(pnl);
                //ten phu tung
                Panel pnl1 = new Panel();
                pnl1.Size = new Size(254, 33);
                pnl1.Location = new Point(224, 15);

                pnl.Controls.Add(pnl1);

                Label lbl1 = new Label();
                lbl1.Text = "Tên phụ tùng:";
                lbl1.Location = new Point(4, 10);

                pnl1.Controls.Add(lbl1);

                TextBox txt1 = new TextBox();
                txt1.Text = accessory.AccessoryName;
                txt1.Location = new Point(105, 7);
                txt1.Size = new Size(146, 20);

                pnl1.Controls.Add(txt1);



                //don gia
                Panel pnl2 = new Panel();
                pnl2.Size = new Size(254, 33);
                pnl2.Location = new Point(224, 54);

                pnl.Controls.Add(pnl2);

                Label lbl2 = new Label();
                lbl2.Text = "Đơn giá:";
                lbl2.Location = new Point(4, 10);

                pnl2.Controls.Add(lbl2);

                TextBox txt2 = new TextBox();
                txt2.Text = accessory.UnitPrice.ToString();
                txt2.Location = new Point(105, 7);
                txt2.Size = new Size(146, 20);

                pnl2.Controls.Add(txt2);

                //so luong
                Panel pnl3 = new Panel();
                pnl3.Size = new Size(254, 33);
                pnl3.Location = new Point(224, 93);

                pnl.Controls.Add(pnl3);

                Label lbl3 = new Label();
                lbl3.Text = "Số lượng:";
                lbl3.Location = new Point(4, 10);

                pnl3.Controls.Add(lbl3);

                NumericUpDown numericAmount = new NumericUpDown();
                numericAmount.Maximum = 999999;
                numericAmount.Value = accessory.SumAmount;
                numericAmount.Location = new Point(105, 7);
                numericAmount.Size = new Size(146, 20);
                numericAmount.Enabled = false;

                List<object> array = new List<object>();

                array.Add(accessory);
                array.Add(numericAmount);

                pnl3.Controls.Add(numericAmount);

                numericAmount.ReadOnly = true;

                //so luong mua
                Panel pnl4 = new Panel();
                pnl4.Size = new Size(254, 33);
                pnl4.Location = new Point(224, 135);

                pnl.Controls.Add(pnl4);

                Label lbl4 = new Label();
                lbl4.Text = "Số lượng mua:";
                lbl4.Location = new Point(4, 10);

                pnl4.Controls.Add(lbl4);

                NumericUpDown numeric = new NumericUpDown();
                numeric.Maximum = accessory.SumAmount;
                numeric.Minimum = 0;
                numeric.ReadOnly = true;
                numeric.ValueChanged += Numeric_ValueChanged;
                numeric.Location = new Point(105, 7);
                numeric.Tag = array;
                
                pnl4.Controls.Add(numeric);

                

                //button
                Button btn11 = new Button();
                btn11.Location = new Point(486, 146);
                btn11.Size = new Size(75, 23);
                btn11.Text = "Cập nhật";
                btn11.Click += Btn11_Click;
                array.Add(txt1);
                array.Add(txt2);
                array.Add(pnl);
                btn11.Tag = array;
                pnl.Controls.Add(btn11);

                Button btn22 = new Button();
                btn22.Location = new Point(486+81, 146);
                btn22.Size = new Size(75, 23);
                btn22.Text = "Xóa ";
                btn22.Click += Btn22_Click;
                btn22.Tag = array;
                pnl.Controls.Add(btn22);

                Button btn33 = new Button();
                btn33.Location = new Point(486 + 81 * 2, 146-8);
                btn33.Size = new Size(75, 40);
                btn33.Text = "Thêm vào hóa đơn";
                btn33.Click += Btn33_Click;
                btn33.Tag = array;
                pnl.Controls.Add(btn33);

                Button btn44 = new Button();
                btn44.Location = new Point(486 + 81 * 3, 146);
                btn44.Size = new Size(75, 23);
                btn44.Text = "Nhập hàng";
                btn44.Click += Btn44_Click;
                btn44.Tag = array;
                pnl.Controls.Add(btn44);

                //so luong nhap
                Panel pnl5 = new Panel();
                pnl5.Size = new Size(254, 33);
                pnl5.Location = new Point(500, 93);

                pnl.Controls.Add(pnl5);

                Label lbl5 = new Label();
                lbl5.Text = "Số lượng nhập:";
                lbl5.Location = new Point(4, 10);

                pnl5.Controls.Add(lbl5);

                NumericUpDown numeric2 = new NumericUpDown();
                numeric2.Maximum = 999999;
                numeric2.Minimum = 0;
                numeric2.Location = new Point(105, 7);

                pnl5.Controls.Add(numeric2);

                array.Add(numeric2);

                //don gia nhap
                Panel pnl6 = new Panel();
                pnl6.Size = new Size(254, 33);
                pnl6.Location = new Point(500, 54);

                pnl.Controls.Add(pnl6);

                Label lbl6 = new Label();
                lbl6.Text = "Đơn giá nhập:";
                lbl6.Location = new Point(4, 10);

                pnl6.Controls.Add(lbl6);

                TextBox txt6 = new TextBox();
                txt6.Location = new Point(105, 7);
                txt6.Size = new Size(146, 20);

                pnl6.Controls.Add(txt6);

                array.Add(txt6);

                if (acc.Type == 0)
                {
                    txt1.ReadOnly = txt2.ReadOnly = true;
                    btn11.Enabled = false;
                    btn22.Enabled = false;
                    btn44.Enabled = false;
                    numeric2.Enabled = false;
                    txt6.ReadOnly = true;
                }

                array.Add(numeric);
            }


        }

        private void Btn44_Click(object sender, EventArgs e)
        {
            List<object> list = (sender as Button).Tag as List<object>;
            int amount = 0;
            decimal price = 0;
            AccessoryOfCar accessory;

            NumericUpDown numericAmount = (list[1] as NumericUpDown);
            NumericUpDown numericSeld = (list[7] as NumericUpDown);

            try
            {
                 accessory = list[0] as AccessoryOfCar;

                 price = decimal.Parse((list[6] as TextBox).Text);

                 amount = (int)(list[5] as NumericUpDown).Value;
            }
            catch
            {
                MessageBox.Show("Sai định dạng dữ liệu");return;
            }

            if(amount <= 0)
            {
                MessageBox.Show("Sai định dạng dữ liệu"); return;
            }

            if(MessageBox.Show("Chắc chắn nhập thêm " + (list[5] as NumericUpDown).Value +" vào phụ tùng '" +
                accessory.AccessoryName + "' ? ","Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (AccessoryOfCarDAO.Instance.IncreaseAmountForAccessory(accessory, price, amount))
                {
                    numericAmount.Maximum = numericAmount.Value + amount + numericSeld.Value;
                    numericAmount.Value += amount;
                    accessory.SumAmount += amount;
                    numericSeld.Maximum = numericAmount.Maximum;
                    MessageBox.Show("Nhập thành công");
                }
                else
                {
                    MessageBox.Show("Nhập không thành công");
                }
            }
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chắc chắn xóa phụ tùng này ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                List<object> list = (sender as Button).Tag as List<object>;

                if (AccessoryOfCarDAO.Instance.DeleteAccessoryById((list[0] as AccessoryOfCar).ID))
                {
                    MessageBox.Show("Xóa thành công");
                    accessoryOfCarsList.Remove(list[0] as AccessoryOfCar);
                    fLPAccessory.Controls.Remove(list[4] as Panel);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

       public  bool isOpen = false;

        private void Btn33_Click(object sender, EventArgs e)
        {
            List<object> list = (sender as Button).Tag as List<object>;

            NumericUpDown numericAmount = (list[1] as NumericUpDown);
            NumericUpDown numericSeld = (list[7] as NumericUpDown);

            if (!isOpen)
            {
                isOpen = true;
                 fCurrent = new fCurrentBills(acc);
                fCurrent.fcarDetails = this;
                fCurrent.Show();
            }
            else
            {
                if (fCurrent.selectIdBill == 0)
                {
                    MessageBox.Show("Chưa chọn hóa đơn"); return;
                }

                AccessoryOfCar accessory = list[0] as AccessoryOfCar;
                int amount = (int)numericSeld.Value;

                if (amount <= 0)
                {
                    return;
                }

                BillInfoDetailsDAO.Instance.AddAccessoryForBill(accessory.ID,accessory.AccessoryName, accessory.UnitPrice, amount, fCurrent.selectIdBill);

                accessory.SumAmount -= amount;

                numericAmount.Value = accessory.SumAmount;

                numericAmount.Maximum = accessory.SumAmount;

                numericSeld.Maximum = accessory.SumAmount;

                numericSeld.Value = 0;

                fCurrent.ResetValueOfBill(amount * accessory.UnitPrice);

                fCurrent.LoadBillDetails();
            }
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            List<object> list = (sender as Button).Tag as List<object>;
            AccessoryOfCar accessory = list[0] as AccessoryOfCar;
            TextBox txt1 = list[2] as TextBox;
            TextBox txt2 = list[3] as TextBox;

            try
            {
                accessory.AccessoryName = txt1.Text;
                accessory.UnitPrice = decimal.Parse(txt2.Text);
            }
            catch
            {
                MessageBox.Show("Địnhh dạng dữ liệu không đúng"); return;
            }

            if (AccessoryOfCarDAO.Instance.UpdateAccessoryOfCarById(accessory))
            {
                MessageBox.Show("Cập nhật thành công");
                (list[4] as Panel).BackgroundImage = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
                
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void PicAccessory_Click(object sender, EventArgs e)
        {
            PictureBox pic1 = sender as PictureBox;

            string fileName = "";

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                string[] ray = fileName.Split('\\');
                string Image = ray[ray.Length - 1];

                string a = System.IO.Path.Combine(fileName);
                string b = System.IO.Path.Combine("..\\..\\Resources\\Accessory\\" + Image);

                try
                {
                    System.IO.File.Copy(a, b);
                }
                catch { }

                (pic1.Tag as AccessoryOfCar).Image = Image;

                pic1.Image = new Bitmap(b);

            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (sender as NumericUpDown);
            AccessoryOfCar accessory = (num.Tag as List<object>)[0] as AccessoryOfCar;
            NumericUpDown numAmount = (num.Tag as List<object>)[1] as NumericUpDown;

            numAmount.Value = accessory.SumAmount - num.Value;
        }

        private void LoadInstanceCarForPageTwo()
        {
            if(acc.Type == 0)
            {
                btnAddNew.Enabled = false;
            }

            foreach (InstanceOfCar instance in instanceOfCarsList)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(759, 200);
                pnl.BackColor = Color.Linen;
                pnl.BackgroundImage = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
                pnl.BackgroundImageLayout = ImageLayout.Stretch;



                PictureBox pic = new PictureBox();
                pic.Size = new Size(215, 147);
                pic.Click += Pic_Click;
                pic.Location = new Point(3, 15);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
                pic.Tag = instance;

                pnl.Controls.Add(pic);
                fLPInstanceCar.Controls.Add(pnl);
                //ngay nhap
                Panel pnl1 = new Panel();
                pnl1.Size = new Size(254, 33);
                pnl1.Location = new Point(224, 15);

                pnl.Controls.Add(pnl1);

                Label lbl1 = new Label();
                lbl1.Text = "Ngày nhập:";
                lbl1.Location = new Point(4, 10);

                pnl1.Controls.Add(lbl1);

                TextBox txt1 = new TextBox();
                txt1.Text = instance.WareHousingDate.ToString();
                txt1.Location = new Point(105, 7);
                txt1.Size = new Size(146, 20);

                pnl1.Controls.Add(txt1);



                //so khung
                Panel pnl2 = new Panel();
                pnl2.Size = new Size(254, 33);
                pnl2.Location = new Point(224, 54);

                pnl.Controls.Add(pnl2);

                Label lbl2 = new Label();
                lbl2.Text = "Số khung:";
                lbl2.Location = new Point(4, 10);

                pnl2.Controls.Add(lbl2);

                TextBox txt2 = new TextBox();
                txt2.Text = instance.ChassisNumber;
                txt2.Location = new Point(105, 7);
                txt2.Size = new Size(146, 20);

                pnl2.Controls.Add(txt2);

                //so may
                Panel pnl3 = new Panel();
                pnl3.Size = new Size(254, 33);
                pnl3.Location = new Point(224, 93);

                pnl.Controls.Add(pnl3);

                Label lbl3 = new Label();
                lbl3.Text = "Số máy:";
                lbl3.Location = new Point(4, 10);

                pnl3.Controls.Add(lbl3);

                TextBox txt3 = new TextBox();
                txt3.Text = instance.MachineNumber;
                txt3.Location = new Point(105, 7);
                txt3.Size = new Size(146, 20);

                pnl3.Controls.Add(txt3);

                //gia nhap
                Panel pnl4 = new Panel();
                pnl4.Size = new Size(254, 33);
                pnl4.Location = new Point(484, 15);

                pnl.Controls.Add(pnl4);

                Label lbl4 = new Label();
                lbl4.Text = "Giá nhập:";
                lbl4.Location = new Point(4, 10);

                pnl4.Controls.Add(lbl4);

                TextBox txt4 = new TextBox();
                txt4.Text = instance.EntryPrice.ToString();
                txt4.Location = new Point(105, 7);
                txt4.Size = new Size(146, 20);

                pnl4.Controls.Add(txt4);

                //gia ban
                Panel pnl5 = new Panel();
                pnl5.Size = new Size(254, 33);
                pnl5.Location = new Point(484, 54);

                pnl.Controls.Add(pnl5);

                Label lbl5 = new Label();
                lbl5.Text = "Giá bán:";
                lbl5.Location = new Point(4, 10);

                pnl5.Controls.Add(lbl5);

                TextBox txt5 = new TextBox();
                txt5.Text = instance.Price.ToString();
                txt5.Location = new Point(105, 7);
                txt5.Size = new Size(146, 20);

                pnl5.Controls.Add(txt5);

                //khách sở hữu
                Panel pnl6 = new Panel();
                pnl6.Size = new Size(254, 33);
                pnl6.Location = new Point(484, 93);

                pnl.Controls.Add(pnl6);

                Label lbl6 = new Label();
                lbl6.Text = "ID Khách mua:";
                lbl6.Location = new Point(4, 10);

                pnl6.Controls.Add(lbl6);

                TextBox txt6 = new TextBox();
                txt6.Text = instance.IdOwnedCustomer.ToString();
                if (txt6.Text == "0")
                {
                    txt6.Text = "Chưa có khách mua";
                }
                else
                {
                    if(instance.Status == 1)//chua ban
                    {
                        txt6.Text = "Đã có khách đặt";
                    }
                }
                txt6.Location = new Point(105, 7);
                txt6.Size = new Size(146, 20);

                pnl6.Controls.Add(txt6);

                //mau sac

                Panel pnl7 = new Panel();
                pnl7.Size = new Size(254, 33);
                pnl7.Location = new Point(224, 132);

                pnl.Controls.Add(pnl7);

                Label lbl7 = new Label();
                lbl7.Text = "Màu:";
                lbl7.Location = new Point(4, 10);

                pnl7.Controls.Add(lbl7);

                TextBox txt7 = new TextBox();
                txt7.Text = instance.Color;
                txt7.Location = new Point(105, 7);
                txt7.Size = new Size(146, 20);

                pnl7.Controls.Add(txt7);

                List<object> textArray = new List<object>();
                textArray.Add(instance);
                textArray.Add(txt1);
                textArray.Add(txt2);
                textArray.Add(txt3);
                textArray.Add(txt4);
                textArray.Add(txt5);
                textArray.Add(txt6);
                textArray.Add(txt7);
                textArray.Add(pnl);

                //button
                Button btn1 = new Button();
                btn1.Location = new Point(486, 146);
                btn1.Size = new Size(75, 23);
                btn1.Text = "Cập nhật";
                btn1.Click += Btn1_Click;
                btn1.Tag = textArray;
                pnl.Controls.Add(btn1);

                Button btn2 = new Button();
                btn2.Location = new Point(567, 146);
                btn2.Size = new Size(75, 23);
                btn2.Text = "Xóa";
                btn2.Tag = instance;
                btn2.Click += Btn2_Click;
                pnl.Controls.Add(btn2);

                if (instance.IdOwnedCustomer == 0)
                { 
                    Button btn3 = new Button();
                    btn3.Location = new Point(648, 146-8);
                    btn3.Size = new Size(75, 40);
                    btn3.Text = "Thêm vào hóa đơn";
                    btn3.Tag = textArray;
                    btn3.Click += Btn3_Click;
                    pnl.Controls.Add(btn3);
                }

                if (acc.Type == 0)
                {
                    txt1.ReadOnly = true;
                    txt2.ReadOnly = true;
                    txt3.ReadOnly = true;
                    txt4.ReadOnly = true;
                    txt5.ReadOnly = true;
                    txt6.ReadOnly = true;
                    txt7.ReadOnly = true;
                    pic.Enabled = false;

                    btn1.Enabled = false;
                    btn2.Enabled = false;
                }


            }


        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            List<object> list = btn.Tag as List<object>;

            InstanceOfCar instance = list[0] as InstanceOfCar;


            try
            {
                instance.WareHousingDate = DateTime.Parse((list[1] as TextBox).Text);
                instance.ChassisNumber = (list[2] as TextBox).Text;
                instance.MachineNumber = (list[3] as TextBox).Text;
                instance.EntryPrice = decimal.Parse((list[4] as TextBox).Text);
                instance.Price = decimal.Parse((list[5] as TextBox).Text);
                try
                {
                    instance.IdOwnedCustomer = int.Parse((list[6] as TextBox).Text);
                }
                catch
                {
                    instance.IdOwnedCustomer = 0;
                }
                instance.Color = (list[7] as TextBox).Text;
            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu không đúng");
                return;
            }


            if (InstanceOFCarDAO.Instance.UpdateInstanceOfCarById(instance))
            {
                MessageBox.Show("Cập nhật thành công");
                (list[8] as Panel).BackgroundImage = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
            }
            else
            {

                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            InstanceOfCar instance = btn.Tag as InstanceOfCar;

            if (MessageBox.Show("Chắc chắn xóa xe " + car.CarName + " " + instance.ChassisNumber + " " + instance.MachineNumber + " chứ ?", "Thông báo ", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (InstanceOFCarDAO.Instance.DeleteInstanceOfCarById(instance))
                {
                    MessageBox.Show("Xóa thành công");

                    for (int i = 0; i < instanceOfCarsList.Count; i++)
                    {
                        if (instanceOfCarsList[i].ID == instance.ID)
                        {
                            instanceOfCarsList.Remove(instanceOfCarsList[i]);
                        }
                    }

                    fLPInstanceCar.Controls.Clear();

                    LoadInstanceCarForPageTwo();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }


        private void Btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            List<object> list = btn.Tag as List<object>;

            InstanceOfCar instance = list[0] as InstanceOfCar;

            if (!isOpen)
            {
                isOpen = true;
                fCurrent = new fCurrentBills(acc);
                fCurrent.fcarDetails = this;
                fCurrent.Show();
            }
            else
            {
                if(fCurrent.selectIdBill == 0)
                {
                    MessageBox.Show("Chưa chọn hóa đơn");return;
                }

                BillInfoDetailsDAO.Instance.AddCarForBill(instance.ID,car.CarName, instance.Price, fCurrent.selectIdBill , fCurrent.selectIdCustomer);

                fCurrent.LoadBillDetails();

                btn.Visible = false;

                fCurrent.ResetValueOfBill(instance.Price);

                (list[6] as TextBox).Text = "Đã có khách đặt";
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic1 = sender as PictureBox;

            string fileName = "";

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                string[] ray = fileName.Split('\\');
                string Image = ray[ray.Length - 1];

                string a = System.IO.Path.Combine(fileName);
                string b = System.IO.Path.Combine("..\\..\\Resources\\Car\\" + Image);

                try
                {
                    System.IO.File.Copy(a, b);
                }
                catch { }

                (pic1.Tag as InstanceOfCar).ImageOfInstance = Image;

                pic1.Image = new Bitmap(b);

            }
        }

        private void LoadInfoDetailsForAll()
        {
            this.Text += car.CarName;

            //Tải hinh cho picturebox.
            Bitmap bm = new Bitmap("..\\..\\" + "\\Resources\\Car\\" + car.ImageOfCar);
            picCar.Image = bm;

            specCar = SpecificDescriptionOfCarDAO.Instance.GetSpecificDescriptionOfCarById(car.ID);
            //cmb
            cmbProducer.DataSource = producersList;
            cmbProducer.DisplayMember = "ProducerName";

            for (int i = 0; i < producersList.Count; i++)
            {
                if (producersList[i].ID == car.IDProducer)
                {
                    cmbProducer.SelectedIndex = i; break;
                }
            }

            //txt
            txtCarName.Text = car.CarName;
            txtSeat.Text = specCar.NumberOfSeat.ToString();
            txtTypeEngine.Text = specCar.TypeOfEngine;
            txtRearBrake.Text = specCar.RearBrake;
            txtFrontBrake.Text = specCar.FrontBrake;
            txtCombine.Text = specCar.CombinationConsumption;
            txtCylinderCapacity.Text = specCar.CylinderCapacity;
            txtFuel.Text = specCar.FuelSystem;
            txtGear.Text = specCar.Gear;
            txtHeight.Text = specCar.Height;
            txtLength.Text = specCar.Length;
            txtMomen.Text = specCar.MaxMomen;
            txtPower.Text = specCar.MaxPower;
            txtUrban.Text = specCar.UrbanConsumption;
            txtNonurban.Text = specCar.NonurbanConsumption;
            txtPetrolTank.Text = specCar.PetrolTankCapacity;
            txtWidth.Text = specCar.Width;
            txtWeight.Text = specCar.Weight;


            if (acc.Type == 0)//Staff
            {
                picCar.Enabled = false;
                cmbProducer.Enabled = false;
                btnUpdateCar.Enabled = false;
                btnDeleteCar.Enabled = false;

                foreach (Control con in pnlDetails.Controls)
                {
                    try
                    {
                        (con as TextBox).ReadOnly = true;
                    }
                    catch
                    {

                    }
                }

                foreach (Control con in pnlEngine.Controls)
                {
                    try
                    {
                        (con as TextBox).ReadOnly = true;
                    }
                    catch
                    {

                    }
                }
            }
            else//Manager
            {

            }
        }

        private void txtTypeEngine_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnUpdateCar_Click(object sender, System.EventArgs e)
        {
            try
            {
                car.CarName = txtCarName.Text;

                specCar.NumberOfSeat = int.Parse(txtSeat.Text);
                specCar.TypeOfEngine = txtTypeEngine.Text;
                specCar.RearBrake = txtRearBrake.Text;
                specCar.FrontBrake = txtFrontBrake.Text;
                specCar.CombinationConsumption = txtCombine.Text;
                specCar.CylinderCapacity = txtCylinderCapacity.Text;
                specCar.FuelSystem = txtFuel.Text;
                specCar.Gear = txtGear.Text;
                specCar.Height = txtHeight.Text;
                specCar.Length = txtLength.Text;
                specCar.MaxMomen = txtMomen.Text;
                specCar.MaxPower = txtPower.Text;
                specCar.UrbanConsumption = txtUrban.Text;
                specCar.NonurbanConsumption = txtNonurban.Text;
                specCar.PetrolTankCapacity = txtPetrolTank.Text;
                specCar.Width = txtWidth.Text;
                specCar.Weight = txtWeight.Text;


            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu nhập không đúng, nhập lại !");
                return;
            }

            if (SpecificDescriptionOfCarDAO.Instance.UpdateSpecificDescriptionOfCarById(specCar) &&
                CarDAO.Instance.UpdateCarByID(car))
            {
                MessageBox.Show("Cập nhật thành công !");
                deleteCar?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật thành công !"); deleteCar?.Invoke(this, new EventArgs());
                //MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void btnDeleteCar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa dòng xe " + car.CarName + " chứ ?", "Thông báo ", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (CarDAO.Instance.DeleteCarById(car.ID))
                {
                    deleteCar?.Invoke(this, new EventArgs());
                    MessageBox.Show("Xóa " + car.CarName + " thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa " + car.CarName + " thất bại !");
                }
            }

        }

        private void picCar_Click(object sender, EventArgs e)
        {
            string fileName = "";

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                string[] ray = fileName.Split('\\');
                string Image = ray[ray.Length - 1];

                string a = System.IO.Path.Combine(fileName);
                string b = System.IO.Path.Combine("..\\..\\Resources\\Car\\" + Image);

                try
                {
                    System.IO.File.Copy(a, b);
                }
                catch { }

                car.ImageOfCar = Image;

                picCar.Image = new Bitmap(b);
            }

        }

        private void cmbProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clicked) return;
            car.IDProducer = (cmbProducer.SelectedItem as Producer).ID;
        }

        bool clicked = false;
        private void cmbProducer_Click(object sender, EventArgs e)
        {
            clicked = true;
        }

        private void tPg2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            InstanceOfCar instance = new InstanceOfCar();
            Panel pnl = new Panel();
            pnl.Size = new Size(759, 200);
            pnl.BackColor = Color.Linen;
            // pnl.BackgroundImage = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
            pnl.BackgroundImageLayout = ImageLayout.Stretch;



            PictureBox pic = new PictureBox();
            pic.Size = new Size(215, 147);
            pic.Click += Pic_Click;
            pic.Location = new Point(3, 15);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            // pic.Image = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
            pic.Tag = instance;

            pnl.Controls.Add(pic);
            fLPInstanceCar.Controls.Add(pnl);
            //ngay nhap
            Panel pnl1 = new Panel();
            pnl1.Size = new Size(254, 33);
            pnl1.Location = new Point(224, 15);

            pnl.Controls.Add(pnl1);

            Label lbl1 = new Label();
            lbl1.Text = "Ngày nhập:";
            lbl1.Location = new Point(4, 10);

            pnl1.Controls.Add(lbl1);

            TextBox txt1 = new TextBox();
            txt1.Text = instance.WareHousingDate.ToString();
            txt1.Location = new Point(105, 7);
            txt1.Size = new Size(146, 20);

            pnl1.Controls.Add(txt1);



            //so khung
            Panel pnl2 = new Panel();
            pnl2.Size = new Size(254, 33);
            pnl2.Location = new Point(224, 54);

            pnl.Controls.Add(pnl2);

            Label lbl2 = new Label();
            lbl2.Text = "Số khung:";
            lbl2.Location = new Point(4, 10);

            pnl2.Controls.Add(lbl2);

            TextBox txt2 = new TextBox();
            txt2.Text = instance.ChassisNumber;
            txt2.Location = new Point(105, 7);
            txt2.Size = new Size(146, 20);

            pnl2.Controls.Add(txt2);

            //so may
            Panel pnl3 = new Panel();
            pnl3.Size = new Size(254, 33);
            pnl3.Location = new Point(224, 93);

            pnl.Controls.Add(pnl3);

            Label lbl3 = new Label();
            lbl3.Text = "Số máy:";
            lbl3.Location = new Point(4, 10);

            pnl3.Controls.Add(lbl3);

            TextBox txt3 = new TextBox();
            txt3.Text = instance.MachineNumber;
            txt3.Location = new Point(105, 7);
            txt3.Size = new Size(146, 20);

            pnl3.Controls.Add(txt3);

            //gia nhap
            Panel pnl4 = new Panel();
            pnl4.Size = new Size(254, 33);
            pnl4.Location = new Point(484, 15);

            pnl.Controls.Add(pnl4);

            Label lbl4 = new Label();
            lbl4.Text = "Giá nhập:";
            lbl4.Location = new Point(4, 10);

            pnl4.Controls.Add(lbl4);

            TextBox txt4 = new TextBox();
            txt4.Text = instance.EntryPrice.ToString();
            txt4.Location = new Point(105, 7);
            txt4.Size = new Size(146, 20);

            pnl4.Controls.Add(txt4);

            //gia ban
            Panel pnl5 = new Panel();
            pnl5.Size = new Size(254, 33);
            pnl5.Location = new Point(484, 54);

            pnl.Controls.Add(pnl5);

            Label lbl5 = new Label();
            lbl5.Text = "Giá bán:";
            lbl5.Location = new Point(4, 10);

            pnl5.Controls.Add(lbl5);

            TextBox txt5 = new TextBox();
            txt5.Text = instance.Price.ToString();
            txt5.Location = new Point(105, 7);
            txt5.Size = new Size(146, 20);

            pnl5.Controls.Add(txt5);

            //khách sở hữu
            Panel pnl6 = new Panel();
            pnl6.Size = new Size(254, 33);
            pnl6.Location = new Point(484, 93);

            pnl.Controls.Add(pnl6);

            Label lbl6 = new Label();
            lbl6.Text = "ID Khách mua:";
            lbl6.Location = new Point(4, 10);

            pnl6.Controls.Add(lbl6);

            TextBox txt6 = new TextBox();
            txt6.Text = instance.IdOwnedCustomer.ToString();
            if (txt6.Text == "0")
            {
                txt6.Text = "Chưa có khách mua";
            }
            txt6.Location = new Point(105, 7);
            txt6.Size = new Size(146, 20);

            pnl6.Controls.Add(txt6);

            //mau sac

            Panel pnl7 = new Panel();
            pnl7.Size = new Size(254, 33);
            pnl7.Location = new Point(224, 132);

            pnl.Controls.Add(pnl7);

            Label lbl7 = new Label();
            lbl7.Text = "Màu:";
            lbl7.Location = new Point(4, 10);

            pnl7.Controls.Add(lbl7);

            TextBox txt7 = new TextBox();
            txt7.Text = instance.Color;
            txt7.Location = new Point(105, 7);
            txt7.Size = new Size(146, 20);

            pnl7.Controls.Add(txt7);

            List<object> textArray = new List<object>();
            textArray.Add(instance);
            textArray.Add(txt1);
            textArray.Add(txt2);
            textArray.Add(txt3);
            textArray.Add(txt4);
            textArray.Add(txt5);
            textArray.Add(txt6);
            textArray.Add(txt7);
            textArray.Add(pnl);

            //button
            Button btnThemInstanceOfCar = new Button();
            btnThemInstanceOfCar.Location = new Point(486, 146);
            btnThemInstanceOfCar.Size = new Size(75, 23);
            btnThemInstanceOfCar.Text = "Thêm xe mới";
            btnThemInstanceOfCar.Click += BtnThemInstanceOfCar_Click; ;
            btnThemInstanceOfCar.Tag = textArray;
            pnl.Controls.Add(btnThemInstanceOfCar);

            Button btnXoaInstanceOfCar = new Button();
            btnXoaInstanceOfCar.Location = new Point(567, 146);
            btnXoaInstanceOfCar.Size = new Size(75, 23);
            btnXoaInstanceOfCar.Text = "Xóa";
            btnXoaInstanceOfCar.Tag = pnl;
            btnXoaInstanceOfCar.Click += BtnXoaInstanceOfCar_Click; ;
            pnl.Controls.Add(btnXoaInstanceOfCar);

            txt6.ReadOnly = true;
            txt1.ReadOnly = true;
        }

        private void BtnXoaInstanceOfCar_Click(object sender, EventArgs e)
        {
            fLPInstanceCar.Controls.Remove((sender as Button).Tag as Panel);
        }

        private void BtnThemInstanceOfCar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            List<object> list = btn.Tag as List<object>;

            InstanceOfCar instance = list[0] as InstanceOfCar;

            instance.IDCar = car.ID;

            

            try
            {
                instance.ChassisNumber = (list[2] as TextBox).Text;
                instance.MachineNumber = (list[3] as TextBox).Text;
                instance.EntryPrice = decimal.Parse((list[4] as TextBox).Text);
                instance.Price = decimal.Parse((list[5] as TextBox).Text);
                
                instance.Color = (list[7] as TextBox).Text;
            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu không đúng");
                return;
            }

            if (instance.ImageOfInstance == "" || instance.ChassisNumber == "" || instance.MachineNumber == "" || instance.Color == "" || instance.EntryPrice == 0 ||
                instance.Price == 0 )
            {
                MessageBox.Show("Định dạng dữ liệu không đúng");
                return;
            }

            if (InstanceOFCarDAO.Instance.InsertInstanceOfCar(instance))
            {
                MessageBox.Show("Thêm mới thành công");
                (list[8] as Panel).BackgroundImage = new Bitmap("..\\..\\Resources\\Car\\" + instance.ImageOfInstance);
            }
            else
            {

                MessageBox.Show("Thêm mới thất bại");
            }
        }

        private void btnAddNewAccessory_Click(object sender, EventArgs e)
        {
            AccessoryOfCar accessory = new AccessoryOfCar();

            Panel pnl = new Panel();
            pnl.Size = new Size(759, 200);
            pnl.BackColor = Color.Linen;
            pnl.BackgroundImage = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
            pnl.BackgroundImageLayout = ImageLayout.Stretch;
            
            PictureBox picAccessory = new PictureBox();
            picAccessory.Size = new Size(215, 147);
            picAccessory.Click += PicAccessory_Click;
            picAccessory.Location = new Point(3, 15);
            picAccessory.SizeMode = PictureBoxSizeMode.Zoom;
            picAccessory.Image = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
            picAccessory.Tag = accessory;

            pnl.Controls.Add(picAccessory);
            fLPAccessory.Controls.Add(pnl);
            //ten phu tung
            Panel pnl1 = new Panel();
            pnl1.Size = new Size(254, 33);
            pnl1.Location = new Point(224, 15);

            pnl.Controls.Add(pnl1);

            Label lbl1 = new Label();
            lbl1.Text = "Tên phụ tùng:";
            lbl1.Location = new Point(4, 10);

            pnl1.Controls.Add(lbl1);

            TextBox txt1 = new TextBox();
            txt1.Text = accessory.AccessoryName;
            txt1.Location = new Point(105, 7);
            txt1.Size = new Size(146, 20);

            pnl1.Controls.Add(txt1);



            //don gia
            Panel pnl2 = new Panel();
            pnl2.Size = new Size(254, 33);
            pnl2.Location = new Point(224, 54);

            pnl.Controls.Add(pnl2);

            Label lbl2 = new Label();
            lbl2.Text = "Đơn giá:";
            lbl2.Location = new Point(4, 10);

            pnl2.Controls.Add(lbl2);

            TextBox txt2 = new TextBox();
            txt2.Text = accessory.UnitPrice.ToString();
            txt2.Location = new Point(105, 7);
            txt2.Size = new Size(146, 20);

            pnl2.Controls.Add(txt2);
            

            List<object> array = new List<object>();

            array.Add(accessory);

            //so luong
            Panel pnl3 = new Panel();
            pnl3.Size = new Size(254, 33);
            pnl3.Location = new Point(224, 93);

            pnl.Controls.Add(pnl3);

            Label lbl3 = new Label();
            lbl3.Text = "Số lượng:";
            lbl3.Location = new Point(4, 10);

            pnl3.Controls.Add(lbl3);

            NumericUpDown numericAmount = new NumericUpDown();
            numericAmount.Value = accessory.SumAmount;
            numericAmount.Location = new Point(105, 7);
            numericAmount.Size = new Size(146, 20);

            array.Add(numericAmount);

            pnl3.Controls.Add(numericAmount);

            //gia nhap

            Panel pnl4 = new Panel();
            pnl4.Size = new Size(254, 33);
            pnl4.Location = new Point(224, 135);

            pnl.Controls.Add(pnl4);

            Label lbl4 = new Label();
            lbl4.Text = "Đơn giá nhập";
            lbl4.Location = new Point(4, 10);

            pnl4.Controls.Add(lbl4);

            TextBox txt3 = new TextBox();
            txt3.Size= new Size(146, 20); 
            txt3.Location = new Point(105, 7);

            pnl4.Controls.Add(txt3);

            pnl.Controls.Add(pnl4);

            //button
            Button btn11AddAccessory = new Button();
            btn11AddAccessory.Location = new Point(486, 146);
            btn11AddAccessory.Size = new Size(75, 23);
            btn11AddAccessory.Text = "Thêm mới";
            btn11AddAccessory.Click += Btn11AddAccessory_Click;
            array.Add(txt1);
            array.Add(txt2);
            array.Add(txt3);
            array.Add(pnl);
            btn11AddAccessory.Tag = array;
            pnl.Controls.Add(btn11AddAccessory);


            Button btn33CancelAccessory = new Button();
            btn33CancelAccessory.Location = new Point((648 - 486) / 2 + 486, 146);
            btn33CancelAccessory.Size = new Size(75, 23);
            btn33CancelAccessory.Text = "Hủy";
            btn33CancelAccessory.Click += Btn33CancelAccessory_Click; ;
            btn33CancelAccessory.Tag = pnl;
            pnl.Controls.Add(btn33CancelAccessory);

        }

        private void Btn33CancelAccessory_Click(object sender, EventArgs e)
        {
            fLPAccessory.Controls.Remove((sender as Button).Tag as Panel);
        }

        private void Btn11AddAccessory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            List<object> list = btn.Tag as List<object>;

            AccessoryOfCar accessory = list[0] as AccessoryOfCar;

           

            decimal donGiaNhap = 0;

            int amount = 0;

            try
            {


                amount = (int)(list[1] as NumericUpDown).Value;

                accessory.AccessoryName = (list[2] as TextBox).Text;

                accessory.UnitPrice = decimal.Parse((list[3] as TextBox).Text);

                donGiaNhap = decimal.Parse((list[4] as TextBox).Text);
            }
            catch
            {
                MessageBox.Show("Định dạng dữ liệu không đúng"); return;
            }

            if (AccessoryOfCarDAO.Instance.InsertAccessoryByIdCar(car, accessory , donGiaNhap, amount))
            {
                MessageBox.Show("Thêm mới thành công");

                btn.Visible = false;

                (list[5] as Panel).BackgroundImage = new Bitmap("..\\..\\Resources\\Accessory\\" + accessory.Image);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }
        }

        private void fCarDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fCurrent != null)
                fCurrent.Close();
        }
    }
}
