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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            Setting model = _context.Settings.FirstOrDefault();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Setting model)
        {
            if (ModelState.IsValid)
            {
                if (model.HeaderLogoFile.ContentType == "image/jpeg" || model.HeaderLogoFile.ContentType == "image/png")
                {
                    if (model.HeaderLogoFile.Length <= 2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.HeaderLogoFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.HeaderLogoFile.CopyTo(stream);
                        }
                        model.HeaderLogo = fileName;
                        _context.Settings.Add(model);
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
            Setting model = _context.Settings.Find(id);
            return View(model);

        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {
                if (model.HeaderLogoFile != null)
                {
                    if (model.HeaderLogoFile.ContentType == "image/jpeg" || model.HeaderLogoFile.ContentType == "image/png")
                    {
                        if (model.HeaderLogoFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.HeaderLogo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.HeaderLogo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.HeaderLogoFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.HeaderLogoFile.CopyTo(stream);
                            }

                            model.HeaderLogo = fileName;
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


                _context.Settings.Update(model);
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

            Setting setting = _context.Settings.Find(id);

            if (setting == null)
            {
                ///
            }

            _context.Settings.Remove(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
