using MediatorDesignPattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.BaseClasses
{
    public abstract class TargetBase
    {

        #region Members

        public TargetsTypes Type { get; set; }

        public string Name { get; set; }

        public bool Destroyed { get; set; } = false;

        #endregion

        protected TargetBase(TargetsTypes type, string name)
        {
            Type = type;
            Name = name;
        }

    }
}
