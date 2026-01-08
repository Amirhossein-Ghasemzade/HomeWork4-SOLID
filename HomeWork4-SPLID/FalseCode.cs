using System;
using System.Collections.Generic;
using System.Text;


namespace DIPExample
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }
    }

    public class BadSwitch
    {
        private Light light = new Light();

        public void On()
        {
            light.TurnOn();
        }
    }
}
