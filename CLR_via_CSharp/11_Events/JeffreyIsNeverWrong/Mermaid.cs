using JeffreyIsNeverWrong;

namespace MessageInABottle
{
    internal class Mermaid
    {
        public Mermaid(Castaway castaway)
        {
            castaway.TheEventHandler += UnderTheSea;
        }

        public void UnderTheSea(object o, Message m)
        {
            Console.WriteLine(m._messageInABottle);
        }
    }
}
