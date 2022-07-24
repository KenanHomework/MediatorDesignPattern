using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Interfaces;
using MediatorDesignPattern.Models.BaseClasses;
using MediatorDesignPattern.Models.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Models.DerivedClasses
{
    public class AEWC : AircraftBase, ICanControlAircrafts, ICanEarlyWarning
    {
        public AEWC(string name) : base(name, AircraftTypes.AEWC) { }

        #region Members

        public int CountOfSingle { get; set; } = 5;

        public List<AircraftBase> Aircrafts { get; set; }

        public List<AirTarget> AirTargets { get; set; } = null;
        public List<GroundTarget> GroundTargets { get; set; } = null;
        public List<NavalTarget> NavalTargets { get; set; } = null;

        #endregion

        public void Control()
        {
            if (Aircrafts == null)
                Console.WriteLine("\a !! Don't have aircrafts !! ~~ !! Connecting Base .. !!");
            else
            {
                if (AirTargets != null) Redirect(TargetsTypes.Air);
                if (GroundTargets != null) Redirect(TargetsTypes.Ground);
                if (NavalTargets != null) Redirect(TargetsTypes.Naval);

            }

        }

        public void Redirect(TargetsTypes targetsType)
        {
            switch (targetsType)
            {
                case TargetsTypes.Air:
                    Aircrafts.FindAll(a => a.Type == AircraftTypes.Fighter).ToList().ForEach(a =>
                    {
                        if (a is Fighter f)
                            f.Fight(AirTargets);
                    });
                    break;
                case TargetsTypes.Ground:
                    Aircrafts.FindAll(a => a.Type == AircraftTypes.Bomber).ToList().ForEach(a =>
                    {
                        if (a is Bomber f)
                            f.Bomb(GroundTargets);
                    });
                    break;
                case TargetsTypes.Naval:
                    Aircrafts.FindAll(a => a.Type == AircraftTypes.MultiRole).ToList().ForEach(a =>
                    {
                        if (a is Multirole f)
                            f.Bomb(NavalTargets);
                    });
                    break;
                default:
                    break;
            }
        }

        public void SeacrhArea(Area area)
        {
            if (!area.IsClean())
            {
                AirTargets = area.AirTargets;
                GroundTargets = area.GroundTargets;
                NavalTargets = area.NavalTargets;
                Control();
            }
        }
    }
}
