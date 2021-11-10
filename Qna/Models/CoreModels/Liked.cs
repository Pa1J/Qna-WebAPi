using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Liked
    {
        public int Id { get; set; }
        public Nullable<int> LikedBy { get; set; }
        public Nullable<int> AnswerId { get; set; }
        public Nullable<byte> IsLiked { get; set; }
        public System.DateTime LikedOn { get; set; }
    }
}