using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PMQLBanHang.BUS;
using PMQLBanHang.DTO;

namespace HOU.UnitTest.BUS
{
    [TestClass]
    public class ChiTietHoaDonBanBUSUnitTest
    {
        ChiTietHoaDonBanBUS bus = new ChiTietHoaDonBanBUS();

        [TestMethod]
        public void addSanPhamOrUpdateQuality()
        {
            ChiTietHoaDonBan chitiet = new ChiTietHoaDonBan()
            {
                Mahd = 1,
                Masp = 3,
                Soluongmua = 2
            };
            int result = bus.addSanPhamOrUpdateQuality(chitiet);

            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void updateSanPhamInChiTietHoaDon()
        {
            ChiTietHoaDonBan chitiet = new ChiTietHoaDonBan()
            {
                Mahd = 2,
                Masp = 6,
                Soluongmua = 2
            };
            int result = bus.updateSanPhamInChiTietHoaDon(chitiet);

            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void deleteSanPhamInChiTietHoaDon()
        {
            int mahd = 2;
            int masp = 4;
            int tongtien = 30000;
            int result = bus.deleteSanPhamInChiTietHoaDon(mahd, masp, tongtien);

            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void getTongTienHD()
        {
            int maHD = 2;
            int result = bus.getTongTienHD(maHD);

            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }
    }
}
