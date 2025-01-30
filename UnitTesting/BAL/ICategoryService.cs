using DAL.Models;
using System.Collections.Generic;

namespace BAL
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);

    }
}
