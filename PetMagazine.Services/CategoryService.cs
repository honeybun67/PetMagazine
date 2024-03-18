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
        private AppDbContext context;
        public CategoryService()
        {
            context = new AppDbContext();
        }
        public CategoryService(AppDbContext context)
        {
            this.context = context;
        }

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
        public List<Category> GetCategories(int page = 1, int itemsPerPage = 10, bool ascSort = true)
        {
            IQueryable<Category> result = null;

            if (ascSort)
            {
                result = this.context.Categories.OrderBy(x => x.Name);
            }
            else
            {
                result = this.context.Categories.OrderByDescending(x => x.Name);
            }

            return result
                  .Skip((page - 1) * itemsPerPage)
                  .Take(itemsPerPage)
                  .ToList();
        }
        public string[] GetAllCategories()
        {
            return this.context.Categories.Select(x => x.Name).ToArray();
        }
        public Category? GetCategoryById(int id)
        {
            return this.context.Categories.Find(id);
        }
        public int GetCategoriesCount()
        {
            return context.Categories.Count();
        }
        public Category? GetCategoryByName(string name)
        {
            return this.context.Categories.FirstOrDefault(x => x.Name == name);
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
        public List<int> GetCategoriesId()
        {
            return this.context.Categories.Select(x => x.Id).ToList();
        }
    }
}
