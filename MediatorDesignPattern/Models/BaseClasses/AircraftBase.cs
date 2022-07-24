using MediatorDesignPattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.BaseClasses
{
    public abstract class AircraftBase
    {
        #region Members

        public string Name { get; set; }

        public AircraftTypes Type { get; set; }

        public bool IsReady { get; set; }

        #endregion

        protected AircraftBase(string name, AircraftTypes type)
        {
            Name = name;
            Type = type;
        }
    }
}
