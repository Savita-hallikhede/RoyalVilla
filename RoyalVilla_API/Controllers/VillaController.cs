using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoyalVilla_API.Controllers
{
    [ApiController]
    [Route("api/villas")] //Controller level route
    public class VillaController : ControllerBase
    {
       // [HttpGet]
       // [Route("GetVillas")] //Action level route
        //public string getVillas()
        //{
        //    return "This is a GET request for Villas";
        //}

        [HttpGet("{id}")]
        public string GetVillaById(int id)
        {
            return "This is a GET request for a specific Villa by ID" +id; 
        }



        [HttpPost]
        public string GetVillaByIdAndName([FromForm]int id, [FromForm]string name)
        {
            return "This is a GET request for a specific Villa by ID and Name " + id + " : " + name;
            
        }

    }
}
