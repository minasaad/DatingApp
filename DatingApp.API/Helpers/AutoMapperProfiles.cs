using System;
using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
         public AutoMapperProfiles()
         {
             CreateMap<User,UserForListingDTO>()
             .ForMember(dest=>dest.PhotoURL,opt=> {
                 opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url);
             })
             .ForMember(dest => dest.Age,opt =>{
                 opt.MapFrom(src => (DateTime.Today.Year - src.DateOfBirth.Year));
             })
             ;
             CreateMap<User,UserDetailsDTO>()
              .ForMember(dest=>dest.PhotoUrl,opt=> {
                 opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url);
             })
              .ForMember(dest => dest.Age,opt =>{
                 opt.MapFrom(src => (DateTime.Today.Year - src.DateOfBirth.Year));
             });
             CreateMap<Photo,PhotosForDetailedDTO>();

             CreateMap<UserForUpdateDto,User>();

         }
    }
}