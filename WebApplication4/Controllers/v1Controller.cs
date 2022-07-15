using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplication4.Interface;

namespace WebApplication4.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class v1Controller : ControllerBase
    {
        private readonly IMath _math;
        public v1Controller(IMath math)
        {
            _math = math;   
        }

        [HttpGet]
       
        [Route("addition")]
        public ActionResult<int> addition(int x, int y)
        {
           int c= _math.add(x, y);

            return Ok(c);

        }

        [HttpGet]
        [Route("subration")]
        public ActionResult<int> subraction(int x, int y)
        {
            int c = _math.subtract(x, y);

            return Ok(c);
        }

        [HttpGet]
        [Route("multiplication")]
        public ActionResult<int> getmultiplication(int x , int y)
        {
            int c = _math.multiply(x, y);
            return Ok(c);
        }

        [HttpGet]
        [Route("divide")]
        public ActionResult<int> getdivide(int x, int y)
        {
            double c = _math.divide(x, y);
            return Ok(c);
        }
    }
}
