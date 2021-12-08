using EstimatesAndActuals.V1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimatesAndActuals.V1.Gateways
{
    public interface IExampleDynamoGateway
    {
        List<EstimateAndActuals> GetAll();
        Task<EstimateAndActuals> GetEntityById(int id);

    }
}
