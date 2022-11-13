namespace JeffreyIsNeverWrong
{
    internal class Message:EventArgs
    {
        public String _messageInABottle { get; }

        public Message(String messageInABottle)
        {
            _messageInABottle=  messageInABottle;
        }
    }
}
