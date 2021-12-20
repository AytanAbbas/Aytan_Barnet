using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Article
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
