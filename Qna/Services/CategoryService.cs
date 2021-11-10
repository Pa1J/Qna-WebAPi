using AutoMapper;
using Qna.Models.DataModels;
using Qna.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Services
{
    
    public class CategoryService : ICategoryService
    {
        
        readonly QnaDBEntities db = new QnaDBEntities();
        public Boolean AddCategory(Models.CoreModels.Category newCategeory)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.CoreModels.Category, Models.DataModels.CATEGEORY>();
            });
            IMapper mapper = config.CreateMapper();

            var newDataCategeory = mapper.Map<Models.CoreModels.Category, Models.DataModels.CATEGEORY>(newCategeory);
            newDataCategeory.CreatedBy = "Pavan";
            newDataCategeory.ModifiedBy = "Pavan";
            newDataCategeory.DateModified = DateTime.Today;
            newDataCategeory.DateCreated = DateTime.Today;
            db.CATEGEORies.Add(newDataCategeory);
            db.SaveChanges();
            return true;
        }
        public List<Models.CoreModels.CatView> GetCategoriesView()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.CategoryView, Models.CoreModels.CatView>();
            });
            IMapper mapper = config.CreateMapper();
            List<Models.DataModels.CategoryView> DataCategoryViews = db.CategoryViews.ToList();
            List<Models.CoreModels.CatView> CoreCategoryViews = new List<Models.CoreModels.CatView>();
            DataCategoryViews.ForEach(dataCategoryView =>
           {
               var coreCategoryView = mapper.Map<Models.DataModels.CategoryView, Models.CoreModels.CatView>(dataCategoryView);
               CoreCategoryViews.Add(coreCategoryView);
           });
            return CoreCategoryViews;
        }
    }
}