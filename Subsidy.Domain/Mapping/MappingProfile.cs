using AutoMapper;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
            //CreateMap<IdentityUser<string>, UserInforamtionViewModel>().ReverseMap();
            //CreateMap<IdentityRole<string>, RoleDto>().ReverseMap();
            //CreateMap<IdentityUser<string>, DeleteUsersCommands>().ReverseMap();
            //CreateMap<Employee, EmployeeInforamtionViewModel>().ReverseMap();
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            // get all the Interfaces have IMapFrom<>
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMappingForm<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping")
                    ?? type.GetInterface("IMapFrom`1")!.GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });

            }
        }

    }
}
