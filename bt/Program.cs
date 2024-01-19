using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so san pham: ");
            int n = int.Parse(Console.ReadLine());
            ArrayList sp=new ArrayList();
            Sanpham[] sparray = new Sanpham[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ma SP: ");
                string MaSP= Console.ReadLine();
                Console.WriteLine("Nhap ten SP: ");
                string TenSP = Console.ReadLine();
                Console.WriteLine("Nhap gia SP:");
                int GiaSP = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong: ");
                int SLSP= int.Parse(Console.ReadLine());
                Sanpham sanpham = new Sanpham(MaSP,TenSP,GiaSP,SLSP);
                sparray[i] = sanpham;
                sp.Add(sanpham);
            }
            foreach (Sanpham item in sp)
            {
                item.Information();
            }
            for (int i = 0;i < n;i++)
                sparray[i].Information();

            Console.ReadKey();
        }
    }
}
