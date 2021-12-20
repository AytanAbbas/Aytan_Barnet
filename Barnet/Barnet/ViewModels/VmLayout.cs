using Barnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.ViewModels
{
    public class VmLayout
    {
        public Setting Setting { get; set; }
        public List<Social> Socials { get; set; }
        public List<Article> Articles { get; set; }

    }
}
