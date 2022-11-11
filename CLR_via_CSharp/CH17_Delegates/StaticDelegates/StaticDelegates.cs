// Simplified version of the example in the book.
internal sealed class StaticDelegates {
   // Old school delegate
   internal delegate void Feedback(Int32 value);
   
   public static void Main() {
      StaticDelegateDemo();
   }
   
   private static void StaticDelegateDemo() {
      Console.WriteLine("----- Static Delegate Demo -----");
      Counter(1, 3, null);
      Counter(1, 3, new Feedback(StaticDelegates.FeedbackToConsole));
      Console.WriteLine();
   }
   
   private static void SimplifiedDelegateDemo() {
      Console.WriteLine("----- Static Delegate Demo -----");
      Counter(1, 3, null);
      Counter(1, 3, FeedbackToConsole);
      Console.WriteLine();
   }
   
   private static void Counter(Int32 from, Int32 to, Feedback fb) {
      for (Int32 val = from; val <= to; val++) {
         // If any callbacks are specified, call them
         if (fb != null)
            fb(val);
      }
   }

   private static void FeedbackToConsole(Int32 value) {
      Console.WriteLine("Item=" + value);
   }

   private void FeedbackToFile(Int32 value) {
      StreamWriter sw = new StreamWriter("Status", true);
      sw.WriteLine("Item=" + value);
      sw.Close();
   }
}