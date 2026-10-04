namespace Tuan01
{
    partial class frmBai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKetQua.Location = new System.Drawing.Point(12, 9);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(629, 52);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoA.Location = new System.Drawing.Point(53, 91);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(102, 20);
            this.lblSoA.TabIndex = 2;
            this.lblSoA.Text = "Số nguyên A";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoB.Location = new System.Drawing.Point(53, 143);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(103, 20);
            this.lblSoB.TabIndex = 3;
            this.lblSoB.Text = "Số nguyên B";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(205, 91);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(244, 25);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(205, 143);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(244, 25);
            this.txtB.TabIndex = 5;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTong.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(70, 258);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(85, 32);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHieu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.Location = new System.Drawing.Point(285, 258);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(85, 32);
            this.btnHieu.TabIndex = 7;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Aqua;
            this.btnReset.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(482, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(285, 322);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(653, 407);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tổng - Hiệu";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
    }
}

