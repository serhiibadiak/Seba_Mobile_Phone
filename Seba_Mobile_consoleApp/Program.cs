using SebaMobileLib;
using SebaMobileLib.Charges;
using SebaMobileLib.Headsets;
using SebaMobileLib.Interfaces;
using SebaMobileLib.NotificationDevices;
using SebaMobileLib.Output;
using System;

namespace SebaMobilePhoneConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile SCPhone = new SimCorpMobile(ChoosePlayback(), ChooseCharge(), ChooseWatches());
            Console.WriteLine(SCPhone.GetDescription());

            SCPhone.Play("Journey - Don`t stop beleeving");
            SCPhone.Charge();
            SCPhone.ShowNotification("Hello world!");

            Console.ReadLine();
        }
        private static IPlayback ChoosePlayback()
        {
            int indicator;
            while (true)
            {
                Console.WriteLine("Choose Device to play audio:\n1 - IPhoneHeadset\n2 - XiaomyHeadset\n3 - ChinaHeadset\n4 - PhoneSpeaker\n");
                var input = Console.ReadLine();
                try
                {
                    indicator = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose between variants.");
                    continue;
                }
                if (indicator > 0 && indicator < 5) break;
                else
                    Console.WriteLine("Please choose between variants.");
            }
            switch (indicator)
            {
                case 1:
                    return new IPhoneHeadset(new ConsoleOutput());
                case 2:
                    return new XiaomiHeadset(new ConsoleOutput());
                case 3:
                    return new ChinaHeadset(new ConsoleOutput());
                case 4:
                    return new PhoneSpeaker(new ConsoleOutput());
                default:
                    return new ChinaHeadset(new ConsoleOutput());
            }
        }
        private static ICharge ChooseCharge()
        {
            int indicator;
            while (true)
            {
                Console.WriteLine("Choose charge:\n1 - MicroUSB Charge\n2 - IPhone Charge\n3 - WireLess Charge\n");
                var input = Console.ReadLine();
                try
                {
                    indicator = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose between variants.");
                    continue;
                }
                if (indicator > 0 && indicator < 4) break;
                else
                    Console.WriteLine("Please choose between variants.");
            }
            switch (indicator)
            {
                case 1:
                    return new MicroUsbCharge(new ConsoleOutput());
                case 2:
                    return new IPhoneCharge(new ConsoleOutput());
                case 3:
                    return new WirelessCharge(new ConsoleOutput());
                default:
                    return new MicroUsbCharge(new ConsoleOutput());
            }
        }
        private static INotification ChooseWatches()
        {
            int indicator;
            while (true)
            {
                Console.WriteLine("Choose charge:\n1 - Apple Watch\n2 - Xiaomi Watch\n3 - Samsung Watch\n4 - NoName Watch\n");
                var input = Console.ReadLine();
                try
                {
                    indicator = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose between variants.");
                    continue;
                }
                if (indicator > 0 && indicator < 5) break;
                else
                    Console.WriteLine("Please choose between variants.");
            }
            switch (indicator)
            {
                case 1:
                    return new AppleWatch(new ConsoleOutput());
                case 2:
                    return new XiaomiWatch(new ConsoleOutput());
                case 3:
                    return new SamsungWatch(new ConsoleOutput());
                case 4:
                    return new NoNameWatch(new ConsoleOutput());
                default:
                    return new NoNameWatch(new ConsoleOutput());
            }
        }
    }
}