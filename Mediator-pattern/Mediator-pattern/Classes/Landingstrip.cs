using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class Landingstrip : ColleagueBase
    {
        public Landingstrip(ControlTowerMediator mediator) : base(mediator) { }

        public void receiveRequest(string permissionRequest, Aircraft aircraft)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Landingstrip received following " +
                "request from {0} : {1} \n", aircraft.Name, permissionRequest); 
        }

        public void permissionGranted(string grantMsg, Aircraft aircraft)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Landingstrip grants permission, aircraft is now landing"); 
        }

      
    }
}
