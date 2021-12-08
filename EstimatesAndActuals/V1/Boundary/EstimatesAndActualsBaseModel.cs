using System;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Boundary
{

    public abstract class EstimatesAndActualsBaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        ///     afc58c24-dbb4-4c11-a652-f5fd90e6b21e
        /// </example>
        public Guid ChargesListId { get; set; }
        public string ChargeName { get; set; }
        public decimal EstimatedTotal { get; set; }
        public bool IsApportioned { get; set; }
        public Notes Notes { get; set; }
        public bool IsManagerApproved { get; set; }
        public string ManagerApproverName { get; set; }
        public DateTime ManagerApprovedAt { get; set; }
        public bool IsFinanceApproved { get; set; }
        public DateTime FinanceApprovedAt { get; set; }
        public string FianceApproverName { get; set; }
        public bool IsHeadApproved { get; set; }
        public string HeadApproverName { get; set; }
        public DateTime HeadApprovedAt { get; set; }
        public int EstimateYear { get; set; }
    }
}
