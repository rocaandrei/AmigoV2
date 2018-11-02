using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoV2.Tests
{
    [TestClass()]
    public class ObjectSourceTests
    {
        [TestMethod()]
        public void AddWorkdaysTest()
        {
            var _engieers = new ObjectSource();
            List<Engineer> ENG = _engieers.AddShifts();

            Assert.Fail();
        }
    }
}