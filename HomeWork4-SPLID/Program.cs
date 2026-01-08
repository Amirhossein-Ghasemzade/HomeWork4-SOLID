
//کلاس‌های سطح بالا نباید مستقیم به کلاس‌های سطح پایین وابسته باشند

using System;
using DIPExample;

namespace DIPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // مثال اشتباه
            BadSwitch badSwitch = new BadSwitch();
            badSwitch.On();

            // مثال درست
            IDevice light = new LightDevice();
            GoodSwitch goodSwitch1 = new GoodSwitch(light);
            goodSwitch1.On();

            IDevice fan = new FanDevice();
            GoodSwitch goodSwitch2 = new GoodSwitch(fan);
            goodSwitch2.On();
        }
    }
}
