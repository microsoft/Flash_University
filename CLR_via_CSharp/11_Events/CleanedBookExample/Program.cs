public static class Events
{
    public static void Main()
    {
        MailManager.Go();
    }

}

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

internal class MailManager
{
    public static void Go()
    {
        MailManager mm = new MailManager();

        mm.SimulateNewMail("Jeffrey", "Mom & Dad", "Happy Birthday.");

        Fax fax = new Fax(mm);
        Pager pager = new Pager(mm);

        mm.SimulateNewMail("Jeffrey", "Mom & Dad", "1");

        

        fax.Unregister(mm);

        mm.SimulateNewMail("Jeffrey", "Mom & Dad", "2");

    }

    private EventHandler<NewMailEventArgs> m_NewMail;

    public event EventHandler<NewMailEventArgs> NewMail
    {
        add
        {
            m_NewMail += value;
        }
        remove
        {
            m_NewMail -= value;
        }
    }
    protected virtual void OnNewMail(NewMailEventArgs e)
    {
        if (m_NewMail != null)
        {
            m_NewMail(this, e);
        }
    }

    public void SimulateNewMail(String from, String to, String subject)
    {
        NewMailEventArgs e = new NewMailEventArgs(from, to, subject);

        OnNewMail(e);
    }
}


internal sealed class Fax
{
    public Fax(MailManager mm)
    {
        mm.NewMail += FaxMsg;
    }

    private void FaxMsg(Object sender, NewMailEventArgs e)
    {

        Console.WriteLine("Faxing mail message:");
        Console.WriteLine("   From={0}, To={1}, Subject={2}",
           e.From, e.To, e.Subject);
    }

    public void Unregister(MailManager mm)
    {
        mm.NewMail -= FaxMsg;
    }
}


internal sealed class Pager
{
    public Pager(MailManager mm)
    {
        mm.NewMail += SendMsgToPager;
    }

    private void SendMsgToPager(Object sender, NewMailEventArgs e)
    {
        Console.WriteLine("Sending mail message to pager:");
        Console.WriteLine("   From={0}, To={1}, Subject={2}", e.From, e.To, e.Subject);
    }

}