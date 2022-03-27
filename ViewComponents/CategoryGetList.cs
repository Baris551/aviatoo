using Microsoft.AspNetCore.Mvc;
using aviato.Models.DB;

namespace Aviato.ViewComponents
{
    public class CategoryGetList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var CategoryList = new List<Category>
            {
                new Category
                {
                    CategoryId=1,
                    CategoryName="Mavi",
                    Status = "true"
                },
                new Category
                {
                    CategoryId=2,
                    CategoryName="Levi's",
                    Status="true"
                },
                new Category
                {
                    CategoryId=3,
                    CategoryName="Nike",
                    Status="true"
                }
            };
            return View(CategoryList);
        }
    }
    
}