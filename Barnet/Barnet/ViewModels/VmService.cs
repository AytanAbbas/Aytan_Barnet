using Barnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.ViewModels
{
    public class VmService : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Client> Clients { get; set; }
    }
}
