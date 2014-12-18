﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Railcar.Search
{
    public class Railcar
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Certificate { get; set; }
        public string Destination { get; set; }
        public DateTime? ShippingDate { get; set; }
        public bool IsShipped { get; set; }
    }
}