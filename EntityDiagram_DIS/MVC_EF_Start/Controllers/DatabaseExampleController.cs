using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityDiagram_DIS.DataAccess;
using EntityDiagram_DIS.Models;

namespace EntityDiagram_DIS.Controllers
{
    public class DatabaseExampleController : Controller
    {
        public ApplicationDbContext dbContext;

        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<ViewResult> DatabaseOperations()
        {

            Store store = new Store();
            store.store_Id = 1;
            store.store_Name = "PatelBrothers";

            Products product1 = new Products();
            product1.Product_Id = 1;
            product1.name = "Tortillas";
            product1.cost = 20;
            product1.store = store;

            Products product2 = new Products();
            product2.Product_Id = 2;
            product2.name = "Iphone";
            product2.cost = 478;
            product2.store = store;

            Products product3 = new Products();
            product3.Product_Id = 3;
            product3.name = "Jacket";
            product3.cost = 20;
            product3.store = store;

            Products product4 = new Products();
            product4.Product_Id = 4;
            product4.name = "cream";
            product4.cost = 145;
            product4.store = store;


            Products product5 = new Products();
            product5.Product_Id = 5;
            product5.name = "Iphone Cable";
            product5.cost = 23;
            product5.store = store;

            Products product6 = new Products();
            product6.Product_Id = 6;
            product6.name = "Dolls";
            product6.cost = 11;
            product6.store = store;

            Products product7 = new Products();
            product7.Product_Id = 7;
            product7.name = "Blender";
            product7.cost = 85;
            product7.store = store;

            Products product8 = new Products();
            product8.Product_Id = 8;
            product8.name = "Book";
            product8.cost = 45;
            product8.store = store;

           
            Orders order1 = new Orders();
            order1.Order_Id = 1;
            order1.Order_Total = 2000;
            order1.store = store;

            Orders order2 = new Orders();
            order2.Order_Id = 2;
            order2.Order_Total = 200;
            order2.store = store;

            Orders order3 = new Orders();
            order3.Order_Id = 3;
            order3.Order_Total = 2200;
            order3.store = store;

            Orders order4 = new Orders();
            order4.Order_Id = 4;
            order4.Order_Total = 2040;
            order4.store = store;

            Orders order5 = new Orders();
            order5.Order_Id = 5;
            order5.Order_Total = 2010;
            order5.store = store;

            Orders order6 = new Orders();
            order6.Order_Id = 6;
            order6.Order_Total = 2300;
            order6.store = store;

            Orders order7 = new Orders();
            order7.Order_Id = 7;
            order7.Order_Total = 2400;
            order7.store = store;

            Orders order8 = new Orders();
            order8.Order_Id = 8;
            order8.Order_Total = 800;
            order8.store = store;

            Orders order9 = new Orders();
            order9.Order_Id = 9;
            order9.Order_Total = 8700;
            order9.store = store;

            Orders order10 = new Orders();
            order10.Order_Id = 10;
            order10.Order_Total = 100;
            order10.store = store;


            OrderProductMap orderProduct1 = new OrderProductMap
            {
                order = order1,
                product = product1,
                ProductQuantity = 10
            };


            OrderProductMap orderProduct2 = new OrderProductMap
            {
                order = order1,
                product = product2,
                ProductQuantity = 100
            };


            OrderProductMap orderProduct3 = new OrderProductMap
            {
                order = order1,
                product = product3,
                ProductQuantity = 15
            };


            OrderProductMap orderProduct4 = new OrderProductMap
            {
                order = order1,
                product = product7,
                ProductQuantity = 1
            };


            OrderProductMap orderProduct5 = new OrderProductMap
            {
                order = order1,
                product = product5,
                ProductQuantity = 8
            };

            OrderProductMap orderProduct6 = new OrderProductMap
            {
                order = order1,
                product = product8,
                ProductQuantity = 10
            };



            OrderProductMap orderProduct7 = new OrderProductMap
            {
                order = order2,
                product = product1,
                ProductQuantity = 66
            };


            OrderProductMap orderProduct8 = new OrderProductMap
            {
                order = order2,
                product = product5,
                ProductQuantity = 40
            };


            OrderProductMap orderProduct10 = new OrderProductMap
            {
                order = order3,
                product = product7,
                ProductQuantity = 132
            };


            OrderProductMap orderProduct11 = new OrderProductMap
            {
                order = order3,
                product = product6,
                ProductQuantity = 83
            };

            OrderProductMap orderProduct12 = new OrderProductMap
            {
                order = order3,
                product = product1,
                ProductQuantity = 110
            };

            OrderProductMap orderProduct13 = new OrderProductMap
            {
                order = order3,
                product = product2,
                ProductQuantity = 11
            };

            OrderProductMap orderProduct14 = new OrderProductMap
            {
                order = order3,
                product = product6,
                ProductQuantity = 15
            };


            OrderProductMap orderProduct15 = new OrderProductMap
            {
                order = order3,
                product = product8,
                ProductQuantity = 190
            };


            OrderProductMap orderProduct16 = new OrderProductMap
            {
                order = order4,
                product = product1,
                ProductQuantity = 11
            };


            OrderProductMap orderProduct17 = new OrderProductMap
            {
                order = order4,
                product = product7,
                ProductQuantity = 111
            };


            OrderProductMap orderProduct18 = new OrderProductMap
            {
                order = order4,
                product = product3,
                ProductQuantity = 80
            };

            OrderProductMap orderProduct19 = new OrderProductMap
            {
                order = order4,
                product = product6,
                ProductQuantity = 140
            };



            OrderProductMap orderProduct20 = new OrderProductMap
            {
                order = order5,
                product = product1,
                ProductQuantity = 600
            };

            OrderProductMap orderProduct21 = new OrderProductMap
            {
                order = order5,
                product = product3,
                ProductQuantity = 1
            };



            OrderProductMap orderProduct22 = new OrderProductMap
            {
                order = order6,
                product = product2,
                ProductQuantity = 300
            };


            OrderProductMap orderProduct23 = new OrderProductMap
            {
                order = order6,
                product = product3,
                ProductQuantity = 15
            };


            OrderProductMap orderProduct24 = new OrderProductMap
            {
                order = order6,
                product = product7,
                ProductQuantity = 11
            };


            OrderProductMap orderProduct25 = new OrderProductMap
            {
                order = order7,
                product = product1,
                ProductQuantity = 8
            };

            OrderProductMap orderProduct26 = new OrderProductMap
            {
                order = order7,
                product = product4,
                ProductQuantity = 110
            };



            OrderProductMap orderProduct27 = new OrderProductMap
            {
                order = order8,
                product = product1,
                ProductQuantity = 30
            };


            OrderProductMap orderProduct28 = new OrderProductMap
            {
                order = order8,
                product = product6,
                ProductQuantity = 35
            };


            OrderProductMap orderProduct29 = new OrderProductMap
            {
                order = order8,
                product = product3,
                ProductQuantity = 15
            };


            OrderProductMap orderProduct30 = new OrderProductMap
            {
                order = order9,
                product = product2,
                ProductQuantity = 158
            };


            OrderProductMap orderProduct31 = new OrderProductMap
            {
                order = order10,
                product = product8,
                ProductQuantity = 980
            };




          


            dbContext.Orders.Add(order1);
            dbContext.Orders.Add(order2);
            dbContext.Orders.Add(order3);
            dbContext.Orders.Add(order4);
            dbContext.Orders.Add(order5);
            dbContext.Orders.Add(order6);
            dbContext.Orders.Add(order7);
            dbContext.Orders.Add(order8);
            dbContext.Orders.Add(order9);
            dbContext.Orders.Add(order10);


            dbContext.Products.Add(product1);
            dbContext.Products.Add(product2);
            dbContext.Products.Add(product3);
            dbContext.Products.Add(product4);
            dbContext.Products.Add(product5);
            dbContext.Products.Add(product6);
            dbContext.Products.Add(product7);
            dbContext.Products.Add(product8);

            dbContext.OrderProductMaps.Add(orderProduct1);
            dbContext.OrderProductMaps.Add(orderProduct2);
            dbContext.OrderProductMaps.Add(orderProduct3);
            dbContext.OrderProductMaps.Add(orderProduct4);
            dbContext.OrderProductMaps.Add(orderProduct5);
            dbContext.OrderProductMaps.Add(orderProduct6);
            dbContext.OrderProductMaps.Add(orderProduct7);
            dbContext.OrderProductMaps.Add(orderProduct8);
            dbContext.OrderProductMaps.Add(orderProduct10);
            dbContext.OrderProductMaps.Add(orderProduct11);
            dbContext.OrderProductMaps.Add(orderProduct12);
            dbContext.OrderProductMaps.Add(orderProduct13);
            dbContext.OrderProductMaps.Add(orderProduct14);
            dbContext.OrderProductMaps.Add(orderProduct15);
            dbContext.OrderProductMaps.Add(orderProduct16);
            dbContext.OrderProductMaps.Add(orderProduct17);
            dbContext.OrderProductMaps.Add(orderProduct18);
            dbContext.OrderProductMaps.Add(orderProduct19);
            dbContext.OrderProductMaps.Add(orderProduct20);
            dbContext.OrderProductMaps.Add(orderProduct21);
            dbContext.OrderProductMaps.Add(orderProduct22);
            dbContext.OrderProductMaps.Add(orderProduct23);
            dbContext.OrderProductMaps.Add(orderProduct24);
            dbContext.OrderProductMaps.Add(orderProduct25);
            dbContext.OrderProductMaps.Add(orderProduct26);
            dbContext.OrderProductMaps.Add(orderProduct27);
            dbContext.OrderProductMaps.Add(orderProduct28);
            dbContext.OrderProductMaps.Add(orderProduct29);
            dbContext.OrderProductMaps.Add(orderProduct30);
            dbContext.OrderProductMaps.Add(orderProduct31);
            dbContext.SaveChanges();



            return View();
        }

        public ViewResult LINQOperations()
        {

            //Geting List of orders Where a product 1 is sold

            var productList = (from or in dbContext.Orders join opm in dbContext.OrderProductMaps on or.Order_Id equals opm.order.Order_Id where opm.product.Product_Id == 3 select new { or.Order_Id }).ToList();

            Console.WriteLine(productList);

            var list = (from op in dbContext.OrderProductMaps where op.ProductQuantity == dbContext.OrderProductMaps.Where(p => p.product.Product_Id == 3).Max(x => x.ProductQuantity) select new { op.order.Order_Id }).ToList();


            //var productList = (from or in dbContext.Orders join opm in dbContext.OrderProductMaps on or.OrderId equals opm.order.OrderId where opm.pquantity=(from op select new { or.OrderId }).ToList();

            ViewBag.Products = productList;
            ViewBag.OrderId = list;
            return View();


        }
    }
}