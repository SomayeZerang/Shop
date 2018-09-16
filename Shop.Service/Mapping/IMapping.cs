using AutoMapper;

namespace Shop.Service.Mapping
{
    public interface IMapping
    {
        void CreateMapping(IMapperConfigurationExpression config);
    }
}