using AutoMapper;
using HealthCareEasyApi.Models;
using HealthCareEasyApi.Dtos;
namespace HealthCareEasyApi.Profiles
{
    public class BenhvienProfile : Profile
    {
        //Benhvien model = this.Mapper.Map<Dichvu>(new Benhvien());
        public BenhvienProfile()
        {
            CreateMap<BenhvienDTOdetail, Benhvien>()
                .ForMember(dest => dest.Benhvien_Id, act => act.MapFrom(src => src.Benhvien_Id))
                .ForMember(dest => dest.Tenbenhvien, act => act.MapFrom(src => src.Tenbenhvien))
                .ForMember(dest => dest.Thongtin, act => act.MapFrom(src => src.Thongtin))
                .ForMember(dest => dest.Giatien, act => act.MapFrom(src => src.Giatien))
                .ForMember(dest => dest.Image, act => act.MapFrom(src => src.Image))
                .ForMember(dest => dest.DichvuId, act => act.MapFrom(src => src.dichvu.DichvuId))
                .ForMember(dest => dest.Dichvu, act => act.MapFrom(src => src.dichvu.DichvuId))
                .ForMember(dest => dest.Dichvu, act => act.MapFrom(src => src.dichvu.Tendichvu));
            CreateMap<Benhvien, BenhvienDTO>();
            CreateMap<Models.Dichvu, DichvuDTO>()
                .ForMember(dest => dest.Tendichvu, act => act.MapFrom(src => src.Tendichvu))
                .ForMember(dest => dest.DichvuId, act => act.MapFrom(src => src.DichvuId));
        }
    }
}
