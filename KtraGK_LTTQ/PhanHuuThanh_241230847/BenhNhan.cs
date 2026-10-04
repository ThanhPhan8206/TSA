using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PhanHuuThanh_241230847
{
    public class BenhNhan
    {
        public string MaBN { get; set; }
        public string HoTen { get; set; }
        public int NgaySinh { get; set; }
        public bool CoBHYT { get; set; }
        public string MaThe { get; set; }
        public string MucHuong { get; set; }
        public bool DungTuyen { get; set; }

       
        public bool Khambenh { get; set; }
        public bool XetNghiem { get; set; }
        public bool SieuAm { get; set; }
        public bool XQuang { get; set; }
        public bool DienTim { get; set; }
        public int SoNgayGiuong { get; set; }


        public decimal TongChiPhi { get; set;  }
        public decimal BHYTChiTra { get; set;  }
        public decimal BNTra { get; set;  }


        public BenhNhan() { }

        public void TinhChiPhi()
        {
            TongChiPhi = 0;
            if(Khambenh) TongChiPhi += 50000;
            if(XetNghiem) TongChiPhi += 120000;
            if(SieuAm) TongChiPhi += 15000;
            if(XQuang) TongChiPhi += 180000;
            if (DienTim) TongChiPhi += 8000;
            
            TongChiPhi += SoNgayGiuong * 250000;

            BHYTChiTra = 0;
            if (CoBHYT && !string.IsNullOrEmpty(MucHuong))
            {
                decimal phanTram = decimal.Parse(MucHuong.Replace("%", "")) / 100m;

                if (DungTuyen)
                {
                    
                    if (TongChiPhi < 351000)
                    {
                        BHYTChiTra = TongChiPhi;
                    }
                    else
                    {
                        BHYTChiTra = TongChiPhi * phanTram;
                    }
                }
                else 
                {
                    BHYTChiTra = TongChiPhi * phanTram * 0.4m; // 40% mức hưởng[cite: 3]
                }
            }

            BNTra = TongChiPhi - BHYTChiTra;
        }

        public override string ToString()
        {
            return $"{MaBN} | {HoTen} | {TongChiPhi:N0} | {BHYTChiTra:N0} | {BNTra:N0}";
        }

    }



}

