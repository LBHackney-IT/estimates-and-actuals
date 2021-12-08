using System;

namespace EstimatesAndActuals.V1.Domain
{
    public class EstimateAndActuals
    {
        public Guid Id { get; set; }
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
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
