using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SonarQubeTest.Cars
{
    public class CreateOrUpdateCarDto : AuditedEntityDto<Guid>
    {
        public string? Color { get; set; }
        public string? Model { get; set; }
    }
}
