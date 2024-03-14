namespace PetMagazine.Services
{
    using PetMagazine.Data;
    using PetMagazine.Data.Models;
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CategoryService
    {
        private AppDbContext context = new AppDbContext();

        public int Add(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                throw new ArgumentException(ExceptionMessages.InvalidCategoryName);
            }
            if (context.Categories.Any(x => x.Name == category.Name))
            {
                throw new ArgumentException(ExceptionMessages.CategoryAlreadyExyst);
            }

            this.context.Add(category);
            this.context.SaveChanges();
            return category.Id;
        }
        public Category? GetCategoryById(int id)
        {
            return this.context.Categories.Find(id);
        }
        public int GetCategoriesCount()
        {
            return context.Categories.Count();
        }
        public int EditCategory(int id, string name)
        {
            Category? category = context.Categories.Find(id);
            if (category == null)
            {
                throw new ArgumentException(ExceptionMessages.CategoryNotFound);
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ExceptionMessages.InvalidCategoryName);
            }
            category.Name = name;
            context.Categories.Update(category);
            context.SaveChanges();
            return id;
        }
        public int DeleteCategory(int id)
        {
            Category? category = context.Categories.Find(id);
            if (category == null)
            {
                throw new ArgumentException(ExceptionMessages.CategoryNotFound);
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return id;
        }
    }
}
