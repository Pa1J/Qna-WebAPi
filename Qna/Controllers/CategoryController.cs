using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Services;
using Qna.Models.CoreModels;
using System.Web.Http;

namespace Qna.Controllers
{
    [System.Web.Http.RoutePrefix("category")]
    public class CategoryController : ApiController
    {
        public ICategoryService CategoryService { get; set; }
        public CategoryController(ICategoryService categoryService)
        {
            this.CategoryService = categoryService;
        }
        
        
        
        [System.Web.Http.Route("get")]
        public IHttpActionResult Get()
        {
            IEnumerable<CatView> Categories = CategoryService.GetCategoriesView();
            if(Categories.Count() == 0)
            {
                return NotFound();
            }
            return Ok(Categories);
        }

        [System.Web.Http.Route("addcategories")]
        public Boolean AddCategory(Models.CoreModels.Category newCategeory)
        {
            return CategoryService.AddCategory(newCategeory);
        }


    }
}