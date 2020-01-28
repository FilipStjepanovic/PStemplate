using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        private Socket klijentskiSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        private Komunikacija()
        {
            //klijentskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        public bool PoveziSe()
        {
            try
            {
                if (klijentskiSocket == null || !klijentskiSocket.Connected)
                {
                    klijentskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSocket.Connect("localhost", 9090);
                    stream = new NetworkStream(klijentskiSocket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }
}
