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
    [System.Web.Http.RoutePrefix("question")]
    public class QuestionController : ApiController
    {
        public IQuestionService QuestionService { get; set; }
        public QuestionController(IQuestionService questionService)
        {
            this.QuestionService = questionService;
        }

        [System.Web.Http.Route("get")]
        public IHttpActionResult Get()
        {
            IEnumerable<QuesView> Questions = QuestionService.GetQuestionView();
            if(Questions.Count() == 0)
            {
                return NotFound();
            }
            return Ok(Questions);
        }

        [System.Web.Http.Route("add")]
        public Boolean Add(Models.CoreModels.Question newQuestion)
        {
            return QuestionService.AddQuestion(newQuestion);
        }


        [System.Web.Http.Route("increasevotes")]
        public Boolean IncreaseVotes(Models.CoreModels.Voted newVote)
        {
            return QuestionService.IncreaseVotes(newVote);
        }

        [System.Web.Http.Route("increaseviews")]
        public Boolean IncreaseViews(Models.CoreModels.Viewed newView)
        {
            return QuestionService.IncreaseViews(newView);
        }
    }
}