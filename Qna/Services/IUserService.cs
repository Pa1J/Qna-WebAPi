using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qna.Services
{
    public interface IUserService
    {
        List<Models.CoreModels.UsersView> GetUsersView();

    }
}
