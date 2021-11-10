using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Qna.Models.DataModels;
using Qna.Models.CoreModels;

namespace Qna.Controllers
{
    public class QnaController : Controller
    {
        readonly QnaDBEntities db = new QnaDBEntities();
        // GET: Qna
        public ActionResult GetCategories()
        {
            
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.CATEGEORY, Models.CoreModels.Category>();
            });
            IMapper mapper = config.CreateMapper();
            List<Models.DataModels.CATEGEORY> Lst = db.CATEGEORies.ToList();
            List<Models.CoreModels.Category> lst = new List<Models.CoreModels.Category>();
            Lst.ForEach(LstItem =>
           {
               var lstItem = mapper.Map<Models.DataModels.CATEGEORY,Models.CoreModels.Category>(LstItem);
               lst.Add(lstItem);
           });
            return View(lst);
        }
        public ActionResult GetQuestions()
        {
            IEnumerable<Models.DataModels.QUESTION> lst = db.QUESTIONs;
            return View(lst);
        }
        public ActionResult GetUsers()
        {
            IEnumerable<Models.DataModels.USER> lst = db.USERS;
            return View(lst);
        }
        public ActionResult GetAnswers()
        {
            IEnumerable<Models.DataModels.ANSWER> lst = db.ANSWERs;
            return View(lst);
        }
        public ActionResult GetViewAnswers()
        {
            IEnumerable<Models.DataModels.AnswerView> lst = db.AnswerViews;
            return View(lst);
        }
        public ActionResult GetViewQuestions()
        {
            IEnumerable<QuestionView> lst = db.QuestionViews;
            return View(lst);
        }
        public ActionResult GetViewCategories()
        {
            IEnumerable<CategoryView> lst = db.CategoryViews;
            return View(lst);
        }
        public ActionResult GetViewUsers()
        {
            IEnumerable<Models.DataModels.UserView> lst = db.UserViews;
            return View(lst);
        }
    }
}