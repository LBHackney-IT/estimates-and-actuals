using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimatesAndActuals.V1.Boundary.Interface
{
    interface IEstimateAndActualsModelWithId
    {
        public Guid Id { get; set; }
    }
}
