using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using TopSpots.Models;
using Newtonsoft.Json;


namespace TopSpots.Controllers
{
    public class TopSpotsController : ApiController
    {
        [HttpGet, Route("api/topspots")]
        public IHttpActionResult GetTopSpots()
        {
            string topspots = File.ReadAllText("C:\\dev\\TopSpots\\TopSpots\\TopSpots.json");

            TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(topspots);


            

            //topspots = JsonConvert.SerializeObject(topSpotsArray);

            //File.WriteAllText("C:\\dev\\TopSpots\\TopSpots\\TopSpots.json", topspots);

            return Ok(topSpotsArray);
        }
    }
}
