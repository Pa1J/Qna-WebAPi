using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Services;

namespace Qna.Controllers
{
    public class ServiceController : Controller
    {
        QuestionService questionService = new QuestionService();

        // GET: Service
        public ActionResult GetQuestions()
        {
            return View(this.questionService.GetQuestionView());
        }
    }
}