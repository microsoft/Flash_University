namespace ResidencyPager
{
    internal class ResidencyPagerManager
    {

        public static void InitiateHell()
        {
            ResidencyPagerManager DrKelso = new ResidencyPagerManager();
            Console.WriteLine("So it begins");

            Console.WriteLine("Generating Page");
            
            DrKelso.GeneratePage("Kelso", "Dorian", "Where is Scooter");

            Console.WriteLine("Oh, I'm incompetent, let me add him to the list");

            Pager pager = new Pager(DrKelso);

            DrKelso.GeneratePage("Kelso", "Dorian", "Where is Scooter");
        }
        //Haha, the first use of 'event' keyword
        private EventHandler<NewPageEventArgs> _newPage;
        protected virtual void OnNewPage(NewPageEventArgs eventArgs)
        {
            EventHandler<NewPageEventArgs> temp = Volatile.Read(ref _newPage);

            if (temp != null) temp(this, eventArgs);
        }
        public void GeneratePage(String from, String to, String subject)
        {
            NewPageEventArgs alert = new NewPageEventArgs(from, to, subject);

            OnNewPage(alert);
        }
        public event EventHandler<NewPageEventArgs> NewPage
        {
            add
            {
                _newPage += value;
            }
            remove
            {
                _newPage -= value;
            }
        }
    }
}
