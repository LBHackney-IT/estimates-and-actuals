using System;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Boundary
{

    public abstract class EstimatesAndActualsApportionBaseModel
    {
        public Notes Notes { get; set; }
        public bool IsApportioned { get; set; }
        public bool IsManagerApproved { get; set; }
        public string ManagerApproverName { get; set; }
        public DateTime ManagerApprovedAt { get; set; }
        public bool IsFinanceApproved { get; set; }
        public DateTime FinanceApprovedAt { get; set; }
        public string FianceApproverName { get; set; }
        public bool IsHeadApproved { get; set; }
        public string HeadApproverName { get; set; }
        public DateTime HeadApprovedAt { get; set; }
        public decimal EstimatedTotal { get; set; }
    }
}
