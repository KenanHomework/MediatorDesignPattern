using MediatorDesignPattern.Models.DerivedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interfaces
{
    public interface ICanBombing
    {
        public void Bomb(List<GroundTarget> groundTargets);
    }
}
