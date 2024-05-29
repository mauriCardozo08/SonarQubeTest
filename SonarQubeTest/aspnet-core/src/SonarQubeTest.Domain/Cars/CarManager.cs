using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SonarQubeTest.Cars
{
    public class CarManager : ICarManager
    {
        public readonly IRepository<Car> _carRepository;
        
        public CarManager(IRepository<Car> carRepository) 
        { 
            _carRepository = carRepository;
        }

        public async Task<Car> Create(Car car)
        {
            return await _carRepository.InsertAsync(car);
        }
    }
}
