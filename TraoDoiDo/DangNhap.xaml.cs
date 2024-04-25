using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using TraoDoiDo.ViewModels;

namespace TraoDoiDo
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        TraoDoiDoEntities db = new TraoDoiDoEntities();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {

            TaiKhoan account = new TaiKhoan(0, txtTenDangNhap.Text, txtMatKhau.Password.ToString());

            int? idNguoiDung = (from nguoiDung in db.NguoiDungs
                                join taiKhoan in db.TaiKhoans on nguoiDung.IdNguoiDung equals
                               taiKhoan.IdNguoiDung
                                where taiKhoan.TenDangNhap == account.TenDangNhap && taiKhoan.MatKhau == account.MatKhau
                                select nguoiDung.IdNguoiDung).FirstOrDefault();
            NguoiDung nguoi = db.NguoiDungs.Find(idNguoiDung);
            if (nguoi == null)
            {
                MessageBox.Show("Tài khoản sai! Vui lòng đăng nhập lại");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                MainWindow fMainwindow = new MainWindow(nguoi);
                fMainwindow.Show();
                this.Hide();
            }
        }

        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
        }

        private void btnQuenMatKhau_Click(object sender, RoutedEventArgs e)
        {

        }
        private void txtQuenMatKhau_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            QuenMatKhau quenMK = new QuenMatKhau();
            quenMK.Show();
        }
    }
}
