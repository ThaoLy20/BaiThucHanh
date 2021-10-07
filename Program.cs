using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QuanLyTienLuongProject.BussinessLayer;
using QuanLyTienLuongProject.UseInterFace;
using QuanLyTienLuongProject.DataAccessLayer.Object;

namespace QuanLyTienLuongProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ManHinhChinh();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F1: // Chọn chức năng quản lý phong ban
                    PhongBanUi phongBanUi = new PhongBanUi();
                    phongBanUi.PhongBanMain();

                    break;

                case ConsoleKey.F2: // Chọn chức năng quản lý nhân viên
                    NhanVienUi nhanVienUi = new NhanVienUi();
                    nhanVienUi.NhanVienMain();

                    break;

                case ConsoleKey.F3: // Chọn chức năng quản lý phiếu lương
                    PhieuLuongUi phieuLuongUi = new PhieuLuongUi();
                    phieuLuongUi.PhieuLuongMain();
                    break;

            }

            if (Console.ReadKey().Key == ConsoleKey.F1)
            {
                PhongBanUi phongBanUi = new PhongBanUi();
                phongBanUi.PhongBanMain();
            }
            if (Console.ReadKey().Key == ConsoleKey.F2)
            {
                NhanVienUi nhanVienUi = new NhanVienUi();
                nhanVienUi.NhanVienMain();
            }
            if (Console.ReadKey().Key == ConsoleKey.F3)
            {
                PhieuLuongUi phieuLuongUi = new PhieuLuongUi();
                phieuLuongUi.PhieuLuongMain   ();
            }

            Console.ReadKey();


        }

    }
}

