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
    public class Bomber : AircraftBase, ICanBombing
    {
        public Bomber(string name) : base(name, AircraftTypes.Bomber) { }

        public void Bomb(List<GroundTarget> groundTargets)
        {
            Console.WriteLine($"{Name} Destroy : ");
            groundTargets.ForEach(
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
