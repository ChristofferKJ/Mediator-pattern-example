using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IControlTowerMediator controlMediator = new ControlTower();

            IAircraft amazing = new ApacheHeli(controlMediator, "amazing");
            controlMediator.AddAircraft(amazing);

            System.Threading.Thread.Sleep(1000);

            amazing.requestPermission(controlMediator.permissionGranted(true, amazing));
            System.Threading.Thread.Sleep(1000);

            amazing.receivePermissionStatus(true); 


        }
    }
}
