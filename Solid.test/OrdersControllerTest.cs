using Microsoft.AspNetCore.Mvc;
using project_api.Controllers;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTest
{
    public class OrdersControllerTest
    {
        [Fact]
        public void GetAllReturnsOk()
        {
            //arrange

            //act
            var controller = new OrdersController();
            var result = controller.Get();
            //assert
            Assert.IsType<List<Order>>(result);
        }
        [Fact]

        
        public void GetAllReturnsCount()
        {
            //arrange

            //act
            var controller = new OrdersController();
            var result = controller.Get();
            //assert
            Assert.Equal(1,result.Count());
        }
        [Fact]
        public void GetById_ReturnsOk()
        {
          
                // Arrange
                var id = 1;
                var controller = new OrdersController(); // Ensure proper initialization with dependencies

                // Act
                var result = controller.Get(id);

                // Assert
                Assert.IsType<Order>(result);
            
        }
        [Fact]
        public void AddToOrderList()
        {
            //arrange
            var o1 = new Order { cust_id = 3, Id = 5, Num = 2, Product_id = 1 };
            //act
            var controller = new OrdersController();
            var result = controller.Post();
            //assert
            //Assert.Equal<List<Order>>(result);
        
        }
    }
}
