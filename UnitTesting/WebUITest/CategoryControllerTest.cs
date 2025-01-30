using BAL;
using DAL.Models;
using Moq;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UnitTesting.Controllers;
using Xunit.Sdk;
using Xunit;

namespace WebUITest
{
    public class CategoryControllerTest
    {

        [Fact]
        public void ReturnView_Index_WithCategories()
        {
            //Arrange
            Mock<ICategoryService> mockService=new Mock<ICategoryService> ();
            CategoryController categoryController = new CategoryController (mockService.Object);
            var categories = new List<Category>()
                {
                new Category (){ Id = 1,Name="mens were",Rating=3 },
                new Category (){ Id = 2,Name="Kids were",Rating=3 }
                };
            mockService.Setup(s => s.GetAll()).Returns(categories);
            //Act
            var result = categoryController.Index() as ViewResult;
            //Assert

            Assert.NotNull(result);

        }
    }
}
