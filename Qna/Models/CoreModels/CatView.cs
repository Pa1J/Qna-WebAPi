using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class CatView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryTagsTotal { get; set; }
        public Nullable<int> CategoryTagsWeek { get; set; }
        public Nullable<int> CategoryTagsMonth { get; set; }
    }
}