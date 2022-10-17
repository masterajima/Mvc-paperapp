using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcZipperPaper.Models
{
    public class ZipperTypeViewModel
    {
        public List<Zipper> Zippers { get; set; }
        public SelectList Type { get; set; }
        public string Title { get; set; }
        public string SearchString { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ZipperType { get; set; }
        public Decimal Price { get; set; }
        public List<Zipper> Model { get; set; }
       
        



    }
}
