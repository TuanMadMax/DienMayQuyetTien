//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangSanPham
    {
        public int id { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Loai_id { get; set; }
        public int GiaBan { get; set; }
        public int GiaGoc { get; set; }
        public int GiaGop { get; set; }
        public int SoLuongTon { get; set; }
    
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
