
using System.Linq;
using DBSportStore_NguyenNhatHao_25DH110348.Models;
using System.Web.Mvc;

namespace DBSportStore_NguyenNhatHao_25DH110348.Controllers
{
    public class StoreController : Controller
    {
        private DBSportStoreEntities db = new DBSportStoreEntities();

        public ActionResult Index()
        {
            var products = db.Products
                .Where(p => p.IsActive == true)
                .Select(p => new ProductCardViewModel
                {
                    ProductID = p.ProductID,
                    NamePro = p.ProductName,
                    CategoryName = p.Category.CategoryName,
                    Price = p.Price,
                    ImagePro = p.ImageUrl,
                    ShortDescription = p.Description
                })
                .ToList();

            return View(products);
        }

        public ActionResult AboutStore()
        {
            return View();
        }
    }
}
