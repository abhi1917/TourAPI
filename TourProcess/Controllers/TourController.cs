using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourProcess.Controllers
{
    public class TourController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            var url = ConfigurationManager.AppSettings["TourAvailabilityUrl"].ToString();
            HttpClient client = new HttpClient();
            try
            {
                return client.GetAsync(url).Result;
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,ex.Message);
            }
        }
    }
}
