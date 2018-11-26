using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public abstract class ColleagueBase 
    {

        protected ControlTowerMediator _mediator; 

        public ColleagueBase(ControlTowerMediator mediator)
        {
            _mediator = mediator; 
        }

        public string Name { get; set; }

        public void ReceiveAircraftRequest(string permissionStatus)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} requested landing " +
                "permission. This is {1}", Name, permissionStatus); 
        }

    }
}
