using Application.AutoMapper.Mappers;
using AutoMapper;
using System.Collections.Generic;

namespace Application.AutoMapper
{
    public static class AutoMapperProfiles
    {
        public static IEnumerable<Profile> GetAssemblyProfiles()
        {
            return new Profile[]
            {
                new CadastroDomainToDtoMapping(),
                new AcessoDomainToDtoMapping()
            };
        }
    }
}