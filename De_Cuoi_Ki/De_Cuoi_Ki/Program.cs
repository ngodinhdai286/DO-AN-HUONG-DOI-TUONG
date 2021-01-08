using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu menuCuahang = new Menu();

            List<DoanhThuNgay> TienThang = new List<DoanhThuNgay>();//quản lí doanh thu từng ngày

            DoanhThuNgay ngayMoney = new DoanhThuNgay(); // tao ra hoa don doanh thu 1 ngay sau do them vao list doanh thu ngay

            int ngayBan = 0;// đếm số ngày của tuần
            while (ngayBan != 2)
            {
                List<NguoiDung> HoaDon = new List<NguoiDung>();
                while (true)//Số đơn trong một ngày
                {

                    NguoiDung User = new NguoiDung();
                    Console.Clear();
                    Console.WriteLine(menuCuahang.hienThiMenu());
                    List<Drink> order = new List<Drink>();
                    int countCoffee = 0;
                    int countBeer = 0;
                    int countRuou = 0;
                    int countFruit = 0;
                    while (true)
                    {
                        Console.Write("Nhập vào lựa chọn của khách hàng: ");
                        int i = int.Parse(Console.ReadLine());
                        if (i == 1)
                        {
                            countCoffee++;
                            Drink a = new Cafe();
                            order.Add(a);
                            Console.WriteLine("Quý khách đã chọn cà phê!\n");
                        }
                        else if (i == 2)
                        {
                            countBeer++;
                            Drink b = new Beer();
                            order.Add(b);
                            Console.WriteLine("Quý khách đã chọn rượu vang!\n");
                        }
                        else if (i == 3)
                        {
                            countRuou++;
                            Drink c = new RuouVang();
                            order.Add(c);
                            Console.WriteLine("Quý khách đã chọn rượu vang!\n");
                        }
                        else if (i == 4)
                        {
                            countFruit++;
                            Drink d = new Fruit();
                            order.Add(d);
                            Console.WriteLine("Quý khách đã chọn nước trái cây!\n");
                        }
                        else if (i == 5)
                        {
                            Console.WriteLine("Cảm ơn quý khách đã sử dụng dịch vụ của cửa hàng!\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Cửa hàng chưa có dịch vụ quý khách yêu cầu. Mời khách khách nhập lại!\n");
                        }
                    }

                    HoaDon.Add(User);//Thêm hóa đơn vừa tạo vào trong list hóa đơn trong ngày

                    // HIỂN THỊ HÓA ĐƠN
                    Console.WriteLine(menuCuahang.hienThiHoaDon(countCoffee, countBeer, countRuou, countFruit));
                    NguoiDung.tienNhan x = new NguoiDung.tienNhan(User.orderDrink);

                    //TÍNH TIỀN 1 BÀN
                    Console.Write("\nSố tiền cửa hàng nhận vào của khách hàng: ");
                    int tienCuakhach = int.Parse(Console.ReadLine());// số tiền khách đưa để thanh toán
                    Console.WriteLine("\nNhà hàng nhận vào của khách hàng: " + tienCuakhach + " VNĐ");

                    // TRẢ LẠI TIỀN THỪA CHO KHÁCH HÀNG
                    int tienThoi = User.thanhToan(tienCuakhach, x, countCoffee, countBeer, countRuou, countFruit);
                    Console.WriteLine("Số tiền của hàng trả lại cho khách hàng: " + tienThoi + " VNĐ");

                    //TÍNH TIỀN 2 BÀN
                    if (HoaDon.Count >= 2)
                    {
                        Console.WriteLine("\nBạn có muốn gộp bàn không: \n0: Không \n1: Có \n");
                        Console.Write("Nhập lựa chọn của quý khách: ");

                        int luachon = int.Parse(Console.ReadLine());
                        if (luachon == 1)
                        {
                            NguoiDung member = new NguoiDung();// tạo người dùng mới để gộp số tiền nhiều bàn

                            Console.Write("\nNhập bàn cần thanh toán: ");
                            int banGop1 = int.Parse(Console.ReadLine());

                            Console.Write("Nhập bàn cần thanh toán: ");
                            int banGop2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Tổng tiền cần thanh toán: " + member.nguoiGop(HoaDon, banGop1, banGop2).soTienThanhToan + "VNĐ");

                            Console.Write("\nSố tiền cửa hàng nhận vào của khách hàng: ");
                            int tienCuakhachGop = int.Parse(Console.ReadLine());// số tiền khách đưa để thanh toán
                            Console.WriteLine("\nNhà hàng nhận vào của khách hàng: " + tienCuakhachGop + " VNĐ");

                            // TRẢ LẠI TIỀN THỪA CHO KHÁCH HÀNG
                            int tienThoi_Gop = tienCuakhachGop - member.nguoiGop(HoaDon, banGop1, banGop2).soTienThanhToan;
                            Console.WriteLine("Số tiền của hàng trả lại cho khách hàng: " + tienThoi_Gop + " VNĐ");
                        }
                    }

                    // KIỂM TRA QUÁN CÓ CÒN BÁN TẾP KHÔNG
                    Console.WriteLine("\n1. Cửa hàng tạm ngưng phục vụ!");
                    Console.WriteLine("2. Cửa hàng tiếp tục phục vụ!\n");
                    Console.Write("Nhập lựa chọn của chủ cửa hàng: ");

                    int dongCua = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (dongCua == 1)
                    {
                        break;
                    }
                }


                ngayBan++;  //nếu cửa hàng nghỉ bán thì số ngày tăng lên 1
                int tien1Ngay = 0;    

                // IN CÁC HÓA ĐƠN TRONG NGÀY
                Console.WriteLine("Hóa đơn ngày thứ " + ngayBan);
                for (int i = 0; i < HoaDon.Count; i++)
                {
                    Console.Write("Hóa đơn của người thứ " + (i + 1) + " : " );
                    Console.WriteLine(HoaDon[i].soTienThanhToan + " VNĐ");
                    tien1Ngay = tien1Ngay + HoaDon[i].soTienThanhToan;
                }
                Console.ReadKey();

            // TÍNH DOANH THU TRONG NGÀY
                Console.Write("\nTổng doanh thu trong ngày thứ " + ngayBan +" là : "+ tien1Ngay + " VNĐ");
                ngayMoney.doanhThu = tien1Ngay;// gan doanh thu 1 ngay cho tien tong hoa don vua tim duoc
                TienThang.Add(ngayMoney);// trong list doanh thi ngay add hoa don vao doanh thi 1 ngay vao list doanh thu ngay de den thang thong ke lai
                                         // sau do add hoa don ngay vao list hoa don ngay dos
                                         // het ngay thi add doanh thu hoa doan vao doanh thu ngay
                                         //k++;
                Console.ReadKey();
                //System.Threading.Thread.Sleep(5000);
            }

            ThongKe ThongKe = new ThongKe();

            //TÍNH TỔNG DOANH THU TRONG TUẦN
            Console.WriteLine("\n\nDoanh thu trong tuần của cửa hàng: " + ThongKe.doanhThuThang(TienThang).ToString() +"VNĐ");

            //THỐNG KÊ CÁC LOẠI THỨC UỐNG TRONG THÁNG
            ThongKe.delegateThongkeThucUong Vattu = new ThongKe.delegateThongkeThucUong(ThongKe.thucUongYeuThich);
            Console.WriteLine("Thống kê tuần này bán được: " + ThongKe.thongKeDoUong(Vattu) +"\n");

            // TÍNH SỐ TIỀN LỜI TRONG TUẦN ( tổng doanh thu tuần - tổng tiền nguyên vật liệu)
            QuanLy tienLoitrongtuan = new QuanLy();
            QuanLy.delegateQuanLi LiVatTu = new QuanLy.delegateQuanLi(tienLoitrongtuan.soTienCanNhapHang);
            int deposit = tienLoitrongtuan.VatTu(LiVatTu, ThongKe.doanhThuThang(TienThang));
            
            Console.WriteLine("Số tiền nhập nguyên vật liệu " + tienLoitrongtuan.soTienCanNhapHang() + " VNĐ");// số tiền nhập nguyên vật liệu 

            Console.WriteLine("Số tiền lãi trong tuần: " +deposit +" VNĐ");


            //EVENT GỘP BÀN
            NguoiDung z = new NguoiDung();
            z.evenTinhTien += Z_evenTinhTien;
            Console.WriteLine(z.tinhTienNhieuBan());
            NguoiDung w = new NguoiDung();
            w.evenTinhTien += W_evenTinhTien;
            Console.WriteLine(w.tinhTienNhieuBan());

            Console.ReadKey();
        }

        private static string W_evenTinhTien(params object[] thamso)
        {
            return "Tính tiền 2 bàn";
        }
        private static string Z_evenTinhTien(params object[] thamso)
        {
            return "Tính tiền 1 bàn";
        }
    }
}
