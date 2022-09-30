using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal sealed class Fax
    {
        // Pass the MailManager object to the constructor
        public Fax(MailManager mm)
        {
            // Construct an instance of the EventHandler<NewMailEventArgs> 
            // delegate that refers to our FaxMsg callback method.
            // Register our callback with MailManager's NewMail event
            mm.NewMail += FaxMsg;
        }

        // This is the method the MailManager will call
        // when a new e-mail message arrives
        private void FaxMsg(Object sender, NewMailEventArgs e)
        {
            // 'sender' identifies the MailManager object in case 
            // we want to communicate back to it.

            // 'e' identifies the additional event information 
            // the MailManager wants to give us.

            // Normally, the code here would fax the e-mail message.
            // This test implementation displays the info in the console
            Console.WriteLine("Faxing mail message:");
            Console.WriteLine("   From={0}, To={1}, Subject={2}",
               e.From, e.To, e.Subject);
        }

        // This method could be executed to have the Fax object unregister itself with the NewMail 
        // event so that it no longer receives notifications
        public void Unregister(MailManager mm)
        {
            // Unregister ourself with MailManager's NewMail event
            mm.NewMail -= FaxMsg;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////

    internal sealed class Pager
    {
        // Pass the MailManager object to the constructor
        public Pager(MailManager mm)
        {
            // Construct an instance of the ProcessMailMsgEventHandler 
            // delegate that refers to our SendMsgToPager callback method.
            // Register our callback with MailManager's ProcessMailMsg event
            mm.NewMail += SendMsgToPager;
        }

        // This is the method that the MailManager will call
        // when a new e-mail message arrives
        private void SendMsgToPager(Object sender, NewMailEventArgs e)
        {
            // 'sender' identifies the MailManager in case we want to communicate back to it.
            // 'e' identifies the additional event information that the MailManager wants to give us.

            // Normally, the code here would send the e-mail message to a pager.
            // This test implementation displays the info on the console
            Console.WriteLine("Sending mail message to pager:");
            Console.WriteLine("   From={0}, To={1}, Subject={2}", e.From, e.To, e.Subject);
        }

        public void Unregister(MailManager mm)
        {
            // Unregister ourself with MailManager's ProcessMailMsg event
            mm.NewMail -= SendMsgToPager;
        }
    }

}
