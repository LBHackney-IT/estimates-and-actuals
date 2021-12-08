using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Gateways;
using EstimatesAndActuals.V1.UseCase.Interfaces;
using Hackney.Core.Logging;

namespace EstimatesAndActuals.V1.UseCase
{
    //TODO: Rename class name and interface name to reflect the entity they are representing eg. GetAllClaimantsUseCase
    public class GetAllUseCase : IGetAllUseCase
    {
        private readonly IExampleGateway _gateway;
        public GetAllUseCase(IExampleGateway gateway)
        {
            _gateway = gateway;
        }
        [LogCall]
        public ResponseObjectList Execute()
        {
            return new ResponseObjectList { ResponseObjects = _gateway.GetAll().ToResponse() };
        }
    }
}
