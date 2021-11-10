using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class AnswerView
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public System.DateTime AnsweredOn { get; set; }
        public Nullable<byte> IsBestSolution { get; set; }
        public string AnsweredUserName { get; set; }
        public string proPicUrl { get; set; }
    }
}