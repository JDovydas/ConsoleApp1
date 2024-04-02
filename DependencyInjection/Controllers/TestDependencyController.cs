using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDependencyController : Controller
    {
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly ITestService _testService;
    }

    //public TestDependencyController(IMyScopedService myScopedService, IMySingletonService mySingletonService, ITestService testService)
    //{
    //    _scopedService = myScopedService;
    //    _singletonService = mySingletonService;
    //    _testService = testService;
    //}

    //public object GetServicesGuid()
    //{
    //    object result = new
    //    {

    //        runOne = new
    //        {
    //            scoped = _scopedService.GetGuid(),
    //            singleton = _singletonService.GetGuid()
    //        },

    //        runTwo = new
    //        {
    //            scoped = _scopedService.GetGuid(),
    //            singleton = _singletonService.GetGuid()
    //        }
    //    }
    //}
}
