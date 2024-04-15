using Endangered_animals.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace UnitTestProject
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Image testImage = Image.FromFile("C:\\Users\\corna\\Downloads\\Danaus_plexippus_MHNT.jpg");

            byte[] result = ImageConverterHelper.ConvertImageToByteArray(testImage);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }
    }
}
