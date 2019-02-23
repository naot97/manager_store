using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Hang
    {
        public string ten { get; set; }
        public string loai{ get; set; }
        public string maHang{ get; set; }
        public string sourceAnh { get; set; }
        public string   id{ get; set; }
        public int soLuong { get; set; }
        public double donGia { get; set; }
    }
    public class Account
    {
        public string tenDN, matKhau, id;
    }
    public class NhanVien : Account
    {
        public string maNV { get; set; }
        public int namSinh { get; set; }
        public string hoTen { get; set; }
        public string soDT { get; set; }
        public double donViLuong;
        public int ngayDiLam;
    }
    public class Manager : Account
    {
        static public List<NhanVien> listNV = new List<NhanVien>();
        static public List<Hang> listHang = new List<Hang>();
    }
}
