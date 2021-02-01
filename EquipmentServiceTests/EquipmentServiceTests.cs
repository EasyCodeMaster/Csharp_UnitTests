using System;
using Xunit;

namespace EquipmentServiceTests
{
    public class EquipmentServiceTests
    {
        [Fact]
        public void AssignStandardBundleToEmployee_EmployeeId_ReturnsCorrectEmployee()
        {
            // Mock: Simulate the behavior of service

            // Arrange
            var employeeService = new EmployeeServiceMock();
            var bundleFactory = new EquipmentBundleFactoryMock();
            var auditService = new AuditServiceMock();

            var employeeId = new Guid();
            var service = new EquipmentService.EquipmentService(bundleFactory, employeeService, auditService);

            // Act
            var result = service.AssignStandardBundleToEmployee(employeeId);

            // Assert
            Assert.Equal(employeeId, result.EmployeeId);
            Assert.Single(result.Bundle.Items);
            Assert.True(auditService.WriteFunctionCalled);
        }
    }
}
