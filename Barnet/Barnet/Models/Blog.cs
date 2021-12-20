using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column("ntext")]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }

    }
}
