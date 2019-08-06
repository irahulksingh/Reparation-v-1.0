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

        public int WorkOrderId { get; set; }

        public string GoldSmithName { get; set; }

        public string CustomerName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string CustomerMobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        public string JewelleryDescription1 { get; set; }
        public string JewelleryDescription2 { get; set; }
        public string JewelleryDescription3 { get; set; }

        public string WorkToBeDone { get; set; }
        public string WorkToBeDone2 { get; set; }
        public string WorkToBeDone3 { get; set; }

        public string AgentName { get; set; }

        public DateTime ProductGivenOn { get; set; }

        public DateTime DateProposed { get; set; }

        public DateTime DateAcceptedOrRejected { get; set; }

        public DateTime ProductToBeReturnedOn { get; set; }

        public int AmountToBeCollected { get; set; }

        public int AmountEstimate { get; set; }

        public string Status { get; set; }
    }
}