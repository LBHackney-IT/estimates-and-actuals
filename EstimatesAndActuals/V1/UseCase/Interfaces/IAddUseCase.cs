using System.Threading.Tasks;
using EstimatesAndActuals.V1.Boundary.Request;
using EstimatesAndActuals.V1.Boundary.Response;

namespace EstimatesAndActuals.V1.UseCase.Interfaces
{
    public interface IAddUseCase
    {
        public Task<EstimatesAndActualsResponse> ExecuteAsync(EstimatesAndActualsAddRequest request);
    }
}
