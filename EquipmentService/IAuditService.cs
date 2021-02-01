using EquipmentService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentService
{
    public interface IAuditService
    {
        void WriteEmployeeInformation(Employee employee);
    }
}
