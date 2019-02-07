using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class ProductsController : Controller
    {
        ProductsData db = new ProductsData();
        public ViewResult Details(int id)
        {
            Product product = db.ProductsList.Single(x => x.ProductId == id);
            return View(product);
        }
    }
}