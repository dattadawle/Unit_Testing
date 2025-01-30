using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _context;
       public CategoryRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

     

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
            
        }
        public void Update(Category category)
        {
         var cat=  GetById(category.Id);
            _context.Categories.
        }
    }
}
