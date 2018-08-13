using Model;
using System.Collections.Generic;
using System.Linq;

namespace DataSource
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly DEMOContext _context;

        public ProductRepository(DEMOContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 查詢所有資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> ReadAll()
        {
            return _context.Product;
        }

        /// <summary>
        /// 查詢特定資料 (By ids)
        /// </summary>
        /// <param name="condition">查詢條件</param>
        /// <returns></returns>
        public IEnumerable<Product> ReadRowsByIds(List<Product> condition)
        {
            return _context.Product.Where(r => condition.Select(c => c.Id).Contains(r.Id));
        }
    }
}