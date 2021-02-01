using System;
using System.Collections.Generic;
using System.Text;
using EquipmentService;
using EquipmentService.Model;

namespace EquipmentServiceTests
{
    public class AuditServiceMock : IAuditService
    {
        public bool WriteFunctionCalled { get; set; } = false;
        public void WriteEmployeeInformation(Employee employee)
        {
            // Test Case: * no need to reach file system only the function call is enough
            WriteFunctionCalled = true;

        }
    }
}
