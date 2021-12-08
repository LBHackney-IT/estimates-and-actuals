using System.Collections.Generic;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Infrastructure;

namespace EstimatesAndActuals.V1.Gateways
{
    //TODO: Rename to match the data source that is being accessed in the gateway eg. MosaicGateway
    public class ExampleGateway : IExampleGateway
    {
        private readonly DatabaseContext _databaseContext;

        public ExampleGateway(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public EstimateAndActuals GetEntityById(int id)
        {
            var result = _databaseContext.DatabaseEntities.Find(id);

            return result?.ToDomain();
        }

        public List<EstimateAndActuals> GetAll()
        {
            return new List<EstimateAndActuals>();
        }
    }
}
