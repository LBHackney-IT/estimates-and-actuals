using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimatesAndActuals.V1.Boundary.Interface
{
    interface IEstimateAndActualsModelWithUserLog
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
