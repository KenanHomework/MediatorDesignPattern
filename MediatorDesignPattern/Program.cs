
using MediatorDesignPattern.Models.DerivedClasses;
using MediatorDesignPattern.Models.GeneralClasses;

AEWC AEWC = new("Boeing 737");

AEWC.Aircrafts = new()
{
    new Fighter("F-22"),
    new Fighter("SU-57"),
    new Multirole("F-16"),
    new Multirole("F-16 Block 70 Viper"),
    new Multirole("F-16 XL"),
    new Multirole("Typhoon"),
    new Bomber("Boeing P-8 Poseidon"),
    new Bomber("Sukhoi Su-34"),
    new Bomber("Tupolev Tu-160")
};

Area Area = new()
{
    AirTargets = new()
    {
        new AirTarget("F-22"),
        new AirTarget("F-35"),
        new AirTarget("F-16"),
        new AirTarget("F-15"),
        new AirTarget("F-18"),
        new AirTarget("Typhoon"),
        new AirTarget("SU-57"),
        new AirTarget("SU-75"),
    },
    GroundTargets = new()
    {
        new GroundTarget("APC"),
        new GroundTarget("APC"),
        new GroundTarget("APC"),
        new GroundTarget("APC"),
        new GroundTarget("APC"),
        new GroundTarget("APC"),
        new GroundTarget("TANK"),
        new GroundTarget("TANK"),
        new GroundTarget("TANK"),
        new GroundTarget("TANK"),
        new GroundTarget("TANK"),
        new GroundTarget("TANK"),
        new GroundTarget("SAM"),
        new GroundTarget("SAM"),
        new GroundTarget("SAM"),
        new GroundTarget("SAM"),
        new GroundTarget("SAM"),
        new GroundTarget("SAM"),
    },
    NavalTargets = new()
    {
        new NavalTarget("AircraftCArrier"),
        new NavalTarget("AircraftCArrier"),
        new NavalTarget("AircraftCArrier"),
        new NavalTarget("AircraftCArrier"),
        new NavalTarget("Firgate"),
        new NavalTarget("Firgate"),
        new NavalTarget("Firgate"),
        new NavalTarget("Firgate"),
        new NavalTarget("Firgate"),
    }

};

AEWC.SeacrhArea(Area);

