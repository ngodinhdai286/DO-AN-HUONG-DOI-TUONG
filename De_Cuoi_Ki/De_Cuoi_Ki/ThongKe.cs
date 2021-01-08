using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class ThongKe
    {
        // Thông kê loại thức yêu thích được dùng nhiều trong tháng
        //Thong ke so luong nhap về cua cac loai thuc uong
        //Thong ke doanh thu của thuc uong và tiền lãi
        public static object goiMon(params object[] thamso)
        {
            return "Gọi Món";
        }
        public object tinhTien(params object[] thamso)
        {
            ThongKe a = new ThongKe();
            a.eventTinhTien += A_eventtinhTien;
            return "Tính tiền các hóa đơn";
        }

        private object A_eventtinhTien(params object[] thamso)
        {
            return (int)thamso[0] + (int)thamso[1] + (int)thamso[2] + (int)thamso[3] + (int)thamso[4];
        }

        public static object luuDatabase(params object[] thamso)
        {
            return "Lưu vào database";
        }


        public delegate object delegateTinhTien(params object[] thamso);
        public event delegateTinhTien eventTinhTien;
        public string thucUongYeuThich(params object[] thamso)//Thong ke loaij thuc uong yeu thichs trong thang
        {

            return "\nCoffee: " + Cafe.countCafe + "\n" + "Fruit: " + Fruit.countFruit + "\n" + "Beer: " + Beer.countBeer + "\n" + "RuouVang: " + RuouVang.countRuou + "\n";
        }
        public int doanhThuThang(List<DoanhThuNgay> Tien)
        {
            int MONEY = 0;
            foreach (DoanhThuNgay a in Tien)
            {
                MONEY = MONEY + a.doanhThu;
            }
            return MONEY;
        }
        public delegate string delegateThongkeThucUong(params object[] thamso);
        public string thongKeDoUong(delegateThongkeThucUong a, params object[] thamso)
        {
            return a(thamso);
        }

        //  public delegate string DoanhThuThang();
        //     public event DoanhThuThang thuTien;


    }
}
