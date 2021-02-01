using System;

namespace EquipmentService.Model
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public EquipmentBundle Bundle { get; set; }
    }
}
