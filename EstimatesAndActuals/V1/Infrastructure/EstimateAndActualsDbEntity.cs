using Amazon.DynamoDBv2.DataModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using EstimatesAndActuals.V1.Domain;
using Hackney.Core.DynamoDb.Converters;

namespace EstimatesAndActuals.V1.Infrastructure
{
    [Table("EstimatesAndActuals")]
    [DynamoDBTable("EstimatesAndActuals", LowerCamelCaseProperties = true)]
    public class EstimateAndActualsDbEntity
    {
        [DynamoDBHashKey]
        [DynamoDBProperty(AttributeName = "id")]
        public Guid Id { get; set; }
        [DynamoDBProperty(AttributeName = "charges_list_id")]
        public Guid ChargesListId { get; set; }
        [DynamoDBProperty(AttributeName = "charge_name")]
        public string ChargeName { get; set; }
        [DynamoDBProperty(AttributeName = "estimated_total")]
        public decimal EstimatedTotal { get; set; }
        [DynamoDBProperty(AttributeName = "is_apportioned", Converter = typeof(DynamoDbBoolConverter))]
        public bool IsApportioned { get; set; }
        [DynamoDBProperty(AttributeName = "notes")]
        public Notes Notes { get; set; }
        [DynamoDBProperty(AttributeName = "is_manager_approved", Converter = typeof(DynamoDbBoolConverter))]
        public bool IsManagerApproved { get; set; }
        [DynamoDBProperty(AttributeName = "manager_approver_name")]
        public string ManagerApproverName { get; set; }
        [DynamoDBProperty(AttributeName = "manager_approved_at", Converter = typeof(DynamoDbDateTimeConverter))]
        public DateTime ManagerApprovedAt { get; set; }
        [DynamoDBProperty(AttributeName = "is_finance_approved", Converter = typeof(DynamoDbBoolConverter))]
        public bool IsFinanceApproved { get; set; }
        [DynamoDBProperty(AttributeName = "finance_approved_at", Converter = typeof(DynamoDbDateTimeConverter))]
        public DateTime FinanceApprovedAt { get; set; }
        [DynamoDBProperty(AttributeName = "fiance_approver_name")]
        public string FianceApproverName { get; set; }
        [DynamoDBProperty(AttributeName = "is_head_approved", Converter = typeof(DynamoDbBoolConverter))]
        public bool IsHeadApproved { get; set; }
        [DynamoDBProperty(AttributeName = "head_approver_name")]
        public string HeadApproverName { get; set; }
        [DynamoDBProperty(AttributeName = "head_approved_at", Converter = typeof(DynamoDbDateTimeConverter))]
        public DateTime HeadApprovedAt { get; set; }
        [DynamoDBProperty(AttributeName = "estimate_year")]
        public int EstimateYear { get; set; }
        [DynamoDBProperty(AttributeName = "created_at", Converter = typeof(DynamoDbDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
        [DynamoDBProperty(AttributeName = "created_by")]
        public string CreatedBy { get; set; }
        [DynamoDBProperty(AttributeName = "last_updated_by")]
        public string LastUpdatedBy { get; set; }
        [DynamoDBProperty(AttributeName = "last_updated_at", Converter = typeof(DynamoDbDateTimeConverter))]
        public DateTime LastUpdatedAt { get; set; }
    }
}
