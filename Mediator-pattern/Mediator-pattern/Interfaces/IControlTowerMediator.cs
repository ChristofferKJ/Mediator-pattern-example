using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public interface IControlTowerMediator
    {
         void AddAircraft(IAircraft aircraft);
         void requestPermissionStatus(bool permission, IAircraft sender);
         bool permissionGranted(bool granted, IAircraft sender);

    }
}
