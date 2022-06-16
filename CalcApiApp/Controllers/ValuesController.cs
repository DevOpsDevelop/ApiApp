using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCalcClassLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalcApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Calc myCalc = new Calc();

        // GET: api/<ValuesController>
        [HttpGet("/average")]
        public int Average([FromQuery]int[]nums)
        {
            return myCalc.Average(nums);
        }

        [HttpGet("/smallest")]
        public int Smallest([FromQuery]int[]nums)
        {
            return myCalc.Smallest(nums);
        }

        [HttpGet("/largest")]
        public int Largest([FromQuery]int[]nums)
        {
            return myCalc.Largest(nums);
        }
    }
}
