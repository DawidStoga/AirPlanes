using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web;
using AirPlane.Domain.Abstract;
using AirPlane.Domain.Entities;
using System.Drawing;

namespace AirPlane.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IAirPlaneRepository repository;
        public AdminController(IAirPlaneRepository repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ViewResult Index()   //todo : view or acrion
        {
            return View(repository.AirCrafts);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int AircraftID)
        {
            return View();
        }
// GET: Admin/Create
        public ViewResult Create()
        {
            return View("Edit", new Aircraft());
        }
        
      

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ViewResult Edit(int AircraftID)
        {
            Aircraft product = repository.AirCrafts.FirstOrDefault(p => p.AircraftID == AircraftID);
           
            return View(product);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Exclude= "MyProperty")]Aircraft product, HttpPostedFileBase image = null)
        {
            if(ModelState.IsValid)
            {
                if(image!=null)
                {
                    if(product.FullImage == null)
                    {
                        PhotoFullImage pff = new PhotoFullImage { HighResolutionBits = new byte[image.ContentLength] };
                        product.FullImage = pff;
                        ImageConverter ic = new ImageConverter();
                       
                       // product.ThumbnailBits =   (byte[])ic.ConvertTo(img, typeof(byte[]));
                       
                    }
                    else
                    {
                    product.FullImage.HighResolutionBits = new byte[image.ContentLength];
                    }
                    
                    image.InputStream.Read(product.FullImage.HighResolutionBits, 0, image.ContentLength);

                }
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name, product.Type);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
           /* try       todo - rozxnica try cath a IsValid
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }*/
        }

     
        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Aircraft deletedProduct = repository.DeleteProduct(productId);
            if(deletedProduct!=null)
            {
                TempData["message"] = String.Format("{0} WAS DELETED", deletedProduct.Name, deletedProduct.Type);
            }
            return RedirectToAction("Index");
        }
    }
}
