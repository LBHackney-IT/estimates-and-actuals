using System.Collections.Generic;
using System.Linq;
using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Factories
{
    public static class ResponseFactory
    {
        //TODO: Map the fields in the domain object(s) to fields in the response object(s).
        // More information on this can be found here https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/Factory-object-mappings
        public static ResponseObject ToResponse(this EstimateAndActuals domain)
        {
            return new ResponseObject();
        }

        public static List<ResponseObject> ToResponse(this IEnumerable<EstimateAndActuals> domainList)
        {
            return domainList.Select(domain => domain.ToResponse()).ToList();
        }
    }
}
