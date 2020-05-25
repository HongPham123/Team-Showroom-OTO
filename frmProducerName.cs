using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyShowroomXeHoi
{
    public partial class frmProducerName : Form
    {
        fSell fsell;

        public frmProducerName(fSell fsell)
        {
            InitializeComponent();
            this.fsell = fsell;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducerName_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmProducerName_FormClosed(object sender, FormClosedEventArgs e)
        {
            fsell.name = txtName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
