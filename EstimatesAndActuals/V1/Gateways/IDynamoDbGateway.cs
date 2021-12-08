using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EstimatesAndActuals.V1.Domain;

namespace EstimatesAndActuals.V1.Gateways
{
    public interface IDynamoDbGateway
    {
        public Task<EstimateAndActuals> GetByIdAsync(Guid id);

        public Task<List<EstimateAndActuals>> GetAllAsync();

        public Task AddAsync(EstimateAndActuals domain);
        public Task EditAsync(EstimateAndActuals domain);
    }
}
