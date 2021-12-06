using Estimates_And_Actuals.V1.Boundary.Response;
using Estimates_And_Actuals.V1.UseCase.Interfaces;
using Hackney.Core.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Estimates_And_Actuals.V1.Controllers
{
    [ApiController]
    //TODO: Rename to match the APIs endpoint
    [Route("api/v1/residents")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    //TODO: rename class to match the API name
    public class Estimates_And_ActualsController : BaseController
    {
        private readonly IGetAllUseCase _getAllUseCase;
        private readonly IGetByIdUseCase _getByIdUseCase;
        public Estimates_And_ActualsController(IGetAllUseCase getAllUseCase, IGetByIdUseCase getByIdUseCase)
        {
            _getAllUseCase = getAllUseCase;
            _getByIdUseCase = getByIdUseCase;
        }

        //TODO: add xml comments containing information that will be included in the auto generated swagger docs (https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/Controllers-and-Response-Objects)
        /// <summary>
        /// ...
        /// </summary>
        /// <response code="200">...</response>
        /// <response code="400">Invalid Query Parameter.</response>
        [ProducesResponseType(typeof(ResponseObjectList), StatusCodes.Status200OK)]
        [HttpGet]
        [LogCall(LogLevel.Information)]

        public IActionResult ListContacts()
        {
            return Ok(_getAllUseCase.Execute());
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <response code="200">...</response>
        /// <response code="404">No ? found for the specified ID</response>
        [ProducesResponseType(typeof(ResponseObject), StatusCodes.Status200OK)]
        [HttpGet]
        [LogCall(LogLevel.Information)]
        //TODO: rename to match the identifier that will be used
        [Route("{yourId}")]
        public IActionResult ViewRecord(int yourId)
        {
            return Ok(_getByIdUseCase.Execute(yourId));
        }
    }
}
