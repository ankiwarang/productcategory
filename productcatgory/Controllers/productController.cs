using productcatgory.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace productcatgory.Controllers
{
    public class productController : Controller
    {
        // GET: product
        StockEntities dbObj = new StockEntities();

        public ActionResult product()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addproduct(Product model)
        {
            if(ModelState.IsValid){
                Product obj = new Product();
                obj.productname = model.productname;
                obj.categoryname = model.categoryname;

                dbObj.Products.Add(obj);
                dbObj.SaveChanges();


            }
            ModelState.Clear();
            return View("product");
        }
    public ActionResult productlist()
        {
            var res = dbObj.Products.ToList();

            res = res.Take(10).ToList();

            return View(res);
        }
        public ActionResult Delete(int Productid)
        {
            var res = dbObj.Products.Where(x => x.productid == Productid).First();
            dbObj.Products.Remove(res);
            dbObj.SaveChanges();
            var es = dbObj.Products.ToList();

            return View("productlist",es);

        }
        public ActionResult productlist1()
        {
            var res = dbObj.Products.ToList();

            res = res.Take(10).ToList();

            return View("productlist",res);

        }
        public ActionResult productlist2()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(10).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist3()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(20).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist4()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(30).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist5()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(40).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist6()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(50).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist7()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(60).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist8()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(70).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist9()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(80).Take(10).ToList();

            return View("productlist", res);

        }
        public ActionResult productlist10()
        {
            var res = dbObj.Products.ToList();

            res = res.Skip(90).Take(10).ToList();

            return View("productlist", res);

        }
    }
}