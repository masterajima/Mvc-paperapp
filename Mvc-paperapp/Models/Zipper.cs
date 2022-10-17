using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


using System.ComponentModel.DataAnnotations.Schema;
namespace MvcZipperPaper.Models
    
{
    public class Zipper
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
    }
}
