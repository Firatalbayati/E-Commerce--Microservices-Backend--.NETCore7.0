using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Service.Discount.Services;
using MyCourse.Shared.ControllerBases;
using MyCourse.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Discounts : CustomBaseController
    {
        private readonly IDiscountService _discountService;

        private readonly ISharedIdentityService _sharedIdentityService;

        public Discounts(IDiscountService discountService, ISharedIdentityService sharedIdentityService)
        {
            _discountService = discountService;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResultInstance(await _discountService.GetAll());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var discount = await _discountService.GetById(id);

            return CreateActionResultInstance(discount);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Models.Discount discount)
        {
            return CreateActionResultInstance(await _discountService.Create(discount));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Models.Discount discount)
        {
            return CreateActionResultInstance(await _discountService.Update(discount));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResultInstance(await _discountService.Delete(id));
        }

        [HttpGet("GetByCode")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var userId = _sharedIdentityService.GetUserId;
            var discount = await _discountService.GetByCodeAndUserId(code, userId);

            return CreateActionResultInstance(discount);
        }
    }
}
