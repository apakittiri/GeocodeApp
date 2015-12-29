// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GeocodeApp.Api.Models;


namespace GeocodeApp.Api
{
    public interface IWeatherController
    {

        Task<IHttpActionResult> Get([FromUri] string latitude,[FromUri] string longitude);
        Task<IHttpActionResult> GetForcast([FromUri] string latitude,[FromUri] string longitude);
        Task<IHttpActionResult> GetHistory([FromUri] string latitude,[FromUri] string longitude);
        Task<IHttpActionResult> GetByPostalcode([FromUri] string postalcode);
        Task<IHttpActionResult> GetA([FromUri] string postalcode);
        Task<IHttpActionResult> GetB([FromUri] string postalcode);
    }
}
