using Domain.Serializable_Entity.Mill;
using Domain.Serializable_Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Serialization
{
    [Serializable]
    public class MillData
    {
        public SerializableProject Project; 
        public IList<SerializableRailcar> RailcarsList;
        public IList<SerializablePipe> PipesList;
        public IList<SerializablePlate> PlatesList;
        public IList<SerializableHeat> HeatsList;
    }
}