using System;
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
    public class DynamoDbGateway : IDynamoDbGateway
    {
        private readonly IDynamoDBContext _dynamoDbContext;
        private readonly ILogger<DynamoDbGateway> _logger;


        public DynamoDbGateway(IDynamoDBContext dynamoDbContext, ILogger<DynamoDbGateway> logger)
        {
            _dynamoDbContext = dynamoDbContext;
            _logger = logger;
        }

        public async Task<EstimateAndActuals> GetByIdAsync(Guid id)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.LoadAsync for id parameter {id}");

            var result = await _dynamoDbContext.LoadAsync<EstimateAndActualsDbEntity>(id).ConfigureAwait(false);
            return result?.ToDomain();
        }

        public Task<List<EstimateAndActuals>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddAsync(EstimateAndActuals dbEntity)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.SaveAsync for Adding {dbEntity}");

            await _dynamoDbContext.SaveAsync<EstimateAndActualsDbEntity>(dbEntity.ToDatabase()).ConfigureAwait(false);
        }

        public async Task EditAsync(EstimateAndActuals dbEntity)
        {
            _logger.LogDebug($"Calling IDynamoDBContext.SaveAsync for Updating {dbEntity}");

            await _dynamoDbContext.SaveAsync<EstimateAndActualsDbEntity>(dbEntity.ToDatabase()).ConfigureAwait(false);
        }
    }
}
