using Endangered_animals.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace Endangered_animalsTests
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
