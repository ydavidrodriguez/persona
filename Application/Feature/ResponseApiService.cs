using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Persona.Application.Dto;

namespace Persona.Application.Feature
{
    public class ResponseApiService
    {
        public static IActionResult Response(int Statuscode, object Data = null, string message = null)
        {
            bool success = false;

            if (Statuscode >= 200 && Statuscode < 300)
                success = true;

            var result = new BaseResponseModel
            {

                StatusCode = Statuscode,
                Succes = success,
                Message = message,
                Data = Data
            };
            return new OkObjectResult(result);

        }

    }
}
