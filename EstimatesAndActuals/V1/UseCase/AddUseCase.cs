using System;
using System.Threading.Tasks;
using EstimatesAndActuals.V1.Boundary.Request;
using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Gateways;
using EstimatesAndActuals.V1.UseCase.Interfaces;

namespace EstimatesAndActuals.V1.UseCase
{
    public class AddUseCase: IAddUseCase
    {
        private readonly IDynamoDbGateway _gateway;

        public AddUseCase(IDynamoDbGateway gateway)
        {
            _gateway = gateway;
        }
        public async Task<EstimatesAndActualsResponse> ExecuteAsync(EstimatesAndActualsAddRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            DateTime curDate = DateTime.UtcNow;
            var domain = request.ToDomain();

            domain.LastUpdatedAt = curDate;
            domain.CreatedAt = curDate;

            await _gateway.AddAsync(domain).ConfigureAwait(false);
            return domain.ToResponse();
        }
    }
}
