using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class DoanhThuNgay
    {

        public static int ngay = 0;
        public int doanhThu { get; set; }
        List<NguoiDung> danhSachHoaDonTrongNgay = new List<NguoiDung>();
        public DoanhThuNgay()
        {
            ngay++;
            this.doanhThu = 0;
        }
        public DoanhThuNgay(int doanhthu)
        {
            ngay++;
            this.doanhThu = doanhthu;
        }
        public DoanhThuNgay(DoanhThuNgay a)
        {
            ngay++;
            this.doanhThu = a.doanhThu;
        }
        public int tongDoanhThuTrongNgay()
        {
            int x = 0;
            foreach (NguoiDung a in danhSachHoaDonTrongNgay)
            {
                x = x + a.orderDrink();
            }
            return x;

        }


    }
}
