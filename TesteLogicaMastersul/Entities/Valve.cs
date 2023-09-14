using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicaMastersul.Entities
{
    public class Valve
    {
        public bool IsOpen { get; private set; }

        public Valve()
        {
            this.IsOpen = false;
        }

        public void Open()
        {
            this.IsOpen = true;
        }

        public void Close()
        {
            this.IsOpen = false;
        }
    }
}
