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
            for (int i = 1; i < 6; i++)
            {
                categoriesList.Add(new Category() { Id = i, Name = $"Category {i}", AgeGroup = $"ageGroup {i}", Medal = $"Medal {i}", Achievements = $"Achievements {i}" });
            }

            dbTable = categoriesList.AsQueryable();

            mockSet = new Mock<DbSet<Category>>();

            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(dbTable.GetEnumerator());
            mockSet.Setup(d => d.Add(It.IsAny<Category>())).Callback<Category>((category) =>
            {
                categoriesList.Add(category);
            }).Returns((Category category) =>
            {
                return (EntityEntry<Category>)null;
            }).Verifiable();



            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Categories).Returns(mockSet.Object);
            mockContext.Setup(m => m.SaveChanges()).Verifiable();

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
        public void AddGanreWithInvalidNameTest()
        {
            // Arrange
            // Act

            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Category() { Name = "" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.InvalidCategoryName);
        }
        [Test]
        public void AddGanreWithSameNameTest()
        {
            // Arrange
            // Act


            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Category() { Name = "Ganre 1", AgeGroup = $"ageGroup 1", Medal = $"Medal 1", Achievements = $"Achievements 1" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.CategoryAlreadyExyst);
        }
        [Test]
        public void GetGanreByNameTest()
        {
            // Arrange
            var expected = categoriesList[0];

            // Act
            var actual = service.GetCategoryByName("Ganre 1");

            // Assert
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void GetAllGanreTest()
        {
            // Arrange
            var expected = categoriesList.Count;

            // Act
            var actual = service.GetAllCategories();

            // Assert
            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}