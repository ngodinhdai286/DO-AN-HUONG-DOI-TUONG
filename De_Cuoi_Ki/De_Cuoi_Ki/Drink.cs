using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Cuoi_Ki
{
    public abstract class Drink
    {
        protected string name;
        protected string _name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        protected int price;
        protected int _price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        protected string nguyenLieu;
        protected string _nguyenLieu
        {
            get { return this.nguyenLieu; }
            set { this.nguyenLieu = value; }
        }
        protected int giaVatlieu;
        protected int _giaVatlieu
        {
            get { return this.giaVatlieu; }
            set { this.giaVatlieu = value; }
        }

        public static int count = 0;
        public Drink()
        {
            this._name = _name;
            this._price = _price;
            this._nguyenLieu = _nguyenLieu;
            this._giaVatlieu = _giaVatlieu;
            count++;
        }
        public Drink(Drink A)
        {
            A._name = this._name;
            A._price = this._price;
            A._giaVatlieu = this._giaVatlieu;
            A._nguyenLieu = this.nguyenLieu;
            count++;
        }
        public Drink(string ten, int gia, int giaNguyenlieu, string vatLieu)
        {
            this._nguyenLieu = vatLieu;
            this._price = gia;
            this._name = ten;
            this._giaVatlieu = giaNguyenlieu;
            count++;
        }
    }
}
