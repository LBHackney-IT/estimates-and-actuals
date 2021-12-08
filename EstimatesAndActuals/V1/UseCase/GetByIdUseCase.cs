using System;
using System.Threading.Tasks;
using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Gateways;
using EstimatesAndActuals.V1.UseCase.Interfaces;
using Hackney.Core.Logging;

namespace EstimatesAndActuals.V1.UseCase
{

    public class GetByIdUseCase : IGetByIdUseCase
    {
        private readonly IDynamoDbGateway _gateway;
        public GetByIdUseCase(IDynamoDbGateway gateway)
        {
            _gateway = gateway;
        }

        [LogCall]
        public async Task<EstimatesAndActualsResponse> ExecuteAsync(Guid id)
        {
            var data = await _gateway.GetByIdAsync(id).ConfigureAwait(false);
            return data?.ToResponse();
        }
    }
}
