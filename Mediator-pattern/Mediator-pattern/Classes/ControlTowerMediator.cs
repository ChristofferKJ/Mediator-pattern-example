using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
   public class ControlTowerMediator
    {
        public Landingstrip Landingstrip { get; set; }
        public List<Aircraft> Aircrafts; 
    
        public void RequestPermission(string request, Aircraft aircraft)
        {
            aircraft.ReceiveAircraftRequest(request);
        }

        public void GrantPermission(string permission, Aircraft aircraft)
        {
            Landingstrip.receiveRequest(permission, aircraft);

        }

    }
}
