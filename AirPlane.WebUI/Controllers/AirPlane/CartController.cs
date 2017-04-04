using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirPlane.Domain.Abstract;
using AirPlane.Domain.Entities;
using AirPlane.WebUI.Models;

namespace AirPlane.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IAirPlaneRepository repository;
        private IOrderProcessor orderProcessor;
        public CartController(IAirPlaneRepository repo, IOrderProcessor orderProc )
        {
            repository = repo;
            orderProcessor = orderProc;

        }

        public RedirectToRouteResult AddToCart(Cart cart, int aircraftId, string returnUrl)  //todo: z prodictId nie dziala
        {
            Aircraft product = repository.AirCrafts.FirstOrDefault(p => p.AircraftID == aircraftId);
            if(product !=null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId, string returnUrl)
        {
            Aircraft product = repository.AirCrafts
            .FirstOrDefault(p => p.AircraftID == productId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

      /* removed due to the binding impelmentation   private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"]; //todo!!!!1
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }*/
        // GET: Cart
        public ViewResult Index(Cart cart,string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
        [HttpPost]
        public ActionResult Checkout(Cart cart, ShippingDetails shippingDetails)
        { //todo - model binder w ksiazce!
            if( cart.Lines.Count() == 0 )
            {
                ModelState.AddModelError("", "Your Cart is Empty !");

            }
            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
      

        }
        [HttpGet]
        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }
    }
}