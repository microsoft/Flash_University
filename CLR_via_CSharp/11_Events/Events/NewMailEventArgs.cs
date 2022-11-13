using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal sealed class NewMailEventArgs : EventArgs
    {

        private readonly String m_from, m_to, m_subject;

        public NewMailEventArgs(String from, String to, String subject)
        {
            m_from = from; m_to = to; m_subject = subject;
        }

        public String From { get { return m_from; } }
        public String To { get { return m_to; } }
        public String Subject { get { return m_subject; } }
    }
    public static class EventArgExtensions
    {
        public static void Raise<TEventArgs>(this TEventArgs e, Object sender, ref EventHandler<TEventArgs> eventDelegate)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety 
            EventHandler<TEventArgs> temp = Volatile.Read(ref eventDelegate);

            // If any methods registered interest with our event, notify them  
            if (temp != null) temp(sender, e);
        }
    }

}
