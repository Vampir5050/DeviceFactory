using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public class PhoneBuilder : DeviceBuilder
    {
        public PhoneBuilder(IDevice device) : base(device)
        {

        }
        public override void SetBody(string body)
        {
            Device.Body = $"{body} body";
        }

        public override void SetModel(string model)
        {
            Device.Model = $"{model} model";
        }

        public override void SetName(string name)
        {
            Device.Name = $"Name: {name} ";
        }

        public override void SetScreen(string screen)
        {
            Device.Screen = $"{screen} screen";
        }
    }
}
