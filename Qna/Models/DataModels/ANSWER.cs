//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qna.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class ANSWER
    {
        public int Id { get; set; }
        public Nullable<int> AnsweredBy { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public string Description { get; set; }
        public System.DateTime AnsweredOn { get; set; }
        public Nullable<byte> IsBestSolution { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    }
}
