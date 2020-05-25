using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PhanMemQuanLyShowroomXeHoi.DAO;
using PhanMemQuanLyShowroomXeHoi.DTO;

namespace PhanMemQuanLyShowroomXeHoi
{
    public partial class fSell : Form
    {
        private Account acc;
        List<Car> carList;
        List<Producer> producerList;
        List<CheckBox> chkList = new List<CheckBox>();

        public fSell(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void fSell_Load(object sender, EventArgs e)
        {
            producerList = ProducerDAO.Instance.LoadProducerList();
            LoadProducerList();

            LoadCarDataAndCarList();

            if (acc.Type == 0)
            {
                btnAddNewCar.Enabled = false;
                btnAddNewProducer.Enabled = false;
                btnDeleteProducer.Enabled = false;
            }
        }

        private void LoadCarDataAndCarList()
        {
            carList = CarDAO.Instance.LoadCarList();
            LoadCarList();
        }

        private void LoadCarList()//tải hình ảnh car lên picturebox.
        {
            fLPCar.Controls.Clear();

            foreach (Car car in carList)
            {
                bool allCheck = true;//flag
                foreach(CheckBox chk in chkList)//kiểm tra xem trong chkList có chk nào là false không, nếu có thì không hiển thị xe của producer đó
                {
                    if(((chk.Tag as Panel).Tag as Producer).ID == car.IDProducer && !chk.Checked)
                    {
                        allCheck = false;
                        break;

                    }
                }

                if (!allCheck) continue;//bỏ qua xe hiện tại.

                //tạo panel
                Panel pnl = new Panel();
                pnl.Size = new Size(300, 200);
                pnl.BackColor = Color.WhiteSmoke;
                pnl.Margin = new Padding(1,10,1,1);
                pnl.Tag = car;

                //tạo picturebox
                PictureBox pic = new PictureBox();
                pic.Padding = new Padding(0);
                pic.Size = new Size(pnl.Size.Width, pnl.Size.Height * 4 / 5);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Tag = pnl;
                pic.MouseHover += Pic_MouseHover;
                pic.MouseLeave += Pic_MouseLeave;
                pic.Click += Pic_Click;

                Bitmap bm = new Bitmap("..\\..\\" + "\\Resources\\Car\\" + car.ImageOfCar);
                pic.Image = bm;
                
                //tạo label
                Label lbl = new Label();
                lbl.Size = new Size(lbl.Size.Width + 20, lbl.Size.Height);
                lbl.Text = car.CarName;
                lbl.ForeColor = Color.Black;
                lbl.Location = new Point(pnl.Size.Width / 3, pnl.Size.Height * 85/100);

                //add vào panel
                pnl.Controls.Add(pic);
                pnl.Controls.Add(lbl);

                //add panel vào fLP
                fLPCar.Controls.Add(pnl);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            fCarDetails fCarDetails = new fCarDetails(((sender as PictureBox).Tag as Panel).Tag as Car, acc, producerList);

            fCarDetails.DeleteCar += FCarDetails_DeleteCar;

            Visible = false;

            fCarDetails.ShowDialog();

            Visible = true;
            
        }

        private void FCarDetails_DeleteCar(object sender, EventArgs e)
        {
            LoadCarDataAndCarList();
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            (pic.Tag as Panel).BackColor = Color.WhiteSmoke;
        }
        
        private void Pic_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            (pic.Tag as Panel).BackColor = Color.Wheat;
        }

        private void LoadProducerList()//tải hình ảnh producer lên picturebox.
        {
            fLPProducer.Controls.Clear();

            foreach (Producer producer in producerList)
            {
                //tạo panel
                Panel pnl = new Panel();
                pnl.Size = new Size(295, 112);
                pnl.BackColor = Color.White;
                pnl.Margin = new Padding(1);
                pnl.Tag = producer;

                //tạo picturebox
                PictureBox pic = new PictureBox();
                pic.Location = new Point(121, 5);
                pic.Size = new Size(170, 100);
                pic.BackColor = Color.WhiteSmoke;
                pic.Tag = producer;
                pic.Click += Pic_Click1;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                Bitmap bm = new Bitmap("..\\..\\" + "\\Resources\\" + producer.Logo);

                pic.Image = bm;

                //tạo check box
                CheckBox chk = new CheckBox();
                chk.Size = new Size(pnl.Size.Width - pic.Size.Width - 5, pnl.Size.Height);
                //chk.BackColor = Color.Aquamarine;
                //chk.Location = new Point(3, 46);
                chk.Text = producer.ProducerName;
                chk.TextAlign = ContentAlignment.MiddleCenter;
                chk.Tag = pnl;
                chk.Checked = true;
                chk.CheckedChanged += Chk_CheckedChanged;

                chkList.Add(chk);


                //add vào panel
                pnl.Controls.Add(chk);
                pnl.Controls.Add(pic);
                //add panel vào fLP
                fLPProducer.Controls.Add(pnl);
            }
        }

        private void Pic_Click1(object sender, EventArgs e)
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
                string b = System.IO.Path.Combine("..\\..\\Resources\\" + Image);

                try
                {
                    System.IO.File.Copy(a, b);
                }
                catch { }

                (pic1.Tag as Producer).Logo = Image;

                ProducerDAO.Instance.UpdateProducerById(pic1.Tag as Producer);

                pic1.Image = new Bitmap(b);
            }
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            Car car = CarDAO.Instance.InsertNewCar();

            //tạo panel
            Panel pnl = new Panel();
            pnl.Size = new Size(300, 200);
            pnl.BackColor = Color.WhiteSmoke;
            pnl.Margin = new Padding(1, 10, 1, 1);
            pnl.Tag = car;

            //tạo picturebox
            PictureBox pic = new PictureBox();
            pic.Padding = new Padding(0);
            pic.Size = new Size(pnl.Size.Width, pnl.Size.Height * 4 / 5);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Tag = pnl;
            pic.MouseHover += Pic_MouseHover;
            pic.MouseLeave += Pic_MouseLeave;
            pic.Click += Pic_Click;

            Bitmap bm = new Bitmap("..\\..\\" + "\\Resources\\Car\\" + car.ImageOfCar);
            pic.Image = bm;

            //tạo label
            Label lbl = new Label();
            lbl.Size = new Size(lbl.Size.Width + 20, lbl.Size.Height);
            lbl.Text = car.CarName;
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(pnl.Size.Width / 3, pnl.Size.Height * 85 / 100);

            //add vào panel
            pnl.Controls.Add(pic);
            pnl.Controls.Add(lbl);

            //add panel vào fLP
            fLPCar.Controls.Add(pnl);
        }
        public string name="";
        private void btnAddNewProducer_Click(object sender, EventArgs e)
        {
            frmProducerName frm = new frmProducerName(this);

            frm.ShowDialog();

            Producer producer = ProducerDAO.Instance.InsertNewProducer(name);
            producerList.Add(producer);
            //tạo panel
            Panel pnl = new Panel();
            pnl.Size = new Size(295, 112);
            pnl.BackColor = Color.White;
            pnl.Margin = new Padding(1);
            pnl.Tag = producer;

            //tạo picturebox
            PictureBox pic = new PictureBox();
            pic.Location = new Point(121, 5);
            pic.Size = new Size(170, 100);
            pic.BackColor = Color.WhiteSmoke;
            pic.Click += Pic_Click1;
            pic.Tag = producer;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            Bitmap bm = new Bitmap("..\\..\\" + "\\Resources\\" + producer.Logo);

            pic.Image = bm;

            //tạo check box
            CheckBox chk = new CheckBox();
            chk.Size = new Size(pnl.Size.Width - pic.Size.Width - 5, pnl.Size.Height);
            //chk.BackColor = Color.Aquamarine;
            //chk.Location = new Point(3, 46);
            chk.Text = producer.ProducerName;
            chk.TextAlign = ContentAlignment.MiddleCenter;

            chk.Tag = pnl;
            chk.Checked = true;
            chk.CheckedChanged += Chk_CheckedChanged;

            chkList.Add(chk);
            
            //add vào panel
            pnl.Controls.Add(chk);
            pnl.Controls.Add(pic);
            //add panel vào fLP
            fLPProducer.Controls.Add(pnl);
        }

        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa các hãng xe?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                for(int i  = 0; i< chkList.Count;i++)
                {
                    CheckBox checkBox = chkList[i];

                    if (!checkBox.Checked) continue;

                    Producer producer = ((checkBox.Tag as Panel).Tag as Producer);

                    if (!ProducerDAO.Instance.DeleteProducerById(producer))
                    {
                        MessageBox.Show("Không xóa được hãng " + producer.ProducerName + " vì đang có dữ liệu tham chiếu !");
                    }
                    else
                    {
                        chkList.Remove(checkBox);
                        producerList.Remove(producer);
                        fLPProducer.Controls.Remove(checkBox.Tag as Panel);
                        i--;
                    }
                }
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            (new fCurrentBills(acc)).ShowDialog();
            Visible = true;
        }

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            (new fGuarantee()).ShowDialog();
            Visible = true;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            (new fCustomer()).ShowDialog(); Visible = true;
        }

        private void tàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new fAccountInfo(acc)).ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            (new fAdmin()).ShowDialog(); Visible = true;
        }
    }
}
