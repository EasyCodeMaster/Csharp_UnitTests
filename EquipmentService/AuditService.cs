using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EquipmentService.Model;

namespace EquipmentService
{
    public class AuditService : IAuditService
    {
        public string path = "auditLog.txt";
        public void WriteEmployeeInformation(Employee employee)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"Employee {employee.EmployeeId} has a bundle with {employee.Bundle}");
            }
        }
    }
}
