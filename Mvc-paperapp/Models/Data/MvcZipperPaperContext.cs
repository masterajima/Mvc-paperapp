using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcZipperPaper.Models;
using System.Threading.Tasks;

namespace MvcZipperPaper.Models.Data
{
    public class MvcZipperPaperContext : DbContext
    {
        public MvcZipperPaperContext(DbContextOptions<MvcZipperPaperContext> options)
            : base(options)
        {
        }

        public DbSet<Zipper> Zipper { get; set; }

    }
}
