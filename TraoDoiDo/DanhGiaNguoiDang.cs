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
    
    public partial class DanhGiaNguoiDang
    {
        public int IdNguoiDang { get; set; }
        public int IdNguoiMua { get; set; }
        public string SoSao { get; set; }
        public string NhanXet { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual NguoiDung NguoiDung1 { get; set; }
    }
}