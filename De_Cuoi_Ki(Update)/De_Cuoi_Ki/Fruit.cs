using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class Fruit : Drink
    {
        public static int countFruit = 0;
        public int count4 = 0;
        public Fruit()
        {
            this._name = "Fruit";
            this._price = 20000;
            this._nguyenLieu = "Các loại hương liệu tạo Nước trái cây";
            this._giaVatlieu = 2000000;
            this.count4++;
            countFruit++;
        }
        public Fruit(Fruit f)
        {
            f._name = this._name;
            f._price = this._price;
            f.nguyenLieu = this._nguyenLieu;
            f.giaVatlieu = this.giaVatlieu;
            countFruit++;
            this.count4++;
        }
        public Fruit(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countFruit++;
            this.count4++;
        }
    }
}
