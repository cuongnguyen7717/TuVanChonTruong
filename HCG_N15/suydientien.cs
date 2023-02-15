using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG_N15
{
    internal class suydientien
    {
        List<define> bin = new List<define>();
        List<define> SAT = new List<define>();
        private int demLuat = 0;
        public void DocLuat()
        {
            string qr = "select NoiDung from Luat";
            ketnoi cn = new ketnoi();
            DataTable tbLuat =cn.getTable(qr);
            for (int i = 0; i < tbLuat.Rows.Count; i++)
            {
                string buff = tbLuat.Rows[i][0].ToString();
                define luatTG = new define();
                char[] delimiterChars = { '>' };
                string[] tg = buff.Split(delimiterChars);

                //ben trai
                char[] delimiterChars1 = { '^' };
                string[] left = tg[0].Split(delimiterChars1);
                int j = 0;
                string buff1 = left[0];
                while (buff1 != null)
                {
                    luatTG.left.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = left[j];
                    }
                    catch { buff1 = null; };

                }

                j = 0;


                //ben phai
                char[] delimiterChars2 = { ',' };
                string[] right = tg[1].Split(delimiterChars2);

                buff1 = right[0];
                while (buff1 != null)
                {
                    luatTG.right.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = right[j];
                    }
                    catch { buff1 = null; };
                }

                bin.Add(luatTG);
                demLuat++;

            }

        }

        public string XuatLuat(List<define> mangLuat)
        {
            string tg = "";
            foreach (define L in mangLuat)
            {
                foreach (string s in L.left)
                {
                    tg += s + "^";
                }
                tg += "->";
                foreach (string s in L.right)
                {
                    tg += s + "^";
                }
                tg += "\n";

            }
            return tg;
        }

        public bool CheckIn(List<string> a, List<string> b)
        {
            int dem = 0;
            foreach (string tg1 in a)
            {
                foreach (string tg2 in b)
                {
                    if (tg1 == tg2)
                        dem++;
                }
            }
            if (dem == a.Count)
                return true;
            else
                return false;
        }

        public void TimTapSat(List<string> L, List<define> mangLuat)
        {
            foreach (define lTG in mangLuat)
            {
                if (CheckIn(lTG.left, L) == true && !SAT.Contains(lTG))
                {
                    SAT.Add(lTG);
                }
            }
        }

        public bool SuyDien(List<string> left, List<string> right)
        {
            List<define> mangLuat = new List<define>();
            mangLuat = bin;
            List<string> L = right;
            List<string> TG = left;
            TimTapSat(TG, mangLuat);
            while (SAT.Count > 0 && CheckIn(L, TG) == false)
            {
                //lay luat r cuoi cung ra ap dung
                define r = SAT.ElementAt(0);
                mangLuat.Remove(r);
                SAT.RemoveAt(0);
                //them cai chua co vao TG
                foreach (string tg in r.right)
                {
                    if (!TG.Contains(tg))
                    {
                        TG.Add(tg);
                        Console.WriteLine(tg);
                    }

                }
                TimTapSat(TG, mangLuat);
            }

            if (CheckIn(L, TG) == false)
                return false;
            else
                return true;
        }
    }
}
