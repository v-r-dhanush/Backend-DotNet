using Microsoft.AspNetCore.Mvc;
using ReactMakeMyTripApp.Models;

namespace ReactMakeMyTripApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MakeMyTripController : Controller
    {
        private IRepository repository;
        public MakeMyTripController(IRepository rep)
        {
            repository = rep;
        }

        [HttpGet]
        public IEnumerable<ReactMakeMyTrip> Get() => repository.Reservations;

        [HttpGet("{id}")]

        public ActionResult<ReactMakeMyTrip> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("value must be passed in the request body");
            }
            return Ok(repository[id]);
        }

        [HttpPost]

        public ReactMakeMyTrip Post([FromBody] ReactMakeMyTrip mmt) =>
            repository.AddReservation(new ReactMakeMyTrip
            {
                name = mmt.name,
                startlocation = mmt.startlocation,
                endlocation = mmt.endlocation
            });

        [HttpPut]
        public ReactMakeMyTrip Put([FromForm] ReactMakeMyTrip mmt) => repository.UpdateReservation(mmt);

        [HttpDelete("{id}")]

        public void Delete(int id) => repository.DeleteReservation(id);


    }
}
