using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qna.Services
{
    public interface ICategoryService
    {
        Boolean AddCategory(Models.CoreModels.Category newCategeory);
        List<Models.CoreModels.CatView> GetCategoriesView();

    }
}
