using System;
using System.Collections.Generic;
using System.Text;

namespace Unipro_Nhom7
{
    class CanBo
    {
        // khai bao cau truc struct de luu thong tin cua giang vien
        struct Manager
        {
            public string MaCB;
            public string TenGV;
            public string gioitinh;
            public string quequan;
            public string chuyennganh;
            public string trinhdo;
            public string phong;
        }

        // dinh nghia cac bien can su dung
        public bool check;
        public int stt;
        // dinh nghia 1 list theo cau truc struct
        List<Manager> canbo = new List<Manager>();

        // kiem tra du lieu giang vien nhap vao co trung voi du lieu co trong list khong
        // neu trung thi bien check --> false, khi do nguoi dung khong them dc can bo nay
        private void kiemTracanbo(string _ma, string _ten)
        {
            check = true;
            for (int i = 0; i < canbo.Count; i++)
            {
                if (canbo[i].MaCB == _ma || canbo[i].TenGV == _ten)
                {
                    check = false;
                    stt = i;
                }
            }
        }
        // nhap thong tin can bo

        public void nhapTTcanbo()
        {
            Console.WriteLine("So thu tu can bo trong danh sach: " + canbo.Count);
            Console.WriteLine("Nhap ma can bo: ");
            string _ma = Console.ReadLine();
            Console.WriteLine("Nhap ho ten can bo: ");
            string _ten = Console.ReadLine();
            // goi ham kiemTracanbo de kiem tra du lieu ng dung nhap vao theo macb,tencb
            // neu co du lieu ve can bo theo keyword _ma, _ten truyen vao thi bien check ---> false, dung viec nhap du lieu va hien thi thong bao
            // neu khong co du lieu bien check van bang true, chuong trinh tiep tuc chay
            kiemTracanbo(_ma, _ten);
            if (check)
            {
                Console.WriteLine("Nhap gioi tinh: ");
                string _gt = Console.ReadLine();
                Console.WriteLine("Nhap que quan: ");
                string _qq = Console.ReadLine();
                Console.WriteLine("Nhap chuyen nganh: ");
                string _cn = Console.ReadLine();
                Console.WriteLine("Nhap trinh do: ");
                string _td = Console.ReadLine();
                Console.WriteLine("Nhap phong ban: ");
                string _mon = Console.ReadLine();
                // luu du lieu can bo vao list
                int stt = canbo.Count;
                Manager themmoi = new Manager();
                themmoi.MaCB = _ma;
                themmoi.TenGV = _ten;
                themmoi.gioitinh = _gt;
                themmoi.quequan = _qq;
                themmoi.chuyennganh = _cn;
                themmoi.trinhdo = _td;
                themmoi.phong = _mon;
                canbo.Add(themmoi);
                Console.WriteLine("Da them can bo vao danh sach");
            }
            else
            {
                Console.WriteLine("can bo nay da co trong danh sach");
            }
        }
        public void TimThongTincanbo()
        {
            Console.WriteLine("Nhap ma can bo: ");
            string _ma = Console.ReadLine();
            kiemTracanbo(_ma, "");
            if (check)
            {
                Console.WriteLine("Khong co du lieu can bo theo ma {0}", _ma);
            }
            else
            {
                Console.WriteLine("Ho ten can bo: " + canbo[stt].TenGV);
                Console.WriteLine("Gioi tinh: " + canbo[stt].gioitinh);
                Console.WriteLine("Que quan: " + canbo[stt].quequan);
                Console.WriteLine("Trinh do: " + canbo[stt].trinhdo);
                Console.WriteLine("Phong chuc nang: " + canbo[stt].phong);
            }
        }
        public void XemDanhSachCB()
        {
            for (int j = 0; j < canbo.Count; j++)
            {
                Console.WriteLine("STT can bo: {0}, ma can bo: {1}", j + 1, canbo[j].MaCB);
                Console.WriteLine("Ho ten can bo: " + canbo[j].TenGV);
                Console.WriteLine("Phong chuc nang: " + canbo[j].phong);
                Console.WriteLine("=====================================");
            }
        }
        public void XoaDuLieuCB()
        {
            Console.WriteLine("Nhap ma can bo: ");
            string _ma = Console.ReadLine();
            kiemTracanbo(_ma, "");
            if (check)
            {
                Console.WriteLine("Khong co du lieu can bo theo ma {0}", _ma);
            }
            else
            {
                canbo.RemoveAt(stt);
                Console.WriteLine("Da xoa du lieu can bo co ma {0}", _ma);
            }
        }
    }
}
