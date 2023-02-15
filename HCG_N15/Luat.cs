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
    public partial class Luat : Form
    {
        public Luat()
        {
            InitializeComponent();
        }

        private void Luat_Load(object sender, EventArgs e)
        {
            Getdata();
        }
        public void Getdata()
        {
            string query = "select * from Luat";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            ds = cn.Laydulieu(query, "Luat");
            dgvluat.DataSource = ds.Tables["Luat"];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmaluat.Text;
            string noidung = txtnoidung.Text;
   
            string sql = "insert into Luat (Maluat,NoiDung) VALUES ('" + ma + "',N'" + noidung + "')";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true)
            {
                MessageBox.Show("Thêm luật thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Thêm luật thất bại !");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmaluat.Text;
            string noidung = txtnoidung.Text;
            string sql = "update Luat set MaLuat = '" + ma + "',NoiDung=N'" + noidung + "'where MaLuat = '" + ma + "'";
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Cập nhật luật thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Cập nhật luật thất bại !");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmaluat.Text;

            string sql = "delete  from Luat where MaLuat= '" + ma + "'";
            DataSet ds = new DataSet();
            ketnoi cn = new ketnoi();
            bool kq = cn.ThucThi(sql);
            if (kq == true && ma != "")
            {
                MessageBox.Show("Xóa luật thành công!");
                Getdata();
            }
            else
            {
                MessageBox.Show("Xóa luật thất bại!");
            }
        }

        private void dgvluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtmaluat.Text = dgvluat.Rows[row].Cells["MaLuat"].Value.ToString();

                txtnoidung.Text = dgvluat.Rows[row].Cells["NoiDung"].Value.ToString();


            }
        }
    }
}
