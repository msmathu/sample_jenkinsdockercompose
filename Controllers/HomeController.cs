using HelloWorld.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly HelloWorldDpContext _context;

        public HomeController(HelloWorldDpContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("addData")]
        public IActionResult PostData([FromBody] string inputData)
        {

            var data = new Datas
            {
                InputData = inputData
            };

            _context.Datas.Add(data);

            _context.SaveChanges();

            return Ok(new { Result = inputData });

        }





        [HttpGet]
        [Route("getData")]
        public IActionResult GetData()
        {



            var data = _context.Datas.ToList();

            return Ok(data);

        }

    }
}
