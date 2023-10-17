using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace CheckersNetworkLib
{
    public abstract class Player
    {
        public IPAddress ipAddress;
        public IPEndPoint endPoint;
        public Socket sender;
        public Player() { }
        public void Send(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            sender.Send(data);
        }
        public string Receive()
        {
            byte[] buffer = new byte[1024];
            int bytesRead = sender.Receive(buffer);
            string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return dataReceived;
        }
    }
}
