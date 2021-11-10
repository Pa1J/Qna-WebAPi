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
    [System.Web.Http.RoutePrefix("answer")]
    public class AnswerController : ApiController
    {
        public IAnswerService AnswerService { get; set; }
        public AnswerController(IAnswerService answerService)
        {
            this.AnswerService = answerService;
        }



        [System.Web.Http.Route("get")]
        public IHttpActionResult Get()
        {
            IEnumerable<AnswerView> Answers = AnswerService.GetAnswerView();
            if(Answers.Count() == 0)
            {
                return NotFound();
            }

            return Ok(Answers);
        }

        [System.Web.Http.Route("add")]
        public Boolean Add(Models.CoreModels.Answer newAnswer)
        {
            return AnswerService.AddAnswer(newAnswer);
        }

        [System.Web.Http.Route("like")]
        public Boolean Like(Models.CoreModels.Liked newLike)
        {
            return AnswerService.LikeAnswer(newLike);
        }

        [System.Web.Http.Route("bestsolution")]
        public Boolean BestSolution(Models.CoreModels.Answer bestAnswer)
        {
            return AnswerService.ChangeBestSolution(bestAnswer);
        }
    }
}