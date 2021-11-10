using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Viewed
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public System.DateTime ViewedOn { get; set; }
    }
}