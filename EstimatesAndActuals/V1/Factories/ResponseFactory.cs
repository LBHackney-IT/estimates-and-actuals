using System.Collections.Generic;
using System.Linq;
using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Factories
{
    public static class ResponseFactory
    {
        public static EstimatesAndActualsResponse ToResponse(this EstimateAndActuals domain)
        {
            return new EstimatesAndActualsResponse
            {
                Id = domain.Id,
                ChargeName = domain.ChargeName,
                ChargesListId = domain.ChargesListId,
                CreatedAt = domain.CreatedAt,
                CreatedBy = domain.CreatedBy,
                EstimateYear = domain.EstimateYear,
                EstimatedTotal = domain.EstimatedTotal,
                FianceApproverName = domain.FianceApproverName,
                FinanceApprovedAt = domain.FinanceApprovedAt,
                HeadApprovedAt = domain.HeadApprovedAt,
                HeadApproverName = domain.HeadApproverName,
                IsApportioned = domain.IsApportioned,
                IsFinanceApproved = domain.IsFinanceApproved,
                IsHeadApproved = domain.IsHeadApproved,
                IsManagerApproved = domain.IsManagerApproved,
                LastUpdatedAt = domain.LastUpdatedAt,
                LastUpdatedBy = domain.LastUpdatedBy,
                ManagerApprovedAt = domain.ManagerApprovedAt,
                ManagerApproverName = domain.ManagerApproverName,
                Notes = domain.Notes
            };
        }

        public static List<EstimatesAndActualsResponse> ToResponse(this IEnumerable<EstimateAndActuals> domainList)
        {
            return domainList.Select(domain => domain.ToResponse()).ToList();
        }
    }
}
