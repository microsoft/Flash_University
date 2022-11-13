using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersioningExample.CompanyB
{
    public class BetterPhone: CompanyA.Phone
    {
        //the fix here is with 'new'
        public void Dial()
        {
            Console.WriteLine("better.dial");
            EstablishConnection();
            base.Dial;


           
        }

        private void EstablishConnection()
        {
            Console.WriteLine("connecting");
        }
    }
}
