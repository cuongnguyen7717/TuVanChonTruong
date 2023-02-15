namespace HCG_N15
{
    partial class SuKien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvsk = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmask = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.RichTextBox();
            this.cbloaisk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsk
            // 
            this.dgvsk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsk.Location = new System.Drawing.Point(12, 207);
            this.dgvsk.Name = "dgvsk";
            this.dgvsk.RowHeadersWidth = 51;
            this.dgvsk.RowTemplate.Height = 29;
            this.dgvsk.Size = new System.Drawing.Size(656, 263);
            this.dgvsk.TabIndex = 0;
            this.dgvsk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsk_CellClick);
            this.dgvsk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsk_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(738, 229);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(133, 52);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(738, 302);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(133, 52);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(738, 376);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(133, 52);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sự kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại";
            // 
            // txtmask
            // 
            this.txtmask.Location = new System.Drawing.Point(115, 31);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(239, 27);
            this.txtmask.TabIndex = 7;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(115, 84);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(303, 43);
            this.txtmota.TabIndex = 8;
            this.txtmota.Text = "";
            // 
            // cbloaisk
            // 
            this.cbloaisk.FormattingEnabled = true;
            this.cbloaisk.Items.AddRange(new object[] {
            "Ngành",
            "Trường",
            "Hệ",
            "Học phí",
            "Tỉnh thành",
            "Phương thức xét tuyển",
            "Tổng điểm"});
            this.cbloaisk.Location = new System.Drawing.Point(115, 147);
            this.cbloaisk.Name = "cbloaisk";
            this.cbloaisk.Size = new System.Drawing.Size(151, 28);
            this.cbloaisk.TabIndex = 9;
            // 
            // SuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 484);
            this.Controls.Add(this.cbloaisk);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvsk);
            this.Name = "SuKien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsk;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmask;
        private System.Windows.Forms.RichTextBox txtmota;
        private System.Windows.Forms.ComboBox cbloaisk;
    }
}
