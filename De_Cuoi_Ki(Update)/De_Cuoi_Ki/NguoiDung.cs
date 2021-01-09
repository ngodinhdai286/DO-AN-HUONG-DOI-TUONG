using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace De_Cuoi_Ki
{
    public class NguoiDung
    {
        public List<Drink> orDer = new List<Drink>();// DANHH SACH THUC UONG 1 NGUOI ODER cung la 1 hoa don thanh toan
        public string nameDrink { get; set; }
        public int soTienThanhToan { get; set; }
        public NguoiDung()
        {
            this.nameDrink = nameDrink;
            this.soTienThanhToan = soTienThanhToan;
            this.orDer = null;
        }
        public NguoiDung(string nameDrink, int SL, int TienThanhToan, List<Drink> a)
        {
            this.nameDrink = nameDrink;
            this.soTienThanhToan = TienThanhToan;
            this.orDer = a;
        }
        public NguoiDung(NguoiDung a)
        {
            this.nameDrink = a.nameDrink;
            this.soTienThanhToan = this.soTienThanhToan + a.soTienThanhToan;
            this.orDer = a.orDer;
        }

        public static NguoiDung operator +(NguoiDung n1, NguoiDung n2)
        {
            NguoiDung tongHop = new NguoiDung();
            tongHop.soTienThanhToan = n1.soTienThanhToan + n2.soTienThanhToan;
            return tongHop;
        }

        public NguoiDung nguoiGop(List<NguoiDung> list, int viTri, int viTri2)// Tính tổng tiền khi gộp 2 bàn
        {
            // nguoidung = new nguoi dung
            // for nêu băng vi tri Nguoidung(list[i], nguoi dung)
            //z
            NguoiDung nd = new NguoiDung();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == viTri || i == viTri2)
                {
                    nd = nd + list[i];
                }
            }
            return nd;
        }

        // Gọi thức uống
        public int orderDrink(params object[] thamso)
        {
            this.soTienThanhToan = 18000 * (int)thamso[0] + 25000 * (int)thamso[1] + 100000 * (int)thamso[2] + 20000 * (int)thamso[3];
            return this.soTienThanhToan;// số tiền cần phải trả khi order
        }
        public string tinhTienNhieuBan(params object[] thamso)
        {
            return evenTinhTien?.Invoke(thamso);
        }
        public string order(params object[] thamso)
        {
            return "Yêu cầu thức uống";
        }
        public string chonPhuongThucThanhToan(params object[] thamso)
        {
            return evenTinhTien?.Invoke(thamso);
        }
        public string inHoaDon(params object[] thamso)
        {
            return "In hóa đơn";
        }
        public string thoiTien(params object[] thamso)
        {
            return "Thối tiền";
        }
        public string quiTrinhPhucVuCuaCuaHang(params object[] thamso)
        {
            string b1 = this.order(thamso);
            this.evenTinhTien += NguoiDung_evenTinhTien;
            string b2 = NguoiDung_evenTinhTien(thamso);
            string b3 = this.inHoaDon(thamso);
            string b4 = this.thoiTien(thamso);
            return "Cảm ơn quý khách đã sử dụng dịch vụ";
        }

        private string NguoiDung_evenTinhTien(params object[] thamso)
        {
            return "Thanh toán bằng "+ (string)thamso[0];
        }

        public delegate string PhuongThucTinhTien(params object[] thamso);
        public event PhuongThucTinhTien evenTinhTien;

        //Thanh toán
        public int thanhToan(int tienMat, tienNhan a, params object[] thamso)
        {

            return tienMat - tienNhanVao(a, thamso);
        }
        public int tienNhanVao(tienNhan a, params object[] thamso)
        {
            return a(thamso);
        }

        public delegate int tienNhan(params object[] thamso);
    }
}
