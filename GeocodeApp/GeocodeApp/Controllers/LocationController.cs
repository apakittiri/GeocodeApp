// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GeocodeApp.Api.Models;

namespace GeocodeApp.Api
{
    public partial class LocationController : ILocationController
    {

		/// <summary>
		/// Get address with geocode points using Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns>LocationIdGetOKResponseContent</returns>
        public async Task<IHttpActionResult> Get([FromUri] string id)
        {
            // TODO: implement Get - route: location/{id}
			// var result = new LocationIdGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get current weather for the location
		/// </summary>
		/// <param name="id"></param>
		/// <returns>LocationIdWeatherCurrentGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetCurrent([FromUri] string id)
        {
            // TODO: implement GetCurrent - route: location/{id}/weather/current
			// var result = new LocationIdWeatherCurrentGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get current weather for the location
		/// </summary>
		/// <param name="id"></param>
		/// <returns>LocationIdWeatherForcastGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetForcast([FromUri] string id)
        {
            // TODO: implement GetForcast - route: location/{id}/weather/forcast
			// var result = new LocationIdWeatherForcastGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get location by address
		/// </summary>
		/// <param name="country"></param>
		/// <param name="statecode"></param>
		/// <param name="postalcode"></param>
		/// <param name="city"></param>
		/// <param name="streetaddress"></param>
		/// <returns>LocationAddressCountryStatecodePostalcodeCityStreetaddressGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetAddressByCountryStatecodePostalcodeCityStreetaddress([FromUri] string country,[FromUri] string statecode,[FromUri] string postalcode,[FromUri] string city,[FromUri] string streetaddress)
        {
            // TODO: implement GetAddressByCountryStatecodePostalcodeCityStreetaddress - route: location/address/{country}/{statecode}/{postalcode}/{city}/{streetaddress}
			// var result = new LocationAddressCountryStatecodePostalcodeCityStreetaddressGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get location by points
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>LocationPointsLatitudeLongitudeGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetPointsByLatitudeLongitude([FromUri] string latitude,[FromUri] string longitude)
        {
            // TODO: implement GetPointsByLatitudeLongitude - route: location/points/{latitude}/{longitude}
			// var result = new LocationPointsLatitudeLongitudeGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

    }
}
