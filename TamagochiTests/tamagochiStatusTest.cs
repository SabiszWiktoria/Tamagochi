
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Tamagochi;

namespace TamagochiTests
{
    class tamagochiStatusTest
    {
        [Test]
        public void Test_TamagochiStatus_ResturnStatus_Death_By_Hunger()
        {
            var tamagochi = new TamagochiStatus(10,10,10);
            Assert.AreEqual("Twoj tamagochci zmarl z glodu", tamagochi.ReturnStatus());
        }
        [Test]
        public void Test_TamagochiStatus_ResturnStatus_Death_By_Exhaustion()
        {
            var tamagochi = new TamagochiStatus(0, 10, 10);
            Assert.AreEqual("Twoj tamagochci zmarl z wycienczenia", tamagochi.ReturnStatus());
        }
        [Test]
        public void Test_TamagochiStatus_ResturnStatus_All_Is_good()
        {
            var tamagochi = new TamagochiStatus(6, 6, 6);
            Assert.AreEqual("energy 6, hunger 6, happiness 6 ", tamagochi.ReturnStatus());
        }
    }
}
