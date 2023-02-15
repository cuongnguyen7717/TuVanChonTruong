using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCG_N15
{
    public partial class SuKien : Form
    {
        public SuKien()
        {
            InitializeComponent();
        }
        public void Getdata()
        {
            string query = "select * from SuKien";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "SuKien");
            dgvsk.DataSource = ds.Tables["SuKien"];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmask.Text;
            string mota = txtmota.Text;
            string loaisk = cbloaisk.Text;
            string sql = "insert into SuKien (Mask,Mota,Loaisk) VALUES ('" + ma + "',N'" + mota + "',N'" + loaisk + "')";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Thêm sự kiện thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Thêm sự kiện thất bại !");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmask.Text;
            string mota = txtmota.Text;
            string loaisk = cbloaisk.Text;
            string sql = "update SuKien set Mask = '" + ma + "',Mota=N'" + mota + "',Loaisk=N'" + loaisk + "' where Mask = '" + ma + "'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Cập nhật thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }

        }

        private void dgvsk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SuKien_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmask.Text;
            string sql = "delete  from SuKien where Mask= '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Xóa sự kiện thành công!");
                Getdata();
            }
            else
            {
                MessageBox.Show("Xóa sự kiện thất bại!");
            }
        }

        private void dgvsk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtmask.Text = dgvsk.Rows[row].Cells["Mask"].Value.ToString();
    
                txtmota.Text = dgvsk.Rows[row].Cells["Mota"].Value.ToString();
                cbloaisk.SelectedItem = dgvsk.Rows[row].Cells["Loaisk"].Value.ToString();
        
            }
        }
    }
}
