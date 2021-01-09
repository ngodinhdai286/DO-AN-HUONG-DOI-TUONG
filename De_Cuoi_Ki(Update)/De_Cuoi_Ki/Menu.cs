using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class Menu
    {
        List<Drink> Drinking = new List<Drink>();//Quản lí danh sách các loại thức uống
                                                 // hàm xuất hóa đơn bao gồm tham số đầu vào là số tiền của khách đâu ra là số tiền trả lại cho khách , tên dồ uống giá tiền, vat
        public string hienThiMenu()
        {
            return
            ("          CHÀO MỪNG BẠN ĐẾN VỚI CỬA HÀNG CỦA CHÚNG TÔI!") + "\n" +
            ("---------------------MỜI BẠN CHỌN THỨC UỐNG---------------------") + "\n" +
            ("         Đồ uống                                 Giá(VNĐ)      ") + "\n" +
            ("         1.Coffee---------------------------------18000             ") + "\n" +
            ("         2.Beer-----------------------------------25000            ") + "\n" +
            ("         3.Rượu vang------------------------------100000          ") + "\n" +
            ("         4.Nước ép--------------------------------20000            ") + "\n" +
            ("         5.Không chọn nữa                                                       ") + "\n" +
            ("----------------------------------------------------------------");

        }
        public string hienThiHoaDon(int countCoffee, int countBeer, int countRuou, int countFruit)
        {
            return
            ("HÓA ĐƠN CỦA QUÝ KHÁCH BAO GỒM ") + "\n" +
            ("Thức uống          Số lượng         Thành tiền") + "\n" +
            ("1.Coffee             " + countCoffee + "                " + countCoffee * 18000) + "\n" +
            ("2.Bia                " + countBeer + "                " + countBeer * 25000) + "\n" +
            ("3.Rượu vang          " + countRuou + "                " + countRuou * 100000) + "\n" +
            ("4.Nước ép            " + countFruit + "                " + countFruit * 20000) + "\n" +
            ("TỔNG SỐ TIỀN BẠN CẦN THANH TOÁN: " + (countCoffee * 18000 + countFruit * 20000 + countBeer * 25000 + countRuou * 100000)) + "\n" +
            ("Thuế VAT: 0VND") + "\n";
        }
    }
}
