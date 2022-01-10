using System;

namespace EstimatesAndActuals.V1.Boundary
{
    public class EstimateAndActualsBaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        ///     afc58c24-dbb4-4c11-a652-f5fd90e6b21e
        /// </example>
        public Guid ChargesListId { get; set; }
        public string ChargeName { get; set; }
        public string ChargeCode { get; set; }
        public int EstimateYear { get; set; }

    }
}
