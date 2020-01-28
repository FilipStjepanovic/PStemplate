using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Obrada
    {
        private Socket klijentskiSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public Obrada(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            stream = new NetworkStream(klijentskiSoket);
        }

        public void ObradaZahteva()
        {
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor o = IzvrsiZahtev(zahtev);
                    formatter.Serialize(stream, o);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($">>> {e.Message}");
                    kraj = true;
                }
            }
        }

        public Odgovor IzvrsiZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                switch (zahtev.Operacija)
                {

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($">>> {e.Message}");
            }
            return odgovor;
        }
    }
}
