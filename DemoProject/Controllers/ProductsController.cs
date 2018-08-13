using DataSource;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace DemoProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private readonly IRepository<Product> _repository;

        public ProductsController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 取得商品清單
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAll()
        {
            return _repository.ReadAll();
        }
    }
}