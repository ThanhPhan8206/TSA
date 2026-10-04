using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cảm ơn em đã Click",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show(
            // "Bạn có chắc chắn muốn thoát?",
            // "Confirm",
            // MessageBoxButtons.YesNo,
            // MessageBoxIcon.Warning
            // );

            //if( result == DialogResult.Yes)
            //{
            //    Close();
            //}
            //else if(result ==  DialogResult.No)
            //{
            //    MessageBox.Show("Mời thím tiếp tục dùng");
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblOutput.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblOutput.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblOutput.ForeColor = radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
            {
                lblOutput.ForeColor = radBlack.ForeColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radBlack.Checked = true;
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font (
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Bold);
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Underline);
        }
    }
}
