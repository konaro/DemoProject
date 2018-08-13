﻿using DataSource;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// 取得總計金額
        /// </summary>
        /// <param name="products">選定的商品</param>
        /// <returns></returns>
        public decimal GetSum(List<Product> products)
        {
            var selected = _repository.ReadRowsByIds(products);
            return selected.Sum(r => r.Price);
        }
    }
}