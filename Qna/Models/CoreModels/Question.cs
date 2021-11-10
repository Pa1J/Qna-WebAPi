using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Question
    {
        public int Id { get; set; }
        public Nullable<int> QuestionedBy { get; set; }
        public string Statement { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategeoryId { get; set; }
        public Nullable<System.DateTime> QuestionedOn { get; set; }
        public Nullable<int> IsResolved { get; set; }
    }
}