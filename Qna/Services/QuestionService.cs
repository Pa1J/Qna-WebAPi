using AutoMapper;
using Qna.Models.DataModels;
using Qna.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Services
{

    public class QuestionService : IQuestionService
    {
        readonly QnaDBEntities db = new QnaDBEntities();
        public List<Models.CoreModels.QuesView> GetQuestionView()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.QuestionView, Models.CoreModels.QuesView>();
            });
            IMapper mapper = config.CreateMapper();
            List<Qna.Models.DataModels.QuestionView> DataQuestionViews = db.QuestionViews.ToList();
            List<Models.CoreModels.QuesView> CoreQuestionViews = new List<Models.CoreModels.QuesView>();
            DataQuestionViews.ForEach(dataQuestionView =>
            {
                var coreQuestionView = mapper.Map<Models.DataModels.QuestionView, Models.CoreModels.QuesView>(dataQuestionView);
                CoreQuestionViews.Add(coreQuestionView);
            });
            return CoreQuestionViews;
        }

        public Boolean AddQuestion(Models.CoreModels.Question newQuestion)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.CoreModels.Question, Models.DataModels.QUESTION>();
            });
            IMapper mapper = config.CreateMapper();

            var newDataQuestion = mapper.Map<Models.CoreModels.Question, Models.DataModels.QUESTION>(newQuestion);
            newDataQuestion.CreatedBy = "Pavan";
            newDataQuestion.ModifiedBy = "Pavan";
            newDataQuestion.DateModified = DateTime.Today;
            newDataQuestion.DateCreated = DateTime.Today;
            db.QUESTIONs.Add(newDataQuestion);
            db.SaveChanges();
            return true;
        }

        public Boolean IncreaseViews(Models.CoreModels.Viewed newView)
        {
            Boolean isViewed = false;
            List<Models.DataModels.VIEWED> DataViewList = db.VIEWEDs.ToList();
            DataViewList.ForEach(dataViewItem =>
            {
                if (dataViewItem.UserId == newView.UserId && dataViewItem.QuestionId == newView.QuestionId)
                {
                    isViewed = true;
                }
            });
            if (!isViewed)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Models.CoreModels.Viewed, Models.DataModels.VIEWED>();
                });
                IMapper mapper = config.CreateMapper();
                Models.DataModels.VIEWED newDataView = mapper.Map<Models.CoreModels.Viewed, Models.DataModels.VIEWED>(newView);
                db.VIEWEDs.Add(newDataView);
                return true;
            }
            return false;
        }

        public Boolean IncreaseVotes(Models.CoreModels.Voted newVote)
        {
            Boolean isVoted = false;
            List<Models.DataModels.VOTED> DataVoteList = db.VOTEDs.ToList();
            DataVoteList.ForEach(dataVoteItem =>
            {
                if (dataVoteItem.UserId == newVote.UserId && dataVoteItem.QuestionId == newVote.QuestionId)
                {
                    isVoted = true;
                }
            });
            if (!isVoted)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Models.CoreModels.Voted, Models.DataModels.VOTED>();
                });
                IMapper mapper = config.CreateMapper();
                Models.DataModels.VOTED newDataVote = mapper.Map<Models.CoreModels.Voted, Models.DataModels.VOTED>(newVote);
                db.VOTEDs.Add(newDataVote);
                return true;
            }
            return false;
        }



    }
}