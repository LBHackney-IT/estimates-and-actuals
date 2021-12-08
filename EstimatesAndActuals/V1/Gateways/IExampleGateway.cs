using System.Collections.Generic;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Gateways
{
    public interface IExampleGateway
    {
        EstimateAndActuals GetEntityById(int id);

        List<EstimateAndActuals> GetAll();
    }
}
