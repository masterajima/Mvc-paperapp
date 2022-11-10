using Azima1Books.DataAccess.Repository.IRepository;
using Azima1Books.Models;
using Azima1Books.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Azima1Books.DataAccess.Repository
{
    class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db) => _db = db;

        public void Add(CoverType entity)
        {
            throw new NotImplementedException();
        }

        public CoverType Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CoverType> GetAll(Expression<Func<CoverType, bool>> filter = null, Func<IQueryable<CoverType>, IOrderedQueryable<CoverType>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public CoverType GetFirstOrDefault(Expression<Func<CoverType, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CoverType entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRanges(IEnumerable<CoverType> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
            }
        }
    }
}
