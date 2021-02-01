using System;
using System.Collections.Generic;
using System.Text;
using EquipmentService;
using EquipmentService.Model;

namespace EquipmentServiceTests
{
    public class EquipmentBundleFactoryMock : IEquipmentBundleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var testItem = new EquipmentItem
            {
                Name = "test"
            };

            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            return testBundle;
        }
    }
}
