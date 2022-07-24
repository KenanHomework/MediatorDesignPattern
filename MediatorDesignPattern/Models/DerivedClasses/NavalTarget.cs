using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.DerivedClasses
{
    public class NavalTarget : TargetBase
    {
        public NavalTarget(string name) : base(TargetsTypes.Naval, name) { }

    }
}
