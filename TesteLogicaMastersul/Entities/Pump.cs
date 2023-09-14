using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicaMastersul.Entities
{
    public class Pump
    {
        public Pump()
        {
            this.IsOn = false;
        }

        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            this.IsOn = true;
        }

        public void TurnOff()
        {
            this.IsOn = false;
        }
    }
}
