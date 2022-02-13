using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP_test
{
    public class UdpReceiver
    {
        private static String my_ip = "null" ;
        public static void Receive( String ip )
        {

            //my_ip = ip;
            //Console.WriteLine("Hello_Receive ip = " + ip);
            //if ( ip == "11.11.11")
            //{
            //    Task.Delay(1000).Wait();
            //}
            //Console.WriteLine("Hello2 = " + ip );

            //バインドするローカルIPとポート番号
            string localIpString = "192.168.3.2";
            System.Net.IPAddress localAddress =
                System.Net.IPAddress.Parse(localIpString);
            int localPort = 1025;

            //UdpClientを作成し、ローカルエンドポイントにバインドする
            System.Net.IPEndPoint localEP =
                new System.Net.IPEndPoint(localAddress, localPort);
            System.Net.Sockets.UdpClient udp =
                new System.Net.Sockets.UdpClient(localEP);

            for (; ; )
            {
                //データを受信する
                System.Net.IPEndPoint remoteEP = null;
                byte[] rcvBytes = udp.Receive(ref remoteEP);

                //データを文字列に変換する
                string rcvMsg = System.Text.Encoding.UTF8.GetString(rcvBytes);

                //受信したデータと送信者の情報を表示する
                Console.WriteLine("受信したデータ:{0}", rcvMsg);
                Console.WriteLine("送信元アドレス:{0}/ポート番号:{1}",
                    remoteEP.Address, remoteEP.Port);

                //"exit"を受信したら終了
                if (rcvMsg.Equals("exit"))
                {
                    break;
                }
            }

            //UdpClientを閉じる
            udp.Close();

            Console.WriteLine("終了しました。");
            Console.ReadLine();
        }

        public static string  print_ip()
        {

            return my_ip;
        }

        
    }



}
