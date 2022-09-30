using JeffreyIsNeverWrong;

namespace MessageInABottle
{
    internal class Castaway
    {
        private EventHandler<Message> eventHandler;
        public event EventHandler<Message> TheEventHandler{
            add
            {
                eventHandler += value;
            }
            remove
            {
                eventHandler -= value;
            }
        }

        protected virtual void Notify(Message m)
        {
            if (eventHandler != null)
            {
                eventHandler(this, m);
            }
        }

        public void CreateNewMessageAndCallNotify(String message)
        {
            Message m = new Message(message);
            Notify(m);
        }

    }
}