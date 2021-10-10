using Application.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Api.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(x => x.AddProfiles(GetProfiles()));
        }

        private static IEnumerable<Profile> GetProfiles()
        {
            var profiles = new List<Profile>();

            profiles.AddRange(AutoMapperProfiles.GetAssemblyProfiles());

            return profiles;
        }
    }
}