using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMQLBanHang.BUS;
using PMQLBanHang.DTO;
using System;

namespace HOU.UnitTest.BUS
{
    [TestClass]
    public class HoaDonBanHangBUSUnitTest
    {
        HoaDonBanHangBUS bus = new HoaDonBanHangBUS();
        [TestMethod]
        public void addHoaDonBan()
        {
            HoaDonBan hoadon = new HoaDonBan()
            {
                Mahd = 3,
                Manv = 4,
                Ngaylap = new DateTime(2021, 11, 11),
                Tongtien = 400000,
                Trangthai = 1
            };
            var result = bus.addHoaDonBan(hoadon);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void updateHoaDonBan()
        {
            HoaDonBan hoadon = new HoaDonBan()
            {
                Mahd = 1,
                Manv = 4,
                Ngaylap = new DateTime(2021, 11, 11),
                Tongtien = 550000,
                Trangthai = 0
            };
            var result = bus.updateHoaDonBan(hoadon);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void deleteHoaDonBanHang()
        {
            string mahd = "1";
            var result = bus.deleteHoaDonBanHang(mahd);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void getMaloaiFromMaTK()
        {
            int matk = 3;
            var result = bus.getMaloaiFromMaTK(matk);

            Assert.IsNotNull(result);
            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void ThanhToan()
        {
            string text = "1";
            var result = bus.ThanhToan(text);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }
    }
}
