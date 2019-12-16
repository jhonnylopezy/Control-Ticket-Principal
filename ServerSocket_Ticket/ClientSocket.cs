using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocket_Ticket
{
    class ClientSocket
    {
        public string nick { set; get; }
        public Socket socket { set; get; }
    }
}
