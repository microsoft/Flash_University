namespace Session_2.Examples
{
    /*
     * Here's simple example of a bank account client. It's intentially
     * simple and not functional (just want to look at the design).
     * 
     * QUESTION
     * How would these factors affect the design?
     *  - network unreliability
     *  - partial offline support
     *  - concurrent operations
     *  - distributed architecture
     *  - latency/performance SLAs
     *  - business priority: must use MFA
     */


    /**
     * The main class. Call Bank.login(...) to get access to the bank.
     */
    public class Bank
    {
        /**
         * uses username/password to give the user access to the bank
         */
        public static Bank login(string username, string password)
        {
            return new Bank(new BankAuthentication(username, password));
        }

        /**
         * get access to the bank account operations
         */
        public Account GetAccount(string accountNumber)
        {
            return new Account(_auth, accountNumber);
        }

        private Bank(BankAuthentication auth)
        {
            _auth = auth;
        }

        private BankAuthentication _auth;
    }

    public class Account
    {
        internal Account(BankAuthentication auth, string accountNumber)
        {
            _auth = auth;
            _accountNumber = accountNumber;
        }

        private BankAuthentication _auth;
        private string _accountNumber;

        #region account operations
        /*
         * These are all the account operations: GetBalance, Deposit, Withdraw
         * 
         * They are purposefully not implemented (that's too much work!). Each
         * makes a call(s?) to some external service, whether it is an HTTP call
         * to a Bank server, or a call to a DB, or something else.
         */

        public double GetBalance()
        {
            // hits an external server, or DB, or something
            throw new NotImplementedException();
        }

        public void Deposit(double amount)
        {
            // hits an external server, or DB, or something
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            // hits an external server, or DB, or something
            throw new NotImplementedException();
        }

        #endregion account operations
    }

    /**
     * A simple username/password based authentication
     */
    public class BankAuthentication
    {
        internal BankAuthentication(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; init; }
        public string Password { get; init; }
    }

    #region usage

    public class User
    {
        /**
         * An example usage of the Bank/Account operations
         */
        public double doBankStuff()
        {
            // get access to the bank account
            Bank bank = Bank.login("hello", "world");
            Account account = bank.GetAccount("0123456789");

            // deposit a paycheck
            double paycheck = 100;
            account.Deposit(paycheck);

            // if you have money to spare, withdraw some
            if (account.GetBalance() > 500)
            {
                account.Withdraw(150);
            }

            // return the new account balance
            return account.GetBalance();
        }
    }

    #endregion usage
}
