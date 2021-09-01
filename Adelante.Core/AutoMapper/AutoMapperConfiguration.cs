using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adelante.Core.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IMapper _mapper { get; set; }

        public static void Register()
        {
            var mapperConfig = new MapperConfiguration(
                config =>
                {
                    config.AddProfile<MappingProfile>();
                }
            );

            _mapper = mapperConfig.CreateMapper();
        }
    }
}
