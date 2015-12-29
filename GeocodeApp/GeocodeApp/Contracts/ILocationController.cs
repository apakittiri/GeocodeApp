// Template: Controller Interface (ApiControllerInterface.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GeocodeApp.Api.Models;


namespace GeocodeApp.Api
{
    public interface ILocationController
    {

        Task<IHttpActionResult> Get([FromUri] string id);
        Task<IHttpActionResult> GetCurrent([FromUri] string id);
        Task<IHttpActionResult> GetForcast([FromUri] string id);
        Task<IHttpActionResult> GetAddressByCountryStatecodePostalcodeCityStreetaddress([FromUri] string country,[FromUri] string statecode,[FromUri] string postalcode,[FromUri] string city,[FromUri] string streetaddress);
        Task<IHttpActionResult> GetPointsByLatitudeLongitude([FromUri] string latitude,[FromUri] string longitude);
    }
}
