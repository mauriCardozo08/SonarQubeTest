using System;
using System.Threading.Tasks;

namespace SonarQubeTest.Cars
{
    public class CarAppService : SonarQubeTestAppService , ICarAppService
    {
        private readonly ICarManager _carManager;

        public CarAppService(ICarManager carManager) 
        { 
            _carManager = carManager;
        }

        public async Task<Guid> CreateAsync(CreateOrUpdateCarDto input) 
        {
            try
            {
                Car car = ObjectMapper.Map<CreateOrUpdateCarDto,Car>(input);
                return (await _carManager.Create(car)).Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
