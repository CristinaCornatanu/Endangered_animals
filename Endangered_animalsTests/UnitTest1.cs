using Endangered_animals.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;
using Moq;
using System;
using Endangered_animals.Interface;
using Endangered_animals;
using Endangered_animals.Data;
using System.Data.Entity;

namespace Endangered_animalsTests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
       
        public void Test_ConvertImageToByteArray()
        {
            Image testImage = Image.FromFile("C:\\Users\\corna\\Downloads\\Danaus_plexippus_MHNT.jpg");

            byte[] result = ImageConverterHelper.ConvertImageToByteArray(testImage);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public void Test_ConvertByteArrayToImage()
        {

            byte[] testByteArray = File.ReadAllBytes("C:\\Users\\corna\\Downloads\\Danaus_plexippus_MHNT.jpg");

            Image result = ImageConverterHelper.ConvertByteArrayToImage(testByteArray);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Image));
            Assert.IsTrue(result.Width > 0 && result.Height > 0);
        }

        [TestMethod]
        public void Test_NotifyAll()
        {
            var subject = new Subject();
            var mockObserver = new Mock<IObserver>();
            subject.Attach(mockObserver.Object);
            subject.NotifyAll(subject, EventArgs.Empty);
            mockObserver.Verify(o => o.OnDataChanged(subject, EventArgs.Empty), Times.Once);
        }

        [TestMethod]
        public void Test_Add_Animal()
        {
            var mockSet = new Mock<DbSet<Animal>>();
            var mockContext = new Mock<endangered_animalsDbContext>();

            mockContext.Setup(c => c.Set<Animal>()).Returns(mockSet.Object);

            var repo = new AnimalRepository(mockContext.Object);
            var newAnimal = new Animal
            {
                Id = 1,
                IdSpecie = 2,
                IdTipAlimentatie = 3,
                Type = "Leu",
                Descriere = "Mamifer",
                Imagine = new byte[] { 0x01, 0x02, 0x03 }
            };

            repo.Add(newAnimal);

            mockSet.Verify(m => m.Add(It.IsAny<Animal>()), Times.Once);
        }

        [TestMethod]
        public void Test_GetById_Animal()
        {
            var mockSet = new Mock<DbSet<Animal>>();
            var mockContext = new Mock<endangered_animalsDbContext>();

            var expectedAnimal = new Animal { Id = 1, Type = "Leu", Descriere = "Mamifer" };

            mockSet.Setup(m => m.Find(1)).Returns(expectedAnimal);
            mockContext.Setup(c => c.Set<Animal>()).Returns(mockSet.Object);

            var repo = new AnimalRepository(mockContext.Object);
            var retrievedAnimal = repo.GetById(1);

            Assert.IsNotNull(retrievedAnimal);
            Assert.AreEqual(expectedAnimal.Type, retrievedAnimal.Type);
        }

       [TestMethod]
        public void Test_Delete_Animal()
        {
            var mockSet = new Mock<DbSet<Animal>>();
            var mockContext = new Mock<endangered_animalsDbContext>();

            var animal = new Animal { Id = 3, Type = "Sarpe", Descriere = "Reptila" };

            mockSet.Setup(m => m.Find(3)).Returns(animal);
            mockContext.Setup(c => c.Set<Animal>()).Returns(mockSet.Object);

            var repo = new AnimalRepository(mockContext.Object);
            repo.Delete(3);

            mockSet.Verify(m => m.Remove(It.IsAny<Animal>()), Times.Once);
            mockContext.Verify(c => c.SaveChanges(), Times.Once);
        }

    }
}
