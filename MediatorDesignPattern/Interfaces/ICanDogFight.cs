using MediatorDesignPattern.Models.BaseClasses;
using MediatorDesignPattern.Models.DerivedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interfaces
{
    public interface ICanDogFight
    {

        public void Fight(List<AirTarget> airTarget);

    }
}
