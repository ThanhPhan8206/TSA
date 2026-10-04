namespace Video3
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkInNghieng = new System.Windows.Forms.CheckBox();
            this.chkInDam = new System.Windows.Forms.CheckBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(21, 23);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(130, 23);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input đi thím";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(184, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(361, 22);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(25, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(42, 168);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(67, 20);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(42, 129);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(59, 20);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.radGreen.Location = new System.Drawing.Point(42, 87);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(70, 20);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(42, 48);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(57, 20);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.chkGachChan);
            this.groupBox2.Controls.Add(this.chkInNghieng);
            this.groupBox2.Controls.Add(this.chkInDam);
            this.groupBox2.Location = new System.Drawing.Point(366, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font chữ";
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(39, 129);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(93, 20);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // chkInNghieng
            // 
            this.chkInNghieng.AutoSize = true;
            this.chkInNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInNghieng.Location = new System.Drawing.Point(39, 88);
            this.chkInNghieng.Name = "chkInNghieng";
            this.chkInNghieng.Size = new System.Drawing.Size(90, 20);
            this.chkInNghieng.TabIndex = 1;
            this.chkInNghieng.Text = "In nghiêng";
            this.chkInNghieng.UseVisualStyleBackColor = true;
            this.chkInNghieng.CheckedChanged += new System.EventHandler(this.chkInNghieng_CheckedChanged);
            // 
            // chkInDam
            // 
            this.chkInDam.AutoSize = true;
            this.chkInDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInDam.Location = new System.Drawing.Point(39, 49);
            this.chkInDam.Name = "chkInDam";
            this.chkInDam.Size = new System.Drawing.Size(75, 20);
            this.chkInDam.TabIndex = 0;
            this.chkInDam.Text = "In đậm";
            this.chkInDam.UseVisualStyleBackColor = true;
            this.chkInDam.CheckedChanged += new System.EventHandler(this.chkInDam_CheckedChanged);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(21, 345);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(75, 20);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Hiển thị";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOutput.Location = new System.Drawing.Point(184, 336);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(361, 35);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(584, 347);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(749, 392);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkInNghieng;
        private System.Windows.Forms.CheckBox chkInDam;
    }
}

