using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class Aircraft : ColleagueBase
    { 
        public Aircraft(ControlTowerMediator mediator) : base(mediator) { }

        public void requestPermission(string permissionRequest)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} with this landing request: {1} \n", Name, permissionRequest);
        }
    }
}
