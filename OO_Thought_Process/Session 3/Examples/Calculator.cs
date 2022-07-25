namespace Session_3.Examples
{
    /**
     * This is a demo of how to use different kinds of error handling.
     * 
     * The base Calculator class has a bug in the GetSum method, and
     * it has a VerifyAverage method that checks if the calculated
     * average is way off.
     * 
     * Each Calculator implementation has a different means of handling
     * when VerifyAverage indicates the calculated average is wrong.
     * 
     * NOTE - the base Calculator class is broken up into two classes
     * (Calculator and DirectCalculator) because the GetAverage method
     * signature is not the same between all error handling strategies.
     */

    #region Base Calculator Classes
    /**
     * The base Calculator class. It holds some helper methods
     */
    public abstract class BaseCalculator
    {
        /**
         * Calculate the average of an array of numbers.
         * 
         * This uses the buggy GetSum method.
         */
        protected double CalculateAverage(int[] nums)
        {
            int sum = GetSum(nums);
            double average = sum / nums.Length;
            return average;
        }

        /**
         * Simple dummy check - the average should be between
         * the lowest and the hightest numbers; if it's not,
         * then something went wrong
         */
        protected bool VerifyAverage(int[] nums, double average)
        {
            return average >= nums[0] && average <= nums[nums.Length - 1];
        }

        /**
         * Gets the sum of an array of numbers
         * 
         * IMPORTANT - this method has a bug can cause the sum
         * (and by extension the average) to be way off.
         */
        public int GetSum(int[] nums)
        {
            int sum = 0;

            // BUG HERE - should start at zero
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }

    /**
     * This is an extension of the base Calculator class -
     * it holds some logic that's used by all of the error handling
     * classes (except for ReturnErrorCalculator).
     */
    public abstract class DirectCalculator : BaseCalculator
    {
        /**
         * Get the average; if the calculated average is way off,
         * allow the subclasses to handle it.
         */
        public double GetAverage(int[] nums)
        {
            double average = CalculateAverage(nums);

            if (!VerifyAverage(nums, average)) {
                return HandleAverageError(average, nums);
            }

            return average;
        }

        protected abstract double HandleAverageError(double average, int[] nums);
    }
    #endregion

    #region Error Handling Implementations
    /**
     * Ignores errors
     */
    public class IgnoreCalculator : DirectCalculator
    {
        protected override double HandleAverageError(double average, int[] nums)
        {
            return average;
        }
    }

    /**
     * Aborts the whole program when an error is discovered
     */
    public class AbortCalculator : DirectCalculator
    {
        protected override double HandleAverageError(double average, int[] nums)
        {
            /*
             * Exit() exits the thread, so it won't every get to the
             * throw statement below - it's just there to make the compiler happy.
             */
            Console.WriteLine("An error occurred");
            System.Environment.Exit(1);
            throw new Exception("won't get here");
        }
    }

    /**
     * Trys to fix the error - doesn't completely fix it, but gets it closer
     * to the actual average
     */
    public class RecoverCalculator : DirectCalculator
    {
        protected override double HandleAverageError(double average, int[] nums)
        {
            double fixedAvg = Math.Clamp(average, nums[0], nums[nums.Length - 1]);
            return fixedAvg;
        }
    }

    /**
     * Throws an exception for someone else to handle
     */
    public class ThrowExceptionCalculator : DirectCalculator
    {
        public class UnexpectedResult : Exception
        {
            public UnexpectedResult(string? message) : base(message) { }
        }

        protected override double HandleAverageError(double average, int[] nums)
        {
            string message;
            if (average < nums[0])
            {
                message = "average was less than the smallest number";
            }
            else if (average > nums[nums.Length - 1])
            {
                message = "average was greater than the largest number";
            }
            else
            {
                message = "something went wrong";
            }
            throw new UnexpectedResult(message);
        }
    }

    /**
     * Returns a success/error flag as well as the calculated average.
     * 
     * Notice - the TryGetAverage method has a slightly different signature;
     * this is because it *returns* both the average and if there was an error.
     * 
     * This is a common C# pattern (you can see it in the standard library):
     * return a bool (representing success/error), and have an out parameter
     * for the actual return value.
     */
    public class ReturnErrorCalculator : BaseCalculator
    {
        public bool TryGetAverage(int[] nums, out double average)
        {
            int sum = GetSum(nums);
            double calculatedAvg = sum / nums.Length;

            if (!VerifyAverage(nums, calculatedAvg))
            {
                average = 0;
                return false;
            }

            average = calculatedAvg;
            return true;
        }
    }
    #endregion
}
