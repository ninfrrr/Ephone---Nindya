using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ephone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone.Tests
{
    [TestClass()]
    public class formatOrderTests
    {
        [TestMethod()]
        public void testhitungTest()
        {
            int expected = 20999998;
            int actual = Ephone.formatOrder.testhitung(2);
            Assert.AreEqual(expected, actual);
        }
    }
}