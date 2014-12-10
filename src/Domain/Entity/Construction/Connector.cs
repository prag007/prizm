﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public class Connector : Item
    {
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }
        public virtual bool IsUsed { get; set; }

        public virtual Component Component { get; set; }
    }
}
