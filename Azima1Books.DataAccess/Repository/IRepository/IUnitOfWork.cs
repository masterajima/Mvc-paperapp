
using System;
using System.Collections.Generic;
using System.Text;

namespace Azima1Books.DataAccess.Repository.IRepository
{
    interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
