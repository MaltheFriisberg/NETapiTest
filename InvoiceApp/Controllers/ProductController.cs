using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Invoices
        Product[] Products = new Product[]
        {
            new Product {id = 0, name = "hans" },
            new Product {id = 1, name = "kurt" }
        };
        //http://localhost:54708/product/GetAllProducts
        public JsonResult GetAllProducts()
        {
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        //http://localhost:54708/product/GetProduct/1
        public ActionResult GetProduct(int id)
        {
            var invoice = Products.FirstOrDefault((p) => p.id == id);
            if (invoice == null)
            {
                return this.Json("error");
            }
            return this.Json(invoice, JsonRequestBehavior.AllowGet);
        }
    }
}