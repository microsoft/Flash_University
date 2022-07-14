namespace Session_2.Taxi
{
    /*
     * This is copied from the Taxi/Cabbie example in the book. I had to fill
     * it out a little, as the book didn't give full UML diagrams for everything.
     * 
     * QUESTION
     * Is this the best design?
     * 
     * Based on the design principles in the book, what is good about this design?
     * What about this design seems wrong? How would you improve this?
     */

    public interface ITaxi
    {
        public void start();
        public void driveTo(string location);
        public void turnOff();
    }

    public interface ICabbie
    {
        public void hailTaxi();
        public void enterTaxi();
        public void greetCabbie(string greeting);
        public void specifyDestination(string location);
        public void payCabbie();
        public void tipCabbie(float amount);
        public void leaveTaxi();
    }

    public class Customer
    {
        public void GoToAirport(ICabbie cabbie)
        {
            cabbie.hailTaxi();
            cabbie.enterTaxi();
            cabbie.greetCabbie("Hi. Nice weather we're having, right?");
            cabbie.specifyDestination("airport");
            cabbie.payCabbie();
            cabbie.tipCabbie(10);
            cabbie.leaveTaxi();
        }
    }
}
