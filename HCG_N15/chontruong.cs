using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HCG_N15
{
    public partial class chontruong : Form
    {
        public chontruong()
        {
            InitializeComponent();
        }
        private List<string> listMa = new List<string>();
        private List<string> listTruong = new List<string>();
        private ketnoi kn = new ketnoi();
        private bool run = false;

        public void Getdata()
        {

            string qr = "select Mask,Mota from SuKien where Loaisk=N'Trường'";
            DataTable tbTruong = kn.getTable(qr);
            for (int i = 0; i < tbTruong.Rows.Count; i++)
            {
                listMa.Add(tbTruong.Rows[i][0].ToString());
                listTruong.Add(tbTruong.Rows[i][1].ToString());
            }
            string query = "select Mask, Mota  from SuKien Where Loaisk=N'Tổng điểm'";
            DataTable dtb = kn.getTable(query);
            cbdiem.DataSource = dtb;
            cbdiem.DisplayMember = "Mota";
            cbdiem.ValueMember = "Mask";

            string queryptxt = "select Mask, Mota  from SuKien Where Loaisk=N'Phương thức xét tuyển'";
            DataTable dtbptxt = kn.getTable(queryptxt);
         cbxettuyen.DataSource = dtbptxt;
            cbxettuyen.DisplayMember = "Mota";
            cbxettuyen.ValueMember = "Mask";


            string querytinh = "select Mask, Mota  from SuKien Where Loaisk=N'Tỉnh thành'";
            DataTable dtbtinh = kn.getTable(querytinh);
            cbtinhthanh.DataSource = dtbtinh;
            cbtinhthanh.DisplayMember = "Mota";
            cbtinhthanh.ValueMember = "Mask";


            string querykhoi = "select Mask, Mota  from SuKien Where Loaisk=N'Khối'";
            DataTable dtbkhoi = kn.getTable(querykhoi);
            cbkhoi.DataSource = dtbkhoi;
            cbkhoi.DisplayMember = "Mota";
            cbkhoi.ValueMember = "Mask";


            string querynganh = "select Mask, Mota  from SuKien Where Loaisk=N'Ngành'";
            DataTable dtbnganh = kn.getTable(querynganh);
            cbnganh.DataSource = dtbnganh;
            cbnganh.DisplayMember = "Mota";
            cbnganh.ValueMember = "Mask";


            string queryhocphi = "select Mask, Mota  from SuKien Where Loaisk=N'Học phí'";
            DataTable dtbhocphi = kn.getTable(queryhocphi);
            cbhocphi.DataSource = dtbhocphi;
            cbhocphi.DisplayMember = "Mota";
            cbhocphi.ValueMember = "Mask";

          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txttruong.Text = "";
            suydientien sd = new suydientien();
            sd.DocLuat();
            run = true;
            cbdiem.Enabled= false;
            cbhocphi.Enabled= false;
            cbtinhthanh.Enabled= false;
            cbnganh.Enabled= false;
            button1.Enabled = false;
            List<string> gt = new List<string>();
            txttruong.Text = "";
            if (cbdiem.SelectedValue.ToString() != "")
            {
                gt.Add(cbdiem.SelectedValue.ToString());
            }
            if (cbhocphi.SelectedValue.ToString() != "")
            {
                gt.Add(cbhocphi.SelectedValue.ToString());
            }
            if (cbnganh.SelectedValue.ToString() != "")
            {
                gt.Add(item: cbnganh.SelectedValue.ToString());
            }
            if (cbtinhthanh.SelectedValue.ToString() != "")
            {
                gt.Add(cbtinhthanh.SelectedValue.ToString());
            }
            int d = 0;

            if (gt.Count > 0)
            {
                int dem = 0;
                foreach (string s in listMa)
                {
                    if (!run)
                    {
                        btnReset.Enabled = false;
                        break;
                    }
                   /* progressBar.Value = dem;*/
                    List<string> T = new List<string>();
                    T.Add(s);

                    if (sd.SuyDien(gt, T) == true)
                    {
                        txttruong.Text += listTruong.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d == 0 && run != false)
                {
                    txttruong.Text = "Không có ngành phù hợp với yêu cầu lựa chọn!!!\nXin vui lòng chọn lại!!\nChúng tôi sẽ cập nhật thông trong thời gian tới";
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn đầy đủ thông tin!");
            }
            cbdiem.Enabled = true;
            cbhocphi.Enabled = true;
            cbtinhthanh.Enabled = true;
            cbnganh.Enabled = true;
            button1.Enabled = true;
        }
        private int FinIndex(string input, List<string> s)
        {
            int i = 0;
            foreach (string a in s)
            {
                if (input == a)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }
        private void chontruong_Load(object sender, EventArgs e)
        {
            Getdata();
        }
    }
}
