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
    
    public partial class MoTaAnhSanPham
    {
        private int idSanPham ;
        private int idAnhMinhHoa;
        private string linkAnhBia = "";
        private string linkAnhMinhHoa = "";
        private string moTa = "";
        public MoTaAnhSanPham() { }
        public MoTaAnhSanPham(int idSanPham, int idAnhMinhHoa, string linkAnhBia, string linkAnhMinhHoa, string moTa)
        {
            this.idSanPham = idSanPham;
            this.idAnhMinhHoa = idAnhMinhHoa;
            this.LinkAnhBia = linkAnhBia;
            this.linkAnhMinhHoa = linkAnhMinhHoa;
            this.moTa = moTa;
        }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int IdAnhMinhHoa { get => idAnhMinhHoa; set => idAnhMinhHoa = value; }
        public string LinkAnhBia { get => linkAnhBia; set => linkAnhBia = value; }
        public string LinkAnhMinhHoa { get => linkAnhMinhHoa; set => linkAnhMinhHoa = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public virtual SanPham SanPham { get; set; }
    }
}
