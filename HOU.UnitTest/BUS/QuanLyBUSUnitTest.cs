using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PMQLBanHang.BUS;
using PMQLBanHang.DTO;

namespace HOU.UnitTest.BUS
{

    [TestClass]
    public class QuanLyBUSUnitTest
    {
        QuanLyBUS bus = new QuanLyBUS();
        [TestMethod]
        public void getUserName()
        {
            var userName = bus.getUserName(3);

            Assert.IsNotNull(userName);
        }
    }
}
