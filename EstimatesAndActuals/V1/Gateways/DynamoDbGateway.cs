using Amazon.DynamoDBv2.DataModel;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Infrastructure;
using Hackney.Core.Logging;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstimatesAndActuals.V1.Gateways
{
    public class DynamoDbGateway : IExampleDynamoGateway
    {
        private readonly IDynamoDBContext _dynamoDbContext;
        private readonly ILogger<DynamoDbGateway> _logger;


        public DynamoDbGateway(IDynamoDBContext dynamoDbContext, ILogger<DynamoDbGateway> logger)
        {
            _dynamoDbContext = dynamoDbContext;
            _logger = logger;
        }

        public List<EstimateAndActuals> GetAll()
        {
            return new List<EstimateAndActuals>();
        }

        [LogCall]
        public async Task<EstimateAndActuals> GetEntityById(int id)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.LoadAsync for id parameter {id}");

            var result = await _dynamoDbContext.LoadAsync<DatabaseEntity>(id).ConfigureAwait(false);
            return result?.ToDomain();
        }
    }
}
