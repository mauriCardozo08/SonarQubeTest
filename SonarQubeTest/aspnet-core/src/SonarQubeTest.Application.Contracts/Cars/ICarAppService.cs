using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SonarQubeTest.Cars
{
    public interface ICarAppService
    {
        Task<Guid> CreateAsync(CreateOrUpdateCarDto input);
    }
}
