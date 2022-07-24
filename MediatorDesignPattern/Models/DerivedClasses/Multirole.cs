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
    public class Multirole : AircraftBase, ICanDogFight, ICanBombing
    {
        public Multirole(string name) : base(name, AircraftTypes.MultiRole) { }

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

        public void Bomb(List<NavalTarget> groundTargets)
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
