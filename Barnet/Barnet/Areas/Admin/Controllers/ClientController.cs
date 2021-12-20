using Barnet.Data;
using Barnet.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ClientController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Client> model = _context.Clients.ToList();
            return View(model);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Client model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length <= 2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }
                        model.Image = fileName;
                        _context.Clients.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        return View(model);
                    }

                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(model);

                }

            }
            return View(model);
        }
        public IActionResult Update(int id)
        {

            return View(_context.Clients.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Client model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.Image = fileName;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        return View(model);
                    }
                }


                _context.Clients.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {

            Client client = _context.Clients.Find(id);

            _context.Clients.Remove(client);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
