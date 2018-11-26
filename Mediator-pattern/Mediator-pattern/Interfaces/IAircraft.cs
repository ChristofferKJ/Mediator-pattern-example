using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public interface IAircraft
    {
        void requestPermission(bool req);
        void receivePermissionStatus(bool req); 
    }
}
