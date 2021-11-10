using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qna.Models.DataModels;

namespace Qna.Models.CoreModels
{
    public class Answer
    {
        public int Id { get; set; }
        public Nullable<int> AnsweredBy { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public string Description { get; set; }
        public System.DateTime AnsweredOn { get; set; }
        public Nullable<byte> IsBestSolution { get; set; }
    }
}