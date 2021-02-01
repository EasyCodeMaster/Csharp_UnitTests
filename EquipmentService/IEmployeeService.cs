using EquipmentService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentService
{
    public interface IEmployeeService
    {
        Employee Connect(Guid employeeId, EquipmentBundle bundle);
    }
}
