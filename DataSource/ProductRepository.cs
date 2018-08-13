using Model;
using System.Collections.Generic;

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
    }
}