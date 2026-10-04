using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            if (a < b)
            {
                int tong = 0;
                for (int i = a; i <= b; i++)
                {
                    tong += i;
                }
                lblHienThi.Text = "Tổng các số từ " + a + " đến " + b + " là =  " + tong;

            }
            else if (a > b)
            {
                int tong = 0;
                for (int i = b; i <= a; i++)
                {
                    tong += i;
                }
                lblHienThi.Text = "Tổng các số từ " + b + " đến " + a + " là =  " + tong;

            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtA.Focus();
        }
    }
}