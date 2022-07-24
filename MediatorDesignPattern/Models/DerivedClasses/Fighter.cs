using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Interfaces;
using MediatorDesignPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.DerivedClasses
{
    public class Fighter : AircraftBase, ICanDogFight
    {
        public Fighter(string name) : base(name, AircraftTypes.Fighter) { }

        public void Fight(List<AirTarget> airTarget)
        {
            Console.WriteLine($"{Name} Destroy : ");
            airTarget.ForEach(
                a =>
                {
                    if (!a.Destroyed)
                    {
                        Console.WriteLine($"\t {a.Name} Destryoed !");
                        a.Destroyed = true;
                    }
                }
                );

        }
    }
}
