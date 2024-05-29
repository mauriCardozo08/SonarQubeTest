using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SonarQubeTest.Cars
{
    public class Car : AuditedAggregateRoot<Guid>
    {
        public string? Color { get; set; }
        public string? Model { get; set; }
    }
}
