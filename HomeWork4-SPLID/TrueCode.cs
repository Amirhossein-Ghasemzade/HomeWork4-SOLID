using System;
using System.Collections.Generic;
using System.Text;


namespace DIPExample
{
    public interface IDevice
    {
        void TurnOn();
    }

    public class LightDevice : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }
    }

    public class FanDevice : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is ON");
        }
    }

    public class GoodSwitch
    {
        private IDevice device;

        public GoodSwitch(IDevice device)
        {
            this.device = device;
        }

        public void On()
        {
            device.TurnOn();
        }
    }
}
