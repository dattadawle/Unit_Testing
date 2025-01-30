using DAL.Models;
using Repositories;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository repository;
        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }
        public List<Category> GetAll()
        {
        return repository.GetAll();
        }
        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

     

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
