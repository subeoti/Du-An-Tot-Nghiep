using DaTa.Model;
using DaTa.ProductDA;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace WebAPI.Product
{
    public class ProDuct 
    {
        private ProductDA productDA = new ProductDA();
        //public IActionResult Index()
        //{
        //    return View();

        //}
        //public List<SanPham> GetProduct(SanPham sanpham, int? id)
        //{
        //    var data = productDA.GetListProduct(sanpham, id);
        //    return data;

        //}
    }
  
}
