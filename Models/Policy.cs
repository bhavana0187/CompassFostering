using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompassFostering.Models
{
    public enum PolicyStatus
    {
        /// <summary>
        /// Policy start date is in the future
        /// </summary>
        Not_Begun,
        /// <summary>
        /// Policy is between its start and end dates
        /// </summary>
        On_Risk,
        /// <summary>
        /// Policy end date has passed
        /// </summary>
        Expired,
        /// <summary>
        /// Policy has been cancelled
        /// </summary>
        Cancelled
    };

    public class Policy
    {      
            public long SaleId { get; set; }
            public PolicyStatus PolicyStatus { get; set; }
            public string ProductCode { get; set; }
            public string CancellationNotes { get; set; }
            public long PolicyNumber { get; set; }
            /// <summary>
            /// Product.Code
            /// </summary>
            public string PolicyNumberPrefix { get; set; }
            /// <summary>
            /// Policy.PolicyNumberPrefix + PolicyNumber
            /// </summary>
            public string PolicyNumberFull { get; set; }       
    }
}
