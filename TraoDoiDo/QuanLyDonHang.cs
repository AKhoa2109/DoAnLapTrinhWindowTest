//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraoDoiDo
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuanLyDonHang
    {
        private int idDonHang;
        private int idNguoiDang;
        private int idNguoiMua;
        private int idSanPham;
        private string trangThai = "";
        private string lyDo = "";

        string tenSanPham;
        string linkAnhBia;
        string soLuongMua;
        string gia;
        string phiShip;
        string tongTien;

        public QuanLyDonHang() { }
        public QuanLyDonHang(int idDonHang, int idNguoiDang, int idNguoiMua, int idSanPham, string trangThai, string lyDo)
        {
            this.idDonHang = idDonHang;
            this.idNguoiDang = idNguoiDang;
            this.idNguoiMua = idNguoiMua;
            this.idSanPham = idSanPham;
            this.trangThai = trangThai;
            this.lyDo = lyDo;
        }

        public QuanLyDonHang(int idDonHang, int idNguoiDang, int idNguoiMua, int idSanPham, string trangThai, string lyDo, string tenSanPham, string linkAnhBia, string soLuongMua, string gia, string phiShip, string tongTien)
        {
            this.idDonHang = idDonHang;
            this.idNguoiDang = idNguoiDang;
            this.idNguoiMua = idNguoiMua;
            this.idSanPham = idSanPham;
            this.trangThai = trangThai;
            this.lyDo = lyDo;
            this.tenSanPham = tenSanPham;
            this.linkAnhBia = linkAnhBia;
            this.soLuongMua = soLuongMua;
            this.gia = gia;
            this.phiShip = phiShip;
            this.tongTien = tongTien;
        }
        public int IdDonHang { get; set; }
        public Nullable<int> IdNguoiDang { get; set; }
        public Nullable<int> IdNguoiMua { get; set; }
        public Nullable<int> IdSanPham { get; set; }
        public string TrangThai { get; set; }
        public string LyDoTraHang { get; set; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string LinkAnhBia { get => linkAnhBia; set => linkAnhBia = value; }
        public string SoLuongMua { get => soLuongMua; set => soLuongMua = value; }
        public string Gia { get => gia; set => gia = value; }
        public string PhiShip { get => phiShip; set => phiShip = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual NguoiDung NguoiDung1 { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
