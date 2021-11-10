using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class UsersView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string proPicUrl { get; set; }
        public Nullable<int> questionsAsked { get; set; }
        public Nullable<int> questionsAnswered { get; set; }
        public Nullable<int> questionsSolved { get; set; }
        public Nullable<int> likes { get; set; }
        public Nullable<int> dislikes { get; set; }
    }
}