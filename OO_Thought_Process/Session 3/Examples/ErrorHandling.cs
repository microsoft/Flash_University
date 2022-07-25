
namespace Session_3.Examples
{
    public class ErrorHandling
    {
        /**
         * Runs all error handling strategy demos
         *  - Ignore: continue blindly, hoping for the best
         *  - Abort: abort the whole program when something goes wrong
         *  - Recover: try to fix the error and keep going
         *  - Throw Exception: throw an exception and let someone else handle it
         *  - Return Error: return an error/flag and let the caller handle it
         */
        public static void RunAll()
        {
            int[] nums = new int[] { 10, 12, 15 };
            Console.WriteLine("Real Average is: {0}", new List<int>(nums).Average());
            
            RunIgnore(nums);
            //RunAbort(nums); // if you uncomment this, it will abort the whole program
            RunRecover(nums);
            RunThrowException(nums);
            RunReturnError(nums);
        }

        public static void RunIgnore(int[] nums) {
            IgnoreCalculator calc = new IgnoreCalculator();

            double avg = calc.GetAverage(nums);

            Console.WriteLine("[Ignore] Average is: {0}", avg);
        }
        
        public static void RunAbort(int[] nums) {
            AbortCalculator calc = new AbortCalculator();

            double avg = calc.GetAverage(nums);

            Console.WriteLine("[Abort] Average is: {0}", avg);
        }
        
        public static void RunRecover(int[] nums) {
            RecoverCalculator calc = new RecoverCalculator();

            double avg = calc.GetAverage(nums);

            Console.WriteLine("[Recover] Average is: {0}", avg);
        }

        public static void RunThrowException(int[] nums) {
            ThrowExceptionCalculator calc = new ThrowExceptionCalculator();

            try
            {
                double avg = calc.GetAverage(nums);
                Console.WriteLine("[Throw] Average is: {0}", avg);
            }
            catch (ThrowExceptionCalculator.UnexpectedResult ex)
            {
                Console.WriteLine("[Throw] Error calculating average: {0}", ex.Message);
            }
        }

        public static void RunReturnError(int[] nums) {
            ReturnErrorCalculator calc = new ReturnErrorCalculator();

            bool success = calc.TryGetAverage(nums, out double avg);
                
            if (success)
            {
                Console.WriteLine("[Return] Average is: {0}", avg);
            }
            else
            {
                Console.WriteLine("[Return] Error calculating average");
            }
        }
    }
}
