using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class QuanLy
    {
        private int _countNguyenlieubeer;
        public int countNguyenlieubeer {
            set { this._countNguyenlieubeer = value; }
            get{ return this._countNguyenlieubeer; }
        }

        private int _countNguyenlieuruouvang;
        public int countNguyenlieuruouvang
        {
            set { this._countNguyenlieuruouvang =value; }
            get { return this._countNguyenlieuruouvang; }
        }
        private int _countNguyenlieucafe;
        public int countNguyenlieucafe
        {
            set { this._countNguyenlieucafe = value; }
            get { return this._countNguyenlieucafe; }
        }
        private int _countNguyenlieufruit;
        public int countNguyenlieufruit
        {
            set { this._countNguyenlieufruit = value; }
            get { return this._countNguyenlieufruit; }
        }
        private int _khoanTiennhapvao;
        public int khoanTiennhapvao
        {
            set { this._khoanTiennhapvao = value; }
            get { return this._khoanTiennhapvao; }
        }

        public QuanLy()
        {
            this.countNguyenlieubeer = 100;// thùng bia
            this.countNguyenlieucafe = 30;// 30 kg
            this.countNguyenlieufruit = 100;// kg
            this.countNguyenlieuruouvang = 100;
           
        }

        public QuanLy(params int[] soLuong) // Contructor thay đổi số lượng vật tư cần nhập của từng loại
        {
            this.countNguyenlieubeer = soLuong[0];// thùng bia
            this.countNguyenlieucafe = soLuong[1];// 30 kg
            this.countNguyenlieufruit = soLuong[2];// kg
            this.countNguyenlieuruouvang = soLuong[3];

        }

        public delegate object delegateLuDuLieu(params object[] thamso);
        public event delegateLuDuLieu eventDB;
        public string goiNuoc(params object[] thamso)
        {
            return "Gọi nước";
        }
        public string thanhToan(params object[] thamso)
        {
            return "Thanh toán tiền";
        }
        public string luuDuLieu(params object[] thamso)
        {
            return (string)eventDB?.Invoke(thamso);
        }
        public string datXe(params object[] thamso)
        {
            return "Dat xe";
        }
        public string cacBuocThucHien(params object[] thamso)
        {
            string b1 = this.goiNuoc(thamso);
            string b2 = this.thanhToan(b1);
            this.eventDB += QuanLy_eventDB1;
            string b4 = this.datXe(thamso);
            return "Cảm ơn quý khách đã sử dụng dịch vụ của cửa hàng";
        }

        private object QuanLy_eventDB1(params object[] thamso)
        {
            return "Lưu dữ liệu vào tuần "+ thamso[0];
        }

        private object QuanLy_eventDB(params object[] thamso)
        {
            throw new NotImplementedException();
        }



        // SÔ TIỀN NHẬP NGUYÊN LIỆU
        public int soTienCanNhapHang(params object[] thamso)
        {
            return (this.countNguyenlieuruouvang * 50000 + this.countNguyenlieufruit * 10000 + this.countNguyenlieucafe * 12000 + this.countNguyenlieubeer * 300000);
        }
        public int VatTu(delegateQuanLi a, params object[] thamso)
        {
            return (int)thamso[0]- (int)(quanLiVatTu(a)) ;
        }
        public int quanLiVatTu(delegateQuanLi a, params object[] thamso)
        {
            return a(thamso);
        }
        public delegate int delegateQuanLi(params object[] thamso);
    }
}
