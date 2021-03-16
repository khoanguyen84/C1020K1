using EmployeeMangement.Models;
using EmployeeMangement.Models.Product;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public const string CartKey = "Cart";

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            GetCookies();
            var products = productService.Gets().OrderByDescending(e => e.ProductId).ToList();
            var pagination = new Pagination(products.Count, 1, 10, null);
            var viewModel = new ProductView()
            {
                Products = products.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
                Pagination = pagination
            };
            return View(viewModel);
        }

        [Route("/Product/{productId:int}")]
        public IActionResult AddToCard([FromRoute] int productId)
        {
            var product = productService.Get(productId);
            if(product == null)
            {
                return NotFound("Product is not foud");
            }

            var cart = GetCartItems();
            var existingItem = cart.Find(c => c.Product.ProductId == productId);
            if(existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new Cart()
                {
                    Quantity = 1,
                    Product = product
                });
            }
            SaveCart(cart);
            return RedirectToAction("index");
        }

        [Route("/Product/Cart",Name = "cart")]
        public IActionResult Cart()
        {
            GetCookies();
            return View(GetCartItems());
        }

        [Route("/Product/UpdateCart", Name ="updatecart")]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            var session = HttpContext.Session;
            var jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
                var cartItem = carts.FirstOrDefault(e => e.Product.ProductId == productid);
                cartItem.Quantity = quantity;
                SaveCart(carts);
            }
            return Ok();
        }

        [Route("/Product/RemoveCartItem/{productId}")]
        public IActionResult RemoveCartItem([FromRoute] int productId)
        {
            var session = HttpContext.Session;
            var jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
                var cartItem = carts.FirstOrDefault(e => e.Product.ProductId == productId);
                carts.Remove(cartItem);
                SaveCart(carts);
            }
            return Ok();
        }
        private List<Cart> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsonCart = session.GetString(CartKey);
            if (!string.IsNullOrEmpty(jsonCart))
            {
                return JsonConvert.DeserializeObject<List<Cart>>(jsonCart);
            }
            return new List<Cart>();
        }
        private void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CartKey);
        }

        private void SaveCart(List<Cart> cart)
        {
            var session = HttpContext.Session;
            var jsonCart = JsonConvert.SerializeObject(cart);
            session.SetString(CartKey, jsonCart);
            SetCookie(jsonCart);
        }

        private void GetCookies()
        {
            var cart_cookie = Request.Cookies["carts"];
            if (!string.IsNullOrEmpty(cart_cookie))
            {
                var cart = JsonConvert.DeserializeObject<List<Cart>>(cart_cookie);
                SaveCart(cart);
            }
        }
        private void SetCookie(string joinCart)
        {
            Response.Cookies.Append("carts", joinCart);
        }
    }
}
