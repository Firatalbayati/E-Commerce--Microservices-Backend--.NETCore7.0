using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Service.Basket.Dtos;
using MyCourse.Service.Basket.Services;
using MyCourse.Shared.ControllerBases;
using MyCourse.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController
    {

        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet("GetBasket")]
        public async Task<IActionResult> GetBasket()
        {
            return CreateActionResultInstance(await _basketService.GetBasket(_sharedIdentityService.GetUserId));
        }

        [HttpPost("CreateOrUpdateBasket")]
        public async Task<IActionResult> CreateOrUpdateBasket(BasketDto basketDto)
        {
            basketDto.UserId = _sharedIdentityService.GetUserId;
            var response = await _basketService.CreateOrUpdate(basketDto);
            return CreateActionResultInstance(response);
        }

        [HttpDelete("DeleteBasket")]
        public async Task<IActionResult> DeleteBasket()
        {
            return CreateActionResultInstance(await _basketService.Delete(_sharedIdentityService.GetUserId));
        }
    }
}
