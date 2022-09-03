using MyCourse.Service.Catalog.Dtos;
using MyCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Service.Catalog.Services
{
    public interface ICourseService
    {
         Task<Response<List<CourseDto>>> GetAllAsync();
         Task<Response<CourseDto>> GetByIdAsync(string id);
         Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string UserId);
         Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
         Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
         Task<Response<NoContent>> DeleteAsync(string id);
    }
}
