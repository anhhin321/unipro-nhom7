using System;

namespace Unipro_Nhom7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap lon de tai so 7");
            Console.WriteLine("Mon: Lap trinh huong doi tuong");
            Console.WriteLine("Giang vien: Nguyen Minh Tuan");
            Console.WriteLine("Nhom: 7");
            Console.WriteLine("Thanh vien: Nguyen Khac Anh(1805HTTA003), Nguyen Hai Linh, Hoang Thi Linh, Pham Thi Phuong Thanh, Nguyen Long Vu");
            Console.WriteLine("========================");
            Console.WriteLine("Menu chuong trinh");
            int n;
            GiangVien GV = new GiangVien();
            CanBo CB = new CanBo();

            do
            {
                Console.WriteLine("1. Nhap thong tin giang vien");
                Console.WriteLine("2. Nhap thong tin giang vien");
                Console.WriteLine("3. Tim kiem thong tin giang vien");
                Console.WriteLine("4. Tim kiem thong tin giang vien");
                Console.WriteLine("5. Xem danh sach giang vien");
                Console.WriteLine("6. Xem danh sach giang vien");
                Console.WriteLine("Nhap lua chon: ");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        GV.nhapTTGiangVien();
                        break;
                    case 2:
                        CB.nhapTTcanbo();
                        break;
                    case 3:
                        GV.TimThongTinGiangVien();
                        break;
                    case 4:
                        CB.TimThongTincanbo();
                        break;
                    case 5:
                        GV.XemDanhSachGV();
                        break;
                    case 6:
                        CB.XemDanhSachCB();
                        break;
                    case 7:
                        GV.XoaDuLieuGV();
                        break;
                    case 8:
                        CB.XoaDuLieuCB();
                        break;
                    default:
                        Console.WriteLine("Lua chon sai");
                        break;
                }
            } while (n != 8);
            Console.ReadKey();
        }
    }
}
