//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleInsurance_Employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Feedback
    {
        [Display(Name = "Feedback ID")]
        public int FeedbackID { get; set; }

        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Datetime")]
        public System.DateTime Datetime { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
