using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại");
                check = false;
            }



            //Tuổi
            int tuoi;
            if(int.TryParse(txtTuoi.Text, out tuoi) == false)
            {
                errorProvider1.SetError(txtTuoi, "Vui lòng nhập tuổi hợp lệ");
                check = false;
            }
            else
            {
                if(tuoi < 18)
                {
                    errorProvider1.SetError(txtTuoi, "Tuổi phải lớn hơn 18");
                    check = false;
                }
            }


            //Kiểm tra thứ
            
            if (dtpNgayDangKi.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpNgayDangKi, "Không được chọn ngày thứ Hai");
                check = false;
            }
            if( check == true)
            {
                MessageBox.Show("Đăng ký thành công");
            }
        }
    }
}
