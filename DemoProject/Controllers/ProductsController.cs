using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        /// <summary>
        /// 取得商品清單
        /// </summary>
        /// <returns></returns>
        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}