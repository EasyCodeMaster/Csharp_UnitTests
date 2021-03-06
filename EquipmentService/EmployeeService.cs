﻿using System;
using System.Collections.Generic;
using System.Text;
using EquipmentService.Model;

namespace EquipmentService
{
    public class EmployeeService : IEmployeeService
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
