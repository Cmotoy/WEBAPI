using System.Collections.Generic;
using DemoApi.Data;
using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    //
    [Route("api/DemoApps")]
    [ApiController]
    public class DemoAppsController : ControllerBase
    {

        private readonly MockDemoRepo _repository = new MockDemoRepo();
        //GET api/DemoApps
        [HttpGet]
        public ActionResult<IEnumerable<DemoApp>> GetAllDemoApps()
        {
            var DemoAppItems = _repository.GetAppDemos();
            return Ok(DemoAppItems);
        }

        //GET api/DemoApps/{id}
        [HttpGet("{id}")]
        public ActionResult <DemoApp> GetDemoAppByid (int Id)
        {
            var DemoAppItem = _repository.GetDemoAppById(Id);
            return Ok(DemoAppItem);
        }
        
    }
}