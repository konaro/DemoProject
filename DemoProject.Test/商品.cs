using DemoProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;

namespace DemoProject.Test
{
    [TestClass]
    public class 商品
    {
        [TestMethod]
        public void 取得商品清單()
        {
            // Arrange
            var expected = new List<Product>
            {
                new Product { Id = 1, Name = "科幻四小俠", Price = 299, InStock = 6, Brief = "垃圾書刊" },
                new Product { Id = 2, Name = "宇宙科幻", Price = 560, InStock = 2, Brief = "暢銷書籍" },
                new Product { Id = 3, Name = "名偵探-ㄎㄅ", Price = 250, InStock = 5, Brief = "都在唬爛" },
                new Product { Id = 4, Name = "這不是我認識的偵探", Price = 520, InStock = 0, Brief = "._." }
            };
            var controller = new ProductsController();

            // Act
            var actual = controller.GetAll();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void 取得所選商品總計金額()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //}

        //[TestMethod]
        //public void 取得所選商品總計金額_未選擇商品()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //}
    }
}