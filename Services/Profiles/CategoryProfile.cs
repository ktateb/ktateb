using System.Linq;
using AutoMapper;
using DAL.Entities.Categories; 
using Model.Category.Input;
using Model.Category.Output;
namespace Services.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryCreateInput,Category >()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BaseCategoryID, opt => opt.MapFrom(src => src.Parentid));

            CreateMap<CategoryUpdateInput, Category>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.BaseCategoryID, opt => opt.MapFrom(src => src.ParentId))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name));
            
            CreateMap<Category , CategoryOutput>() 
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)) 
                .ForMember(dest => dest.parentId, opt => opt.MapFrom(src => src.BaseCategoryID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
        }
    }
}