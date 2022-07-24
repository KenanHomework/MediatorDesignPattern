using MediatorDesignPattern.Models.BaseClasses;
using MediatorDesignPattern.Models.DerivedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.GeneralClasses
{
    public class Area
    {
        public bool IsClean() => AirTargets == null && NavalTargets == null && GroundTargets == null;

        public List<AirTarget> AirTargets { get; set; } = null;
        public List<GroundTarget> GroundTargets { get; set; } = null;
        public List<NavalTarget> NavalTargets { get; set; } = null;

    }
}
