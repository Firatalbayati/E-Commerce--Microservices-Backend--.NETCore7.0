using AutoMapper;
using CatalogService.Models;
using MyCourse.Service.Catalog.Dtos;

namespace MyCourse.Service.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course,CourseDto>().ReverseMap();
            CreateMap<Course,CourseCreateDto>().ReverseMap();
            CreateMap<Course,CourseUpdateDto>().ReverseMap();
            CreateMap<Course,CourseCreateCategory>().ReverseMap();
            CreateMap<Course,CourseUpdateCategory>().ReverseMap();

            CreateMap<Category,CategoryDto> ().ReverseMap();
            CreateMap<Category,CategoryCreateDto>().ReverseMap();
            CreateMap<Category,CategoryUpdateDto>().ReverseMap();

            CreateMap<Feature,FeatureDto>().ReverseMap();

        }
    }
}
