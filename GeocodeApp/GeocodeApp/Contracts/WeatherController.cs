// Template: Base Controller (ApiControllerBase.t4) version 3.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GeocodeApp.Api.Models;

// Do not modify this file. This code was generated by RAML Web Api 2 Scaffolder

namespace GeocodeApp.Api
{
    [RoutePrefix("weather")]
    public partial class WeatherController : ApiController
    {


        /// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherLatitudeLongitudeGetOKResponseContent))]
        [HttpGet]
        [Route("{latitude}/{longitude}")]
        public virtual async Task<IHttpActionResult> GetBase([FromUri] string latitude,[FromUri] string longitude)
        {
            // Do not modify this code
            return await ((IWeatherController)this).Get(latitude,longitude);
        }

        /// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeForcastGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherLatitudeLongitudeForcastGetOKResponseContent))]
        [HttpGet]
        [Route("{latitude}/{longitude}/forcast")]
        public virtual async Task<IHttpActionResult> GetForcastBase([FromUri] string latitude,[FromUri] string longitude)
        {
            // Do not modify this code
            return await ((IWeatherController)this).GetForcast(latitude,longitude);
        }

        /// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns>WeatherLatitudeLongitudeHistoryGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherLatitudeLongitudeHistoryGetOKResponseContent))]
        [HttpGet]
        [Route("{latitude}/{longitude}/history")]
        public virtual async Task<IHttpActionResult> GetHistoryBase([FromUri] string latitude,[FromUri] string longitude)
        {
            // Do not modify this code
            return await ((IWeatherController)this).GetHistory(latitude,longitude);
        }

        /// <summary>
		/// Get weather information by postalcode
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherPostalcodeGetOKResponseContent))]
        [HttpGet]
        [Route("{postalcode}")]
        public virtual async Task<IHttpActionResult> GetByPostalcodeBase([FromUri] string postalcode)
        {
            // Do not modify this code
            return await ((IWeatherController)this).GetByPostalcode(postalcode);
        }

        /// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeForcastGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherPostalcodeForcastGetOKResponseContent))]
        [HttpGet]
        [Route("{postalcode}/forcast")]
        public virtual async Task<IHttpActionResult> GetABase([FromUri] string postalcode)
        {
            // Do not modify this code
            return await ((IWeatherController)this).GetA(postalcode);
        }

        /// <summary>
		/// Get weather information by gecode points(latitude &amp; longitude)
		/// </summary>
		/// <param name="postalcode"></param>
		/// <returns>WeatherPostalcodeHistoryGetOKResponseContent</returns>
        [ResponseType(typeof(WeatherPostalcodeHistoryGetOKResponseContent))]
        [HttpGet]
        [Route("{postalcode}/history")]
        public virtual async Task<IHttpActionResult> GetBBase([FromUri] string postalcode)
        {
            // Do not modify this code
            return await ((IWeatherController)this).GetB(postalcode);
        }
    }
}
