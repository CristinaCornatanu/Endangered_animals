using Endangered_animals.Presentation;
using Endangered_animals.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestConvertImageToByteArray()
        {
            Image testImage = Image.FromFile("C:\\Users\\corna\\source\\repos\\Endangered_animals\\Endangered_animals\\Resources\\natural-setting-sun-background-powerpoint-nature-26.jpg"); 
            
            byte[] result = ImageConverterHelper.ConvertImageToByteArray(testImage);
           
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }
    

        [TestMethod]
        public void TestConvertByteArrayToImage()
        {
        
            byte[] testByteArray = File.ReadAllBytes("C:\\Users\\corna\\source\\repos\\Endangered_animals\\Endangered_animals\\Resources\\natural-setting-sun-background-powerpoint-nature-26.jpg"); 
            
            Image result = ImageConverterHelper.ConvertByteArrayToImage(testByteArray);
            
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Image));
            Assert.IsTrue(result.Width > 0 && result.Height > 0);
        }

        [TestMethod]
        public void TestDeleteAnimal_Success()
        {
            int testAnimalId = 1; 
            var mockRepository = new Mock<AnimalRepository>(); 
            var form = new Animals(); 

            form.DeleteAnimal(testAnimalId);

            mockRepository.Verify(repo => repo.Delete(testAnimalId), Times.Once);
        }
    }
}
