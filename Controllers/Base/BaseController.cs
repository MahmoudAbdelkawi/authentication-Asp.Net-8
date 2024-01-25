using CRUD_Operations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CRUD_Operations.Controllers.Base
{
    public class BaseController : ControllerBase
    {

        protected IActionResult Result<T>(Response<T> response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return new OkObjectResult(response);
                case HttpStatusCode.Created:
                    return new CreatedResult(string.Empty, response);
                case HttpStatusCode.Unauthorized:
                    return new UnauthorizedObjectResult(response);
                case HttpStatusCode.BadRequest:
                    return new BadRequestObjectResult(response);
                case HttpStatusCode.NotFound:
                    return new NotFoundObjectResult(response);
                case HttpStatusCode.Accepted:
                    return new AcceptedResult(string.Empty, response);
                case HttpStatusCode.UnprocessableEntity:
                    return new UnprocessableEntityObjectResult(response);
                case HttpStatusCode.UnsupportedMediaType:
                    var BadRequestObjectResult = new BadRequestObjectResult(response);
                    BadRequestObjectResult.StatusCode = (int)HttpStatusCode.UnsupportedMediaType;
                    return BadRequestObjectResult;
                default:
                    return new BadRequestObjectResult(response);
            }
        }
    }
}
