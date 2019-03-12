using ClothBazar.Database;
using ClothBazar.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ClothBazar.Services
{
    public class CategoriesService
    {
        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
                return context.Categories.ToList();
        }
        public void SaveCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public Category GetCategory(int id)
        {
            using (var context = new CBContext())
                return context.Categories.Find(id);
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
