using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{

    public class Beer : Drink
    {
        public static int countBeer = 0;
        public int beerCount = 0;
        public Beer()
        {
            this._name = "Beer";
            this._price = 25000;
            this._nguyenLieu = "Thung beer";
            this._giaVatlieu = 2000000;
            this.beerCount++;
            countBeer++;
        }
        public Beer(Beer b)
        {
            b._name = this._name;
            b._price = this._price;
            b.nguyenLieu = this._nguyenLieu;
            b.giaVatlieu = this.giaVatlieu;
            countBeer++;
            this.beerCount++;
        }
        public Beer(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countBeer++;
            this.beerCount++;
        }
    }
}
