using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using Timer = System.Threading.Timer;
using Timer = System.Timers.Timer;

namespace UDP_test
{
    internal class Class1
    {
        static void Main()
        {

            UdpSender.Send();
            UdpReceiver.Receive("11.11.11");
            
            // Thread PLC1 = new Thread(new ThreadStart(() =>
            // {
            //     UdpReceiver.Receive("11.11.11");
            //     Console.WriteLine("PLC1_NOW_IP = " + UdpReceiver.print_ip());

            // }));
            // Thread PLC2 = new Thread(new ThreadStart(() =>
            // {
            //     UdpReceiver.Receive("22.22.22");
            //     Console.WriteLine("PLC2_NOW_IP = " + UdpReceiver.print_ip());
            // }));


            // PLC1.Start();
            // PLC2.Start();
            // PLC1.Join();
            // PLC2.Join();

            // //Timer PLC3 = new Timer(new TimerCallback(UdpReceiver.Receive("")));
            // //Timer PLC3 = new Timer(UdpReceiver.Receive(""), new AutoResetEvent(false), 1000, 250);
            // Timer PLC3 = new Timer();

            //// PLC3.Elapsed += new ElapsedEventHandler(UdpReceiver.Receive("33.33.33"));



            // UdpReceiver.Receive("33.33.33");
            // //UdpReceiver test1 = new UdpReceiver();
            // Console.WriteLine("Hello!!");

            // Timer timer = new Timer(1000);
            // // タイマーの処理
            // timer.Elapsed += (sender, e) =>
            // {
            //     UdpReceiver.Receive("33.33.33");
            // };
            // // タイマーを開始する
            // timer.Start();
            // Console.ReadKey();
        }

    }
}
