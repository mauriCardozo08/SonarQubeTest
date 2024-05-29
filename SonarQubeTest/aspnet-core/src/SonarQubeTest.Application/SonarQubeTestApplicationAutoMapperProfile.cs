using AutoMapper;
using SonarQubeTest.Cars;

namespace SonarQubeTest;

public class SonarQubeTestApplicationAutoMapperProfile : Profile
{
    public SonarQubeTestApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<CreateOrUpdateCarDto, Car>();
    }
}
