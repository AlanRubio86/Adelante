using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adelante.Core.Entities;
using Adelante.Core.Models;
using AutoMapper;

namespace Adelante.Core.AutoMapper
{
    public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<User, UserModel>().ReverseMap();
            }
        }
}
