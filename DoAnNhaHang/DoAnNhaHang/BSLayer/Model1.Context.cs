﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNhaHang.BSLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NhaHangEntities : DbContext
    {
        public NhaHangEntities()
            : base("name=NhaHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<CHAMCONG> CHAMCONGs { get; set; }
        public virtual DbSet<CHITIETPHIEU> CHITIETPHIEUx { get; set; }
        public virtual DbSet<CONGTHUC> CONGTHUCs { get; set; }
        public virtual DbSet<KHUVUC> KHUVUCs { get; set; }
        public virtual DbSet<LOAIMON> LOAIMONs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEU> PHIEUx { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THUCDON> THUCDONs { get; set; }
    }
}