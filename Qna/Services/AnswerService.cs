using AutoMapper;
using Qna.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Services
{
    public class AnswerService : IAnswerService
    {
        readonly QnaDBEntities db = new QnaDBEntities();
        public List<Models.CoreModels.AnswerView> GetAnswerView()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.AnswerView, Models.CoreModels.AnswerView>();
            });
            IMapper mapper = config.CreateMapper();
            List<Qna.Models.DataModels.AnswerView> DataAnswerViews = db.AnswerViews.ToList();
            List<Models.CoreModels.AnswerView> CoreAnswerViews = new List<Models.CoreModels.AnswerView>();
            DataAnswerViews.ForEach(dataAnswerView =>
            {
                var coreAnswerView = mapper.Map<Models.DataModels.AnswerView, Models.CoreModels.AnswerView>(dataAnswerView);
                CoreAnswerViews.Add(coreAnswerView);
            });
            return CoreAnswerViews;
        }

        public Boolean AddAnswer(Models.CoreModels.Answer newAnswer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.CoreModels.Answer, Models.DataModels.ANSWER>();
            });
            IMapper mapper = config.CreateMapper();

            var newDataAnswer = mapper.Map<Models.CoreModels.Answer, Models.DataModels.ANSWER>(newAnswer);
            newDataAnswer.CreatedBy = "Pavan";
            newDataAnswer.ModifiedBy = "Pavan";
            newDataAnswer.DateModified = DateTime.Today;
            newDataAnswer.DateCreated = DateTime.Today;
            db.ANSWERs.Add(newDataAnswer);
            db.SaveChanges();
            return true;
        }

        public Boolean LikeAnswer(Models.CoreModels.Liked newLike)
        {
            var likeResult = db.LIKEDs.SingleOrDefault(like => like.AnswerId == newLike.AnswerId && like.LikedBy == newLike.LikedBy);

            if (likeResult != null)
            {
                if (likeResult.IsLiked == 1)
                {
                    likeResult.IsLiked = null;
                }
                else
                {
                    likeResult.IsLiked = 1;
                }
                db.SaveChanges();
                return true;
            }
            else
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Models.CoreModels.Liked, Models.DataModels.LIKED>();
                });
                IMapper mapper = config.CreateMapper();
                var newDataLike = mapper.Map<Models.CoreModels.Liked, Models.DataModels.LIKED>(newLike);
                newDataLike.CreatedBy = "Pavan";
                newDataLike.ModifiedBy = "Pavan";
                newDataLike.DateModified = DateTime.Today;
                newDataLike.DateCreated = DateTime.Today;
                return true;
            }
        }

        public Boolean ChangeBestSolution(Models.CoreModels.Answer bestAnswer)
        {
            var result = db.ANSWERs.SingleOrDefault(answer => answer.Id == bestAnswer.Id);
            if(result != null && result.IsBestSolution!=1)
            {
                result.IsBestSolution = 1;
                db.SaveChanges();
            }
            return true;
        }
    }
}