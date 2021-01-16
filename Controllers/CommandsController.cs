namespace  Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {
         
         // two different endpoints 

        // GET api/commands
         [HttpGet]
         public ActionResult <IEnumerable<Command>> GetAllCommands(){


         }


    // GET api/commands/{id}
        [HttpGet("{id}")]
         public ActionResult <Command> GetCommandById(int id){

         }


    }

    }
}