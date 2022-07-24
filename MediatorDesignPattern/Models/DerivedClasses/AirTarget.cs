using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.DerivedClasses
{
    public class AirTarget : TargetBase
    {
        public AirTarget(string name) : base(TargetsTypes.Air, name) { }

    }
}
