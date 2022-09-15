namespace Session_2.Examples
{
    /*
     * This is copied from the Taxi/Cabbie example in the book. I had to fill
     * it out a little, as the book didn't give full UML diagrams for everything.
     * 
     * QUESTION
     * Is this the best design?
     * 
     * Based on the design principles in the book, what is good about this design?
     * What about this design seems strange/wrong? How would you improve this?
     */

    public interface ITaxi
    {
        public void Start();
        public void DriveTo(string location);
        public void TurnOff();
    }

    public interface ICabbie
    {
        public void HailTaxi();
        public void EnterTaxi();
        public void GreetCabbie(string greeting);
        public void specifyDestination(string location);
        public void PayCabbie();
        public void TipCabbie(float amount);
        public void LeaveTaxi();
    }

    public class Customer
    {
        /**
         * here's an example usage of ICabbie/ITaxi
         */
        public void GoToAirport()
        {
            ICabbie cabbie = GetACabbie();

            cabbie.HailTaxi();
            cabbie.EnterTaxi();
            cabbie.GreetCabbie("Hi. Nice weather we're having, right?");
            cabbie.specifyDestination("airport");
            cabbie.PayCabbie();
            cabbie.TipCabbie(10);
            cabbie.LeaveTaxi();
        }

        /**
         * this method is just for completeness sake
         */
        private ICabbie GetACabbie()
        {
            throw new NotImplementedException();
        }
    }
}
