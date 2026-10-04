namespace ListBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblNhapA = new System.Windows.Forms.Label();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapA.Location = new System.Drawing.Point(57, 60);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(73, 16);
            this.lblNhapA.TabIndex = 0;
            this.lblNhapA.Text = "Nhập a = ";
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapB.Location = new System.Drawing.Point(60, 116);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(73, 16);
            this.lblNhapB.TabIndex = 1;
            this.lblNhapB.Text = "Nhập b = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(174, 60);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 22);
            this.txtA.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtA, "Hãy nhập số nguyên a");
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(174, 116);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 22);
            this.txtB.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtB, "Hãy nhập số nguyên b");
            // 
            // lblHienThi
            // 
            this.lblHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(60, 184);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(348, 44);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(29, 265);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 32);
            this.btnTong.TabIndex = 3;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(174, 264);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 32);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(309, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(537, 374);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.lblNhapA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương tình tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

