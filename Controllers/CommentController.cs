using CoffeeHouseProducts.Data;
using CoffeeHouseProducts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CoffeeHouseProducts.Controllers
{
    public class CommentController : Controller
    {
        private readonly ProductContext _context;
    
        public CommentController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            var _comments = _context.Comments;
            return Json(_comments);
        }

        [Route("comments/new")]
        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return Content("Success :)");
        }

    }
}
