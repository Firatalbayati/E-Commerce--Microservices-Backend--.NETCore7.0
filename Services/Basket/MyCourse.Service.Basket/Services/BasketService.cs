using MyCourse.Service.Basket.Dtos;
using MyCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyCourse.Service.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }


        public async Task<Response<BasketDto>> GetBasket(string userId)
        {
            var existBasket = await _redisService.GetDB().StringGetAsync(userId);

            if (String.IsNullOrEmpty(existBasket))
                return Response<BasketDto>.Fail("Basket Not Found", 404);

            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket), 200);
        }

        public async Task<Response<bool>> CreateOrUpdate(BasketDto basketDto)
        {
            var status = await _redisService.GetDB().StringSetAsync(basketDto.UserId, JsonSerializer.Serialize(basketDto));

            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket Could Not Update Or Save", 500);
        }

        public async Task<Response<bool>> Delete(string userId)
        {
            var status = await _redisService.GetDB().KeyDeleteAsync(userId);
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket Not Found", 404);
        }
    }
}
