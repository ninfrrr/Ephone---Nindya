using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone
{
    public abstract class gadget : ivar, ispec //abstraction
    {
        // private string ram;
        // private string rom;
        // private string camera;
        // private string battery;

        public abstract void varian();
        public void spec()
        {
            Console.WriteLine("ROM: \n1. 16gb \n2. 32gb \n3. 64gb \n4. 128gb");
        }
    }
    class Laptop : gadget //inheritance
    {
        public override void varian()
        {
            // throw new NotImplementedException();
            Console.WriteLine("1. Galaxy Chromebook \n2. Galaxy Chromebook 2");
        }
    }
    class Tablet : gadget //inheriance
    {
        public override void varian()
        {
            // throw new NotImplementedException();
            Console.WriteLine("1. Galaxy Tab S7 \n2. Galaxy Tab A7");
        }
    }
}
