﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TraoDoiDoEntities : DbContext
    {
        public TraoDoiDoEntities()
            : base("name=TraoDoiDoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanhGiaNguoiDang> DanhGiaNguoiDangs { get; set; }
        public virtual DbSet<DanhMucYeuThich> DanhMucYeuThiches { get; set; }
        public virtual DbSet<GiaoDich> GiaoDiches { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<MoTaAnhSanPham> MoTaAnhSanPhams { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<QuanLyDonHang> QuanLyDonHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }
    }
}
