using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class QuesView
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsResolved { get; set; }
        public Nullable<int> QuestionedBy { get; set; }
        public Nullable<System.DateTime> QuestionedOn { get; set; }
        public string ProPicUrl { get; set; }
        public Nullable<int> Votes { get; set; }
        public Nullable<int> Viewers { get; set; }
        public Nullable<int> Answers { get; set; }
    }
}