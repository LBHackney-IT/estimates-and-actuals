using System;
using System.Threading.Tasks;
using EstimatesAndActuals.V1.Boundary.Response;

namespace EstimatesAndActuals.V1.UseCase.Interfaces
{
    public interface IGetByIdUseCase
    {
        public Task<EstimatesAndActualsResponse> ExecuteAsync(Guid id);
    }
}
