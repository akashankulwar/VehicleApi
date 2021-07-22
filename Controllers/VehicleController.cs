using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleApi.Repository;
using VehicleApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleRepository _vehicleRepository = null;

        public VehicleController(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        // GET: api/<VehicleController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Vehicle/Getvalues")]
        public IEnumerable<Makes> Getvalues()
        {
            // return new string[] { "value1", "value2" };
           return _vehicleRepository.GetVehicles();
        }

    
        //ignore method GetValueById 
        
        // GET api/<VehicleController>/5
         // [HttpGet("{id}")]
         //[Route("[action]")]
         //[Route("api/Vehicle/GetValueById/{id}")]
        [Route("GetValueById/{id}")]
        public string GetValueById(int id)
        {
            return "value is "+id;
        }

        [Route("makesbyid/{makeid}/{modelId}")]
        public IEnumerable<MakesModels> makesbyid(int makeid,int modelId)
        {
            //  return "make id value is : " + makeid +"Model id value is :" + modelId ;
            return _vehicleRepository.GetVehiclesByMakeIdandModelId(makeid, modelId);
        }


        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
