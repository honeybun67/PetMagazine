//namespace PetMagazine.Tests
//{
//    using Microsoft.EntityFrameworkCore;
//    using Moq;
//    using PetMagazine.Common;
//    using PetMagazine.Data;
//    using PetMagazine.Data.Models;
//    using PetMagazine.Services;
//    [TestFixture]
//    public class PetServiceTest
//    {
//        private List<Pet> petsList = new List<Pet>();
//        private IQueryable<Pet> dbTable = null;
//        private PetService service = null;
//        private Mock<AppDbContext> mockContext = null;
//        private Mock<DbSet<Pet>> mockSet = null;

//        [SetUp]
//        public void Setup()
//        {
//            // Инициализиране на списъка с жанрове
//            petsList = new List<Pet>();
//            for (int i = 1; i <= 5; i++)
//            {
//                petsList.Add(new Pet() { Name = $"Pet {i} ", Age = i, Breed = $"breed {i} ", Owner = $"owner {i} ", KindOfPet = $"kind {i}" });
//            }

//            // Превръщане на списъка в IQueryable
//            dbTable = petsList.AsQueryable();

//            // Подиграване (Mocking) на DbSet<Ganre>
//            mockSet = new Mock<DbSet<Pet>>();
//            mockSet.As<IQueryable<Pet>>().Setup(m => m.Provider).Returns(dbTable.Provider);
//            mockSet.As<IQueryable<Pet>>().Setup(m => m.Expression).Returns(dbTable.Expression);
//            mockSet.As<IQueryable<Pet>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
//            mockSet.As<IQueryable<Pet>>().Setup(m => m.GetEnumerator()).Returns(() => petsList.GetEnumerator());

//            // Подиграване на метода Add
//            mockSet.Setup(m => m.Add(It.IsAny<Pet>())).Callback<Pet>(pet => petsList.Add(pet));

//            // Инициализиране и настройка на подигравания контекст
//            mockContext = new Mock<AppDbContext>();
//            mockContext.Setup(p => p.Pets).Returns(mockSet.Object);

//            // Не е нужно да се подиграва методът Any, тъй като LINQ операциите ще работят върху подигравания DbSet

//            // Подиграване на SaveChanges
//            mockContext.Setup(m => m.SaveChanges()).Returns(1);

//            // Инициализиране на сервиса с подигравания контекст
//            service = new PetService(mockContext.Object);
//        }



//        [Test]
//        public void GetPeysCountTest()
//        {
//            // Arrange
//            var expected = petsList.Count;

//            // Act
//            var actual = service.GetPetsCount();

//            // Assert
//            Assert.That(actual, Is.EqualTo(expected));
//        }

//        [Test]
//        public void AddPetWithInvalidNameTest()
//        {
//            // Arrange
//            // Act


//            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Pet() { Name = $"Pet 1 ", Age = 1, Breed = $"breed 1 ", Owner = $"owner 1 ", KindOfPet = $"kind 1" }));

//            // Assert
//            Assert.AreEqual(ex.Message, ExceptionMessages.InvalidPetName);
//        }

//        [Test]
//        public void AddPetWithSameNameTest()
//        {
//            // Arrange
//            // Act


//            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Pet() { Name = "Pet 1" }));

//            // Assert
//            Assert.AreEqual(ex.Message, ExceptionMessages.PetAlreadyExist);
//        }

//        [Test]
//        public void GetPetByNameTest()
//        {
//            // Arrange
//            var expected = petsList[0];

//            // Act
//            var actual = service.GetPetByName("Pet 1");

//            // Assert
//            Assert.That(actual.Name, Is.EqualTo(expected.Name));
//        }

//        [Test]
//        public void GetAllPetTest()
//        {
//            // Arrange
//            var expected = petsList.Count;

//            // Act
//            var actual = service.GetAllPets();

//            // Assert
//            Assert.That(actual.Count, Is.EqualTo(expected));
//        }

//        [Test]
//        public void GetPetsIdTest()
//        {
//            // Arrange
//            var expected = new int[] { 1, 2, 3, 4, 5 };

//            // Act
//            var actual = service.GetPetsId();

//            // Assert
//            Assert.That(actual, Is.EquivalentTo(expected)); // За сравнение без подредба
//        }

//    }
//}
