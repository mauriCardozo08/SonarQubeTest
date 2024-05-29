using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace SonarQubeTest.Cars
{
    public interface ICarManager : IDomainService
    {
        Task<Car> Create(Car car);
    }
}
