using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MvcZipperPaper.Models;

namespace MvcZipperPaper.Data
{
    public class MvcZipperPaperContext : IdentityDbContext
    {
        public MvcZipperPaperContext(DbContextOptions<MvcZipperPaperContext> options)
            : base(options)
        {
        }
        public DbSet<MvcZipperPaper.Models.Zipper> Zipper { get; set; }
    }
}
