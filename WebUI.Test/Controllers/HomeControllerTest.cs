using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.Controllers;
using WebUI.Model;
using Xunit;

namespace WebUI.Test.Controllers
{
   public class HomeControllerTest
    {
        private readonly HomeController _controller;
        private readonly BrandContext _dbContext;

        public HomeControllerTest(BrandContext dbContext)
        {
            _dbContext = dbContext;
            _controller = new HomeController(_dbContext);
        }


        [Fact]
        public  void HomeController_GetBrands_Validresult()
        {         
            //Act
            var okResult = _controller.GetBrands();

            //Asert
            Assert.IsType<OkObjectResult>(okResult);
        }

       
    }
}
