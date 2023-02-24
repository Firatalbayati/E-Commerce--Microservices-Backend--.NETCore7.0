using MyCourse.Service.Basket.Dtos;
using MyCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> CreateOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string userId); 
    }
}
