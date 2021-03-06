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
    
    public partial class Reviewer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reviewer()
        {
            this.UserAccounts = new HashSet<UserAccount>();
            this.TaskReviewComments = new HashSet<TaskReviewComment>();
        }
    
        public int ReviewerID { get; set; }
        public string ReviewerFirstName { get; set; }
        public string ReviewerMiddleName { get; set; }
        public string ReviewerLastName { get; set; }
        public string ReviewerNickName { get; set; }
        public string ReviewerTitle { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Active { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public int RoleID { get; set; }
        public int EmployerID { get; set; }
        public string Extn { get; set; }
    
        public virtual Business Business { get; set; }
        public virtual E2E_UserRole E2E_UserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskReviewComment> TaskReviewComments { get; set; }
    }
}
