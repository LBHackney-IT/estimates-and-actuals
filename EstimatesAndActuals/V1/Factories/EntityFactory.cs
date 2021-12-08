using System;
using EstimatesAndActuals.V1.Boundary.Request;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Infrastructure;

namespace EstimatesAndActuals.V1.Factories
{
    public static class EntityFactory
    {
        public static EstimateAndActuals ToDomain(this EstimateAndActualsDbEntity estimatesAndActualsDbEntity)
        {
            return new EstimateAndActuals
            {
                Id = estimatesAndActualsDbEntity.Id,
                CreatedAt = estimatesAndActualsDbEntity.CreatedAt,
                ManagerApprovedAt = estimatesAndActualsDbEntity.ManagerApprovedAt,
                ManagerApproverName = estimatesAndActualsDbEntity.ManagerApproverName,
                ChargeName = estimatesAndActualsDbEntity.ChargeName,
                EstimatedTotal = estimatesAndActualsDbEntity.EstimatedTotal,
                IsApportioned = estimatesAndActualsDbEntity.IsApportioned,
                Notes = estimatesAndActualsDbEntity.Notes,
                IsManagerApproved = estimatesAndActualsDbEntity.IsManagerApproved,
                IsFinanceApproved = estimatesAndActualsDbEntity.IsFinanceApproved,
                IsHeadApproved = estimatesAndActualsDbEntity.IsHeadApproved,
                HeadApproverName = estimatesAndActualsDbEntity.HeadApproverName,
                HeadApprovedAt = estimatesAndActualsDbEntity.HeadApprovedAt,
                EstimateYear = estimatesAndActualsDbEntity.EstimateYear,
                CreatedBy = estimatesAndActualsDbEntity.CreatedBy,
                LastUpdatedBy = estimatesAndActualsDbEntity.LastUpdatedBy,
                LastUpdatedAt = estimatesAndActualsDbEntity.LastUpdatedAt,
                FinanceApprovedAt = estimatesAndActualsDbEntity.FinanceApprovedAt,
                FianceApproverName = estimatesAndActualsDbEntity.FianceApproverName,
                ChargesListId = estimatesAndActualsDbEntity.ChargesListId
            };
        }

        public static EstimateAndActuals ToDomain(this EstimatesAndActualsAddRequest estimatesAndActualsAddRequest)
        {
            return new EstimateAndActuals
            {
                Id = Guid.NewGuid(),
                ManagerApprovedAt = estimatesAndActualsAddRequest.ManagerApprovedAt,
                ManagerApproverName = estimatesAndActualsAddRequest.ManagerApproverName,
                ChargeName = estimatesAndActualsAddRequest.ChargeName,
                EstimatedTotal = estimatesAndActualsAddRequest.EstimatedTotal,
                IsApportioned = estimatesAndActualsAddRequest.IsApportioned,
                Notes = estimatesAndActualsAddRequest.Notes,
                IsManagerApproved = estimatesAndActualsAddRequest.IsManagerApproved,
                IsFinanceApproved = estimatesAndActualsAddRequest.IsFinanceApproved,
                IsHeadApproved = estimatesAndActualsAddRequest.IsHeadApproved,
                HeadApproverName = estimatesAndActualsAddRequest.HeadApproverName,
                HeadApprovedAt = estimatesAndActualsAddRequest.HeadApprovedAt,
                EstimateYear = estimatesAndActualsAddRequest.EstimateYear,
                /*CreatedAt = estimatesAndActualsAddRequest.CreatedAt,
                CreatedBy = estimatesAndActualsAddRequest.CreatedBy,
                LastUpdatedBy = estimatesAndActualsAddRequest.LastUpdatedBy,
                LastUpdatedAt = estimatesAndActualsAddRequest.LastUpdatedAt,*/
                FinanceApprovedAt = estimatesAndActualsAddRequest.FinanceApprovedAt,
                FianceApproverName = estimatesAndActualsAddRequest.FianceApproverName,
                ChargesListId = estimatesAndActualsAddRequest.ChargesListId
            };
        }

        public static EstimateAndActualsDbEntity ToDatabase(this EstimateAndActuals estimatesAndActuals)
        {
            return new EstimateAndActualsDbEntity
            {
                Id = estimatesAndActuals.Id,
                CreatedAt = estimatesAndActuals.CreatedAt,
                ManagerApprovedAt = estimatesAndActuals.ManagerApprovedAt,
                ManagerApproverName = estimatesAndActuals.ManagerApproverName,
                ChargeName = estimatesAndActuals.ChargeName,
                EstimatedTotal = estimatesAndActuals.EstimatedTotal,
                IsApportioned = estimatesAndActuals.IsApportioned,
                Notes = estimatesAndActuals.Notes,
                IsManagerApproved = estimatesAndActuals.IsManagerApproved,
                IsFinanceApproved = estimatesAndActuals.IsFinanceApproved,
                IsHeadApproved = estimatesAndActuals.IsHeadApproved,
                HeadApproverName = estimatesAndActuals.HeadApproverName,
                HeadApprovedAt = estimatesAndActuals.HeadApprovedAt,
                EstimateYear = estimatesAndActuals.EstimateYear,
                CreatedBy = estimatesAndActuals.CreatedBy,
                LastUpdatedBy = estimatesAndActuals.LastUpdatedBy,
                LastUpdatedAt = estimatesAndActuals.LastUpdatedAt,
                FinanceApprovedAt = estimatesAndActuals.FinanceApprovedAt,
                FianceApproverName = estimatesAndActuals.FianceApproverName,
                ChargesListId = estimatesAndActuals.ChargesListId
            };
        }
    }
}
