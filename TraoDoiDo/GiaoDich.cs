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
    
    public partial class GiaoDich
    {
        public int IdGiaoDich { get; set; }
        public int IdNguoiDung { get; set; }
        public string loaiGiaoDich { get; set; }
        public string soTien { get; set; }
        public string tuNguonGiaoDich { get; set; }
        public string denNguonGiaoDich { get; set; }
        public string ngayGiaoDich { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
