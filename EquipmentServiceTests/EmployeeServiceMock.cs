using System;
using System.Collections.Generic;
using System.Text;
using EquipmentService;
using EquipmentService.Model;

namespace EquipmentServiceTests
{
    public class EmployeeServiceMock : IEmployeeService
    {
        public Employee Connect(Guid employeeGuid, EquipmentBundle bundle)
        {
            return new Employee()
            {
                EmployeeId = employeeGuid,
                Bundle = bundle
            };
        }
    }
}
