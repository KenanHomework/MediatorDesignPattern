using MediatorDesignPattern.Enums;
using MediatorDesignPattern.Models.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interfaces
{
    public interface ICanControlAircrafts
    {
        public void Control();

        public void Redirect(TargetsTypes targetsType);
    }
}
