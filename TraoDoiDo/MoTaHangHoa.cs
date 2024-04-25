namespace TraoDoiDo
{
    public class MoTaHangHoa
    {
        private int idSanPham;
        private int idAnhMinhHoa;
        private string linkAnh = "";
        private string moTa = "";

        public MoTaHangHoa() { }
        public MoTaHangHoa(int idSanPham, int idAnhMinhHoa, string linkAnh, string moTa)
        {
            this.idSanPham = idSanPham;
            this.idAnhMinhHoa = idAnhMinhHoa;
            this.linkAnh = linkAnh;
            this.moTa = moTa;

        }

        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int IdAnhMinhHoa { get => idAnhMinhHoa; set => idAnhMinhHoa = value; }
        public string LinkAnh { get => linkAnh; set => linkAnh = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
