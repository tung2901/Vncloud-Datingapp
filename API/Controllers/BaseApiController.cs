// using API.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    // [ServiceFilter(typeof(LogUserActivity))]
    [Route("API/[controller]")]
    [ApiController]
    public class BaseApiController: ControllerBase
    {
            
    }
}
