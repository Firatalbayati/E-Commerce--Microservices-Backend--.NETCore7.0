using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Shared.ControllerBases;
using MyCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.FakePayment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {

        [HttpPost("ReceivePayment")]
        public IActionResult ReceivePayment()
        {
            return CreateActionResultInstance(Shared.Dtos.Response<NoContent>.Success(200));
        }

    }
}
