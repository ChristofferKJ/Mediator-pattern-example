using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
   public class ControlTower : IControlTowerMediator
    {
        List<IAircraft> aircrafts;

        public ControlTower()
        {
            aircrafts = new List<IAircraft>(); 
        }

        public void AddAircraft(IAircraft aircraft)
        {
            aircrafts.Add(aircraft); 
        }

        public bool permissionGranted(bool granted, IAircraft sender)
        {
           return granted = true; 
        }

        public void requestPermissionStatus(bool permission, IAircraft sender)
        {
            foreach(IAircraft aircraft in aircrafts)
            {
                if (aircraft != sender)
                    aircraft.requestPermission(permission); 
            }
        }

        

       
    }
}
