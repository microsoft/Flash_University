using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidencyPager
{
    internal class NewPageEventArgs:EventArgs
    {
        private readonly String _from, _to, _message;
        public NewPageEventArgs(String from,String to, String message)
        {
            _from = from;
            _to = to;
            _message = message;
        }

        public String From { get { return _from; } }
        public String To { get { return _to; } }  
        public String Message { get { return _message; } }  
    }
}
