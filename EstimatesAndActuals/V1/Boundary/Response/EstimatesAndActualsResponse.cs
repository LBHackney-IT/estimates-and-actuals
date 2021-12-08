using System;
using EstimatesAndActuals.V1.Boundary.Interface;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Boundary.Response
{

    public class EstimatesAndActualsResponse:EstimatesAndActualsBaseModel,IEstimateAndActualsModelWithId
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        ///     afc58c24-dbb4-4c11-a652-f5fd90e6b21e
        /// </example>
        public Guid Id { get; set; }
    }
}
