﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Database.DA.AuthTickets
{
    public class AuthTicket
    {
        public string ticket_id { get; set; }
        public uint user_id { get; set; }
        public uint date { get; set; }
        public string ip { get; set; }
    }
}
