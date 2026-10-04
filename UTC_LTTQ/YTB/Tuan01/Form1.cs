using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan01
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void lblSoNguyenB_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoNguyenA_Click(object sender, EventArgs e)
        {

        }

        private void frmBai1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " + " + txtB.Text + " = " + tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắn chắn muốn reset",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if( result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txtA.Text = "";
                txtB.Text = "";
            }

        }
    }
}
