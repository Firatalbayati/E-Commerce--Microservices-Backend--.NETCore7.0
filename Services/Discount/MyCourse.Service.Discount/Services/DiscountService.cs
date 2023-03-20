using Dapper;
using Microsoft.Extensions.Configuration;
using MyCourse.Shared.Dtos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }



        public async Task<Response<List<Models.Discount>>> GetAll()
        {
            var discounts = await _dbConnection.QueryAsync<Models.Discount>("SELECT * FROM discount");

            return Response<List<Models.Discount>>.Success(discounts.ToList(), 200);
        }

        public async Task<Response<Models.Discount>> GetById(int id)
        {
            var discount = (await _dbConnection.QueryAsync<Models.Discount>("SELECT * FROM discount WHERE id=@Id", new { Id = id })).SingleOrDefault();

            if (discount is null)
                return Response<Models.Discount>.Fail("Discount Not Found", 404);

            return Response<Models.Discount>.Success(discount, 200);
        }

        public async Task<Response<NoContent>> Create(Models.Discount discount)
        {
            var status = await _dbConnection.ExecuteAsync("INSERT INTO discount (userid,rate,code) VALUES (@UserId,@Rate,@Code)", discount);

            if (status > 0)
                return Response<NoContent>.Success(204);

            return Response<NoContent>.Fail("An Error Occurred While Adding", 500);
        }

        public async Task<Response<NoContent>> Update(Models.Discount discount)
        {
            var status = await _dbConnection.ExecuteAsync("UPDATE discount SET userid=@UserId,rate=@Rate,code=@Code WHERE id=@Id", new
            {
                Id = discount.Id,
                UserId = discount.UserId,
                Rate = discount.Rate,
                Code = discount.Code
            });

            if (status > 0)
                return Response<NoContent>.Success(204);

            return Response<NoContent>.Fail("Discount Not Found", 404);
        }

        public async Task<Response<NoContent>> Delete(int id)
        {
            var status = await _dbConnection.ExecuteAsync("DELETE FROM discount WHERE id=@Id ", new { Id = id });

            if (status > 0)
                return Response<NoContent>.Success(204);

            return Response<NoContent>.Fail("Discount Not Found", 404);
        }

        public async Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId)
        {
            var discount = await _dbConnection.QueryAsync<Models.Discount>("SELECT * FROM discount WHERE userid=@UserId AND code=@Code", new
            {
                UserId = userId,
                Code = code
            });

            var hasDiscount = discount.FirstOrDefault();

            if (hasDiscount is null)
                return Response<Models.Discount>.Fail("Discount Not Found", 404);

            return Response<Models.Discount>.Success(hasDiscount, 200);
        }
    }
}
