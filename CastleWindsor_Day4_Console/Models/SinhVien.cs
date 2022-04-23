﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor_Day4_Console.Models
{
    public class SinhVien
    {
        //thuộc tính của sinh viên
        #region Thuộc tính
        private string _maSinhVien;
        private string _tenSinhVien;
        private string _gioiTinh;
        private DateTime _ngayThangNamSinh;
        private string _lop;
        private string _khoa;

        #endregion

        //property
        #region property
        public string MaSinhVien { get => _maSinhVien; set => _maSinhVien = value; }
        public string TenSinhVien { get => _tenSinhVien; set => _tenSinhVien = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public DateTime NgayThangNamSinh { get => _ngayThangNamSinh; set => _ngayThangNamSinh = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public string Khoa { get => _khoa; set => _khoa = value; }

        #endregion

        //constructor khởi tạo dữ liệu thông tin SV
        #region Constructor
        //khởi tạo mặc định
        public SinhVien()
        {
            _maSinhVien = string.Empty;
            _tenSinhVien = string.Empty;
            _gioiTinh = string.Empty;
            _ngayThangNamSinh = DateTime.Now.Date;
            _lop = string.Empty;
            _khoa = string.Empty;
        }
        //khởi tạo thông qua tham số
        public SinhVien(string maSV, string tenSV, bool gioiTinh, DateTime ngayThangNamSinh, string Lop, string Khoa)
        {
            MaSinhVien = maSV;
            TenSinhVien = tenSV;
            if (gioiTinh)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
            NgayThangNamSinh = ngayThangNamSinh;
            this.Lop = Lop;
            this.Khoa = Khoa;
        }
        //sao chép từ SV khác
        public SinhVien(SinhVien svOther)
        {
            MaSinhVien = svOther.MaSinhVien;
            TenSinhVien = svOther.TenSinhVien;
            GioiTinh = svOther.GioiTinh;
            NgayThangNamSinh = svOther.NgayThangNamSinh;
            Lop = svOther.Lop;
            Khoa = svOther.Khoa;
        }
        #endregion

        //phương thức của sinh viên
        #region Phương thức

        //xuất thông tin môn học chi tiết tất cả điểm của môn học
        public void XuatThongTinMonHocDangKi(string maMon, string tenMon, int soTiet, string loaiMon, float diemQT, float diemTP, float tongDiem)
        {
            Console.WriteLine(string.Format("{0,-11} {1,-24} {2,-10} {3,-11} {4,-8:0.0} {5,-8:0.0} {6,-8:0.0}", maMon, tenMon, soTiet, loaiMon, diemQT, diemTP, tongDiem));
        }

        //xuất ra màn hình thông tin sinh viên
        public void XuatThongTinSinhVien()
        {
            string output = string.Format("{0,-12} {1,-25} {2,-8} {3,-12} {4,-14} {5,-20}", _maSinhVien, _tenSinhVien, _gioiTinh, _ngayThangNamSinh.Date.ToString("dd/MM/yyyy"), _lop, _khoa);
            Console.WriteLine(output);
        }

        //xuất ra màn hình thông tin sinh viên - rớt hay đậu
        public void XemThongTinSinhVienDauRot(string ketQua)
        {
            Console.Write(string.Format("{0,-12} {1,-24} {2,-10} {3,-12} {4,-14} {5,-10}", _maSinhVien, _tenSinhVien, _gioiTinh, _ngayThangNamSinh.Date.ToString("dd/MM/yyyy"), _lop, _khoa));
            if (string.Compare(ketQua, "Trượt") != 0)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  " +ketQua + "\n");
            Console.ResetColor();
        }

        //Kiểm tra sinh viên trượt hay đậu dựa trên tổng điểm học lực >= 4
        public string KiemTraSVTruotHayDau(float tongDiem)
        {
            if (tongDiem < 4)
                return "Trượt";
            else
                return " Đậu";
        }
        #endregion
    }
}
