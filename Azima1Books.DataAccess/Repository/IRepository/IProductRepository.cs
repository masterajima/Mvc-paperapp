﻿using Azima1Books.DataAccess.Data;
using Azima1Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azima1Books.DataAccess.Repository.IRepository
{
    interface IProductRepository
    {
        public interface IProductRepository : IRepository<Product>
        {
            void Update(Product product);
        }
    }
}
