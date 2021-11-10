using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qna.Models.CoreModels;
using Qna.Models.DataModels;

namespace Qna.Services
{
    public class UserService : IUserService
    {
        readonly QnaDBEntities db = new QnaDBEntities();
        public List<Models.CoreModels.UsersView> GetUsersView()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.UserView, Models.CoreModels.UsersView>();
            });
            IMapper mapper = config.CreateMapper();
            List<Qna.Models.DataModels.UserView> DataUserViews = db.UserViews.ToList();
            List<Models.CoreModels.UsersView> CoreUserViews = new List<Models.CoreModels.UsersView>();
            DataUserViews.ForEach(dataUserView =>
            {
                var coreUserView = mapper.Map<Models.DataModels.UserView, Models.CoreModels.UsersView>(dataUserView);
                CoreUserViews.Add(coreUserView);
            });
            return CoreUserViews;
        }

        

        }
}