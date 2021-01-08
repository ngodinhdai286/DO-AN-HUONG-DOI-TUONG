using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public class RuouVang : Drink
    {
        public static int countRuou = 0;
        public int ruouVangcount = 0;

        public RuouVang()
        {
            this._name = "Beer";
            this._price = 100000;
            this._nguyenLieu = "Các chai Ruou Vang được ủ";
            this._giaVatlieu = 10000000;
            this.ruouVangcount++;
            countRuou++;
        }
        public RuouVang(RuouVang r)
        {
            r._name = this._name;
            r._price = this._price;
            r.nguyenLieu = this._nguyenLieu;
            r.giaVatlieu = this.giaVatlieu;
            countRuou++;
            this.ruouVangcount++;
        }
        public RuouVang(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countRuou++;
            this.ruouVangcount++;
        }
    }
}
