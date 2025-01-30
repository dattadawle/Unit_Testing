using BAL;
using DAL.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UnitTesting.Controllers;

namespace WebUITestwithXUnit
{
    public class CategoryControllerTest
    {
        [Fact]
        public void ReturnView_Index_WithCategories()
        {
            // Arrange
            Mock<ICategoryService> mockService = new Mock<ICategoryService>();
            CategoryController categoryController = new CategoryController(mockService.Object);
            var categories = new List<Category>()
             {
             new Category (){Id=1,Name="mens were" ,Rating=4},
             new Category (){Id=2,Name="leadies were", Rating = 4 }
             };
            mockService.Setup(s => s.GetAll()).Returns(categories);
            //Act
            var result = categoryController.Index() as ViewResult;
            //Assert

            Assert.NotNull(result);
            /* Assert.IsType<ViewResult>(result);

             Assert.IsAssignableFrom<IEnumerable<Category>>(result.Model);

             var model = result.Model as IEnumerable<Category>;

             Assert.Equal(2, model.Count());*/


        }
    }
}