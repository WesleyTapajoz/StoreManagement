using AutoMapper;
using System.Linq;
using System.Reflection;

namespace SGL.Application.AutoMapper
{
    public static class MappingConfig
    {
        public static void RegisterMap()
        {

            var targetAssembly = Assembly.GetExecutingAssembly();

            var automapperProfiles = targetAssembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Profile)));

            Mapper.Initialize(cfg =>
            {
                foreach (var automapperProfile in automapperProfiles)
                {
                    cfg.AddProfile(automapperProfile);
                }
            });
        }
    }
}
