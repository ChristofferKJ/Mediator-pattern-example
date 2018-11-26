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

            ControlTowerMediator mediator = new ControlTowerMediator();
            Landingstrip landingstrip = new Landingstrip(mediator);
            landingstrip.Name = "Billund Lufthavn";
            mediator.Landingstrip = landingstrip;

            Aircraft Boeing737 = new Aircraft(mediator);
            Boeing737.Name = "Boeing 737";

            Aircraft Apache = new Aircraft(mediator);
            Apache.Name = "Apache";

            Aircraft Hercules = new Aircraft(mediator);
            Hercules.Name = "Hercules";
            mediator.Aircrafts = new List<Aircraft> { Boeing737, Apache, Hercules };

            Boeing737.requestPermission("Can i land here?");
            landingstrip.permissionGranted("Absolutely!", Boeing737);

            Apache.requestPermission("Can i land here?");
            landingstrip.permissionGranted("Yes, of course!", Apache);


            Hercules.requestPermission("Can i land here?");
            landingstrip.permissionGranted("Ok, also u.", Hercules);




        }
    }
}
