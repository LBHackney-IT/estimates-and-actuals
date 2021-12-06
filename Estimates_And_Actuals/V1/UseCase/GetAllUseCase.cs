using Estimates_And_Actuals.V1.Boundary.Response;
using Estimates_And_Actuals.V1.Factories;
using Estimates_And_Actuals.V1.Gateways;
using Estimates_And_Actuals.V1.UseCase.Interfaces;
using Hackney.Core.Logging;

namespace Estimates_And_Actuals.V1.UseCase
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
