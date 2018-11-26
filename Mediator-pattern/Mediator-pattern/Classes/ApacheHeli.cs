using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class ApacheHeli : IAircraft
    {
        string name;
        IControlTowerMediator controlMediator; 

        public ApacheHeli(IControlTowerMediator controlMediator, string name)
        {
            this.name = name;
            this.controlMediator = controlMediator; 
        }
            
            
            
        public void requestPermission(bool req)
        {
            controlMediator.requestPermissionStatus(req, this);
            Console.WriteLine("ApacheHeli requests landing permission.\n"); 
        }

        public void receivePermissionStatus(bool req)
        {
            controlMediator.permissionGranted(req,this);
            Console.WriteLine("Controltower grants permission and ApacheHeli is now Landing\n");
        }
    }
}
