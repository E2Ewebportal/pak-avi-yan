//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E2ERepositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskID { get; set; }
        public System.DateTime WeekStartDate { get; set; }
        public System.DateTime WeekEndDate { get; set; }
        public string WeekPeriod { get; set; }
        public System.DateTime TaskCreationDate { get; set; }
        public Nullable<decimal> HoursBilled { get; set; }
        public string TaskDetails { get; set; }
        public string AnyIssues { get; set; }
        public string Solution { get; set; }
        public string PercentCompleted { get; set; }
        public Nullable<System.DateTime> SubmissionDate { get; set; }
        public string TaskContinueFromLastWeekPeriod { get; set; }
        public string TaskContinueToNextWeekPeriod { get; set; }
        public string TaskSubmissionStatus { get; set; }
        public Nullable<int> ReviewerID { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public string ReviewerComments { get; set; }
        public int EmployeeID { get; set; }
        public int EmployerID { get; set; }
        public int EndClientID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ReviewerName { get; set; }
    
        public virtual Business Business { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual EndClient EndClient { get; set; }
    }
}
