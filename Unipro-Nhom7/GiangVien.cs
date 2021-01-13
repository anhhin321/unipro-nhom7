using System;
using System.Collections.Generic;
using System.Text;

namespace Unipro_Nhom7
{
    class GiangVien
    {
       // khai bao cau truc struct de luu thong tin cua giang vien
        struct Teacher
        {
            public string MaGV;
            public string TenGV;
            public string gioitinh;
            public string quequan;
            public string chuyennganh;
            public string trinhdo;
            public string khoa;
            public string mon;
        }

        // dinh nghia cac bien can su dung
        public bool check;
        public int stt;
        // dinh nghia 1 list theo cau truc struct
        List<Teacher> giangvien = new List<Teacher>();
        
        // kiem tra du lieu giang vien nhap vao co trung voi du lieu co trong list khong
        // neu trung thi bien check --> false, khi do nguoi dung khong them dc giang vien nay
        private void kiemTraGiangVien(string _ma, string _ten)
        {
            check = true;
            for(int i = 0; i < giangvien.Count; i++)
            {    
                if(giangvien[i].MaGV == _ma || giangvien[i].TenGV == _ten)
                {
                    check = false;
                    stt = i;
                }
            }
        }
        // nhap thong tin giang vien
        
        public void nhapTTGiangVien()
        {
            Console.WriteLine("So thu tu giang vien trong danh sach: " + giangvien.Count+1);
            Console.WriteLine("Nhap ma giang vien: ");
            string _ma = Console.ReadLine();
            Console.WriteLine("Nhap ho ten giang vien: ");
            string _ten = Console.ReadLine();
            // goi ham kiemTraGiangVien de kiem tra du lieu ng dung nhap vao theo magv, tengv
            // neu co du lieu ve giang vien theo keyword _ma, _ten truyen vao thi bien check ---> false, dung viec nhap du lieu va hien thi thong bao
            // neu khong co du lieu bien check van bang true, chuong trinh tiep tuc chay
            kiemTraGiangVien(_ma, _ten);
            if (check)
            {
                Console.WriteLine("Nhap gioi tinh: ");
                string _gt = Console.ReadLine();
                Console.WriteLine("Nhap que quan: ");
                string _qq = Console.ReadLine();
                Console.WriteLine("Nhap chuyen nganh: ");
                string _cn = Console.ReadLine();
                Console.WriteLine("Nhap khoa cong tac: ");
                string khoa = Console.ReadLine();
                Console.WriteLine("Nhap trinh do: ");
                string _td = Console.ReadLine();
                Console.WriteLine("Nhap mon giang day: ");
                string _mon = Console.ReadLine();
                // luu du lieu giang vien vao list
                int stt = giangvien.Count;
                Teacher themmoi = new Teacher();
                themmoi.MaGV = _ma;
                themmoi.TenGV = _ten;
                themmoi.gioitinh = _gt;
                themmoi.quequan = _qq;
                themmoi.chuyennganh = _cn;
                themmoi.khoa = khoa;
                themmoi.trinhdo = _td;
                themmoi.mon = _mon;
                giangvien.Add(themmoi);
                Console.WriteLine("Da them giang vien vao danh sach");
            }
            else
            {
                Console.WriteLine("giang vien nay da co trong danh sach");
            }
        }
        public void TimThongTinGiangVien()
        {
            Console.WriteLine("Nhap ma giang vien: ");
            string _ma = Console.ReadLine();
            kiemTraGiangVien(_ma, "");
            if (check)
            {
                Console.WriteLine("Khong co du lieu giang vien theo ma {0}", _ma);
            }
            else
            {
                Console.WriteLine("Ho ten giang vien: "+giangvien[stt].TenGV);
                Console.WriteLine("Gioi tinh: "+giangvien[stt].gioitinh);
                Console.WriteLine("Que quan: "+giangvien[stt].quequan);
                Console.WriteLine("Khoa cong tac: " + giangvien[stt].khoa);
                Console.WriteLine("Trinh do: " + giangvien[stt].trinhdo);
                Console.WriteLine("Mon giang day: " + giangvien[stt].mon);
            }
        }
        public void XemDanhSachGV()
        {
            for(int j = 0; j < giangvien.Count; j++)
            {
                Console.WriteLine("STT giang vien: {0}, ma giang vien: {1}", j + 1, giangvien[j].MaGV);
                Console.WriteLine("Ho ten giang vien: " + giangvien[j].TenGV);
                Console.WriteLine("Khoa cong tac: " + giangvien[j].khoa);
                Console.WriteLine("=====================================");
            }
        }
        public void XoaDuLieuGV()
        {
            Console.WriteLine("Nhap ma giang vien: ");
            string _ma = Console.ReadLine();
            kiemTraGiangVien(_ma, "");
            if (check)
            {
                Console.WriteLine("Khong co du lieu giang vien theo ma {0}", _ma);
            }
            else
            {
                giangvien.RemoveAt(stt);
                Console.WriteLine("Da xoa du lieu giang vien co ma {0}", _ma);
            }
        }
    }
}
