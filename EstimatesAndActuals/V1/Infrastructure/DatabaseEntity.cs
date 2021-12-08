using Amazon.DynamoDBv2.DataModel;
using Hackney.Core.DynamoDb.Converters;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Infrastructure
{
    //TODO: rename table and add needed fields relating to the table columns.
    // There's an example of this in the wiki https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/DatabaseContext

    //TODO: Pick the attributes for the required data source, delete the others as appropriate
    // Postgres will use the "Table" and "Column" attributes
    // DynamoDB will use the "DynamoDBTable", "DynamoDBHashKey" and "DynamoDBProperty" attributes

    //TODO: For DynamoDB...
    // * The table name must match that specified in the terraform step that provisions the DynamoDb resource
    // * The name of the hash key property must match that specified in the terraform step that provisions the DynamoDb resource

    [Table("EstimatesAndActuals")]
    [DynamoDBTable("EstimatesAndActuals", LowerCamelCaseProperties = true)]
    public class DatabaseEntity
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
