using System.Collections.Generic;
using Estimates_And_Actuals.V1.Domain;

namespace Estimates_And_Actuals.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
