using PROJECT_OOAD;
using PROJECT_OOAD.DAL;
using PROJECT_OOAD.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PROJECT_OOAD.Controllers
{
    public class ProductController : Controller
    {


        // GET: Product
        public ActionResult Index()
        {
            dynamic model1 = new ExpandoObject();
            ProductDAL pruDAL = new ProductDAL();
            model1 = pruDAL.ListProduts();
            ViewBag.data1 = model1;
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {   
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            try
                {
                    Product product = new Product();
                        product.Name = collection["Name"].ToString();
                        product.Price = collection["Price"].ToString();
                        product.StockQuantity = collection["StockQuantity"].ToString();

                     ProductDAL ProDal = new ProductDAL();
                    string Result = ProDal.CreateProduct(product);
                    ViewBag.Msg = Intranet.Message("Success", "New Record has been saved.");
                    return View();
                }
                catch (Exception ex)
                {
                ViewBag.Msg = Intranet.Message("Error", ex.Message);
                    return View();
                }
           
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductDAL PrDAL = new ProductDAL();
            dynamic model = new ExpandoObject();
            model = PrDAL.EditProduct(id);
            ViewBag.data = model;
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, FormCollection collection)
        {
     
                Product products = new Product();
                try
                {
                    products.ID = Id;
                    products.Name = collection["Name"].ToString();
                    products.Price = collection["Price"].ToString();
                    products.StockQuantity = collection["StockQuantity"].ToString();

                    ProductDAL mtrDal = new ProductDAL();
                    string Result = mtrDal.UpdateProduct(products);
                    ViewBag.Msg = Intranet.Message("Success", "New Record has been updated.");
                    ViewBag.data = products;
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.Msg = Intranet.Message("Error", ex.Message);
                    ViewBag.data = products;
                    return View();
                }
           
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public JsonResult DeleteRecord(string Id)
        {
            ProductDAL PRdal = new ProductDAL();
            string Result = PRdal.DeleteProduct(Id);
            return Json(Result);

        }
    }
}
