using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidencyPager
{
    internal class Pager
    {
        public Pager(ResidencyPagerManager rpm)
        {
            rpm.NewPage += PageMessage;
        }

        private void PageMessage(object sender, NewPageEventArgs e)
        {
            Console.WriteLine("Sending a pager alert");
            Console.WriteLine("From: " + e.From + "To: " + e.To + "Message: " + e.Message );
        }

        public void Unregister(ResidencyPagerManager rpm)
        {
            rpm.NewPage -= PageMessage;
        }
    }
}
