using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketPiirto_receiver_runko
{
    public partial class Form1 : Form
    {
        private static Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        static int count = 1;
        public Form1()
        {
            InitializeComponent();

            //Käynnistä server motodi omaan säikeeseen 
        }

        private void server()
        {
            TcpListener ServerSocket = new TcpListener(IPAddress.Any, 5000);
            ServerSocket.Start();
            //while loopissa otetaan clinetit vastaan ja luodaan uusi säie handle_clients
      
        }
        public void handle_clients(object o)
        {
            int id = (int)o;
            TcpClient client;
            client = list_clients[id];
            while (true)
            {
               //client luo network streamin ja muuntaa tavut merkkijonoksi
               //kutsutaan metodia jossa piirto tapahtuu. koordinaatit menee parametrinä



            }

        }
        delegate void SetTextCallback(string t);
        private void SetText(string t)
        {
            if (this.panel1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { t });
            }
            else
            {
                /*Tässä tapahtuu varsinen piirtäminen
                 * 
                 * Luodaan SolidBrush piirtämiseen
                 * Siirretään paneeli ylimmäksi "BringToFront"
                 * Paneelista luodaan Graphics olio
                 * Parsitaan soketin kautta tulleesta merkkijonosta x ja y koordinaatit
                 * piirretään g.FillEllipse(brush, x, y, 4, 4);
                 * */
     
            }
        }
    }
}
