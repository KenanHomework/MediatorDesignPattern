using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.DerivedClasses
{
    public class GroundTarget : TargetBase
    {
        public GroundTarget(string name) : base(TargetsTypes.Ground, name) { }
    }
}
