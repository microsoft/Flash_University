namespace ResidencyPager
{
    internal class ResidencyPagerManager
    {
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
