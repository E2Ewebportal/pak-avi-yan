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
    
    public partial class EndClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EndClient()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int EndClientID { get; set; }
        public string EndClientBusinessName { get; set; }
        public string EmployeeTitleAtEndClientSite { get; set; }
        public string EndClientAddress1 { get; set; }
        public string EndClientAddress2 { get; set; }
        public string EndClientCity { get; set; }
        public string EndClientState { get; set; }
        public string EndClientzip { get; set; }
        public string EndClientPhoneNumber { get; set; }
        public string EndClientExtn { get; set; }
        public string EmployeeEmailAtEndClient { get; set; }
        public string SupervisorNameAtEndClient { get; set; }
        public string SupervisorTitleAtEndClient { get; set; }
        public string SupervisorAddress1 { get; set; }
        public string SupervisorAddress2 { get; set; }
        public string SupervisorCity { get; set; }
        public string SupervisorState { get; set; }
        public string Supervisorzip { get; set; }
        public string SupervisorPhoneNumber { get; set; }
        public string SupervisorExtn { get; set; }
        public string SupervisorEmail { get; set; }
        public string Active { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public int EmployerID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Business Business { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}