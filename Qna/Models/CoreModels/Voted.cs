using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Voted
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public System.DateTime VotedOn { get; set; }
    }
}