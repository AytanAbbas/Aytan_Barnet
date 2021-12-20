using Barnet.Data;
using Barnet.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ArticleController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Article> model = _context.Articles.ToList();
            return View(model);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Article model)
        {

            if (ModelState.IsValid)
            {
                _context.Articles.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Errors");

            return View(model);
        }

        public IActionResult Update(int id)
        {
            Article model = _context.Articles.Find(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Article model)
        {
            if (ModelState.IsValid)
            {
                _context.Articles.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Article article = _context.Articles.Find(id);
            if (article == null)
            {
                ///
            }
            _context.Articles.Remove(article);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
