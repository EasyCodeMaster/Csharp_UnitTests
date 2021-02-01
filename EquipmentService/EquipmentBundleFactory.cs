using System;
using System.Collections.Generic;
using System.Text;
using EquipmentService.Model;
namespace EquipmentService
{
    public class EquipmentBundleFactory: IEquipmentBundleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var monitor = new EquipmentItem { Name="Monitor" };

            var keyboard = new EquipmentItem { Name = "keyboard" };

            // add to bundle
            var standardBundle = new EquipmentBundle();
            standardBundle.Add(monitor);
            standardBundle.Add(keyboard);

            return standardBundle;
        }
    }
}
