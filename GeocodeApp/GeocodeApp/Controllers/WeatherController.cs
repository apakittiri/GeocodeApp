// Template: Controller Implementation (ApiControllerImplementation.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GeocodeApp.Api.Models;

namespace GeocodeApp.Api
{
    public partial class WeatherController : IWeatherController
    {

		/// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeGetOKResponseContent</returns>
        public async Task<IHttpActionResult> Get([FromUri] string latitude,[FromUri] string longitude)
        {
            // TODO: implement Get - route: weather/{latitude}/{longitude}
			// var result = new WeatherLatitudeLongitudeGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeForcastGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetForcast([FromUri] string latitude,[FromUri] string longitude)
        {
            // TODO: implement GetForcast - route: weather/{latitude}/{longitude}/forcast
			// var result = new WeatherLatitudeLongitudeForcastGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeHistoryGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetHistory([FromUri] string latitude,[FromUri] string longitude)
        {
            // TODO: implement GetHistory - route: weather/{latitude}/{longitude}/history
			// var result = new WeatherLatitudeLongitudeHistoryGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get weather information by postalcode
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetByPostalcode([FromUri] string postalcode)
        {
            // TODO: implement GetByPostalcode - route: weather/{postalcode}
			// var result = new WeatherPostalcodeGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeForcastGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetA([FromUri] string postalcode)
        {
            // TODO: implement GetA - route: weather/{postalcode}/forcast
			// var result = new WeatherPostalcodeForcastGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

		/// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeHistoryGetOKResponseContent</returns>
        public async Task<IHttpActionResult> GetB([FromUri] string postalcode)
        {
            // TODO: implement GetB - route: weather/{postalcode}/history
			// var result = new WeatherPostalcodeHistoryGetOKResponseContent();
			// return Ok(result);
			return Ok();
        }

    }
}
