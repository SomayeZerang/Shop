using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using StructureMap;

namespace Shop.IoC.Mapping
{
    public class MappingRegister : Registry
    {
        public MappingRegister()
        {
            For<IMapper>().Use<Mapper>();

            For<IConfigurationProvider>().Use<MapperConfiguration>();
        }
    }
}