using Barnet.Data;
using Barnet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;
  

        public ServicesController(AppDbContext context)
        {
            _context = context;
    
        }
        public IActionResult Index()
        {
            VmService model = new VmService

        {
            Banner = _context.Banners.FirstOrDefault(),
            Services = _context.Services.ToList(),
            Sliders = _context.Sliders.ToList(),
            Clients = _context.Clients.ToList(),
            Socials=_context.Socials.ToList(),
            Setting=_context.Settings.FirstOrDefault(),
            Articles=_context.Articles.ToList()


         };
            return View(model);
        }
    }
}
