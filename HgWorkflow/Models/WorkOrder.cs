using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HgWorkflow.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Work-order no. :")]
        public string WorkOrderId { get; set; }

        [Display(Name = "Gold-Smith :")]
        public string GoldSmithName { get; set; }

        [Required(ErrorMessage = "Customer Name required")]
        [Display(Name = "Customer Name :")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Customer contact number required")]
        [Display(Name = "Contact Number :")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        public string CustomerMobileNumber { get; set; }

        [Display(Name = "Email Address :")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }


        [Display(Name = "Jewellery (1) :")]
        public string JewelleryDescription1 { get; set; }

        [Display(Name = "Jewellery (2) :")]
        public string JewelleryDescription2 { get; set; }

        [Display(Name = "Jewellery (3) :")]
        public string JewelleryDescription3 { get; set; }


        [Display(Name = "To be done (1) :")]
        public string WorkToBeDone { get; set; }

        [Display(Name = "To be done (2) :")]
        public string WorkToBeDone2 { get; set; }

        [Display(Name = "To be done (3) :")]
        public string WorkToBeDone3 { get; set; }


        [Display(Name = "Sales person :")]
        public string AgentName { get; set; }

        [Required(ErrorMessage = "Jewellery given on required")]
        [Display(Name = "Given On :")]
      
        public DateTime ProductGivenOn { get; set; }


        [Required(ErrorMessage = "Date proposed required")]
        [Display(Name = "Date Proposed :")]
   
        public DateTime DateProposed { get; set; }


        [Display(Name = "Accepted/ Rejected On:")]
       public DateTime? DateAcceptedOrRejected { get; set; }

        [Display(Name = "To be returned on :")]
       public DateTime? ProductToBeReturnedOn { get; set; }

        [Display(Name = "Amount :")]

        public int? AmountToBeCollected { get; set; }

        [Display(Name = "Estimate :")]

        public int AmountEstimate { get; set; }

        [Display(Name = "Status :")]


        public string Status { get; set; }

        [Display(Name = "Comments :")]

        public string Comments { get; set; }
    }
}