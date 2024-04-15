using Endangered_animals;
using Endangered_animals.Presentation;
using Endangered_animals.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Drawing;
using System.IO;

namespace UnitTestProject1
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvertImageToByteArray_Success()
        {
            Image testImage = Image.FromFile("C:\\Users\\corna\\Downloads\\Danaus_plexippus_MHNT.jpg");

            byte[] result = ImageConverterHelper.ConvertImageToByteArray(testImage);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public void TestConvertByteArrayToImage()
        {

            byte[] testByteArray = File.ReadAllBytes("C:\\Users\\corna\\Downloads\\Danaus_plexippus_MHNT.jpg");

            Image result = ImageConverterHelper.ConvertByteArrayToImage(testByteArray);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Image));
            Assert.IsTrue(result.Width > 0 && result.Height > 0);
        }

      
    }
}
