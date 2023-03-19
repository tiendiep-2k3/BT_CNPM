namespace BT_Lon_CNPM
{
    partial class Form2
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
            this.cbdi = new System.Windows.Forms.ComboBox();
            this.cbden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btATM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbdi
            // 
            this.cbdi.FormattingEnabled = true;
            this.cbdi.Items.AddRange(new object[] {
            "ĐH Tôn Đức Thắng",
            "ĐH Văn Lang",
            "ĐH Hoa Sen",
            "ĐH Du Lịch",
            "ĐH Kinh Tế"});
            this.cbdi.Location = new System.Drawing.Point(134, 320);
            this.cbdi.Name = "cbdi";
            this.cbdi.Size = new System.Drawing.Size(162, 28);
            this.cbdi.TabIndex = 1;
            this.cbdi.SelectedIndexChanged += new System.EventHandler(this.cbdi_SelectedIndexChanged);
            // 
            // cbden
            // 
            this.cbden.FormattingEnabled = true;
            this.cbden.Items.AddRange(new object[] {
            "ĐH Tôn Đức Thắng",
            "ĐH Văn Lang",
            "ĐH Hoa Sen",
            "ĐH Du Lịch",
            "ĐH Kinh Tế"});
            this.cbden.Location = new System.Drawing.Point(134, 372);
            this.cbden.Name = "cbden";
            this.cbden.Size = new System.Drawing.Size(162, 28);
            this.cbden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "diem di";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "diem den";
            // 
            // btATM
            // 
            this.btATM.AutoSize = true;
            this.btATM.Location = new System.Drawing.Point(486, 232);
            this.btATM.Name = "btATM";
            this.btATM.Size = new System.Drawing.Size(116, 69);
            this.btATM.TabIndex = 0;
            this.btATM.Text = "ATM";
            this.btATM.UseVisualStyleBackColor = true;
            this.btATM.Click += new System.EventHandler(this.btATM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ho ten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "sdt";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(134, 226);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(162, 26);
            this.txtTen.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(134, 269);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(162, 26);
            this.txtsdt.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "QR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 202);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.cbden);
            this.Controls.Add(this.cbdi);
            this.Controls.Add(this.btATM);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdi;
        private System.Windows.Forms.ComboBox cbden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btATM;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}