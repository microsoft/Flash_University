using System.Net.Mail;

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
        public void Register(ResidencyPagerManager rpm)
        {
            rpm.NewPage += PageMessage;
        }
    }

    internal class Email
    {
        public Email(ResidencyPagerManager rpm)
        {
            rpm.NewPage += EmailMessage;
        }

        private void EmailMessage(object sender, NewPageEventArgs e)
        {
            Console.WriteLine("Sending an email alert");
            Console.WriteLine("From: " + e.From + "To: " + e.To + "Message: " + e.Message);
        }
        public void Unregister(ResidencyPagerManager rpm)
        {
            rpm.NewPage -= EmailMessage;
        }
        public void Register(ResidencyPagerManager rpm)
        {
            rpm.NewPage += EmailMessage;
        }

    }

    internal class Phone
    {
        public Phone(ResidencyPagerManager rpm)
        {
            rpm.NewPage += PhoneCall;
        }

        private void PhoneCall(object sender, NewPageEventArgs e)
        {
            Console.WriteLine("Calling the doc");
            Console.WriteLine("From: " + e.From + "To: " + e.To + "Message: " + e.Message);
        }
        public void Unregister(ResidencyPagerManager rpm)
        {
            rpm.NewPage -= PhoneCall;
        }

        public void Register(ResidencyPagerManager rpm)
        {
            rpm.NewPage += PhoneCall;
        }

    }
}
