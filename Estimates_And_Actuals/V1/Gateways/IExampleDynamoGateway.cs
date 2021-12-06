using Estimates_And_Actuals.V1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimates_And_Actuals.V1.Gateways
{
    public interface IExampleDynamoGateway
    {
        List<Entity> GetAll();
        Task<Entity> GetEntityById(int id);

    }
}
