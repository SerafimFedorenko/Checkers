using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CheckersNetworkLib
{
    public class Client : Player
    {
        public Client()
        {

            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //ipAddress = host.AddressList[0].MapToIPv4();
            //ipAddress = IPAddress.Parse("192.168.43.254");
            ipAddress = IPAddress.Parse("127.0.0.1");
            endPoint = new IPEndPoint(ipAddress, 11000);
            sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(endPoint);
        }
    }
}
