using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    public class Sanpham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public Sanpham()
        {

        }
        public Sanpham(string MaSanPham, string TenSanPham, int DonGIa, int SoLuong)
        {
            this.MaSanPham = MaSanPham;
            this.TenSanPham = TenSanPham;
            this.DonGia = DonGIa;
            this.SoLuong = SoLuong;
        }
        public int TinhTien()
        {
            return this.DonGia * this.SoLuong;
        }
        public void Information()
        {
            Console.WriteLine("Ma san pham: {0}", this.MaSanPham);
            Console.WriteLine("Ten san pham: {0}", this.TenSanPham);
            Console.WriteLine("Don gia: {0}", this.DonGia);
            Console.WriteLine("So luong: {0}", this.SoLuong);
            Console.WriteLine("Thanh tien: {0}", TinhTien());
        }
    }
}
