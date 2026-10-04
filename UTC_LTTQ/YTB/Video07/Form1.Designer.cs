namespace Video07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKi = new System.Windows.Forms.DateTimePicker();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.grbThongTinDangKi = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongTinDangKi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đăng kí";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(207, 47);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(207, 91);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(206, 27);
            this.txtTuoi.TabIndex = 4;
            // 
            // dtpNgayDangKi
            // 
            this.dtpNgayDangKi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDangKi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDangKi.Location = new System.Drawing.Point(207, 141);
            this.dtpNgayDangKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayDangKi.Name = "dtpNgayDangKi";
            this.dtpNgayDangKi.Size = new System.Drawing.Size(206, 27);
            this.dtpNgayDangKi.TabIndex = 5;
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDangKi.Location = new System.Drawing.Point(155, 222);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(97, 31);
            this.btnDangKi.TabIndex = 6;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // grbThongTinDangKi
            // 
            this.grbThongTinDangKi.Controls.Add(this.label1);
            this.grbThongTinDangKi.Controls.Add(this.btnDangKi);
            this.grbThongTinDangKi.Controls.Add(this.txtPhone);
            this.grbThongTinDangKi.Controls.Add(this.dtpNgayDangKi);
            this.grbThongTinDangKi.Controls.Add(this.label2);
            this.grbThongTinDangKi.Controls.Add(this.label3);
            this.grbThongTinDangKi.Controls.Add(this.txtTuoi);
            this.grbThongTinDangKi.Location = new System.Drawing.Point(51, 27);
            this.grbThongTinDangKi.Name = "grbThongTinDangKi";
            this.grbThongTinDangKi.Size = new System.Drawing.Size(446, 292);
            this.grbThongTinDangKi.TabIndex = 7;
            this.grbThongTinDangKi.TabStop = false;
            this.grbThongTinDangKi.Text = "Thông tin đăng kí";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(543, 357);
            this.Controls.Add(this.grbThongTinDangKi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí xem phim";
            this.grbThongTinDangKi.ResumeLayout(false);
            this.grbThongTinDangKi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKi;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.GroupBox grbThongTinDangKi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

