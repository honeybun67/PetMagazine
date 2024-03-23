namespace PetMagazine.Tests
{
    using PetMagazine.Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Services;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using PetMagazine.Common;
    [TestFixture]
    public class CategorySetviceTests
    {

        private List<Category> categoriesList = new List<Category>();
        private IQueryable<Category> dbTable = null;
        private CategoryService service = null;
        private Mock<AppDbContext> mockContext = null;
        private Mock<DbSet<Category>> mockSet = null;

        [SetUp]
        public void Setup()
        {
            // Инициализиране на списъка с жанрове
            categoriesList = new List<Category>();
            for (int i = 1; i <= 5; i++)
            {
                categoriesList.Add(new Category() { Id = i, Name = $"Category {i}", AgeGroup = $"ageGroup {i}", Medal = $"Medal {i}", Achievements = $"Achievements {i}" });
            }

            // Превръщане на списъка в IQueryable
            dbTable = categoriesList.AsQueryable();

            // Подиграване (Mocking) на DbSet<Ganre>
            mockSet = new Mock<DbSet<Category>>();
            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(() => categoriesList.GetEnumerator());

            // Подиграване на метода Add
            mockSet.Setup(m => m.Add(It.IsAny<Category>())).Callback<Category>(category=> categoriesList.Add(category));

            // Инициализиране и настройка на подигравания контекст
            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Categories).Returns(mockSet.Object);

            // Не е нужно да се подиграва методът Any, тъй като LINQ операциите ще работят върху подигравания DbSet

            // Подиграване на SaveChanges
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            // Инициализиране на сервиса с подигравания контекст
            service = new CategoryService(mockContext.Object);
        }

        [Test]
        public void GetCategoriesCountTest()
        {
            // Arrange
            var expected = categoriesList.Count;

            // Act
            var actual = service.GetCategoriesCount();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AddCategoryWithInvalidNameTest()
        {
            // Arrange
            // Act
            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Category() { Name = "", AgeGroup = $"", Medal = $"", Achievements = $"" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.InvalidCategoryName);
        }

        [Test]
        public void AddCategoryWithSameNameTest()
        {
            // Arrange
            // Act
            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Category() { Name = "Category 1", AgeGroup = $"ageGroup 1", Medal = $"Medal 1", Achievements = $"Achievements 1" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.CategoryAlreadyExyst);
        }

        [Test]
        public void GetCategoryByNameTest()
        {
            // Arrange
            var expected = categoriesList[0];

            // Act
            var actual = service.GetCategoryByName("Category 1");

            // Assert
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void GetAllCategoriesTest()
        {
            // Arrange
            var expected = categoriesList.Count;

            // Act
            var actual = service.GetAllCategories();

            // Assert
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void GetCategoriesIdTest()
        {
            // Arrange
            var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var actual = service.GetCategoriesId();

            // Assert
            Assert.That(actual, Is.EquivalentTo(expected)); // За сравнение без подредба
        }
    }
}